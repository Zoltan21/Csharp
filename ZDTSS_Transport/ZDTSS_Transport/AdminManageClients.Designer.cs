namespace ZDTSS_Transport
{
    partial class AdminManageClients
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
            this.UserFirstNameBox = new System.Windows.Forms.TextBox();
            this.UserLastNameBox = new System.Windows.Forms.TextBox();
            this.UserPhoneBox = new System.Windows.Forms.TextBox();
            this.UserUsernameBox = new System.Windows.Forms.TextBox();
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.UserStatusBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // UserFirstNameBox
            // 
            this.UserFirstNameBox.Location = new System.Drawing.Point(104, 28);
            this.UserFirstNameBox.Name = "UserFirstNameBox";
            this.UserFirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserFirstNameBox.TabIndex = 1;
            // 
            // UserLastNameBox
            // 
            this.UserLastNameBox.Location = new System.Drawing.Point(104, 54);
            this.UserLastNameBox.Name = "UserLastNameBox";
            this.UserLastNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserLastNameBox.TabIndex = 2;
            // 
            // UserPhoneBox
            // 
            this.UserPhoneBox.Location = new System.Drawing.Point(104, 80);
            this.UserPhoneBox.Name = "UserPhoneBox";
            this.UserPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.UserPhoneBox.TabIndex = 3;
            // 
            // UserUsernameBox
            // 
            this.UserUsernameBox.Location = new System.Drawing.Point(104, 106);
            this.UserUsernameBox.Name = "UserUsernameBox";
            this.UserUsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UserUsernameBox.TabIndex = 4;
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(104, 132);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.UserPasswordBox.TabIndex = 5;
            // 
            // UserStatusBox
            // 
            this.UserStatusBox.Location = new System.Drawing.Point(104, 158);
            this.UserStatusBox.Name = "UserStatusBox";
            this.UserStatusBox.Size = new System.Drawing.Size(100, 20);
            this.UserStatusBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phonenumber :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 161);
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
            this.groupBox1.Controls.Add(this.UserStatusBox);
            this.groupBox1.Controls.Add(this.UserPasswordBox);
            this.groupBox1.Controls.Add(this.UserUsernameBox);
            this.groupBox1.Controls.Add(this.UserPhoneBox);
            this.groupBox1.Controls.Add(this.UserLastNameBox);
            this.groupBox1.Controls.Add(this.UserFirstNameBox);
            this.groupBox1.Location = new System.Drawing.Point(528, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // AdddButton
            // 
            this.AdddButton.Location = new System.Drawing.Point(4, 19);
            this.AdddButton.Name = "AdddButton";
            this.AdddButton.Size = new System.Drawing.Size(75, 23);
            this.AdddButton.TabIndex = 14;
            this.AdddButton.Text = "Add";
            this.AdddButton.UseVisualStyleBackColor = true;
            this.AdddButton.Click += new System.EventHandler(this.AdddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(85, 19);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(166, 19);
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
            this.groupBox2.Controls.Add(this.AdddButton);
            this.groupBox2.Location = new System.Drawing.Point(524, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 54);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // AdminManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminManageClients";
            this.Text = "AdminManageClients";
            this.Load += new System.EventHandler(this.AdminManageClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox UserFirstNameBox;
        private System.Windows.Forms.TextBox UserLastNameBox;
        private System.Windows.Forms.TextBox UserPhoneBox;
        private System.Windows.Forms.TextBox UserUsernameBox;
        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.TextBox UserStatusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AdddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}