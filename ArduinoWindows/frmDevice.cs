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




        public frmDevice(IArduinoCom arduinoCom)
        {
            InitializeComponent();

            _arduinoCom = arduinoCom;

            _arduinoCom.DataReceived += OnDataReceived;

            lblTemp.Text = "_" + degree + "C";
            cmboPort.DataSource = SerialPort.GetPortNames();
            cmboBaud.DataSource = baudRates;
            cmboBaud.SelectedIndex = 5;
            cmboPort.SelectedIndex = 0;

        }




        // User connect event
        private void btnConnect_Click(object sender, EventArgs e)
        {



            if (_arduinoCom.IsConnected)
            {
                _arduinoCom.Disconnect();
                btnConnect.BackColor = Color.Red;
                btnConnect.Text = "Connect";
            }
            else
            {
                _arduinoCom.Connect(cmboPort.Text, int.Parse(cmboBaud.Text));
                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "Connected";
            }
        }



        // DataReceive event 
        private void OnDataReceived(object sender, string data)
        {
            if (data.Contains("tem"))
            {
                string[] results = data.Split(",");
                string tempStr = results[1].Trim();
                this.Invoke(new Action(() =>
                {
                    lblTemp.Text = tempStr + degree + "C";
                }));

            }
            else if (data.Contains("uls"))
            {
                string[] results = data.Split(",");
                string ulsStr = results[1].Trim();
                int distance = int.Parse(ulsStr);
                pbarDistance.Invoke(new Action(() =>
                {
                    pbarDistance.Value = distance;
                }));
            }
            else
            {
                // Handle other data ...
            }
        }

        private void frmDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Release resources
            _arduinoCom.Disconnect();
        }
    }


}
