using System.IO.Ports;


namespace ArduinoWindows
{
    internal class ArduinoCommunication : IArduinoCommunication
    {

        private SerialPort serialPort;
        public bool IsConnected => serialPort != null && serialPort.IsOpen;

        public ArduinoCommunication()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += OnDataReceived;
        }

        public void Connect(string portName, int baudRate)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                try
                {
                    serialPort.Open();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Disconnect()
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void SendCommand(string command)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(command);
            }
        }




        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            DataReceived?.Invoke(this, data);
        }

        public event EventHandler<string> DataReceived;


    }
}


 