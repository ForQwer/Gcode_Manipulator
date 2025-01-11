using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_2
{
    public static class PrinterInterface
    {
        private static SerialPort serialPort;

        public static event Action<string> DataReceived;
        public static void SendCommand(string command)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show("Printer is not connected.");
            }
        }

        public static void ConnectToPrinter(string portName, int baudRate)
        {
            try
            {
                // Initialize the SerialPort
                serialPort = new SerialPort
                {
                    PortName = portName, // Example: "COM3"
                    BaudRate = baudRate, // Example: 115200
                    Parity = Parity.None,
                    DataBits = 8,
                    StopBits = StopBits.One,
                    Handshake = Handshake.None,
                    DtrEnable = true, // Required for some 3D printers
                    RtsEnable = true  // Required for some 3D printers
                };

                // Attach event handler for incoming data
                serialPort.DataReceived += SerialPort_DataReceived;

                // Open the connection
                serialPort.Open();
                DataReceived?.Invoke("Connected !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect: {ex.Message}");
            }
        }

        public static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read the incoming data
                string data = serialPort.ReadExisting();

                // Trigger the DataReceived event
                DataReceived?.Invoke(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}");
            }
        }

        public static void DisconnectPrinter()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                DataReceived?.Invoke("Disconnected !");
            }
        }
        


    }

}
