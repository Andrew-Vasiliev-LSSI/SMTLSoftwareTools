namespace SMTLSoftwareTools.AutoCalibration
{
    partial class Calibration
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
            this.tabControlCalibr = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.lstBaudrate = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btRepeatVoltage = new System.Windows.Forms.Button();
            this.lbInfoVoltage = new System.Windows.Forms.Label();
            this.dataGridViewResultVoltage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btStartVoltageInput = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewResultCurrent = new System.Windows.Forms.DataGridView();
            this.btStartCurrentInput = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btStartCurrentOutput = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfoCurrent = new System.Windows.Forms.Label();
            this.btRepeatCurrent = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCalibr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxConnect.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultVoltage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCurrent)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCalibr
            // 
            this.tabControlCalibr.Controls.Add(this.tabPage1);
            this.tabControlCalibr.Controls.Add(this.tabPage2);
            this.tabControlCalibr.Controls.Add(this.tabPage3);
            this.tabControlCalibr.Controls.Add(this.tabPage4);
            this.tabControlCalibr.Location = new System.Drawing.Point(6, 1);
            this.tabControlCalibr.Name = "tabControlCalibr";
            this.tabControlCalibr.SelectedIndex = 0;
            this.tabControlCalibr.Size = new System.Drawing.Size(1119, 580);
            this.tabControlCalibr.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подключение к калибратору";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.lbInfo);
            this.groupBoxConnect.Controls.Add(this.lbSpeed);
            this.groupBoxConnect.Controls.Add(this.lbPort);
            this.groupBoxConnect.Controls.Add(this.btConnect);
            this.groupBoxConnect.Controls.Add(this.lstPorts);
            this.groupBoxConnect.Controls.Add(this.lstBaudrate);
            this.groupBoxConnect.Location = new System.Drawing.Point(351, 49);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(409, 133);
            this.groupBoxConnect.TabIndex = 3;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Подключение к калибратору";
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInfo.Location = new System.Drawing.Point(217, 16);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(171, 21);
            this.lbInfo.TabIndex = 5;
            this.lbInfo.Text = "      ";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(20, 57);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(55, 13);
            this.lbSpeed.TabIndex = 4;
            this.lbSpeed.Text = "Скорость";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(20, 16);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(32, 13);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Порт";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(144, 95);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(121, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Подключится";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(81, 16);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(121, 21);
            this.lstPorts.TabIndex = 0;
            // 
            // lstBaudrate
            // 
            this.lstBaudrate.FormattingEnabled = true;
            this.lstBaudrate.Location = new System.Drawing.Point(81, 57);
            this.lstBaudrate.Name = "lstBaudrate";
            this.lstBaudrate.Size = new System.Drawing.Size(121, 21);
            this.lstBaudrate.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btRepeatVoltage);
            this.tabPage2.Controls.Add(this.lbInfoVoltage);
            this.tabPage2.Controls.Add(this.dataGridViewResultVoltage);
            this.tabPage2.Controls.Add(this.btStartVoltageInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калибровка входов по напряжению";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Информация о процессе";
            // 
            // btRepeatVoltage
            // 
            this.btRepeatVoltage.AutoSize = true;
            this.btRepeatVoltage.Enabled = false;
            this.btRepeatVoltage.Location = new System.Drawing.Point(498, 422);
            this.btRepeatVoltage.Name = "btRepeatVoltage";
            this.btRepeatVoltage.Size = new System.Drawing.Size(133, 23);
            this.btRepeatVoltage.TabIndex = 7;
            this.btRepeatVoltage.Text = "Повторить калибровку";
            this.btRepeatVoltage.UseVisualStyleBackColor = true;
            this.btRepeatVoltage.Click += new System.EventHandler(this.btVoltageRepeat_Click);
            // 
            // lbInfoVoltage
            // 
            this.lbInfoVoltage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoVoltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfoVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfoVoltage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInfoVoltage.Location = new System.Drawing.Point(381, 84);
            this.lbInfoVoltage.Name = "lbInfoVoltage";
            this.lbInfoVoltage.Size = new System.Drawing.Size(349, 21);
            this.lbInfoVoltage.TabIndex = 6;
            this.lbInfoVoltage.Text = "      ";
            // 
            // dataGridViewResultVoltage
            // 
            this.dataGridViewResultVoltage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultVoltage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridViewResultVoltage.Location = new System.Drawing.Point(381, 137);
            this.dataGridViewResultVoltage.Name = "dataGridViewResultVoltage";
            this.dataGridViewResultVoltage.Size = new System.Drawing.Size(349, 150);
            this.dataGridViewResultVoltage.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Калибровочный коэффициент";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Смещение ко входу. В";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Погрешность. мВ";
            this.Column4.Name = "Column4";
            // 
            // btStartVoltageInput
            // 
            this.btStartVoltageInput.AutoSize = true;
            this.btStartVoltageInput.Location = new System.Drawing.Point(498, 481);
            this.btStartVoltageInput.Name = "btStartVoltageInput";
            this.btStartVoltageInput.Size = new System.Drawing.Size(133, 23);
            this.btStartVoltageInput.TabIndex = 0;
            this.btStartVoltageInput.Text = "Начать калибровку";
            this.btStartVoltageInput.UseVisualStyleBackColor = true;
            this.btStartVoltageInput.Click += new System.EventHandler(this.btStartVoltageInput_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btRepeatCurrent);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lbInfoCurrent);
            this.tabPage3.Controls.Add(this.dataGridViewResultCurrent);
            this.tabPage3.Controls.Add(this.btStartCurrentInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1111, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Калибровка входов по току";
            // 
            // dataGridViewResultCurrent
            // 
            this.dataGridViewResultCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultCurrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewResultCurrent.Location = new System.Drawing.Point(429, 202);
            this.dataGridViewResultCurrent.Name = "dataGridViewResultCurrent";
            this.dataGridViewResultCurrent.Size = new System.Drawing.Size(253, 150);
            this.dataGridViewResultCurrent.TabIndex = 2;
            // 
            // btStartCurrentInput
            // 
            this.btStartCurrentInput.AutoSize = true;
            this.btStartCurrentInput.Location = new System.Drawing.Point(489, 481);
            this.btStartCurrentInput.Name = "btStartCurrentInput";
            this.btStartCurrentInput.Size = new System.Drawing.Size(133, 23);
            this.btStartCurrentInput.TabIndex = 1;
            this.btStartCurrentInput.Text = "Начать калибровку";
            this.btStartCurrentInput.UseVisualStyleBackColor = true;
            this.btStartCurrentInput.Click += new System.EventHandler(this.btStartCurrentInput_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btStartCurrentOutput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1111, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Калибровка токовых выходов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btStartCurrentOutput
            // 
            this.btStartCurrentOutput.AutoSize = true;
            this.btStartCurrentOutput.Location = new System.Drawing.Point(498, 481);
            this.btStartCurrentOutput.Name = "btStartCurrentOutput";
            this.btStartCurrentOutput.Size = new System.Drawing.Size(115, 23);
            this.btStartCurrentOutput.TabIndex = 1;
            this.btStartCurrentOutput.Text = "Начать калибровку";
            this.btStartCurrentOutput.UseVisualStyleBackColor = true;
            this.btStartCurrentOutput.Click += new System.EventHandler(this.btStartCurrentOutput_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(526, 599);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Выход";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Информация о процессе";
            // 
            // lbInfoCurrent
            // 
            this.lbInfoCurrent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfoCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfoCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInfoCurrent.Location = new System.Drawing.Point(381, 125);
            this.lbInfoCurrent.Name = "lbInfoCurrent";
            this.lbInfoCurrent.Size = new System.Drawing.Size(349, 21);
            this.lbInfoCurrent.TabIndex = 9;
            this.lbInfoCurrent.Text = "      ";
            // 
            // btRepeatCurrent
            // 
            this.btRepeatCurrent.AutoSize = true;
            this.btRepeatCurrent.Enabled = false;
            this.btRepeatCurrent.Location = new System.Drawing.Point(489, 425);
            this.btRepeatCurrent.Name = "btRepeatCurrent";
            this.btRepeatCurrent.Size = new System.Drawing.Size(133, 23);
            this.btRepeatCurrent.TabIndex = 11;
            this.btRepeatCurrent.Text = "Повторить калибровку";
            this.btRepeatCurrent.UseVisualStyleBackColor = true;
            this.btRepeatCurrent.Click += new System.EventHandler(this.btRepeatCurrent_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Коменсация в режиме тока";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Погрешность мкА";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 634);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tabControlCalibr);
            this.Name = "Calibration";
            this.Text = "Автоматическая калибровка ";
            this.tabControlCalibr.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultVoltage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCurrent)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCalibr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox lstPorts;
        private System.Windows.Forms.ComboBox lstBaudrate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btStartVoltageInput;
        private System.Windows.Forms.Button btStartCurrentInput;
        private System.Windows.Forms.Button btStartCurrentOutput;
        private System.Windows.Forms.DataGridView dataGridViewResultVoltage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewResultCurrent;
        private System.Windows.Forms.Label lbInfoVoltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btRepeatVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInfoCurrent;
        private System.Windows.Forms.Button btRepeatCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}