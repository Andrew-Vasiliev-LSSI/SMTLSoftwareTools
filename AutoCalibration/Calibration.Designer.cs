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
            this.cbEnableCheckErrors = new System.Windows.Forms.CheckBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.lstBaudrate = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCheckVoltage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRepeatVoltage = new System.Windows.Forms.Button();
            this.lbInfoVoltage = new System.Windows.Forms.Label();
            this.dataGridViewResultVoltage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btStartVoltageInput = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btCheckCurrent = new System.Windows.Forms.Button();
            this.btRepeatCurrent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfoCurrent = new System.Windows.Forms.Label();
            this.dataGridViewResultCurrent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btStartCurrentInput = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btCheckAnalog = new System.Windows.Forms.Button();
            this.dataGridViewResultOutput4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultOutput3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultOutput2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInfoOutput = new System.Windows.Forms.Label();
            this.dataGridViewResultOutput1 = new System.Windows.Forms.DataGridView();
            this.prameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btStartCurrentOutput = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlCalibr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxConnect.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultVoltage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCurrent)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCalibr
            // 
            this.tabControlCalibr.Controls.Add(this.tabPage1);
            this.tabControlCalibr.Controls.Add(this.tabPage2);
            this.tabControlCalibr.Controls.Add(this.tabPage3);
            this.tabControlCalibr.Controls.Add(this.tabPage4);
            this.tabControlCalibr.Location = new System.Drawing.Point(4, 1);
            this.tabControlCalibr.Name = "tabControlCalibr";
            this.tabControlCalibr.SelectedIndex = 0;
            this.tabControlCalibr.Size = new System.Drawing.Size(1119, 580);
            this.tabControlCalibr.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbEnableCheckErrors);
            this.tabPage1.Controls.Add(this.groupBoxConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подключение к калибратору";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbEnableCheckErrors
            // 
            this.cbEnableCheckErrors.AutoSize = true;
            this.cbEnableCheckErrors.Location = new System.Drawing.Point(452, 252);
            this.cbEnableCheckErrors.Name = "cbEnableCheckErrors";
            this.cbEnableCheckErrors.Size = new System.Drawing.Size(207, 17);
            this.cbEnableCheckErrors.TabIndex = 4;
            this.cbEnableCheckErrors.Text = "Разрешить проверку погрешностей";
            this.cbEnableCheckErrors.UseVisualStyleBackColor = true;
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
            this.btConnect.Text = "Подключиться";
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
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btCheckVoltage);
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
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btCheckVoltage
            // 
            this.btCheckVoltage.AutoSize = true;
            this.btCheckVoltage.Location = new System.Drawing.Point(489, 351);
            this.btCheckVoltage.Name = "btCheckVoltage";
            this.btCheckVoltage.Size = new System.Drawing.Size(141, 23);
            this.btCheckVoltage.TabIndex = 9;
            this.btCheckVoltage.Text = "Проверить погрешности";
            this.btCheckVoltage.UseVisualStyleBackColor = true;
            this.btCheckVoltage.Click += new System.EventHandler(this.btCheckVoltage_Click);
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
            this.btRepeatVoltage.Location = new System.Drawing.Point(489, 422);
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
            this.dataGridViewResultVoltage.AllowUserToAddRows = false;
            this.dataGridViewResultVoltage.AllowUserToDeleteRows = false;
            this.dataGridViewResultVoltage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultVoltage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewResultVoltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.btStartVoltageInput.Location = new System.Drawing.Point(489, 481);
            this.btStartVoltageInput.Name = "btStartVoltageInput";
            this.btStartVoltageInput.Size = new System.Drawing.Size(133, 23);
            this.btStartVoltageInput.TabIndex = 0;
            this.btStartVoltageInput.Text = "Начать калибровку";
            this.btStartVoltageInput.UseVisualStyleBackColor = true;
            this.btStartVoltageInput.Click += new System.EventHandler(this.btStartVoltageInput_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btCheckCurrent);
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
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // btCheckCurrent
            // 
            this.btCheckCurrent.AutoSize = true;
            this.btCheckCurrent.Location = new System.Drawing.Point(489, 351);
            this.btCheckCurrent.Name = "btCheckCurrent";
            this.btCheckCurrent.Size = new System.Drawing.Size(141, 23);
            this.btCheckCurrent.TabIndex = 12;
            this.btCheckCurrent.Text = "Проверить погрешности";
            this.btCheckCurrent.UseVisualStyleBackColor = true;
            this.btCheckCurrent.Click += new System.EventHandler(this.btCheckCurrent_Click);
            // 
            // btRepeatCurrent
            // 
            this.btRepeatCurrent.AutoSize = true;
            this.btRepeatCurrent.Enabled = false;
            this.btRepeatCurrent.Location = new System.Drawing.Point(489, 422);
            this.btRepeatCurrent.Name = "btRepeatCurrent";
            this.btRepeatCurrent.Size = new System.Drawing.Size(133, 23);
            this.btRepeatCurrent.TabIndex = 11;
            this.btRepeatCurrent.Text = "Повторить калибровку";
            this.btRepeatCurrent.UseVisualStyleBackColor = true;
            this.btRepeatCurrent.Click += new System.EventHandler(this.btRepeatCurrent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 68);
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
            this.lbInfoCurrent.Location = new System.Drawing.Point(381, 84);
            this.lbInfoCurrent.Name = "lbInfoCurrent";
            this.lbInfoCurrent.Size = new System.Drawing.Size(349, 21);
            this.lbInfoCurrent.TabIndex = 9;
            this.lbInfoCurrent.Text = "      ";
            // 
            // dataGridViewResultCurrent
            // 
            this.dataGridViewResultCurrent.AllowUserToAddRows = false;
            this.dataGridViewResultCurrent.AllowUserToDeleteRows = false;
            this.dataGridViewResultCurrent.AllowUserToResizeColumns = false;
            this.dataGridViewResultCurrent.AllowUserToResizeRows = false;
            this.dataGridViewResultCurrent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultCurrent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResultCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResultCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultCurrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewResultCurrent.Location = new System.Drawing.Point(429, 137);
            this.dataGridViewResultCurrent.Name = "dataGridViewResultCurrent";
            this.dataGridViewResultCurrent.Size = new System.Drawing.Size(253, 150);
            this.dataGridViewResultCurrent.TabIndex = 2;
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
            this.tabPage4.Controls.Add(this.btCheckAnalog);
            this.tabPage4.Controls.Add(this.dataGridViewResultOutput4);
            this.tabPage4.Controls.Add(this.dataGridViewResultOutput3);
            this.tabPage4.Controls.Add(this.dataGridViewResultOutput2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.lbInfoOutput);
            this.tabPage4.Controls.Add(this.dataGridViewResultOutput1);
            this.tabPage4.Controls.Add(this.btStartCurrentOutput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1111, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Калибровка токовых выходов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btCheckAnalog
            // 
            this.btCheckAnalog.AutoSize = true;
            this.btCheckAnalog.Enabled = false;
            this.btCheckAnalog.Location = new System.Drawing.Point(489, 383);
            this.btCheckAnalog.Name = "btCheckAnalog";
            this.btCheckAnalog.Size = new System.Drawing.Size(141, 23);
            this.btCheckAnalog.TabIndex = 16;
            this.btCheckAnalog.Text = "Проверить погрешности";
            this.btCheckAnalog.UseVisualStyleBackColor = true;
            this.btCheckAnalog.Click += new System.EventHandler(this.btCheckAnalog_Click);
            // 
            // dataGridViewResultOutput4
            // 
            this.dataGridViewResultOutput4.AllowUserToAddRows = false;
            this.dataGridViewResultOutput4.AllowUserToDeleteRows = false;
            this.dataGridViewResultOutput4.AllowUserToResizeColumns = false;
            this.dataGridViewResultOutput4.AllowUserToResizeRows = false;
            this.dataGridViewResultOutput4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultOutput4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultOutput4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewResultOutput4.Location = new System.Drawing.Point(847, 155);
            this.dataGridViewResultOutput4.Name = "dataGridViewResultOutput4";
            this.dataGridViewResultOutput4.Size = new System.Drawing.Size(247, 150);
            this.dataGridViewResultOutput4.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewResultOutput3
            // 
            this.dataGridViewResultOutput3.AllowUserToAddRows = false;
            this.dataGridViewResultOutput3.AllowUserToDeleteRows = false;
            this.dataGridViewResultOutput3.AllowUserToResizeColumns = false;
            this.dataGridViewResultOutput3.AllowUserToResizeRows = false;
            this.dataGridViewResultOutput3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultOutput3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultOutput3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewResultOutput3.Location = new System.Drawing.Point(570, 155);
            this.dataGridViewResultOutput3.Name = "dataGridViewResultOutput3";
            this.dataGridViewResultOutput3.Size = new System.Drawing.Size(247, 150);
            this.dataGridViewResultOutput3.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewResultOutput2
            // 
            this.dataGridViewResultOutput2.AllowUserToAddRows = false;
            this.dataGridViewResultOutput2.AllowUserToDeleteRows = false;
            this.dataGridViewResultOutput2.AllowUserToResizeColumns = false;
            this.dataGridViewResultOutput2.AllowUserToResizeRows = false;
            this.dataGridViewResultOutput2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultOutput2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultOutput2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewResultOutput2.Location = new System.Drawing.Point(293, 155);
            this.dataGridViewResultOutput2.Name = "dataGridViewResultOutput2";
            this.dataGridViewResultOutput2.Size = new System.Drawing.Size(247, 150);
            this.dataGridViewResultOutput2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Параметр";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Информация о процессе";
            // 
            // lbInfoOutput
            // 
            this.lbInfoOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfoOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInfoOutput.Location = new System.Drawing.Point(310, 84);
            this.lbInfoOutput.Name = "lbInfoOutput";
            this.lbInfoOutput.Size = new System.Drawing.Size(491, 21);
            this.lbInfoOutput.TabIndex = 11;
            // 
            // dataGridViewResultOutput1
            // 
            this.dataGridViewResultOutput1.AllowUserToAddRows = false;
            this.dataGridViewResultOutput1.AllowUserToDeleteRows = false;
            this.dataGridViewResultOutput1.AllowUserToResizeColumns = false;
            this.dataGridViewResultOutput1.AllowUserToResizeRows = false;
            this.dataGridViewResultOutput1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultOutput1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultOutput1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prameter,
            this.value});
            this.dataGridViewResultOutput1.Location = new System.Drawing.Point(16, 155);
            this.dataGridViewResultOutput1.Name = "dataGridViewResultOutput1";
            this.dataGridViewResultOutput1.Size = new System.Drawing.Size(247, 150);
            this.dataGridViewResultOutput1.TabIndex = 2;
            // 
            // prameter
            // 
            this.prameter.HeaderText = "Параметр";
            this.prameter.Name = "prameter";
            // 
            // value
            // 
            this.value.HeaderText = "Значение";
            this.value.Name = "value";
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
            this.tabPage1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultOutput1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewResultOutput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbInfoOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn prameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridView dataGridViewResultOutput4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dataGridViewResultOutput3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridViewResultOutput2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btCheckVoltage;
        private System.Windows.Forms.Button btCheckCurrent;
        private System.Windows.Forms.Button btCheckAnalog;
        private System.Windows.Forms.CheckBox cbEnableCheckErrors;
    }
}