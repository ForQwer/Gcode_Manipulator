using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_2
{
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
