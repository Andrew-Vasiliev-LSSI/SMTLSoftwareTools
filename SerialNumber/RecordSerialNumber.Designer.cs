
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
            // 
            // RecordSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
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
    }
}