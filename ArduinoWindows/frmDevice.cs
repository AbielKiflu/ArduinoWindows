using System;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
 

namespace ArduinoWindows
{
    public partial class frmDevice : Form
    {
        private Chart chart;
        private const char degree = '\u00B0';
        private readonly int[] baudRates = new int[] { 110, 300, 1200, 2400, 4800, 9600, 14400, 19200, 38400,
            57600, 115200, 128000, 256000 };

        private IArduinoCommunication _arduinoCom;






        public frmDevice(IArduinoCommunication arduinoCom)
        {
            InitializeComponent();

            _arduinoCom = arduinoCom;

            _arduinoCom.DataReceived += OnDataReceived;

            //Initial form values
            Init_Load();


            var dataPoints = new[] {
        new { X = "A", Y = 10 },
        new { X = "B", Y = 20 },
        new { X = "C", Y = 15 },
        new { X = "D", Y = 30 },
        new { X = "E", Y = 25 }
    };
              chart = new Chart();

            // Configure chart properties
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series());
            chart.Series[0].ChartType = SeriesChartType.Column; // Set chart type (e.g., Column, Line, Pie)
            chart.Series[0].Points.DataBindXY(
                new[] { "A", "B", "C", "D", "E" },
                new[] { 10, 20, 15, 30, 25 });

            
            this.Controls.Add(chart);

        }


        private void btnLED_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string ledColor = button.Text[0].ToString().ToUpper();
            switch (ledColor)
            {
                case "R":
                    _arduinoCom.SendCommand("R");
                    break;
                case "G":
                    _arduinoCom.SendCommand("G");
                    break;
                case "B":
                    _arduinoCom.SendCommand("B");
                    break;
                default:
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
                int temperature = data.GetDeviceValue();
                this.Invoke(new Action(() =>
                {
                    lblTemp.Text = temperature.ToString() + degree + "C";

                    pbarTemp.Value = temperature > 0 ? temperature : 0;
                }));

            }
            else if (data.Contains("uls"))
            {
                int distance = data.GetDeviceValue();
                this.Invoke(new Action(() =>
                {
                    pbarDistance.Value = distance;
                }));
            }
            else if (data.Contains("point"))
            {
                // point=41,117
                (int x, int y) = data.GetDevicePoint();
                this.Invoke(new Action(() =>
                {
                    lblPoint.Text = string.Format("{{{0}, {1}}}", x, y);
                }));
            }
        }





        // Initial values of controls
        private void Init_Load()
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
            
        }




    }


}
