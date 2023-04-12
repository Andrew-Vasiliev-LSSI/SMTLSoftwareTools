
namespace SMTLSoftwareTools.SensorConfig
{
    partial class SensorConfigForm
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
            this.dataGridViewSensors = new System.Windows.Forms.DataGridView();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSelectSensor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSelected = new System.Windows.Forms.Label();
            this.btWrite = new System.Windows.Forms.Button();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.chLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensors)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(191, 477);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dataGridViewSensors
            // 
            this.dataGridViewSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorName,
            this.MeasurementType});
            this.dataGridViewSensors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSensors.Name = "dataGridViewSensors";
            this.dataGridViewSensors.Size = new System.Drawing.Size(424, 132);
            this.dataGridViewSensors.TabIndex = 3;
            this.dataGridViewSensors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewSensors_KeyDown);
            // 
            // SensorName
            // 
            this.SensorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SensorName.HeaderText = "Название датчика";
            this.SensorName.Name = "SensorName";
            this.SensorName.ReadOnly = true;
            this.SensorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SensorName.Width = 96;
            // 
            // MeasurementType
            // 
            this.MeasurementType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MeasurementType.HeaderText = "Тип канала";
            this.MeasurementType.Name = "MeasurementType";
            this.MeasurementType.ReadOnly = true;
            this.MeasurementType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btSelectSensor
            // 
            this.btSelectSensor.Location = new System.Drawing.Point(0, 138);
            this.btSelectSensor.Name = "btSelectSensor";
            this.btSelectSensor.Size = new System.Drawing.Size(95, 23);
            this.btSelectSensor.TabIndex = 4;
            this.btSelectSensor.Text = "Выбор датчика";
            this.btSelectSensor.UseVisualStyleBackColor = true;
            this.btSelectSensor.Click += new System.EventHandler(this.btSelectSensor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSelectSensor);
            this.panel2.Controls.Add(this.dataGridViewSensors);
            this.panel2.Location = new System.Drawing.Point(23, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 164);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridViewSelected.Location = new System.Drawing.Point(23, 246);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.Size = new System.Drawing.Size(428, 150);
            this.dataGridViewSelected.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Параметр";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Название параметра";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Location = new System.Drawing.Point(26, 227);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(89, 13);
            this.lbSelected.TabIndex = 7;
            this.lbSelected.Text = "Текущий датчик";
            // 
            // btWrite
            // 
            this.btWrite.Enabled = false;
            this.btWrite.Location = new System.Drawing.Point(165, 436);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(146, 23);
            this.btWrite.TabIndex = 8;
            this.btWrite.Text = "Записать в прибор";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.Enabled = false;
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Items.AddRange(new object[] {
            "Канал 1",
            "Канал 2",
            "Канал 3",
            "Канал 4"});
            this.comboBoxChannels.Location = new System.Drawing.Point(23, 33);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChannels.TabIndex = 9;
            this.comboBoxChannels.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannels_SelectedIndexChanged);
            // 
            // chLabel
            // 
            this.chLabel.AutoSize = true;
            this.chLabel.Location = new System.Drawing.Point(23, 17);
            this.chLabel.Name = "chLabel";
            this.chLabel.Size = new System.Drawing.Size(80, 13);
            this.chLabel.TabIndex = 10;
            this.chLabel.Text = "Номер канала";
            // 
            // SensorConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 527);
            this.Controls.Add(this.chLabel);
            this.Controls.Add(this.comboBoxChannels);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.dataGridViewSelected);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btExit);
            this.Name = "SensorConfigForm";
            this.Text = "Конфигурация датчиков";
            this.Load += new System.EventHandler(this.SensorConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensors)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dataGridViewSensors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementType;
        private System.Windows.Forms.Button btSelectSensor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.Label chLabel;
    }
}