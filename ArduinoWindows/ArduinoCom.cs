using System.IO.Ports;


namespace ArduinoWindows
{
    internal class ArduinoCom : IArduinoCom
    {

        private SerialPort serialPort;
        public bool IsConnected => serialPort.IsOpen;

        public ArduinoCom()
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
                serialPort.Open();
            }
        }

        public void Disconnect()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                
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


 