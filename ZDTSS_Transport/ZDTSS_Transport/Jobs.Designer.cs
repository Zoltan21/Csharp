namespace ZDTSS_Transport
{
    partial class Jobs
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
            this.lstRegions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRegions
            // 
            this.lstRegions.FormattingEnabled = true;
            this.lstRegions.Location = new System.Drawing.Point(12, 196);
            this.lstRegions.Name = "lstRegions";
            this.lstRegions.Size = new System.Drawing.Size(120, 95);
            this.lstRegions.TabIndex = 2;
            this.lstRegions.Visible = false;
            this.lstRegions.SelectedIndexChanged += new System.EventHandler(this.lstRegions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regions";
            // 
            // lstType
            // 
            this.lstType.FormattingEnabled = true;
            this.lstType.Items.AddRange(new object[] {
            "extern",
            "intern-Collect",
            "intern-Divide"});
            this.lstType.Location = new System.Drawing.Point(12, 34);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(120, 95);
            this.lstType.TabIndex = 4;
            this.lstType.SelectedIndexChanged += new System.EventHandler(this.lstType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 384);
            this.dataGridView1.TabIndex = 6;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRegions);
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRegions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}