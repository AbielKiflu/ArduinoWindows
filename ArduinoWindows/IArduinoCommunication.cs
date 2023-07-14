

namespace ArduinoWindows
{
    public interface IArduinoCommunication
    {
        bool IsConnected { get; }
        void Connect(string portName, int baudRate);
        void Disconnect();
        void SendCommand(string command);

        event EventHandler<string> DataReceived;
    }
}


 