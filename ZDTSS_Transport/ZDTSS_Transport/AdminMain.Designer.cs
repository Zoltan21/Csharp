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
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setClientToAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCommands = new System.Windows.Forms.Panel();
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pPrices = new System.Windows.Forms.Panel();
            this.lbPrices = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnpClose = new System.Windows.Forms.Button();
            this.pRoutes = new System.Windows.Forms.Panel();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.lbRoutes = new System.Windows.Forms.ListBox();
            this.btnAddR = new System.Windows.Forms.Button();
            this.btnChangeR = new System.Windows.Forms.Button();
            this.btnrClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pCommands.SuspendLayout();
            this.pPrices.SuspendLayout();
            this.pRoutes.SuspendLayout();
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
            this.manageCarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.deleteCarToolStripMenuItem,
            this.modifyCarToolStripMenuItem});
            this.manageCarsToolStripMenuItem.Name = "manageCarsToolStripMenuItem";
            this.manageCarsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.manageCarsToolStripMenuItem.Text = "Cars";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            // 
            // modifyCarToolStripMenuItem
            // 
            this.modifyCarToolStripMenuItem.Name = "modifyCarToolStripMenuItem";
            this.modifyCarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modifyCarToolStripMenuItem.Text = "Modify Car";
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
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.routesToolStripMenuItem.Text = "Routes";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.viewToolStripMenuItem.Text = "Report";
            // 
            // pCommands
            // 
            this.pCommands.Controls.Add(this.lbCommands);
            this.pCommands.Controls.Add(this.btnAdd);
            this.pCommands.Controls.Add(this.btnUpdate);
            this.pCommands.Controls.Add(this.btnDelete);
            this.pCommands.Controls.Add(this.btnClose);
            this.pCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCommands.Location = new System.Drawing.Point(0, 24);
            this.pCommands.Name = "pCommands";
            this.pCommands.Size = new System.Drawing.Size(839, 290);
            this.pCommands.TabIndex = 3;
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(22, 17);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(789, 212);
            this.lbCommands.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(562, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(659, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pPrices
            // 
            this.pPrices.Controls.Add(this.lbPrices);
            this.pPrices.Controls.Add(this.btnChange);
            this.pPrices.Controls.Add(this.btnpClose);
            this.pPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrices.Location = new System.Drawing.Point(0, 24);
            this.pPrices.Name = "pPrices";
            this.pPrices.Size = new System.Drawing.Size(839, 290);
            this.pPrices.TabIndex = 5;
            // 
            // lbPrices
            // 
            this.lbPrices.FormattingEnabled = true;
            this.lbPrices.Location = new System.Drawing.Point(13, 20);
            this.lbPrices.Name = "lbPrices";
            this.lbPrices.Size = new System.Drawing.Size(797, 199);
            this.lbPrices.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(605, 255);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(129, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change price";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnpClose
            // 
            this.btnpClose.Location = new System.Drawing.Point(752, 255);
            this.btnpClose.Name = "btnpClose";
            this.btnpClose.Size = new System.Drawing.Size(75, 23);
            this.btnpClose.TabIndex = 0;
            this.btnpClose.Text = "Close";
            this.btnpClose.UseVisualStyleBackColor = true;
            this.btnpClose.Click += new System.EventHandler(this.btnpClose_Click);
            // 
            // pRoutes
            // 
            this.pRoutes.Controls.Add(this.btnDeleteR);
            this.pRoutes.Controls.Add(this.lbRoutes);
            this.pRoutes.Controls.Add(this.btnAddR);
            this.pRoutes.Controls.Add(this.btnChangeR);
            this.pRoutes.Controls.Add(this.btnrClose);
            this.pRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRoutes.Location = new System.Drawing.Point(0, 24);
            this.pRoutes.Name = "pRoutes";
            this.pRoutes.Size = new System.Drawing.Size(839, 290);
            this.pRoutes.TabIndex = 3;
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.Location = new System.Drawing.Point(454, 255);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteR.TabIndex = 4;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.UseVisualStyleBackColor = true;
            // 
            // lbRoutes
            // 
            this.lbRoutes.FormattingEnabled = true;
            this.lbRoutes.Location = new System.Drawing.Point(13, 20);
            this.lbRoutes.Name = "lbRoutes";
            this.lbRoutes.Size = new System.Drawing.Size(804, 225);
            this.lbRoutes.TabIndex = 3;
            // 
            // btnAddR
            // 
            this.btnAddR.Location = new System.Drawing.Point(562, 254);
            this.btnAddR.Name = "btnAddR";
            this.btnAddR.Size = new System.Drawing.Size(75, 23);
            this.btnAddR.TabIndex = 2;
            this.btnAddR.Text = "Add";
            this.btnAddR.UseVisualStyleBackColor = true;
            // 
            // btnChangeR
            // 
            this.btnChangeR.Location = new System.Drawing.Point(659, 254);
            this.btnChangeR.Name = "btnChangeR";
            this.btnChangeR.Size = new System.Drawing.Size(75, 23);
            this.btnChangeR.TabIndex = 1;
            this.btnChangeR.Text = "Change";
            this.btnChangeR.UseVisualStyleBackColor = true;
            // 
            // btnrClose
            // 
            this.btnrClose.Location = new System.Drawing.Point(751, 254);
            this.btnrClose.Name = "btnrClose";
            this.btnrClose.Size = new System.Drawing.Size(75, 23);
            this.btnrClose.TabIndex = 0;
            this.btnrClose.Text = "Close";
            this.btnrClose.UseVisualStyleBackColor = true;
            this.btnrClose.Click += new System.EventHandler(this.btnrClose_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 314);
            this.Controls.Add(this.pRoutes);
            this.Controls.Add(this.pPrices);
            this.Controls.Add(this.pCommands);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pCommands.ResumeLayout(false);
            this.pPrices.ResumeLayout(false);
            this.pRoutes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setClientToAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morningJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel pCommands;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem manageCommandsToolStripMenuItem;
        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pPrices;
        private System.Windows.Forms.ListBox lbPrices;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnpClose;
        private System.Windows.Forms.Panel pRoutes;
        private System.Windows.Forms.ListBox lbRoutes;
        private System.Windows.Forms.Button btnAddR;
        private System.Windows.Forms.Button btnChangeR;
        private System.Windows.Forms.Button btnrClose;
        private System.Windows.Forms.Button btnDeleteR;
    }
}