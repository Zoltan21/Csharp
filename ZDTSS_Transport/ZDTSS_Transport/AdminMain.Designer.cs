namespace ZDTSS_Transport
{
    partial class AdminMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.morningJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setClientToAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morningJobsToolStripMenuItem,
            this.manageCarsToolStripMenuItem,
            this.manageClientsToolStripMenuItem,
            this.manageCommandsToolStripMenuItem,
            this.pricesToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // morningJobsToolStripMenuItem
            // 
            this.morningJobsToolStripMenuItem.Name = "morningJobsToolStripMenuItem";
            this.morningJobsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.morningJobsToolStripMenuItem.Text = "Morning Jobs";
            this.morningJobsToolStripMenuItem.Click += new System.EventHandler(this.morningJobsToolStripMenuItem_Click);
            // 
            // manageCarsToolStripMenuItem
            // 
            this.manageCarsToolStripMenuItem.Name = "manageCarsToolStripMenuItem";
            this.manageCarsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.manageCarsToolStripMenuItem.Text = "Cars";
            this.manageCarsToolStripMenuItem.Click += new System.EventHandler(this.manageCarsToolStripMenuItem_Click);
            // 
            // manageClientsToolStripMenuItem
            // 
            this.manageClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteClientsToolStripMenuItem,
            this.changeClientInfoToolStripMenuItem,
            this.setClientToAdminToolStripMenuItem});
            this.manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            this.manageClientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.manageClientsToolStripMenuItem.Text = "Clients";
            // 
            // deleteClientsToolStripMenuItem
            // 
            this.deleteClientsToolStripMenuItem.Name = "deleteClientsToolStripMenuItem";
            this.deleteClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteClientsToolStripMenuItem.Text = "Delete Clients";
            // 
            // changeClientInfoToolStripMenuItem
            // 
            this.changeClientInfoToolStripMenuItem.Name = "changeClientInfoToolStripMenuItem";
            this.changeClientInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeClientInfoToolStripMenuItem.Text = "Change Client Info";
            // 
            // setClientToAdminToolStripMenuItem
            // 
            this.setClientToAdminToolStripMenuItem.Name = "setClientToAdminToolStripMenuItem";
            this.setClientToAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setClientToAdminToolStripMenuItem.Text = "Set Client To Admin";
            // 
            // manageCommandsToolStripMenuItem
            // 
            this.manageCommandsToolStripMenuItem.Name = "manageCommandsToolStripMenuItem";
            this.manageCommandsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.manageCommandsToolStripMenuItem.Text = " Commands";
            this.manageCommandsToolStripMenuItem.Click += new System.EventHandler(this.manageCommandsToolStripMenuItem_Click);
            // 
            // pricesToolStripMenuItem
            // 
            this.pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            this.pricesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pricesToolStripMenuItem.Text = "Prices";
            this.pricesToolStripMenuItem.Click += new System.EventHandler(this.pricesToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.routesToolStripMenuItem.Text = "Routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.viewToolStripMenuItem.Text = "Report";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 314);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setClientToAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morningJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCommandsToolStripMenuItem;
    }
}