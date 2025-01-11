using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.IO.Ports;
using System.Xml;
using System.Linq;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Master_2.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Text.RegularExpressions;

namespace Master_2
{
    public partial class GcodeManipulator : Form
    {
        // this.button14.Image= new Bitmap(global::Master_2.Properties.Resources.up_left_arrow, button1.Size);
        //////////////////////////////////////////// PRINTER SETTINGS
        public static int bedSizeX = 220;
        public static int bedSizeY = 220;

        public static bool OriginLeft = true;
        public static bool OriginUp = true;

        public static int offSetXMinus = 0;
        public static int offSetXPlus = 0;
        public static int offSetYMinus = 0;
        public static int offSetYPlus = 0;

        public static string TopIdentifier = ";LAYER:0";
        //////////////////////////////////////////// GENERAL VARIABILES
        private float minX = 0, maxX = 0, minY = 0, maxY = 0, posZ = 0, posX = 0, posY = 0;



        public string filePath = string.Empty;

        public bool PrintLoaded = false;

        public bool PrinterConnected = false;

        public bool PrinterHomed = false;

        public string[] printerPreCommands = new string[3];

        public List<string> printerExecutedCommands = new List<string>();

        private int currentCommandIndex = -1; 




        public GcodeManipulator()
        {
            InitializeComponent();
            Main();
            AttachEventHandlers();
            PrinterInterface.DataReceived += OnDataReceived;
        }
        //////////////////////////////////////////// INITIALIZATION
        #region 
        public void Main()
        {
            chk_1.Checked = true;
            chk_2.Checked = false;
            chk_3.Checked = false;
            chk_4.Checked = false;
            chk_5.Checked = false;
            chk_6.Checked = false;
            chk_7.Checked = false;
            chk_8.Checked = false;
            chk_9.Checked = false;
            //////////////////////////////////////////// UI
            button2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX); 
            button3.Image.RotateFlip(RotateFlipType.RotateNoneFlipY); 
            button4.Image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            button13.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            button29.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            button33.Image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            button22.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);




            cmb_COM.Items.Add("COM3");
            cmb_BAUD.Items.Add(250000);

            cmb_COM.SelectedIndex = 0;
            cmb_BAUD.SelectedIndex = 0;

            printerPreCommands[0] = "G28"; // Home all axes
            printerPreCommands[1] = "M104 S200"; // Set extruder temperature to 200°C
        }
        private void AttachEventHandlers()
        {
            chk_1.CheckedChanged += chk_CheckedChanged;
            chk_2.CheckedChanged += chk_CheckedChanged;
            chk_3.CheckedChanged += chk_CheckedChanged;
            chk_4.CheckedChanged += chk_CheckedChanged;
            chk_5.CheckedChanged += chk_CheckedChanged;
            chk_6.CheckedChanged += chk_CheckedChanged;
            chk_7.CheckedChanged += chk_CheckedChanged;
            chk_8.CheckedChanged += chk_CheckedChanged;
            chk_9.CheckedChanged += chk_CheckedChanged;

        }
        #endregion
        //////////////////////////////////////////// GENERAL EVENTS IN FORMS
        #region 
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure only one checkbox is checked
            if (sender is CheckBox chk && chk.Checked)
            {
                chk_1.Checked = chk == chk_1;
                chk_2.Checked = chk == chk_2;
                chk_3.Checked = chk == chk_3;
                chk_4.Checked = chk == chk_4;
                chk_5.Checked = chk == chk_5;
                chk_6.Checked = chk == chk_6;
                chk_7.Checked = chk == chk_7;
                chk_8.Checked = chk == chk_8;
                chk_9.Checked = chk == chk_9;
            }
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            DrawArea.Invalidate();
        }
        private void txt_Command_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true; // Set in Form's constructor or Load event

            if (e.KeyCode == Keys.Enter && txt_Command.Text != "")
            {
                // Action to perform when Enter is pressed
                string command = txt_Command.Text.ToUpper();

                PrinterInterface.SendCommand(command);  // Sending the command to the printer interface

                // Display the command in the text box
                txtCommandShow.AppendText(command + Environment.NewLine);

                // Add the command to the list of executed commands
                printerExecutedCommands.Add(command);

                // Reset the command textbox
                txt_Command.Text = "";

                // Reset the currentCommandIndex to the last added command
                currentCommandIndex = printerExecutedCommands.Count - 1;

                e.Handled = true; // Prevent further processing if necessary
                                  // e.SuppressKeyPress = true; // Prevents the ding sound
            }

            // Navigate through previous commands using the Up arrow key
            if (e.KeyCode == Keys.Up)
            {
                if (currentCommandIndex >= 0) // Ensure we don't go out of bounds
                {
              
                    txt_Command.Text = printerExecutedCommands[currentCommandIndex];
                    if (printerExecutedCommands[currentCommandIndex] != "")
                    {
                        currentCommandIndex--;
                    }
                }
            }

            // Navigate through next commands using the Down arrow key
            else if (e.KeyCode == Keys.Down)
            {
                if (currentCommandIndex < printerExecutedCommands.Count - 1) // Ensure we don't go out of bounds
                {
                    currentCommandIndex++;
                    txt_Command.Text = printerExecutedCommands[currentCommandIndex];
                }
            }
        }
        #endregion
        /////////////////////////////////////////// CLICKS
        #region 
        private void btnOpernGcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text files | *.gcode",
                Multiselect = false
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                ReadGCodeFile(filePath);
            }
        }

        private void btn_DisconnectPrinter_Click(object sender, EventArgs e)
        {
            PrinterInterface.DisconnectPrinter();
            PrinterConnected = false;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Create an instance of the Options form
            Options optionsForm = new Options();

            // Subscribe to the FormClosed event
            optionsForm.FormClosed += new FormClosedEventHandler(Options_FormClosed);

            // Show the Options form
            optionsForm.ShowDialog();  // ShowDialog makes the form modal
        }

        private void btn_ConnectToPrinter_Clicked(object sender, EventArgs e)
        {
            if (cmb_COM.Text != "" && cmb_BAUD.Text != "")
            {
                PrinterInterface.ConnectToPrinter(cmb_COM.Text, int.Parse(cmb_BAUD.Text));
                PrinterInterface.SendCommand("M114");
                PrinterConnected = true;
            }


        }
        
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            // Get the directory of the input file
            try
            {
                string directory2 = Path.GetDirectoryName(filePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string directory = Path.GetDirectoryName(filePath);

            // Get the file name without the extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

            // Get the file extension
            string fileExtension = Path.GetExtension(filePath);

            // Create the output file name by appending "_modified" to the Original file name
            string outputFileName = fileNameWithoutExtension + fileExtension;

            // Combine the directory path with the new output file name
            string outputFilePath = Path.Combine(directory, outputFileName);

            // Call the method to process the G-code file and modify it
            float offsetX = -minX + offSetXMinus;
            float offsetY = -minY + offSetYPlus;
            float halfBedSizeX = bedSizeX / 2;
            float halfBedSizeY = bedSizeY / 2;
            float midX = (minX + maxX) / 2;
            float midY = (minY + maxY) / 2;
            if (OriginLeft && !OriginUp)
            {
                switch (true)
                {

                    case var _ when chk_7.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_8.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_9.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_4.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_5.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_6.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_1.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_2.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_3.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    default:
                        break;
                }

            }
            else if (!OriginLeft && OriginUp)
            {
                switch (true)
                {

                    case var _ when chk_3.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_2.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_1.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_6.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_5.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_4.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_9.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_8.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_7.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    default:
                        break;
                }

            }
            else if (!OriginLeft && !OriginUp)
            {
                switch (true)
                {

                    case var _ when chk_9.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_8.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_7.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_6.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_5.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_4.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_3.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_2.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_1.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    default:
                        break;
                }

            }
            else
            {
                switch (true)
                {

                    case var _ when chk_1.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_2.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_3.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, -offsetY, TopIdentifier);
                        break;
                    case var _ when chk_4.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_5.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_6.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, (halfBedSizeY) - midY, TopIdentifier);
                        break;
                    case var _ when chk_7.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, offsetX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_8.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (halfBedSizeX) - midX, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    case var _ when chk_9.Checked:
                        GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                        break;
                    default:
                        break;
                }

            }
            
            ReadGCodeFile(filePath);


        }

        private void MoveToCorner(object sender, EventArgs e)
        {
            string MoveCommand = "";
            if (sender is System.Windows.Forms.Button button)
            {
                if (PrinterConnected && PrintLoaded && PrinterHomed)
                {
                    if (OriginLeft && !OriginUp)
                    {
                        switch (button.Name)
                        {
                            case "button1":
                                MoveCommand = $"G1 X{minX} Y{maxY} F5000.0";
                                break;

                            case "button2":
                                MoveCommand = $"G1 X{maxX} Y{maxY} F5000.0";
                                break;
                            case "button4":
                                MoveCommand = $"G1 X{maxX} Y{minY} F5000.0";
                                break;
                            case "button3":
                                MoveCommand = $"G1 X{minX} Y{minY} F5000.0";
                                break;

                        }
                    }
                    else if (!OriginLeft && OriginUp)
                    {
                        switch (button.Name)
                        {
                            case "button1":
                                MoveCommand = $"G1 X{maxX} Y{maxY} F5000.0";
                                break;

                            case "button2":
                                MoveCommand = $"G1 X{minX} Y{maxY} F5000.0";
                                break;
                            case "button4":
                                MoveCommand = $"G1 X{minX} Y{minY} F5000.0";
                                break;
                            case "button3":
                                MoveCommand = $"G1 X{maxY} Y{minY} F5000.0";
                                break;

                        }
                    }
                    else if (!OriginLeft && !OriginUp)
                    {
                        switch (button.Name)
                        {
                            case "button1":
                                MoveCommand = $"G1 X{maxY} Y{maxY} F5000.0";
                                break;

                            case "button2":
                                MoveCommand = $"G1 X{minX} Y{maxY} F5000.0";
                                break;
                            case "button4":
                                MoveCommand = $"G1 X{minX} Y{minY} F5000.0";
                                break;
                            case "button3":
                                MoveCommand = $"G1 X{maxY} Y{minY} F5000.0";
                                break;

                        }
                    }
                    else
                    {
                        switch (button.Name)
                        {
                            case "button1":
                                MoveCommand = $"G1 X{minX} Y{minY} F5000.0";
                                break;

                            case "button2":
                                MoveCommand = $"G1 X{maxX} Y{minY} F5000.0";
                                break;
                            case "button3":
                                MoveCommand = $"G1 X{maxX} Y{maxY} F5000.0";
                                break;
                            case "button4":
                                MoveCommand = $"G1 X{minX} Y{maxY} F5000.0";
                                break;

                        }
                    }

                    PrinterInterface.SendCommand(MoveCommand);
                    txtCommandShow.AppendText(MoveCommand + Environment.NewLine);
                }
                else if (PrinterConnected == false) { txtCommandShow.AppendText("Not Connected" + Environment.NewLine); }
                else { MessageBox.Show("Printer not homed"); }
            }
            
        }

        private void MoveAxis(object sender, EventArgs e)
        {

            if (sender is System.Windows.Forms.Button button)
            {
                if (PrinterHomed == true)
                {
                    if (button.Name == "button6" || button.Name == "button7" || button.Name == "button8")
                    {
                        posZ = posZ - float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 Z{posZ} F5000.0");
                    }
                    if (button.Name == "button10" || button.Name == "button11" || button.Name == "button12")
                    {
                        posZ = posZ + float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 Z{posZ} F5000.0");
                    }
                    if (button.Name == "button19" || button.Name == "button20" || button.Name == "button21")
                    {
                        posY = posY + float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 Y{posY} F5000.0");
                    }
                    if (button.Name == "button27" || button.Name == "button26" || button.Name == "button28")
                    {
                        posX = posX + float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 X{posX} F5000.0");
                    }
                    if (button.Name == "button32" || button.Name == "button31" || button.Name == "button30")
                    {
                        posY = posY - float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 Y{posY} F5000.0");
                    }
                    if (button.Name == "button23" || button.Name == "button24" || button.Name == "button25")
                    {
                        posX = posX - float.Parse(button.Text);
                        PrinterInterface.SendCommand($"G1 X{posX} F5000.0");
                    }
                }
                else { MessageBox.Show("Printer not homed"); }
            }
        }

        private void HomeAxis(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button)
            {

                    if (button.Name == "button14" || button.Name == "button15" || button.Name == "button16")
                    {
                        PrinterInterface.SendCommand(printerPreCommands[0] + " " + button.Text);
                    }
                    else
                    {
                        PrinterInterface.SendCommand(printerPreCommands[0]);
                        PrinterHomed = true;
                    }
                
            }

        }
        //////////////////////////////////////////// METHODS
        private void ReadGCodeFile(string filePath)
        {
            // Initialize minX, maxX, minY, maxY to extreme values
            minX = 10000;
            maxX = -10000;
            minY = 10000;
            maxY = -10000;

            try
            {
                // Read the file line by line
                foreach (string line in File.ReadLines(filePath))
                {
                    // Remove any extra spaces and convert to uppercase
                    string cleanLine = line.Trim().ToUpper();

                    if (line.StartsWith(";MIN") || line.StartsWith(";MAX"))
                    {
                        // Extract the coordinate name (e.g., MINX, MAXY) and value
                        int colonIndex = line.IndexOf(':');
                        if (colonIndex != -1)
                        {
                            string coordinate = line.Substring(1, colonIndex - 1).Trim(); // Extract MINX, MAXY, etc.
                            string valueString = line.Substring(colonIndex + 1).Trim(); // Extract the value

                            // Try to parse the value as a double
                            if (double.TryParse(valueString, out double value))
                            {
                                // Update min/max values based on the coordinate
                                if (coordinate == "MINX")
                                {
                                    minX = (float)Math.Min(minX, value);
                                }
                                else if (coordinate == "MAXX")
                                {
                                    maxX = (float)Math.Max(maxX, value);
                                }
                                else if (coordinate == "MINY")
                                {
                                    minY = (float)Math.Min(minY, value);
                                }
                                else if (coordinate == "MAXY")
                                {
                                    maxY = (float)Math.Max(maxY, value);
                                }
                            }
                        }
                    }
                    if (line.StartsWith(TopIdentifier)) { break; }
                }
                PrintLoaded = true;
                DrawArea.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading G-code file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static float ExtractValue(string input, string label)
        {
            // Find the index of the label (e.g., "X:")
            int labelIndex = input.IndexOf(label);
            if (labelIndex == -1)
                return 0.0f; // Return 0 if label is not found

            // Find the starting index of the value (after the label)
            int startIndex = labelIndex + label.Length;

            // Find the index of the next space after the value
            int endIndex = input.IndexOf(" ", startIndex);

            // If no space is found, take the value until the end of the string
            if (endIndex == -1)
            {
                endIndex = input.Length;
            }

            // Extract the substring and convert it to a float
            string valueStr = input.Substring(startIndex, endIndex - startIndex);
            return float.Parse(valueStr);
        }
        #endregion
        //////////////////////////////////////////// EVENTS
        #region 
        private void OnDataReceived(string data)
        {
            bool X = true, Y = true, Z = true;
            // Regex pattern to extract X, Y, Z values
            string pattern = @"X:([0-9.]+)\s*Y:([0-9.]+)\s*Z:([0-9.]+)";

       
            // Ensure thread-safe UI update
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (!(data.StartsWith("echo") || data.StartsWith("ok")))

                    {
                        txtCommandShow.AppendText(data + Environment.NewLine);
                        // Apply regex to the data string
                        Match match = Regex.Match(data, pattern);
                        if (match.Success)
                        {
                            // Extract the values from the matched groups
                            posX = float.Parse(match.Groups[1].Value);
                            posY = float.Parse(match.Groups[2].Value);
                            posZ = float.Parse(match.Groups[3].Value);

                        }
                        match = Regex.Match(data, @"[A-Za-z]+1234567890");
                    }

                    
                }));
            }
            else
            {
                if (!(data.StartsWith("echo") || data.StartsWith("ok")))

                {
                    txtCommandShow.AppendText(data + Environment.NewLine);
                    if (data.Contains("X:") && data.Contains("Y:") && data.Contains("Z:"))
                    {

                        string firstLine = data.Split('\n')[0];

                        // Split the first line into parts
                        string[] parts = firstLine.Split(' ');

                        // Parse X, Y, and Z values
                        foreach (var part in parts)
                        {
                            if (part.StartsWith("X:") && X == true)
                            {
                                posX = float.Parse(part.Substring(2)); // Extract value after "X:"
                                X = false;
                            }
                            else if (part.StartsWith("Y:") && Y == true)
                            {
                                posX = float.Parse(part.Substring(2)); // Extract value after "Y:"
                                Y = false;
                            }
                            else if (part.StartsWith("Z:") && Z == true)
                            {
                                posZ = float.Parse(part.Substring(2)); // Extract value after "Z:"
                                Z = false;
                            }


                        }

                    }
                }
            }
        }
        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int panelOffset = 30;
            int scaleFactor = 2;
            g.ScaleTransform(scaleFactor, scaleFactor);


            // Adjust the panel size dynamically
            DrawArea.Width = (bedSizeX + 2 * panelOffset) * 2;
            DrawArea.Height = (bedSizeY + 2 * panelOffset) * 2;

            // Apply transformations for origin movement
            if (OriginLeft && !OriginUp)
            {
                g.TranslateTransform(0, DrawArea.Height / scaleFactor);
                g.ScaleTransform(1, -1); // Flip vertically
            }
            else if (!OriginLeft && OriginUp)
            {
                g.TranslateTransform(DrawArea.Width / scaleFactor, 0);
                g.ScaleTransform(-1, 1); // Flip horizontally
            }
            else if (!OriginLeft && !OriginUp)
            {
                g.TranslateTransform(DrawArea.Width / scaleFactor, DrawArea.Height / scaleFactor);
                g.ScaleTransform(-1, -1); // Flip both axes
            }

            // Draw origin-dependent elements (offsets and bed area)
            using (Brush redBrush = new SolidBrush(Color.Red))
            using (Brush greenBrush = new SolidBrush(Color.Green))
            using (Brush orangeBrush = new SolidBrush(Color.Orange))
            using (Brush purpleBrush = new SolidBrush(Color.Purple))
            using (Brush brownBrush = new SolidBrush(Color.Brown))
            {
                // Draw offset areas
                g.FillRectangle(redBrush, panelOffset, panelOffset, offSetXMinus, bedSizeY); // X- offset
                g.FillRectangle(greenBrush, bedSizeX + panelOffset - offSetXPlus, panelOffset, offSetXPlus, bedSizeY); // X+ offset
                g.FillRectangle(orangeBrush, panelOffset, bedSizeY + panelOffset - offSetYMinus, bedSizeX, offSetYMinus); // Y- offset
                g.FillRectangle(purpleBrush, panelOffset, panelOffset, bedSizeX, offSetYPlus); // Y+ offset
                if (PrintLoaded == true)
                {

                g.FillRectangle(brownBrush, minX + panelOffset, minY + panelOffset, maxX - minX, maxY - minY);

                }

            }

            // Reset transformations to keep the grid and rulers fixed
            g.ResetTransform();
            g.ScaleTransform(scaleFactor, scaleFactor);

            // Drawing parameters
            int gridSpacing = 10; // Space between grid lines
            using (Pen gridPen = new Pen(Color.LightGray, 1))
            using (Pen rulerPen = new Pen(Color.Black, 2))
            using (Font rulerFont = new Font("Arial", 4))
            {
                // Draw vertical grid lines
                for (int x = 0; x <= bedSizeX; x += gridSpacing)
                {
                    int xPosition = panelOffset + x;
                    g.DrawLine(gridPen, xPosition, panelOffset, xPosition, panelOffset + bedSizeY);
                }

                // Draw horizontal grid lines
                for (int y = 0; y <= bedSizeY; y += gridSpacing)
                {
                    int yPosition = panelOffset + y;
                    g.DrawLine(gridPen, panelOffset, yPosition, panelOffset + bedSizeX, yPosition);
                }

                // Draw rulers
                for (int x = panelOffset; x <= bedSizeX + panelOffset; x += gridSpacing)
                {
                    g.DrawLine(rulerPen, x, panelOffset - 5, x, panelOffset);
                    g.DrawString((x - panelOffset).ToString(), rulerFont, Brushes.Black, x - 5, panelOffset - 15);
                }
                for (int y = panelOffset; y <= bedSizeY + panelOffset; y += gridSpacing)
                {
                    g.DrawLine(rulerPen, panelOffset - 5, y, panelOffset, y);
                    g.DrawString((y - panelOffset).ToString(), rulerFont, Brushes.Black, panelOffset - 20, y - 4);
                }
            }
        }
        #endregion

    }


}