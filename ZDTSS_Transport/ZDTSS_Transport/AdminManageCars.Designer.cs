namespace ZDTSS_Transport
{
    partial class AdminManageCars
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
            this.components = new System.ComponentModel.Container();
            this.CarsDataGrid = new System.Windows.Forms.DataGridView();
            this.vanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCapKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCapPalletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zDTSS_TransportDataSet = new ZDTSS_Transport.ZDTSS_TransportDataSet();
            this.CarNameBox = new System.Windows.Forms.TextBox();
            this.CarSpeedBox = new System.Windows.Forms.TextBox();
            this.CarWeightBox = new System.Windows.Forms.TextBox();
            this.CarVolumeBox = new System.Windows.Forms.TextBox();
            this.CarConsumptionBox = new System.Windows.Forms.TextBox();
            this.CarStatusBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManageCarsAddButton = new System.Windows.Forms.Button();
            this.ManageCarsUpdateButton = new System.Windows.Forms.Button();
            this.ManageCarsDeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vansTableAdapter = new ZDTSS_Transport.ZDTSS_TransportDataSetTableAdapters.vansTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDTSS_TransportDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsDataGrid
            // 
            this.CarsDataGrid.AutoGenerateColumns = false;
            this.CarsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vanIdDataGridViewTextBoxColumn,
            this.vanNameDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.loadCapKgDataGridViewTextBoxColumn,
            this.loadCapPalletDataGridViewTextBoxColumn,
            this.consumptionDataGridViewTextBoxColumn,
            this.vanStatusDataGridViewTextBoxColumn});
            this.CarsDataGrid.DataSource = this.vansBindingSource;
            this.CarsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.CarsDataGrid.Name = "CarsDataGrid";
            this.CarsDataGrid.ReadOnly = true;
            this.CarsDataGrid.Size = new System.Drawing.Size(655, 292);
            this.CarsDataGrid.TabIndex = 0;
            this.CarsDataGrid.SelectionChanged += new System.EventHandler(this.CarsDataGrid_SelectionChanged_1);
            // 
            // vanIdDataGridViewTextBoxColumn
            // 
            this.vanIdDataGridViewTextBoxColumn.DataPropertyName = "vanId";
            this.vanIdDataGridViewTextBoxColumn.HeaderText = "vanId";
            this.vanIdDataGridViewTextBoxColumn.Name = "vanIdDataGridViewTextBoxColumn";
            this.vanIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vanNameDataGridViewTextBoxColumn
            // 
            this.vanNameDataGridViewTextBoxColumn.DataPropertyName = "vanName";
            this.vanNameDataGridViewTextBoxColumn.HeaderText = "vanName";
            this.vanNameDataGridViewTextBoxColumn.Name = "vanNameDataGridViewTextBoxColumn";
            this.vanNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loadCapKgDataGridViewTextBoxColumn
            // 
            this.loadCapKgDataGridViewTextBoxColumn.DataPropertyName = "loadCapKg";
            this.loadCapKgDataGridViewTextBoxColumn.HeaderText = "loadCapKg";
            this.loadCapKgDataGridViewTextBoxColumn.Name = "loadCapKgDataGridViewTextBoxColumn";
            this.loadCapKgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loadCapPalletDataGridViewTextBoxColumn
            // 
            this.loadCapPalletDataGridViewTextBoxColumn.DataPropertyName = "loadCapPallet";
            this.loadCapPalletDataGridViewTextBoxColumn.HeaderText = "loadCapPallet";
            this.loadCapPalletDataGridViewTextBoxColumn.Name = "loadCapPalletDataGridViewTextBoxColumn";
            this.loadCapPalletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "consumption";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            this.consumptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vanStatusDataGridViewTextBoxColumn
            // 
            this.vanStatusDataGridViewTextBoxColumn.DataPropertyName = "vanStatus";
            this.vanStatusDataGridViewTextBoxColumn.HeaderText = "vanStatus";
            this.vanStatusDataGridViewTextBoxColumn.Name = "vanStatusDataGridViewTextBoxColumn";
            this.vanStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vansBindingSource
            // 
            this.vansBindingSource.DataMember = "vans";
            this.vansBindingSource.DataSource = this.zDTSS_TransportDataSet;
            // 
            // zDTSS_TransportDataSet
            // 
            this.zDTSS_TransportDataSet.DataSetName = "ZDTSS_TransportDataSet";
            this.zDTSS_TransportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CarNameBox
            // 
            this.CarNameBox.Location = new System.Drawing.Point(126, 13);
            this.CarNameBox.Name = "CarNameBox";
            this.CarNameBox.Size = new System.Drawing.Size(100, 20);
            this.CarNameBox.TabIndex = 1;
            // 
            // CarSpeedBox
            // 
            this.CarSpeedBox.Location = new System.Drawing.Point(126, 39);
            this.CarSpeedBox.Name = "CarSpeedBox";
            this.CarSpeedBox.Size = new System.Drawing.Size(100, 20);
            this.CarSpeedBox.TabIndex = 2;
            // 
            // CarWeightBox
            // 
            this.CarWeightBox.Location = new System.Drawing.Point(126, 65);
            this.CarWeightBox.Name = "CarWeightBox";
            this.CarWeightBox.Size = new System.Drawing.Size(100, 20);
            this.CarWeightBox.TabIndex = 3;
            // 
            // CarVolumeBox
            // 
            this.CarVolumeBox.Location = new System.Drawing.Point(126, 91);
            this.CarVolumeBox.Name = "CarVolumeBox";
            this.CarVolumeBox.Size = new System.Drawing.Size(100, 20);
            this.CarVolumeBox.TabIndex = 4;
            // 
            // CarConsumptionBox
            // 
            this.CarConsumptionBox.Location = new System.Drawing.Point(126, 117);
            this.CarConsumptionBox.Name = "CarConsumptionBox";
            this.CarConsumptionBox.Size = new System.Drawing.Size(100, 20);
            this.CarConsumptionBox.TabIndex = 5;
            // 
            // CarStatusBox
            // 
            this.CarStatusBox.Location = new System.Drawing.Point(126, 143);
            this.CarStatusBox.Name = "CarStatusBox";
            this.CarStatusBox.Size = new System.Drawing.Size(100, 20);
            this.CarStatusBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max speed :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight Capacity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Volume Capacity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consumption :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status :";
            // 
            // ManageCarsAddButton
            // 
            this.ManageCarsAddButton.Location = new System.Drawing.Point(18, 31);
            this.ManageCarsAddButton.Name = "ManageCarsAddButton";
            this.ManageCarsAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCarsAddButton.TabIndex = 13;
            this.ManageCarsAddButton.Text = "Add New";
            this.ManageCarsAddButton.UseVisualStyleBackColor = true;
            this.ManageCarsAddButton.Click += new System.EventHandler(this.ManageCarsAddButton_Click);
            // 
            // ManageCarsUpdateButton
            // 
            this.ManageCarsUpdateButton.Location = new System.Drawing.Point(113, 31);
            this.ManageCarsUpdateButton.Name = "ManageCarsUpdateButton";
            this.ManageCarsUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCarsUpdateButton.TabIndex = 14;
            this.ManageCarsUpdateButton.Text = "Update";
            this.ManageCarsUpdateButton.UseVisualStyleBackColor = true;
            this.ManageCarsUpdateButton.Click += new System.EventHandler(this.ManageCarsUpdateButton_Click);
            // 
            // ManageCarsDeleteButton
            // 
            this.ManageCarsDeleteButton.Location = new System.Drawing.Point(214, 31);
            this.ManageCarsDeleteButton.Name = "ManageCarsDeleteButton";
            this.ManageCarsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCarsDeleteButton.TabIndex = 15;
            this.ManageCarsDeleteButton.Text = "Delete";
            this.ManageCarsDeleteButton.UseVisualStyleBackColor = true;
            this.ManageCarsDeleteButton.Click += new System.EventHandler(this.ManageCarsDeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CarStatusBox);
            this.groupBox1.Controls.Add(this.CarConsumptionBox);
            this.groupBox1.Controls.Add(this.CarVolumeBox);
            this.groupBox1.Controls.Add(this.CarWeightBox);
            this.groupBox1.Controls.Add(this.CarSpeedBox);
            this.groupBox1.Controls.Add(this.CarNameBox);
            this.groupBox1.Location = new System.Drawing.Point(673, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Van";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ManageCarsDeleteButton);
            this.groupBox2.Controls.Add(this.ManageCarsUpdateButton);
            this.groupBox2.Controls.Add(this.ManageCarsAddButton);
            this.groupBox2.Location = new System.Drawing.Point(673, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // vansTableAdapter
            // 
            this.vansTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "(km/h)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "(Kg)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "(No of pallets)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "(l/100*km)";
            // 
            // AdminManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CarsDataGrid);
            this.Name = "AdminManageCars";
            this.Text = "Manage Cars";
            this.Load += new System.EventHandler(this.AdminManageCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDTSS_TransportDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarsDataGrid;
        private System.Windows.Forms.TextBox CarNameBox;
        private System.Windows.Forms.TextBox CarSpeedBox;
        private System.Windows.Forms.TextBox CarWeightBox;
        private System.Windows.Forms.TextBox CarVolumeBox;
        private System.Windows.Forms.TextBox CarConsumptionBox;
        private System.Windows.Forms.TextBox CarStatusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ManageCarsAddButton;
        private System.Windows.Forms.Button ManageCarsUpdateButton;
        private System.Windows.Forms.Button ManageCarsDeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZDTSS_TransportDataSet zDTSS_TransportDataSet;
        private System.Windows.Forms.BindingSource vansBindingSource;
        private ZDTSS_TransportDataSetTableAdapters.vansTableAdapter vansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadCapKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadCapPalletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}