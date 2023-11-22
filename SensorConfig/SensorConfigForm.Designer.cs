
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
            this.rbCh4 = new System.Windows.Forms.RadioButton();
            this.rbCh3 = new System.Windows.Forms.RadioButton();
            this.rbCh2 = new System.Windows.Forms.RadioButton();
            this.rbCh1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensors)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(194, 535);
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
            this.panel2.Location = new System.Drawing.Point(26, 118);
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
            this.dataGridViewSelected.Location = new System.Drawing.Point(26, 304);
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
            this.lbSelected.Location = new System.Drawing.Point(29, 285);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(89, 13);
            this.lbSelected.TabIndex = 7;
            this.lbSelected.Text = "Текущий датчик";
            // 
            // btWrite
            // 
            this.btWrite.Enabled = false;
            this.btWrite.Location = new System.Drawing.Point(168, 494);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(146, 23);
            this.btWrite.TabIndex = 8;
            this.btWrite.Text = "Записать в прибор";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // rbCh4
            // 
            this.rbCh4.AutoSize = true;
            this.rbCh4.Location = new System.Drawing.Point(321, 28);
            this.rbCh4.Name = "rbCh4";
            this.rbCh4.Size = new System.Drawing.Size(62, 17);
            this.rbCh4.TabIndex = 3;
            this.rbCh4.TabStop = true;
            this.rbCh4.Text = "Канал4";
            this.rbCh4.UseVisualStyleBackColor = true;
            this.rbCh4.Click += new System.EventHandler(this.rbCh4_Click);
            // 
            // rbCh3
            // 
            this.rbCh3.AutoSize = true;
            this.rbCh3.Location = new System.Drawing.Point(230, 28);
            this.rbCh3.Name = "rbCh3";
            this.rbCh3.Size = new System.Drawing.Size(62, 17);
            this.rbCh3.TabIndex = 2;
            this.rbCh3.TabStop = true;
            this.rbCh3.Text = "Канал3";
            this.rbCh3.UseVisualStyleBackColor = true;
            this.rbCh3.Click += new System.EventHandler(this.rbCh3_Click);
            // 
            // rbCh2
            // 
            this.rbCh2.AutoSize = true;
            this.rbCh2.Location = new System.Drawing.Point(139, 28);
            this.rbCh2.Name = "rbCh2";
            this.rbCh2.Size = new System.Drawing.Size(62, 17);
            this.rbCh2.TabIndex = 1;
            this.rbCh2.TabStop = true;
            this.rbCh2.Text = "Канал2";
            this.rbCh2.UseVisualStyleBackColor = true;
            this.rbCh2.Click += new System.EventHandler(this.rbCh2_Click);
            // 
            // rbCh1
            // 
            this.rbCh1.AutoSize = true;
            this.rbCh1.Checked = true;
            this.rbCh1.Location = new System.Drawing.Point(48, 28);
            this.rbCh1.Name = "rbCh1";
            this.rbCh1.Size = new System.Drawing.Size(62, 17);
            this.rbCh1.TabIndex = 0;
            this.rbCh1.TabStop = true;
            this.rbCh1.Text = "Канал1";
            this.rbCh1.UseVisualStyleBackColor = true;
            this.rbCh1.Click += new System.EventHandler(this.rbCh1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCh4);
            this.groupBox1.Controls.Add(this.rbCh3);
            this.groupBox1.Controls.Add(this.rbCh1);
            this.groupBox1.Controls.Add(this.rbCh2);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 64);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номер канала";
            // 
            // SensorConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 572);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbCh4;
        private System.Windows.Forms.RadioButton rbCh3;
        private System.Windows.Forms.RadioButton rbCh2;
        private System.Windows.Forms.RadioButton rbCh1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}