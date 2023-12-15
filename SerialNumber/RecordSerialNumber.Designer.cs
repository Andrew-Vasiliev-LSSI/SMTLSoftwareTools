
namespace SMTLSoftwareTools.SerialNumber
{
    partial class RecordSerialNumber
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
            this.textBoxSerNum = new System.Windows.Forms.TextBox();
            this.labelSerNum = new System.Windows.Forms.Label();
            this.btWriteManual = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.btPortSelect = new System.Windows.Forms.Button();
            this.btScan = new System.Windows.Forms.Button();
            this.labelMacAddr = new System.Windows.Forms.Label();
            this.textBoxMacAddr = new System.Windows.Forms.TextBox();
            this.btWriteMac = new System.Windows.Forms.Button();
            this.labelInterface = new System.Windows.Forms.Label();
            this.panelVCOM = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHid = new System.Windows.Forms.RadioButton();
            this.rbVcom = new System.Windows.Forms.RadioButton();
            this.panelVCOM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSerNum
            // 
            this.textBoxSerNum.Location = new System.Drawing.Point(199, 98);
            this.textBoxSerNum.Name = "textBoxSerNum";
            this.textBoxSerNum.Size = new System.Drawing.Size(214, 20);
            this.textBoxSerNum.TabIndex = 0;
            // 
            // labelSerNum
            // 
            this.labelSerNum.AutoSize = true;
            this.labelSerNum.Location = new System.Drawing.Point(196, 82);
            this.labelSerNum.Name = "labelSerNum";
            this.labelSerNum.Size = new System.Drawing.Size(138, 13);
            this.labelSerNum.TabIndex = 1;
            this.labelSerNum.Text = "Серийный номер прибора";
            // 
            // btWriteManual
            // 
            this.btWriteManual.Location = new System.Drawing.Point(199, 137);
            this.btWriteManual.Name = "btWriteManual";
            this.btWriteManual.Size = new System.Drawing.Size(214, 23);
            this.btWriteManual.TabIndex = 2;
            this.btWriteManual.Text = "Запись серийного номера вручную";
            this.btWriteManual.UseVisualStyleBackColor = true;
            this.btWriteManual.Click += new System.EventHandler(this.btWriteManual_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(267, 346);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(14, 29);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(121, 21);
            this.lstPorts.TabIndex = 4;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(14, 10);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(141, 13);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "Выбор  порта для сканера";
            // 
            // btPortSelect
            // 
            this.btPortSelect.Location = new System.Drawing.Point(14, 69);
            this.btPortSelect.Name = "btPortSelect";
            this.btPortSelect.Size = new System.Drawing.Size(121, 23);
            this.btPortSelect.TabIndex = 6;
            this.btPortSelect.Text = "Выбор";
            this.btPortSelect.UseVisualStyleBackColor = true;
            this.btPortSelect.Click += new System.EventHandler(this.btPortSelect_Click);
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(199, 181);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(214, 23);
            this.btScan.TabIndex = 7;
            this.btScan.Text = "Сканирование серийного номера ";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // labelMacAddr
            // 
            this.labelMacAddr.AutoSize = true;
            this.labelMacAddr.Location = new System.Drawing.Point(196, 220);
            this.labelMacAddr.Name = "labelMacAddr";
            this.labelMacAddr.Size = new System.Drawing.Size(129, 13);
            this.labelMacAddr.TabIndex = 9;
            this.labelMacAddr.Text = "MAC адрес. Интерфейс:";
            // 
            // textBoxMacAddr
            // 
            this.textBoxMacAddr.Location = new System.Drawing.Point(199, 236);
            this.textBoxMacAddr.Name = "textBoxMacAddr";
            this.textBoxMacAddr.Size = new System.Drawing.Size(214, 20);
            this.textBoxMacAddr.TabIndex = 8;
            // 
            // btWriteMac
            // 
            this.btWriteMac.Location = new System.Drawing.Point(199, 275);
            this.btWriteMac.Name = "btWriteMac";
            this.btWriteMac.Size = new System.Drawing.Size(214, 23);
            this.btWriteMac.TabIndex = 11;
            this.btWriteMac.Text = "Запись MAC адреса";
            this.btWriteMac.UseVisualStyleBackColor = true;
            this.btWriteMac.Click += new System.EventHandler(this.btWriteMac_Click);
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(331, 220);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(16, 13);
            this.labelInterface.TabIndex = 12;
            this.labelInterface.Text = "   ";
            // 
            // panelVCOM
            // 
            this.panelVCOM.Controls.Add(this.lbPort);
            this.panelVCOM.Controls.Add(this.lstPorts);
            this.panelVCOM.Controls.Add(this.btPortSelect);
            this.panelVCOM.Location = new System.Drawing.Point(12, 12);
            this.panelVCOM.Name = "panelVCOM";
            this.panelVCOM.Size = new System.Drawing.Size(167, 100);
            this.panelVCOM.TabIndex = 13;
            this.panelVCOM.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVcom);
            this.groupBox1.Controls.Add(this.rbHid);
            this.groupBox1.Location = new System.Drawing.Point(199, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 41);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор интерфейса для сканера";
            // 
            // rbHid
            // 
            this.rbHid.AutoSize = true;
            this.rbHid.Checked = true;
            this.rbHid.Location = new System.Drawing.Point(7, 18);
            this.rbHid.Name = "rbHid";
            this.rbHid.Size = new System.Drawing.Size(69, 17);
            this.rbHid.TabIndex = 0;
            this.rbHid.TabStop = true;
            this.rbHid.Text = "USB HID";
            this.rbHid.UseVisualStyleBackColor = true;
            this.rbHid.Click += new System.EventHandler(this.rbHid_Click);
            // 
            // rbVcom
            // 
            this.rbVcom.AutoSize = true;
            this.rbVcom.Location = new System.Drawing.Point(152, 18);
            this.rbVcom.Name = "rbVcom";
            this.rbVcom.Size = new System.Drawing.Size(56, 17);
            this.rbVcom.TabIndex = 1;
            this.rbVcom.Text = "VCOM";
            this.rbVcom.UseVisualStyleBackColor = true;
            this.rbVcom.Click += new System.EventHandler(this.rbVcom_Click);
            // 
            // RecordSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelVCOM);
            this.Controls.Add(this.labelInterface);
            this.Controls.Add(this.btWriteMac);
            this.Controls.Add(this.labelMacAddr);
            this.Controls.Add(this.textBoxMacAddr);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btWriteManual);
            this.Controls.Add(this.labelSerNum);
            this.Controls.Add(this.textBoxSerNum);
            this.Name = "RecordSerialNumber";
            this.Text = "Запись серийного номера и MAC адреса";
            this.panelVCOM.ResumeLayout(false);
            this.panelVCOM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSerNum;
        private System.Windows.Forms.Label labelSerNum;
        private System.Windows.Forms.Button btWriteManual;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox lstPorts;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btPortSelect;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.Label labelMacAddr;
        private System.Windows.Forms.TextBox textBoxMacAddr;
        private System.Windows.Forms.Button btWriteMac;
        private System.Windows.Forms.Label labelInterface;
        private System.Windows.Forms.Panel panelVCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVcom;
        private System.Windows.Forms.RadioButton rbHid;
    }
}