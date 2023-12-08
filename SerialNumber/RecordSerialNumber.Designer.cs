
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
            this.btScan = new System.Windows.Forms.Button();
            this.labelMacAddr = new System.Windows.Forms.Label();
            this.textBoxMacAddr = new System.Windows.Forms.TextBox();
            this.btWriteMac = new System.Windows.Forms.Button();
            this.labelInterface = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSerNum
            // 
            this.textBoxSerNum.Location = new System.Drawing.Point(124, 98);
            this.textBoxSerNum.Name = "textBoxSerNum";
            this.textBoxSerNum.Size = new System.Drawing.Size(214, 20);
            this.textBoxSerNum.TabIndex = 0;
            // 
            // labelSerNum
            // 
            this.labelSerNum.AutoSize = true;
            this.labelSerNum.Location = new System.Drawing.Point(121, 82);
            this.labelSerNum.Name = "labelSerNum";
            this.labelSerNum.Size = new System.Drawing.Size(138, 13);
            this.labelSerNum.TabIndex = 1;
            this.labelSerNum.Text = "Серийный номер прибора";
            // 
            // btWriteManual
            // 
            this.btWriteManual.Location = new System.Drawing.Point(124, 137);
            this.btWriteManual.Name = "btWriteManual";
            this.btWriteManual.Size = new System.Drawing.Size(214, 23);
            this.btWriteManual.TabIndex = 2;
            this.btWriteManual.Text = "Запись серийного номера вручную";
            this.btWriteManual.UseVisualStyleBackColor = true;
            this.btWriteManual.Click += new System.EventHandler(this.btWriteManual_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(192, 346);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(124, 181);
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
            this.labelMacAddr.Location = new System.Drawing.Point(121, 220);
            this.labelMacAddr.Name = "labelMacAddr";
            this.labelMacAddr.Size = new System.Drawing.Size(129, 13);
            this.labelMacAddr.TabIndex = 9;
            this.labelMacAddr.Text = "MAC адрес. Интерфейс:";
            // 
            // textBoxMacAddr
            // 
            this.textBoxMacAddr.Location = new System.Drawing.Point(124, 236);
            this.textBoxMacAddr.Name = "textBoxMacAddr";
            this.textBoxMacAddr.Size = new System.Drawing.Size(214, 20);
            this.textBoxMacAddr.TabIndex = 8;
            // 
            // btWriteMac
            // 
            this.btWriteMac.Location = new System.Drawing.Point(124, 275);
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
            this.labelInterface.Location = new System.Drawing.Point(256, 220);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(16, 13);
            this.labelInterface.TabIndex = 12;
            this.labelInterface.Text = "   ";
            // 
            // RecordSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 381);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSerNum;
        private System.Windows.Forms.Label labelSerNum;
        private System.Windows.Forms.Button btWriteManual;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.Label labelMacAddr;
        private System.Windows.Forms.TextBox textBoxMacAddr;
        private System.Windows.Forms.Button btWriteMac;
        private System.Windows.Forms.Label labelInterface;
    }
}