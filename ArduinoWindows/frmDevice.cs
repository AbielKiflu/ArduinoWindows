﻿using System;
using System.IO.Ports;


namespace ArduinoWindows
{
    public partial class frmDevice : Form
    {
        private static SerialPort serialPort;
        private delegate void SafeDisplay(string val);

        private readonly int[] baudRates = new int[] { 110, 300, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

        public frmDevice()
        {
            InitializeComponent();

            cmboPort.DataSource = SerialPort.GetPortNames();
            cmboBaud.DataSource = baudRates;
            cmboBaud.SelectedIndex = 5;
            cmboPort.SelectedIndex = 0;

            serialPort = new SerialPort();
            serialPort.DataReceived += OnDataReceived;

        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

            if (pbarTemp.InvokeRequired)
            {
                try
                {
                    pbarTemp.Invoke(new SafeDisplay((data) =>
                    {
                        try
                        {
                            int temp = (int)double.Parse(data);
                            if (temp > 50) { return; }
                            if (temp <= 27)
                                pbarTemp.ForeColor = Color.Blue;
                            else
                                pbarTemp.ForeColor = Color.Red;


                            pbarTemp.Value = temp;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }), new object[] { data });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmboPort.Items.Count > 0 && cmboBaud.Items.Count > 0)
            {
                try
                {
                    string baudrate = cmboBaud.SelectedValue?.ToString();
                    serialPort.PortName = cmboPort.SelectedItem?.ToString();
                    serialPort.BaudRate = baudrate != null ? int.Parse(baudrate) : 9600;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }

        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            if (cmboPort.Items.Count > 0 && cmboBaud.Items.Count > 0)
            {
                try
                {
                    string baudrate = cmboBaud.SelectedValue?.ToString();
                    serialPort.PortName = cmboPort.SelectedItem?.ToString();
                    serialPort.BaudRate = baudrate != null ? int.Parse(baudrate) : 9600;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    btnConnect.BackColor = Color.Red;
                    btnConnect.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                    btnConnect.BackColor = Color.Green;
                    btnConnect.Text = "Connected";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void cmboPort_Click(object sender, EventArgs e)
        {
            cmboPort.DataSource = SerialPort.GetPortNames();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("R");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("B");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("G");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("O");
        }


    }





    // Helper functions


}
