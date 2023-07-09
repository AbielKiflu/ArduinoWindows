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
            pnlConfig.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConfig
            // 
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
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Port Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(173, 175);
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
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Config";
            // 
            // frmDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 491);
            Controls.Add(pnlConfig);
            MaximizeBox = false;
            Name = "frmDevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arduino";
            Load += frmDevice_Load;
            pnlConfig.ResumeLayout(false);
            pnlConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConfig;
        private Label label1;
        private ComboBox cmboPort;
        private Label label2;
        private Button btnSave;
        private ComboBox cmboBaud;
        private Label label3;
    }
}