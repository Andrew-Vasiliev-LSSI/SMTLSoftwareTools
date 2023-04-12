namespace SMTLSoftwareTools.SetpointsConfig
{
    partial class SetpointsConfigForms
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
            this.btWrite = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dataGridViewSetpoints1 = new System.Windows.Forms.DataGridView();
            this.Param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSp1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbSp4 = new System.Windows.Forms.Label();
            this.lbSp3 = new System.Windows.Forms.Label();
            this.lbSp2 = new System.Windows.Forms.Label();
            this.dataGridViewSetpoints4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSetpoints3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSetpoints2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints2)).BeginInit();
            this.SuspendLayout();
            // 
            // btWrite
            // 
            this.btWrite.Enabled = false;
            this.btWrite.Location = new System.Drawing.Point(24, 20);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(146, 23);
            this.btWrite.TabIndex = 10;
            this.btWrite.Text = "Записать в прибор";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(60, 66);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dataGridViewSetpoints1
            // 
            this.dataGridViewSetpoints1.AllowUserToAddRows = false;
            this.dataGridViewSetpoints1.AllowUserToDeleteRows = false;
            this.dataGridViewSetpoints1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Param,
            this.hl,
            this.hh});
            this.dataGridViewSetpoints1.Location = new System.Drawing.Point(14, 26);
            this.dataGridViewSetpoints1.Name = "dataGridViewSetpoints1";
            this.dataGridViewSetpoints1.Size = new System.Drawing.Size(300, 193);
            this.dataGridViewSetpoints1.TabIndex = 11;
            // 
            // Param
            // 
            this.Param.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Param.HeaderText = "Параметр";
            this.Param.Name = "Param";
            // 
            // hl
            // 
            this.hl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hl.HeaderText = "ВПУ";
            this.hl.Name = "hl";
            this.hl.Width = 55;
            // 
            // hh
            // 
            this.hh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hh.HeaderText = "ВАУ";
            this.hh.Name = "hh";
            this.hh.Width = 54;
            // 
            // lbSp1
            // 
            this.lbSp1.AutoSize = true;
            this.lbSp1.Location = new System.Drawing.Point(11, 10);
            this.lbSp1.Name = "lbSp1";
            this.lbSp1.Size = new System.Drawing.Size(47, 13);
            this.lbSp1.TabIndex = 12;
            this.lbSp1.Text = "Канал 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btWrite);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Location = new System.Drawing.Point(263, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSp4);
            this.panel3.Controls.Add(this.lbSp3);
            this.panel3.Controls.Add(this.lbSp2);
            this.panel3.Controls.Add(this.dataGridViewSetpoints4);
            this.panel3.Controls.Add(this.dataGridViewSetpoints3);
            this.panel3.Controls.Add(this.dataGridViewSetpoints2);
            this.panel3.Controls.Add(this.dataGridViewSetpoints1);
            this.panel3.Controls.Add(this.lbSp1);
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 458);
            this.panel3.TabIndex = 14;
            // 
            // lbSp4
            // 
            this.lbSp4.AutoSize = true;
            this.lbSp4.Location = new System.Drawing.Point(352, 228);
            this.lbSp4.Name = "lbSp4";
            this.lbSp4.Size = new System.Drawing.Size(47, 13);
            this.lbSp4.TabIndex = 18;
            this.lbSp4.Text = "Канал 4";
            // 
            // lbSp3
            // 
            this.lbSp3.AutoSize = true;
            this.lbSp3.Location = new System.Drawing.Point(11, 228);
            this.lbSp3.Name = "lbSp3";
            this.lbSp3.Size = new System.Drawing.Size(47, 13);
            this.lbSp3.TabIndex = 17;
            this.lbSp3.Text = "Канал 3";
            // 
            // lbSp2
            // 
            this.lbSp2.AutoSize = true;
            this.lbSp2.Location = new System.Drawing.Point(352, 10);
            this.lbSp2.Name = "lbSp2";
            this.lbSp2.Size = new System.Drawing.Size(47, 13);
            this.lbSp2.TabIndex = 16;
            this.lbSp2.Text = "Канал 2";
            // 
            // dataGridViewSetpoints4
            // 
            this.dataGridViewSetpoints4.AllowUserToAddRows = false;
            this.dataGridViewSetpoints4.AllowUserToDeleteRows = false;
            this.dataGridViewSetpoints4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewSetpoints4.Location = new System.Drawing.Point(356, 244);
            this.dataGridViewSetpoints4.Name = "dataGridViewSetpoints4";
            this.dataGridViewSetpoints4.Size = new System.Drawing.Size(300, 193);
            this.dataGridViewSetpoints4.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "ВПУ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 55;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.HeaderText = "ВАУ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 54;
            // 
            // dataGridViewSetpoints3
            // 
            this.dataGridViewSetpoints3.AllowUserToAddRows = false;
            this.dataGridViewSetpoints3.AllowUserToDeleteRows = false;
            this.dataGridViewSetpoints3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewSetpoints3.Location = new System.Drawing.Point(14, 244);
            this.dataGridViewSetpoints3.Name = "dataGridViewSetpoints3";
            this.dataGridViewSetpoints3.Size = new System.Drawing.Size(300, 193);
            this.dataGridViewSetpoints3.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "ВПУ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 55;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "ВАУ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 54;
            // 
            // dataGridViewSetpoints2
            // 
            this.dataGridViewSetpoints2.AllowUserToAddRows = false;
            this.dataGridViewSetpoints2.AllowUserToDeleteRows = false;
            this.dataGridViewSetpoints2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewSetpoints2.Location = new System.Drawing.Point(355, 26);
            this.dataGridViewSetpoints2.Name = "dataGridViewSetpoints2";
            this.dataGridViewSetpoints2.Size = new System.Drawing.Size(300, 193);
            this.dataGridViewSetpoints2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "ВПУ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "ВАУ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // SetpointsConfigForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "SetpointsConfigForms";
            this.Text = "Задание уставок";
            this.Load += new System.EventHandler(this.SetpointsConfigForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetpoints2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dataGridViewSetpoints1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param;
        private System.Windows.Forms.DataGridViewTextBoxColumn hl;
        private System.Windows.Forms.DataGridViewTextBoxColumn hh;
        private System.Windows.Forms.Label lbSp1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSp4;
        private System.Windows.Forms.Label lbSp3;
        private System.Windows.Forms.Label lbSp2;
        private System.Windows.Forms.DataGridView dataGridViewSetpoints4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dataGridViewSetpoints3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridViewSetpoints2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}