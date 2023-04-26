namespace SchoolSocketDB
{
    partial class FMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.MIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MIOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MIConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MIImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMain
            // 
            this.MSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIFile,
            this.MIOption});
            resources.ApplyResources(this.MSMain, "MSMain");
            this.MSMain.Name = "MSMain";
            // 
            // MIFile
            // 
            this.MIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIExit});
            this.MIFile.Name = "MIFile";
            resources.ApplyResources(this.MIFile, "MIFile");
            // 
            // MIOption
            // 
            this.MIOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIConnect,
            this.toolStripMenuItem1,
            this.MIImport,
            this.toolStripMenuItem2,
            this.MIDisconnect});
            this.MIOption.Name = "MIOption";
            resources.ApplyResources(this.MIOption, "MIOption");
            // 
            // MIConnect
            // 
            this.MIConnect.Name = "MIConnect";
            resources.ApplyResources(this.MIConnect, "MIConnect");
            this.MIConnect.Click += new System.EventHandler(this.MIConnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MIImport
            // 
            this.MIImport.Name = "MIImport";
            resources.ApplyResources(this.MIImport, "MIImport");
            this.MIImport.Click += new System.EventHandler(this.MIImport_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // MIDisconnect
            // 
            this.MIDisconnect.Checked = true;
            this.MIDisconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MIDisconnect.Name = "MIDisconnect";
            resources.ApplyResources(this.MIDisconnect, "MIDisconnect");
            this.MIDisconnect.Click += new System.EventHandler(this.MIDisconnect_Click);
            // 
            // MIExit
            // 
            this.MIExit.Name = "MIExit";
            resources.ApplyResources(this.MIExit, "MIExit");
            this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MSMain);
            this.MainMenuStrip = this.MSMain;
            this.Name = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem MIFile;
        private System.Windows.Forms.ToolStripMenuItem MIExit;
        private System.Windows.Forms.ToolStripMenuItem MIOption;
        private System.Windows.Forms.ToolStripMenuItem MIConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MIImport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MIDisconnect;
    }
}

