using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoWindows
{
    public partial class frmDevice : Form
    {
        private static SerialPort serialPort;

        private readonly int[] baudRates = new int[] { 110, 300, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

        public frmDevice()
        {
            InitializeComponent();

            cmboPort.DataSource = SerialPort.GetPortNames();
            cmboBaud.DataSource = baudRates;
            cmboBaud.SelectedIndex = 5;
            cmboPort.SelectedIndex = 0;

            serialPort = new SerialPort();


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
                    serialPort.BaudRate = baudrate!=null ? int.Parse(baudrate): 9600;
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
    }





    // Helper functions


}
