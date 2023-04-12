namespace SMTLSoftwareTools.ConfigManagment
{
    partial class ConfigManagmentForm
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
            this.btExit = new System.Windows.Forms.Button();
            this.btSaveConfig = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLoadConfig = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(129, 171);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.Location = new System.Drawing.Point(36, 25);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(180, 23);
            this.btSaveConfig.TabIndex = 11;
            this.btSaveConfig.Text = "Сохранение конфигурации";
            this.btSaveConfig.UseVisualStyleBackColor = true;
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btLoadConfig);
            this.panel2.Controls.Add(this.btSaveConfig);
            this.panel2.Location = new System.Drawing.Point(54, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 110);
            this.panel2.TabIndex = 12;
            // 
            // btLoadConfig
            // 
            this.btLoadConfig.Location = new System.Drawing.Point(36, 65);
            this.btLoadConfig.Name = "btLoadConfig";
            this.btLoadConfig.Size = new System.Drawing.Size(180, 23);
            this.btLoadConfig.TabIndex = 12;
            this.btLoadConfig.Text = "Загрузка конфигурации";
            this.btLoadConfig.UseVisualStyleBackColor = true;
            this.btLoadConfig.Click += new System.EventHandler(this.btLoadConfig_Click);
            // 
            // ConfigManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 239);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel2);
            this.Name = "ConfigManagmentForm";
            this.Text = "Управление конфигурацией";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSaveConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLoadConfig;
    }
}