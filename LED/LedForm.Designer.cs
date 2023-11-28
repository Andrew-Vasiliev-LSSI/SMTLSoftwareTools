namespace SMTLSoftwareTools.LED
{
    partial class LedForm
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
            this.btLedTest = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLedTest
            // 
            this.btLedTest.Location = new System.Drawing.Point(156, 135);
            this.btLedTest.Name = "btLedTest";
            this.btLedTest.Size = new System.Drawing.Size(112, 23);
            this.btLedTest.TabIndex = 10;
            this.btLedTest.Text = "Выполнить тест";
            this.btLedTest.UseVisualStyleBackColor = true;
            this.btLedTest.Click += new System.EventHandler(this.btLedTest_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(173, 227);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // LedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 293);
            this.Controls.Add(this.btLedTest);
            this.Controls.Add(this.btExit);
            this.Name = "LedForm";
            this.Text = "Тест светодиодов и выходных реле";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLedTest;
        private System.Windows.Forms.Button btExit;
    }
}