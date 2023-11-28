
namespace SMTLSoftwareTools
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAS02 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxSerNum = new System.Windows.Forms.TextBox();
            this.lbSerNum = new System.Windows.Forms.Label();
            this.lbConnect = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.btExecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtSerialNumber = new System.Windows.Forms.RadioButton();
            this.rbtAutoCalibration = new System.Windows.Forms.RadioButton();
            this.rbtDeviceConfig = new System.Windows.Forms.RadioButton();
            this.rbtConfigManagement = new System.Windows.Forms.RadioButton();
            this.rbtSetpoint = new System.Windows.Forms.RadioButton();
            this.rbtSensorConfig = new System.Windows.Forms.RadioButton();
            this.tabPageRT24 = new System.Windows.Forms.TabPage();
            this.btRtConfig = new System.Windows.Forms.Button();
            this.tabPageAI24 = new System.Windows.Forms.TabPage();
            this.btAiConfig = new System.Windows.Forms.Button();
            this.tabPageFMD2 = new System.Windows.Forms.TabPage();
            this.btFmdConfig = new System.Windows.Forms.Button();
            this.tabPageAS01 = new System.Windows.Forms.TabPage();
            this.btAs01Show = new System.Windows.Forms.Button();
            this.btAs01Calibr = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.rbtLed = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPageAS02.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRT24.SuspendLayout();
            this.tabPageAI24.SuspendLayout();
            this.tabPageFMD2.SuspendLayout();
            this.tabPageAS01.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAS02);
            this.tabControl1.Controls.Add(this.tabPageRT24);
            this.tabControl1.Controls.Add(this.tabPageAI24);
            this.tabControl1.Controls.Add(this.tabPageFMD2);
            this.tabControl1.Controls.Add(this.tabPageAS01);
            this.tabControl1.Location = new System.Drawing.Point(50, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAS02
            // 
            this.tabPageAS02.Controls.Add(this.panel2);
            this.tabPageAS02.Controls.Add(this.btExecute);
            this.tabPageAS02.Controls.Add(this.panel1);
            this.tabPageAS02.Location = new System.Drawing.Point(4, 22);
            this.tabPageAS02.Name = "tabPageAS02";
            this.tabPageAS02.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAS02.Size = new System.Drawing.Size(485, 432);
            this.tabPageAS02.TabIndex = 0;
            this.tabPageAS02.Text = "AS02";
            this.tabPageAS02.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbVersion);
            this.panel2.Controls.Add(this.textBoxVersion);
            this.panel2.Controls.Add(this.textBoxSerNum);
            this.panel2.Controls.Add(this.lbSerNum);
            this.panel2.Controls.Add(this.lbConnect);
            this.panel2.Controls.Add(this.btConnect);
            this.panel2.Controls.Add(this.textBoxIP);
            this.panel2.Controls.Add(this.lbIP);
            this.panel2.Location = new System.Drawing.Point(48, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 112);
            this.panel2.TabIndex = 2;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(22, 69);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(63, 13);
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "Версия ПО";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(115, 66);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(117, 20);
            this.textBoxVersion.TabIndex = 6;
            // 
            // textBoxSerNum
            // 
            this.textBoxSerNum.Location = new System.Drawing.Point(115, 40);
            this.textBoxSerNum.Name = "textBoxSerNum";
            this.textBoxSerNum.ReadOnly = true;
            this.textBoxSerNum.Size = new System.Drawing.Size(117, 20);
            this.textBoxSerNum.TabIndex = 5;
            // 
            // lbSerNum
            // 
            this.lbSerNum.AutoSize = true;
            this.lbSerNum.Location = new System.Drawing.Point(22, 44);
            this.lbSerNum.Name = "lbSerNum";
            this.lbSerNum.Size = new System.Drawing.Size(93, 13);
            this.lbSerNum.TabIndex = 4;
            this.lbSerNum.Text = "Серийный номер";
            // 
            // lbConnect
            // 
            this.lbConnect.AutoSize = true;
            this.lbConnect.Location = new System.Drawing.Point(302, 40);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(57, 13);
            this.lbConnect.TabIndex = 3;
            this.lbConnect.Text = "Отключен";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(294, 13);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(86, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Подключить";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(115, 11);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(117, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "192.168.0.1";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(22, 18);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(50, 13);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP адрес";
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(184, 384);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(117, 23);
            this.btExecute.TabIndex = 1;
            this.btExecute.Text = "Выполнить";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtLed);
            this.panel1.Controls.Add(this.rbtSerialNumber);
            this.panel1.Controls.Add(this.rbtAutoCalibration);
            this.panel1.Controls.Add(this.rbtDeviceConfig);
            this.panel1.Controls.Add(this.rbtConfigManagement);
            this.panel1.Controls.Add(this.rbtSetpoint);
            this.panel1.Controls.Add(this.rbtSensorConfig);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(116, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 190);
            this.panel1.TabIndex = 0;
            // 
            // rbtSerialNumber
            // 
            this.rbtSerialNumber.AutoSize = true;
            this.rbtSerialNumber.Location = new System.Drawing.Point(10, 91);
            this.rbtSerialNumber.Name = "rbtSerialNumber";
            this.rbtSerialNumber.Size = new System.Drawing.Size(233, 17);
            this.rbtSerialNumber.TabIndex = 5;
            this.rbtSerialNumber.TabStop = true;
            this.rbtSerialNumber.Text = "Запись серийного номера и MAC адреса";
            this.rbtSerialNumber.UseVisualStyleBackColor = true;
            // 
            // rbtAutoCalibration
            // 
            this.rbtAutoCalibration.AutoSize = true;
            this.rbtAutoCalibration.Location = new System.Drawing.Point(10, 69);
            this.rbtAutoCalibration.Name = "rbtAutoCalibration";
            this.rbtAutoCalibration.Size = new System.Drawing.Size(172, 17);
            this.rbtAutoCalibration.TabIndex = 4;
            this.rbtAutoCalibration.TabStop = true;
            this.rbtAutoCalibration.Text = "Автоматическая калибровка";
            this.rbtAutoCalibration.UseVisualStyleBackColor = true;
            // 
            // rbtDeviceConfig
            // 
            this.rbtDeviceConfig.AutoSize = true;
            this.rbtDeviceConfig.Checked = true;
            this.rbtDeviceConfig.Location = new System.Drawing.Point(10, 154);
            this.rbtDeviceConfig.Name = "rbtDeviceConfig";
            this.rbtDeviceConfig.Size = new System.Drawing.Size(143, 17);
            this.rbtDeviceConfig.TabIndex = 3;
            this.rbtDeviceConfig.TabStop = true;
            this.rbtDeviceConfig.Text = "Конфигурация прибора";
            this.rbtDeviceConfig.UseVisualStyleBackColor = true;
            // 
            // rbtConfigManagement
            // 
            this.rbtConfigManagement.AutoSize = true;
            this.rbtConfigManagement.Location = new System.Drawing.Point(10, 47);
            this.rbtConfigManagement.Name = "rbtConfigManagement";
            this.rbtConfigManagement.Size = new System.Drawing.Size(211, 17);
            this.rbtConfigManagement.TabIndex = 3;
            this.rbtConfigManagement.TabStop = true;
            this.rbtConfigManagement.Text = "Сохранение/загрузка конфигурации";
            this.rbtConfigManagement.UseVisualStyleBackColor = true;
            // 
            // rbtSetpoint
            // 
            this.rbtSetpoint.AutoSize = true;
            this.rbtSetpoint.Location = new System.Drawing.Point(10, 25);
            this.rbtSetpoint.Name = "rbtSetpoint";
            this.rbtSetpoint.Size = new System.Drawing.Size(111, 17);
            this.rbtSetpoint.TabIndex = 2;
            this.rbtSetpoint.TabStop = true;
            this.rbtSetpoint.Text = "Задание уставок";
            this.rbtSetpoint.UseVisualStyleBackColor = true;
            // 
            // rbtSensorConfig
            // 
            this.rbtSensorConfig.AutoSize = true;
            this.rbtSensorConfig.Location = new System.Drawing.Point(10, 3);
            this.rbtSensorConfig.Name = "rbtSensorConfig";
            this.rbtSensorConfig.Size = new System.Drawing.Size(147, 17);
            this.rbtSensorConfig.TabIndex = 1;
            this.rbtSensorConfig.TabStop = true;
            this.rbtSensorConfig.Text = "Конфигурация датчиков";
            this.rbtSensorConfig.UseVisualStyleBackColor = true;
            // 
            // tabPageRT24
            // 
            this.tabPageRT24.Controls.Add(this.btRtConfig);
            this.tabPageRT24.Location = new System.Drawing.Point(4, 22);
            this.tabPageRT24.Name = "tabPageRT24";
            this.tabPageRT24.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRT24.Size = new System.Drawing.Size(485, 432);
            this.tabPageRT24.TabIndex = 1;
            this.tabPageRT24.Text = "RT24";
            this.tabPageRT24.UseVisualStyleBackColor = true;
            // 
            // btRtConfig
            // 
            this.btRtConfig.Location = new System.Drawing.Point(170, 171);
            this.btRtConfig.Name = "btRtConfig";
            this.btRtConfig.Size = new System.Drawing.Size(145, 42);
            this.btRtConfig.TabIndex = 1;
            this.btRtConfig.Text = "Конфигурация прибора";
            this.btRtConfig.UseVisualStyleBackColor = true;
            this.btRtConfig.Click += new System.EventHandler(this.btRtConfig_Click);
            // 
            // tabPageAI24
            // 
            this.tabPageAI24.Controls.Add(this.btAiConfig);
            this.tabPageAI24.Location = new System.Drawing.Point(4, 22);
            this.tabPageAI24.Name = "tabPageAI24";
            this.tabPageAI24.Size = new System.Drawing.Size(485, 432);
            this.tabPageAI24.TabIndex = 5;
            this.tabPageAI24.Text = "AI24";
            this.tabPageAI24.UseVisualStyleBackColor = true;
            // 
            // btAiConfig
            // 
            this.btAiConfig.Location = new System.Drawing.Point(170, 171);
            this.btAiConfig.Name = "btAiConfig";
            this.btAiConfig.Size = new System.Drawing.Size(145, 42);
            this.btAiConfig.TabIndex = 2;
            this.btAiConfig.Text = "Конфигурация прибора";
            this.btAiConfig.UseVisualStyleBackColor = true;
            this.btAiConfig.Click += new System.EventHandler(this.btAiConfig_Click);
            // 
            // tabPageFMD2
            // 
            this.tabPageFMD2.Controls.Add(this.btFmdConfig);
            this.tabPageFMD2.Location = new System.Drawing.Point(4, 22);
            this.tabPageFMD2.Name = "tabPageFMD2";
            this.tabPageFMD2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFMD2.Size = new System.Drawing.Size(485, 432);
            this.tabPageFMD2.TabIndex = 3;
            this.tabPageFMD2.Text = "FMD2";
            this.tabPageFMD2.UseVisualStyleBackColor = true;
            // 
            // btFmdConfig
            // 
            this.btFmdConfig.Location = new System.Drawing.Point(170, 171);
            this.btFmdConfig.Name = "btFmdConfig";
            this.btFmdConfig.Size = new System.Drawing.Size(145, 42);
            this.btFmdConfig.TabIndex = 0;
            this.btFmdConfig.Text = "Конфигурация прибора";
            this.btFmdConfig.UseVisualStyleBackColor = true;
            this.btFmdConfig.Click += new System.EventHandler(this.btFmdConfig_Click);
            // 
            // tabPageAS01
            // 
            this.tabPageAS01.Controls.Add(this.btAs01Show);
            this.tabPageAS01.Controls.Add(this.btAs01Calibr);
            this.tabPageAS01.Location = new System.Drawing.Point(4, 22);
            this.tabPageAS01.Name = "tabPageAS01";
            this.tabPageAS01.Size = new System.Drawing.Size(485, 432);
            this.tabPageAS01.TabIndex = 4;
            this.tabPageAS01.Text = "AS01";
            this.tabPageAS01.UseVisualStyleBackColor = true;
            // 
            // btAs01Show
            // 
            this.btAs01Show.Location = new System.Drawing.Point(170, 242);
            this.btAs01Show.Name = "btAs01Show";
            this.btAs01Show.Size = new System.Drawing.Size(145, 42);
            this.btAs01Show.TabIndex = 3;
            this.btAs01Show.Text = "Конфигурация и проверка";
            this.btAs01Show.UseVisualStyleBackColor = true;
            this.btAs01Show.Click += new System.EventHandler(this.btAs01Show_Click);
            // 
            // btAs01Calibr
            // 
            this.btAs01Calibr.Location = new System.Drawing.Point(170, 171);
            this.btAs01Calibr.Name = "btAs01Calibr";
            this.btAs01Calibr.Size = new System.Drawing.Size(145, 42);
            this.btAs01Calibr.TabIndex = 2;
            this.btAs01Calibr.Text = "Калибровка";
            this.btAs01Calibr.UseVisualStyleBackColor = true;
            this.btAs01Calibr.Click += new System.EventHandler(this.btAs01Calibr_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(259, 498);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // rbtLed
            // 
            this.rbtLed.AutoSize = true;
            this.rbtLed.Location = new System.Drawing.Point(10, 114);
            this.rbtLed.Name = "rbtLed";
            this.rbtLed.Size = new System.Drawing.Size(209, 17);
            this.rbtLed.TabIndex = 6;
            this.rbtLed.TabStop = true;
            this.rbtLed.Text = "Тест светодиодов и выходных  реле";
            this.rbtLed.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 533);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программные инструменты ЛССИ";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAS02.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageRT24.ResumeLayout(false);
            this.tabPageAI24.ResumeLayout(false);
            this.tabPageFMD2.ResumeLayout(false);
            this.tabPageAS01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAS02;
        private System.Windows.Forms.TabPage tabPageRT24;
        private System.Windows.Forms.TabPage tabPageFMD2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btFmdConfig;
        private System.Windows.Forms.Button btRtConfig;
        private System.Windows.Forms.RadioButton rbtDeviceConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbConnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtConfigManagement;
        private System.Windows.Forms.RadioButton rbtSetpoint;
        private System.Windows.Forms.RadioButton rbtSensorConfig;
        private System.Windows.Forms.TextBox textBoxSerNum;
        private System.Windows.Forms.Label lbSerNum;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TabPage tabPageAS01;
        private System.Windows.Forms.Button btAs01Show;
        private System.Windows.Forms.Button btAs01Calibr;
        private System.Windows.Forms.RadioButton rbtAutoCalibration;
        private System.Windows.Forms.TabPage tabPageAI24;
        private System.Windows.Forms.Button btAiConfig;
        private System.Windows.Forms.RadioButton rbtSerialNumber;
        private System.Windows.Forms.RadioButton rbtLed;
    }
}

