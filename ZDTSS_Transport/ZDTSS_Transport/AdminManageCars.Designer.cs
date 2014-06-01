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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelYellow = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // CarNameBox
            // 
            this.CarNameBox.Location = new System.Drawing.Point(110, 16);
            this.CarNameBox.Name = "CarNameBox";
            this.CarNameBox.Size = new System.Drawing.Size(100, 20);
            this.CarNameBox.TabIndex = 1;
            // 
            // CarSpeedBox
            // 
            this.CarSpeedBox.Location = new System.Drawing.Point(110, 42);
            this.CarSpeedBox.Name = "CarSpeedBox";
            this.CarSpeedBox.Size = new System.Drawing.Size(100, 20);
            this.CarSpeedBox.TabIndex = 2;
            // 
            // CarWeightBox
            // 
            this.CarWeightBox.Location = new System.Drawing.Point(110, 68);
            this.CarWeightBox.Name = "CarWeightBox";
            this.CarWeightBox.Size = new System.Drawing.Size(100, 20);
            this.CarWeightBox.TabIndex = 3;
            // 
            // CarVolumeBox
            // 
            this.CarVolumeBox.Location = new System.Drawing.Point(110, 94);
            this.CarVolumeBox.Name = "CarVolumeBox";
            this.CarVolumeBox.Size = new System.Drawing.Size(100, 20);
            this.CarVolumeBox.TabIndex = 4;
            // 
            // CarConsumptionBox
            // 
            this.CarConsumptionBox.Location = new System.Drawing.Point(110, 120);
            this.CarConsumptionBox.Name = "CarConsumptionBox";
            this.CarConsumptionBox.Size = new System.Drawing.Size(100, 20);
            this.CarConsumptionBox.TabIndex = 5;
            // 
            // CarStatusBox
            // 
            this.CarStatusBox.Location = new System.Drawing.Point(110, 146);
            this.CarStatusBox.Name = "CarStatusBox";
            this.CarStatusBox.Size = new System.Drawing.Size(100, 20);
            this.CarStatusBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max speed :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight Capacity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Volume Capacity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consumption :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status :";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(806, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Van";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(87, 19);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(168, 19);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Location = new System.Drawing.Point(806, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 48);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Van status is 1 when it is available, 2 when it is busy and 3 when it is on repai" +
    "r";
            // 
            // labelYellow
            // 
            this.labelYellow.AutoSize = true;
            this.labelYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelYellow.Location = new System.Drawing.Point(436, 385);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(50, 13);
            this.labelYellow.TabIndex = 21;
            this.labelYellow.Text = "On repair";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.BackColor = System.Drawing.Color.Green;
            this.labelGreen.Location = new System.Drawing.Point(275, 385);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(50, 13);
            this.labelGreen.TabIndex = 20;
            this.labelGreen.Text = "Available";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(91, 385);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(30, 13);
            this.labelRed.TabIndex = 19;
            this.labelRed.Text = "Busy";
            // 
            // AdminManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 440);
            this.Controls.Add(this.labelYellow);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminManageCars";
            this.Text = "AdminManageCars";
            this.Load += new System.EventHandler(this.AdminManageCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
    }
}