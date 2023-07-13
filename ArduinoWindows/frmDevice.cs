using System;
using System.IO.Ports;


namespace ArduinoWindows
{
    public partial class frmDevice : Form
    {
        private IArduinoCom _arduinoCom;

        private delegate void SafeDisplay(string val);
        private const char degree = '\u00B0';
        private readonly int[] baudRates = new int[] { 110, 300, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };




        public frmDevice(IArduinoCom arduinoCom )
        {
            InitializeComponent();

            _arduinoCom = arduinoCom;
            // _arduinoCom.DataReceived += OnDataReceived;
            lblTemp.Text = "_" + degree + "C";
            cmboPort.DataSource = SerialPort.GetPortNames();
            cmboBaud.DataSource = baudRates;
            cmboBaud.SelectedIndex = 5;
            cmboPort.SelectedIndex = 0;







        }





    }
 

}
