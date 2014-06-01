namespace ZDTSS_Transport
{
    partial class Commands
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_vanid = new System.Windows.Forms.TextBox();
            this.tb_wareid = new System.Windows.Forms.TextBox();
            this.tb_originid = new System.Windows.Forms.TextBox();
            this.tb_destinationid = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_priceid = new System.Windows.Forms.TextBox();
            this.tb_customerid = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(150, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(878, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(
            dataGridView1_SelectionChanged);
            // 
            // tb_vanid
            // 
            this.tb_vanid.Location = new System.Drawing.Point(240, 5);
            this.tb_vanid.Name = "tb_vanid";
            this.tb_vanid.Size = new System.Drawing.Size(100, 20);
            this.tb_vanid.TabIndex = 4;
            this.tb_vanid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_wareid
            // 
            this.tb_wareid.Location = new System.Drawing.Point(240, 31);
            this.tb_wareid.Name = "tb_wareid";
            this.tb_wareid.Size = new System.Drawing.Size(100, 20);
            this.tb_wareid.TabIndex = 5;
            // 
            // tb_originid
            // 
            this.tb_originid.Location = new System.Drawing.Point(240, 57);
            this.tb_originid.Name = "tb_originid";
            this.tb_originid.Size = new System.Drawing.Size(100, 20);
            this.tb_originid.TabIndex = 6;
            // 
            // tb_destinationid
            // 
            this.tb_destinationid.Location = new System.Drawing.Point(240, 83);
            this.tb_destinationid.Name = "tb_destinationid";
            this.tb_destinationid.Size = new System.Drawing.Size(100, 20);
            this.tb_destinationid.TabIndex = 7;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(240, 109);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(100, 20);
            this.tb_time.TabIndex = 8;
            // 
            // tb_priceid
            // 
            this.tb_priceid.Location = new System.Drawing.Point(240, 135);
            this.tb_priceid.Name = "tb_priceid";
            this.tb_priceid.Size = new System.Drawing.Size(100, 20);
            this.tb_priceid.TabIndex = 9;
            // 
            // tb_customerid
            // 
            this.tb_customerid.Location = new System.Drawing.Point(240, 161);
            this.tb_customerid.Name = "tb_customerid";
            this.tb_customerid.Size = new System.Drawing.Size(100, 20);
            this.tb_customerid.TabIndex = 10;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(240, 187);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(100, 20);
            this.tb_status.TabIndex = 11;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(66, 5);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "VanId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "WareId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "OriginId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DestinationId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "StartTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "CustomerId";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.tb_status);
            this.panel1.Controls.Add(this.tb_customerid);
            this.panel1.Controls.Add(this.tb_priceid);
            this.panel1.Controls.Add(this.tb_time);
            this.panel1.Controls.Add(this.tb_destinationid);
            this.panel1.Controls.Add(this.tb_originid);
            this.panel1.Controls.Add(this.tb_wareid);
            this.panel1.Controls.Add(this.tb_vanid);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(8, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 278);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(720, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 334);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Command";
            // 
            // Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Name = "Commands";
            this.Text = "Manage Commands";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_vanid;
        private System.Windows.Forms.TextBox tb_wareid;
        private System.Windows.Forms.TextBox tb_originid;
        private System.Windows.Forms.TextBox tb_destinationid;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_priceid;
        private System.Windows.Forms.TextBox tb_customerid;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}