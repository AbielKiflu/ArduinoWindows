namespace ArduinoWindows
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
             
            IArduinoCommunication arduinoCom = new ArduinoCommunication();   
            Application.Run(new frmDevice(arduinoCom));
        }
    }
}