namespace ArduinoWindows
{
    partial class frmDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlConfig = new Panel();
            cmboBaud = new ComboBox();
            label3 = new Label();
            cmboPort = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnConnect = new Button();
            pbarTemp = new ProgressBar();
            label4 = new Label();
            pnlLED = new Panel();
            btnBlue = new Button();
            btnGreen = new Button();
            btnRed = new Button();
            label5 = new Label();
            lblTemp = new Label();
            lblDistance = new Label();
            label7 = new Label();
            pbarDistance = new ProgressBar();
            label6 = new Label();
            lblPoint = new Label();
            pnlChart = new Panel();
            pnlConfig.SuspendLayout();
            pnlLED.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConfig
            // 
            pnlConfig.BackColor = Color.Thistle;
            pnlConfig.BorderStyle = BorderStyle.FixedSingle;
            pnlConfig.Controls.Add(cmboBaud);
            pnlConfig.Controls.Add(label3);
            pnlConfig.Controls.Add(cmboPort);
            pnlConfig.Controls.Add(label2);
            pnlConfig.Controls.Add(label1);
            pnlConfig.Controls.Add(btnConnect);
            pnlConfig.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConfig.Location = new Point(23, 28);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(295, 306);
            pnlConfig.TabIndex = 0;
            // 
            // cmboBaud
            // 
            cmboBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBaud.FormattingEnabled = true;
            cmboBaud.Location = new Point(116, 108);
            cmboBaud.Name = "cmboBaud";
            cmboBaud.Size = new Size(132, 28);
            cmboBaud.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Baud Rate";
            // 
            // cmboPort
            // 
            cmboPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboPort.FormattingEnabled = true;
            cmboPort.Location = new Point(116, 65);
            cmboPort.Name = "cmboPort";
            cmboPort.Size = new Size(132, 28);
            cmboPort.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Port Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Red;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(192, 165);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 29);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // pbarTemp
            // 
            pbarTemp.Location = new Point(424, 43);
            pbarTemp.Maximum = 50;
            pbarTemp.Name = "pbarTemp";
            pbarTemp.Size = new Size(262, 23);
            pbarTemp.Step = 1;
            pbarTemp.Style = ProgressBarStyle.Continuous;
            pbarTemp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 51);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Temprature";
            // 
            // pnlLED
            // 
            pnlLED.BackColor = Color.Plum;
            pnlLED.Controls.Add(btnBlue);
            pnlLED.Controls.Add(btnGreen);
            pnlLED.Controls.Add(btnRed);
            pnlLED.Controls.Add(label5);
            pnlLED.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlLED.Location = new Point(340, 145);
            pnlLED.Name = "pnlLED";
            pnlLED.Size = new Size(375, 189);
            pnlLED.TabIndex = 8;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.FromArgb(0, 0, 192);
            btnBlue.ForeColor = Color.White;
            btnBlue.Location = new Point(232, 56);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(108, 29);
            btnBlue.TabIndex = 10;
            btnBlue.Text = "Blue LED";
            btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.ForeColor = Color.White;
            btnGreen.Location = new Point(124, 56);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(108, 29);
            btnGreen.TabIndex = 9;
            btnGreen.Text = "Green LED";
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.ForeColor = Color.White;
            btnRed.Location = new Point(17, 56);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(108, 29);
            btnRed.TabIndex = 8;
            btnRed.Text = "Red LED";
            btnRed.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 13);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 1;
            label5.Text = "RGB";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemp.Location = new Point(692, 41);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(23, 25);
            lblTemp.TabIndex = 9;
            lblTemp.Text = "0";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDistance.Location = new Point(692, 84);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(23, 25);
            lblDistance.TabIndex = 12;
            lblDistance.Text = "0";
            lblDistance.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 94);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 11;
            label7.Text = "Proximity";
            // 
            // pbarDistance
            // 
            pbarDistance.ForeColor = Color.SaddleBrown;
            pbarDistance.Location = new Point(424, 86);
            pbarDistance.Maximum = 400;
            pbarDistance.Name = "pbarDistance";
            pbarDistance.Size = new Size(262, 23);
            pbarDistance.Step = 1;
            pbarDistance.Style = ProgressBarStyle.Continuous;
            pbarDistance.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 374);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 13;
            label6.Text = "Coordinate";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(96, 374);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(36, 15);
            lblPoint.TabIndex = 14;
            lblPoint.Text = "{x , y}";
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.WhiteSmoke;
            pnlChart.Location = new Point(185, 374);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(495, 287);
            pnlChart.TabIndex = 15;
            // 
            // frmDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 673);
            Controls.Add(pnlChart);
            Controls.Add(lblPoint);
            Controls.Add(label6);
            Controls.Add(lblDistance);
            Controls.Add(label7);
            Controls.Add(pbarDistance);
            Controls.Add(lblTemp);
            Controls.Add(pnlLED);
            Controls.Add(label4);
            Controls.Add(pbarTemp);
            Controls.Add(pnlConfig);
            MaximizeBox = false;
            Name = "frmDevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arduino";
            FormClosing += frmDevice_FormClosing;
            pnlConfig.ResumeLayout(false);
            pnlConfig.PerformLayout();
            pnlLED.ResumeLayout(false);
            pnlLED.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlConfig;
        private Label label1;
        private ComboBox cmboPort;
        private Label label2;
        private ComboBox cmboBaud;
        private Label label3;
        private ProgressBar pbarTemp;
        private Label label4;
        private Button btnConnect;
        private Panel pnlLED;
        private Label label5;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnRed;
        private Label lblTemp;
        private Label lblDistance;
        private Label label7;
        private ProgressBar pbarDistance;
        private Label label6;
        private Label lblPoint;
        private Panel pnlChart;
    }
}