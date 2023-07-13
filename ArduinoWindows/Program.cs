namespace ArduinoWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            IArduinoCommunication arduinoCom = new ArduinoCommunication();   
            Application.Run(new frmDevice(arduinoCom));
        }
    }
}