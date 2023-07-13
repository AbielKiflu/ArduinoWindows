using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoWindows
{
    public interface IArduinoCom
    {
        void Connect(string portName, int baudRate);
        void Disconnect();
        void SendCommand(string command);
        event EventHandler<string> DataReceived;
    }
}


 