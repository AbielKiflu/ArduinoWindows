namespace ArduinoWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            IArduinoCom arduinoCom = new ArduinoCom();   
            Application.Run(new frmDevice(arduinoCom));
        }
    }
}