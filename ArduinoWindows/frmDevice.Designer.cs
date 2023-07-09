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
            btnSave = new Button();
            label1 = new Label();
            pbarTemp = new ProgressBar();
            label4 = new Label();
            btnConnect = new Button();
            panel1 = new Panel();
            btnOff = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnRed = new Button();
            label5 = new Label();
            pnlConfig.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlConfig.Controls.Add(btnSave);
            pnlConfig.Controls.Add(label1);
            pnlConfig.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConfig.Location = new Point(23, 28);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(295, 439);
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
            cmboPort.Click += cmboPort_Click;
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
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(173, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // pbarTemp
            // 
            pbarTemp.Location = new Point(435, 102);
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
            label4.Location = new Point(351, 110);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Temprature";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Red;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(334, 28);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 29);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(btnOff);
            panel1.Controls.Add(btnBlue);
            panel1.Controls.Add(btnGreen);
            panel1.Controls.Add(btnRed);
            panel1.Controls.Add(label5);
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(351, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 145);
            panel1.TabIndex = 8;
            // 
            // btnOff
            // 
            btnOff.BackColor = Color.Black;
            btnOff.ForeColor = Color.White;
            btnOff.Location = new Point(260, 56);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(75, 29);
            btnOff.TabIndex = 11;
            btnOff.Text = "Off";
            btnOff.UseVisualStyleBackColor = false;
            btnOff.Click += btnOff_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.FromArgb(0, 0, 192);
            btnBlue.ForeColor = Color.White;
            btnBlue.Location = new Point(179, 56);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(75, 29);
            btnBlue.TabIndex = 10;
            btnBlue.Text = "Blue";
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.ForeColor = Color.White;
            btnGreen.Location = new Point(98, 56);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(75, 29);
            btnGreen.TabIndex = 9;
            btnGreen.Text = "Green";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.ForeColor = Color.White;
            btnRed.Location = new Point(17, 56);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(75, 29);
            btnRed.TabIndex = 8;
            btnRed.Text = "Red";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
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
            // frmDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 491);
            Controls.Add(panel1);
            Controls.Add(btnConnect);
            Controls.Add(label4);
            Controls.Add(pbarTemp);
            Controls.Add(pnlConfig);
            MaximizeBox = false;
            Name = "frmDevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arduino";
            Load += frmDevice_Load;
            pnlConfig.ResumeLayout(false);
            pnlConfig.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlConfig;
        private Label label1;
        private ComboBox cmboPort;
        private Label label2;
        private Button btnSave;
        private ComboBox cmboBaud;
        private Label label3;
        private ProgressBar pbarTemp;
        private Label label4;
        private Button btnConnect;
        private Panel panel1;
        private Label label5;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnRed;
        private Button btnOff;
    }
}