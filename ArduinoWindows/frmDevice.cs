using System;
using System.IO.Ports;
using System.Windows.Forms;


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

            //Initial form values
            init_Load();

        }


        private void btnLED_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string ledColor = button.Text[0].ToString().ToUpper();
            switch(ledColor) {
                case "R":
                    _arduinoCom.SendCommand("R");
                    break;
                case "G":
                    _arduinoCom.SendCommand("G");
                    break;
                case "B":
                    _arduinoCom.SendCommand("B");
                    break;
                case "O":
                    _arduinoCom.SendCommand("O");
                    break;
            }
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


        //Release resources when closing
        private void frmDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            _arduinoCom.Disconnect();
        }


        // DataReceive event 
        private void OnDataReceived(object sender, string data)
        {
            if (data.Contains("tem"))
            {
                string[] results = data.Split(",");
                try
                {
                    string tempStr = results[1].Trim();
                    this.Invoke(new Action(() =>
                    {
                        lblTemp.Text = tempStr + degree + "C";

                        //pbarTemp.Value = int.Parse(tempStr); //To be fixed
                    }));
                }
                catch (Exception ex)
                {
                    // show unbothering error message
                }

            }
            else if (data.Contains("uls"))
            {
                string[] results = data.Split(",");
                string ulsStr = results[1].Trim();
                int distance = int.Parse(ulsStr);
                this.Invoke(new Action(() =>
                {
                    pbarDistance.Value = distance;
                }));
            }
            else
            {
                // Handle other data ...
            }
        }





        // Initial values of controls
        private void init_Load()
        {

            // subscribe event to each btn LED
            foreach (Control btn in this.pnlLED.Controls)
            {
                if (btn.GetType() == typeof(Button))
                    if (btn.Text.Contains("LED"))
                        btn.Click += btnLED_Click;

            }

            //Loading input initial value
            lblTemp.Text = "_" + degree + "C";
            cmboPort.DataSource = SerialPort.GetPortNames();
            cmboBaud.DataSource = baudRates;
            cmboBaud.SelectedIndex = 5;
            cmboPort.SelectedIndex = 0;
        }




    }


}
