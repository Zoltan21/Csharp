namespace ZDTSS_Transport
{
    partial class ReportCommand
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtKgPerPallet = new System.Windows.Forms.TextBox();
            this.txtNrOfPallets = new System.Windows.Forms.TextBox();
            this.txtToCity = new System.Windows.Forms.TextBox();
            this.txtFromCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtPickUpDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(99, 269);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Decline
            // 
            this.btn_Decline.Location = new System.Drawing.Point(409, 269);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(75, 23);
            this.btn_Decline.TabIndex = 1;
            this.btn_Decline.Text = "Decline";
            this.btn_Decline.UseVisualStyleBackColor = true;
            this.btn_Decline.Click += new System.EventHandler(this.btn_Decline_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtKgPerPallet);
            this.panel2.Controls.Add(this.txtNrOfPallets);
            this.panel2.Controls.Add(this.txtToCity);
            this.panel2.Controls.Add(this.txtFromCity);
            this.panel2.Location = new System.Drawing.Point(22, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 190);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kg per pallet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nr of pallets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(109, 137);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(87, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtKgPerPallet
            // 
            this.txtKgPerPallet.Location = new System.Drawing.Point(109, 103);
            this.txtKgPerPallet.Name = "txtKgPerPallet";
            this.txtKgPerPallet.ReadOnly = true;
            this.txtKgPerPallet.Size = new System.Drawing.Size(87, 20);
            this.txtKgPerPallet.TabIndex = 4;
            // 
            // txtNrOfPallets
            // 
            this.txtNrOfPallets.Location = new System.Drawing.Point(109, 67);
            this.txtNrOfPallets.Name = "txtNrOfPallets";
            this.txtNrOfPallets.ReadOnly = true;
            this.txtNrOfPallets.Size = new System.Drawing.Size(87, 20);
            this.txtNrOfPallets.TabIndex = 3;
            // 
            // txtToCity
            // 
            this.txtToCity.Location = new System.Drawing.Point(109, 38);
            this.txtToCity.Name = "txtToCity";
            this.txtToCity.ReadOnly = true;
            this.txtToCity.Size = new System.Drawing.Size(87, 20);
            this.txtToCity.TabIndex = 2;
            // 
            // txtFromCity
            // 
            this.txtFromCity.Location = new System.Drawing.Point(109, 12);
            this.txtFromCity.Name = "txtFromCity";
            this.txtFromCity.ReadOnly = true;
            this.txtFromCity.Size = new System.Drawing.Size(87, 20);
            this.txtFromCity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtDeliveryDate);
            this.panel1.Controls.Add(this.txtPickUpDate);
            this.panel1.Location = new System.Drawing.Point(321, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 127);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Delivery Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "PickUp Date";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(98, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(98, 62);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDate.TabIndex = 2;
            // 
            // txtPickUpDate
            // 
            this.txtPickUpDate.Location = new System.Drawing.Point(98, 34);
            this.txtPickUpDate.Name = "txtPickUpDate";
            this.txtPickUpDate.ReadOnly = true;
            this.txtPickUpDate.Size = new System.Drawing.Size(100, 20);
            this.txtPickUpDate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Delivery Details";
            // 
            // ReportCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Decline);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "ReportCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Command";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Decline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtKgPerPallet;
        private System.Windows.Forms.TextBox txtNrOfPallets;
        private System.Windows.Forms.TextBox txtToCity;
        private System.Windows.Forms.TextBox txtFromCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox txtPickUpDate;
        private System.Windows.Forms.Label label7;
    }
}