
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
            this.SuspendLayout();
            // 
            // textBoxSerNum
            // 
            this.textBoxSerNum.Location = new System.Drawing.Point(197, 98);
            this.textBoxSerNum.Name = "textBoxSerNum";
            this.textBoxSerNum.Size = new System.Drawing.Size(214, 20);
            this.textBoxSerNum.TabIndex = 0;
            // 
            // labelSerNum
            // 
            this.labelSerNum.AutoSize = true;
            this.labelSerNum.Location = new System.Drawing.Point(211, 82);
            this.labelSerNum.Name = "labelSerNum";
            this.labelSerNum.Size = new System.Drawing.Size(138, 13);
            this.labelSerNum.TabIndex = 1;
            this.labelSerNum.Text = "Серийный номер прибора";
            // 
            // btWriteManual
            // 
            this.btWriteManual.Location = new System.Drawing.Point(197, 165);
            this.btWriteManual.Name = "btWriteManual";
            this.btWriteManual.Size = new System.Drawing.Size(214, 23);
            this.btWriteManual.TabIndex = 2;
            this.btWriteManual.Text = "Запись серийного номера вручную";
            this.btWriteManual.UseVisualStyleBackColor = true;
            this.btWriteManual.Click += new System.EventHandler(this.btWriteManual_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(267, 270);
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
            this.lstPorts.Location = new System.Drawing.Point(38, 97);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(121, 21);
            this.lstPorts.TabIndex = 4;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(38, 78);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(141, 13);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "Выбор  порта для сканера";
            // 
            // btPortSelect
            // 
            this.btPortSelect.Location = new System.Drawing.Point(38, 137);
            this.btPortSelect.Name = "btPortSelect";
            this.btPortSelect.Size = new System.Drawing.Size(121, 23);
            this.btPortSelect.TabIndex = 6;
            this.btPortSelect.Text = "Выбор";
            this.btPortSelect.UseVisualStyleBackColor = true;
            this.btPortSelect.Click += new System.EventHandler(this.btPortSelect_Click);
            // 
            // btScan
            // 
            this.btScan.Enabled = false;
            this.btScan.Location = new System.Drawing.Point(197, 209);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(214, 23);
            this.btScan.TabIndex = 7;
            this.btScan.Text = "Сканирование серийного номера ";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // RecordSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.btPortSelect);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lstPorts);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btWriteManual);
            this.Controls.Add(this.labelSerNum);
            this.Controls.Add(this.textBoxSerNum);
            this.Name = "RecordSerialNumber";
            this.Text = "Запись серийного номера";
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
    }
}