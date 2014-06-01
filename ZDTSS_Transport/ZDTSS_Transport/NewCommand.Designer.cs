namespace ZDTSS_Transport
{
    partial class NewCommand
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFromList = new System.Windows.Forms.ComboBox();
            this.cmbToList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nrNrOfPallets = new System.Windows.Forms.NumericUpDown();
            this.nrKgPerPallet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrNrOfPallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrKgPerPallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // cmbFromList
            // 
            this.cmbFromList.FormattingEnabled = true;
            this.cmbFromList.Location = new System.Drawing.Point(66, 45);
            this.cmbFromList.Name = "cmbFromList";
            this.cmbFromList.Size = new System.Drawing.Size(108, 21);
            this.cmbFromList.Sorted = true;
            this.cmbFromList.TabIndex = 2;
            // 
            // cmbToList
            // 
            this.cmbToList.FormattingEnabled = true;
            this.cmbToList.Location = new System.Drawing.Point(406, 45);
            this.cmbToList.Name = "cmbToList";
            this.cmbToList.Size = new System.Drawing.Size(121, 21);
            this.cmbToList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "good description: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(258, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr Of Pallets:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kg Per Pallet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Delivery Date:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(342, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(257, 234);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // nrNrOfPallets
            // 
            this.nrNrOfPallets.Location = new System.Drawing.Point(258, 147);
            this.nrNrOfPallets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrNrOfPallets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrNrOfPallets.Name = "nrNrOfPallets";
            this.nrNrOfPallets.Size = new System.Drawing.Size(61, 20);
            this.nrNrOfPallets.TabIndex = 16;
            this.nrNrOfPallets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrKgPerPallet
            // 
            this.nrKgPerPallet.Location = new System.Drawing.Point(258, 187);
            this.nrKgPerPallet.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.nrKgPerPallet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nrKgPerPallet.Name = "nrKgPerPallet";
            this.nrKgPerPallet.Size = new System.Drawing.Size(61, 20);
            this.nrKgPerPallet.TabIndex = 17;
            this.nrKgPerPallet.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZDTSS_Transport.Properties.Resources.original;
            this.pictureBox1.Location = new System.Drawing.Point(496, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // NewCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 492);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nrKgPerPallet);
            this.Controls.Add(this.nrNrOfPallets);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbToList);
            this.Controls.Add(this.cmbFromList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Command";
            ((System.ComponentModel.ISupportInitialize)(this.nrNrOfPallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrKgPerPallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFromList;
        private System.Windows.Forms.ComboBox cmbToList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown nrNrOfPallets;
        private System.Windows.Forms.NumericUpDown nrKgPerPallet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}