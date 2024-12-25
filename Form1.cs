using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Master_2
{
    public partial class GcodeManipulator : Form
    {
        public int bedSizeX = 220;
        public int bedSizeY = 220;

        public bool OriginLeft = true;
        public bool OriginUp = true;

        public int offSetXMinus = 0;
        public int offSetXPlus = 0;
        public int offSetYMinus = 0;
        public int offSetYPlus = 0;

        public string TopIdentifier = ";LAYER:0";

        private float minX = 0, maxX = 0, minY = 0, maxY = 0;

        public string filePath = string.Empty;

        public GcodeManipulator()
        {
            InitializeComponent();
            Main();
            AttachEventHandlers();
        }
        public void Main()
        {

            txt_BedSizeX.Text = bedSizeX.ToString();
            txt_BedSizeY.Text = bedSizeY.ToString();
            txt_TopIdentifier.Text = TopIdentifier;
            chk_OriginLeft.Checked = OriginLeft;
            chk_OriginUp.Checked = OriginUp;

            txt_OffSetXMinus.Text = offSetXMinus.ToString();
            txt_OffSetXPlus.Text = offSetXPlus.ToString();
            txt_OffSetYMinus.Text = offSetYMinus.ToString();
            txt_OffSetYPlus.Text = offSetYPlus.ToString();

            chk_1.Checked = true;
            chk_2.Checked = false;
            chk_3.Checked = false;
            chk_4.Checked = false;
            chk_5.Checked = false;
            chk_6.Checked = false;
            chk_7.Checked = false;
            chk_8.Checked = false;
            chk_9.Checked = false;

            lbl_OffSetXMinus.BackColor = Color.Red;
            lbl_OffSetXPlus.BackColor = Color.Green;
            lbl_OffSetYMinus.BackColor = Color.Orange;
            lbl_OffSetYPlus.BackColor = Color.Purple;

        }

        private void AttachEventHandlers()
        {
            // Attach KeyPress event handler to all TextBoxes
            txt_BedSizeX.KeyPress += NumbersOnly_KeyPress;
            txt_BedSizeY.KeyPress += NumbersOnly_KeyPress;
            txt_OffSetXMinus.KeyPress += NumbersOnly_KeyPress;
            txt_OffSetXPlus.KeyPress += NumbersOnly_KeyPress;
            txt_OffSetYMinus.KeyPress += NumbersOnly_KeyPress;
            txt_OffSetYPlus.KeyPress += NumbersOnly_KeyPress;

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

        private void btnInputFile_Click(object sender, EventArgs e)
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
                    if (line.StartsWith(txt_TopIdentifier.Text)) { break; }
                }
                DrawArea.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading G-code file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void GcodeManipulator_Load(object sender, EventArgs e)
        {

        }

        private void txt_TopIdentifier_TextChanged(object sender, EventArgs e)
        {
            TopIdentifier=txt_TopIdentifier.Text;
        }

        private void Update(object sender, EventArgs e)
        {
            int.TryParse(txt_BedSizeX.Text, out bedSizeX);
            int.TryParse(txt_BedSizeY.Text, out bedSizeY);
            OriginLeft = chk_OriginLeft.Checked;
            OriginUp = chk_OriginUp.Checked;
            int.TryParse(txt_OffSetXMinus.Text, out offSetXMinus);
            int.TryParse(txt_OffSetXPlus.Text, out offSetXPlus);
            int.TryParse(txt_OffSetYMinus.Text, out offSetYMinus);
            int.TryParse(txt_OffSetYPlus.Text, out offSetYPlus);
            DrawArea.Invalidate();
        }

        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int panelOffset = 30;
            float scaleFactor = 2f;
            g.ScaleTransform(scaleFactor, scaleFactor);

            // Adjust the panel size dynamically
            DrawArea.Width = (bedSizeX + 2 * panelOffset)*2;
            DrawArea.Height = (bedSizeY + 2 * panelOffset)*2;

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

                // Draw the bed area
                g.FillRectangle(brownBrush, minX + panelOffset, minY + panelOffset, maxX - minX, maxY - minY);
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
                    g.DrawString((y - panelOffset).ToString(), rulerFont, Brushes.Black, panelOffset - 20, y -4);
                }
            }
            /*
            // Draw origin labels in the fixed coordinate system
            Point locationX = OriginLeft
                ? new Point(0, bedSizeY / 2 + 25)
                : new Point(bedSizeX + 30, bedSizeY / 2 + 25);
            g.DrawString("Origin X", new Font("Arial", 5), Brushes.Black, locationX);

            Point locationY = OriginUp
                ? new Point(bedSizeX / 2 + 10, 20)
                : new Point(bedSizeX / 2 + 10, bedSizeY + 35);
            g.DrawString("Origin Y", new Font("Arial", 5), Brushes.Black, locationY);
            */
        }



        private void btn_Modify_Click(object sender, EventArgs e)
        {
            // Get the directory of the input file

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
            switch (true)
            {
                case var _ when chk_1.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, -minX + offSetXMinus, -minY + offSetYPlus,TopIdentifier);
                    Console.WriteLine("Checkbox 1 is selected.");
                    break;
                case var _ when chk_2.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (bedSizeX / 2) - (minX + maxX) / 2, -minY + offSetYPlus, TopIdentifier);
                    Console.WriteLine("Checkbox 2 is selected.");
                    break;
                case var _ when chk_3.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, -minY + offSetYPlus, TopIdentifier);
                    Console.WriteLine("Checkbox 3 is selected.");
                    break;
                case var _ when chk_4.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, -minX + offSetXMinus, (bedSizeY / 2) - (minY + maxY) / 2, TopIdentifier);
                    Console.WriteLine("Checkbox 4 is selected.");
                    break;
                case var _ when chk_5.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (bedSizeX / 2) - (minX + maxX) / 2, (bedSizeY / 2) - (minY + maxY) / 2, TopIdentifier);
                    Console.WriteLine("Checkbox 5 is selected.");
                    break;
                case var _ when chk_6.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, (bedSizeY / 2) - (minY + maxY) / 2, TopIdentifier);
                    Console.WriteLine("Checkbox 6 is selected.");
                    break;
                case var _ when chk_7.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, -minX + offSetXMinus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                    Console.WriteLine("Checkbox 7 is selected.");
                    break;
                case var _ when chk_8.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, (bedSizeX / 2) - (minX + maxX) / 2, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                    Console.WriteLine("Checkbox 8 is selected.");
                    break;
                case var _ when chk_9.Checked:
                    GCodeModifyer.ProcessGCodeFile(filePath, outputFilePath, bedSizeX - maxX - offSetXPlus, bedSizeY - maxY - offSetXMinus, TopIdentifier);
                    Console.WriteLine("Checkbox 9 is selected.");
                    break;
                default:
                    Console.WriteLine("No checkbox is selected.");
                    break;
            }
            ReadGCodeFile(filePath);


        }
    }
        public static class GCodeModifyer
        {
            public static void ProcessGCodeFile(string filePath, string outputFilePath, float xOffset, float yOffset, string TopIdentifier)
            {
                bool startProcessing = false;
                // Read all lines from the input G-code file
                var lines = File.ReadAllLines(filePath);

                // Create a list to store modified lines
                var modifiedLines = new List<string>();

                // Process each line in the G-code
                foreach (var line in lines)
                {
                    if (line.StartsWith(TopIdentifier))
                    {
                        startProcessing = true;
                    }

                    if (line.StartsWith("G91"))
                    {
                        startProcessing = false;
                    }

                    // If the line starts with G0 or G1 (indicating a move)
                    if ((line.StartsWith("G0") || line.StartsWith("G1")) && startProcessing == true)
                    {
                        // Modify X and Y values if present
                        string modifiedLine = ModifyCoordinates(line, xOffset, yOffset);
                        modifiedLines.Add(modifiedLine);

                    }
                    else
                    {
                        if (line.StartsWith(";MINX:") || line.StartsWith(";MINY:") || line.StartsWith(";MAXX:") || line.StartsWith(";MAXY:"))
                        {
                            string modifiedLine = ModifyCoordinates(line, xOffset, yOffset);
                            modifiedLines.Add(modifiedLine);
                        }
                        else
                        {
                            modifiedLines.Add(line);
                        }

                    }

                }

                // Write the modified lines to the output file
                File.WriteAllLines(outputFilePath, modifiedLines);
            }

            private static string ModifyCoordinates(string line, float xOffset, float yOffset)
            {
                if (line.StartsWith(";MINX:") || line.StartsWith(";MAXX:"))
                {
                    int xStartIndex = line.IndexOf(":") + 1;
                    int xEndIndex = line.IndexOf(" ", xStartIndex);
                    if (xEndIndex == -1) xEndIndex = line.Length; // If no space, take till end of string

                    string xValue = line.Substring(xStartIndex, xEndIndex - xStartIndex);
                    double newX = double.Parse(xValue) + xOffset; // Add the X offset
                    line = line.Replace($":{xValue}", $":{newX:F3}"); // Replace with new X value

                }
                if (line.StartsWith(";MINY:") || line.StartsWith(";MAXY:"))
                {
                    int yStartIndex = line.IndexOf(":") + 1;
                    int yEndIndex = line.IndexOf(" ", yStartIndex);
                    if (yEndIndex == -1) yEndIndex = line.Length; // If no space, take till end of string

                    string yValue = line.Substring(yStartIndex, yEndIndex - yStartIndex);
                    double newY = double.Parse(yValue) + yOffset; // Add the X offset
                    line = line.Replace($":{yValue}", $":{newY:F3}"); // Replace with new X value

                }

                // Modify X coordinate
                if (line.Contains("X") && (!(line.Contains("MIN")) && !(line.Contains("MAX"))))
                {
                    int xStartIndex = line.IndexOf("X") + 1;
                    int xEndIndex = line.IndexOf(" ", xStartIndex);
                    if (xEndIndex == -1) xEndIndex = line.Length; // If no space, take till end of string

                    string xValue = line.Substring(xStartIndex, xEndIndex - xStartIndex);
                    double newX = double.Parse(xValue) + xOffset; // Add the X offset
                    line = line.Replace($"X{xValue}", $"X{newX:F3}"); // Replace with new X value
                }

                // Modify Y coordinate
                if (line.Contains("Y") && (!(line.Contains("MIN")) && !(line.Contains("MAX"))))
                {
                    int yStartIndex = line.IndexOf("Y") + 1;
                    int yEndIndex = line.IndexOf(" ", yStartIndex);
                    if (yEndIndex == -1) yEndIndex = line.Length; // If no space, take till end of string

                    string yValue = line.Substring(yStartIndex, yEndIndex - yStartIndex);
                    double newY = double.Parse(yValue) + yOffset; // Add the Y offset
                    line = line.Replace($"Y{yValue}", $"Y{newY:F3}"); // Replace with new Y value
                }

                return line;
            }
        }
      
}