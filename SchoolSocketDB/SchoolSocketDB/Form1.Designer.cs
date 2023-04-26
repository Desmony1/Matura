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
            this.MIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MIOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MIConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MIImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.LSchool = new System.Windows.Forms.Label();
            this.LClass = new System.Windows.Forms.Label();
            this.LStudents = new System.Windows.Forms.Label();
            this.LTeachers = new System.Windows.Forms.Label();
            this.CBSchool = new System.Windows.Forms.ComboBox();
            this.CBClass = new System.Windows.Forms.ComboBox();
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.LBTeachers = new System.Windows.Forms.ListBox();
            this.MIPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.PPD = new System.Windows.Forms.PrintPreviewDialog();
            this.PDoc = new System.Drawing.Printing.PrintDocument();
            this.PD = new System.Windows.Forms.PrintDialog();
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
            // MIExit
            // 
            this.MIExit.Name = "MIExit";
            resources.ApplyResources(this.MIExit, "MIExit");
            this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // MIOption
            // 
            this.MIOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIConnect,
            this.toolStripMenuItem1,
            this.MIImport,
            this.MIPrint,
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
            // LSchool
            // 
            resources.ApplyResources(this.LSchool, "LSchool");
            this.LSchool.Name = "LSchool";
            this.LSchool.Click += new System.EventHandler(this.label1_Click);
            // 
            // LClass
            // 
            resources.ApplyResources(this.LClass, "LClass");
            this.LClass.Name = "LClass";
            // 
            // LStudents
            // 
            resources.ApplyResources(this.LStudents, "LStudents");
            this.LStudents.Name = "LStudents";
            // 
            // LTeachers
            // 
            resources.ApplyResources(this.LTeachers, "LTeachers");
            this.LTeachers.Name = "LTeachers";
            this.LTeachers.Click += new System.EventHandler(this.LTeachers_Click);
            // 
            // CBSchool
            // 
            this.CBSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSchool.FormattingEnabled = true;
            resources.ApplyResources(this.CBSchool, "CBSchool");
            this.CBSchool.Name = "CBSchool";
            this.CBSchool.SelectedIndexChanged += new System.EventHandler(this.CBSchool_SelectedIndexChanged);
            // 
            // CBClass
            // 
            this.CBClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBClass.FormattingEnabled = true;
            resources.ApplyResources(this.CBClass, "CBClass");
            this.CBClass.Name = "CBClass";
            this.CBClass.SelectedIndexChanged += new System.EventHandler(this.CBClass_SelectedIndexChanged);
            // 
            // LBStudents
            // 
            this.LBStudents.FormattingEnabled = true;
            resources.ApplyResources(this.LBStudents, "LBStudents");
            this.LBStudents.Name = "LBStudents";
            // 
            // LBTeachers
            // 
            this.LBTeachers.FormattingEnabled = true;
            resources.ApplyResources(this.LBTeachers, "LBTeachers");
            this.LBTeachers.Name = "LBTeachers";
            // 
            // MIPrint
            // 
            this.MIPrint.Name = "MIPrint";
            resources.ApplyResources(this.MIPrint, "MIPrint");
            this.MIPrint.Click += new System.EventHandler(this.MIPrint_Click);
            // 
            // PPD
            // 
            resources.ApplyResources(this.PPD, "PPD");
            this.PPD.Document = this.PDoc;
            this.PPD.Name = "PPD";
            // 
            // PDoc
            // 
            this.PDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PDoc_BeginPrint);
            this.PDoc.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PDoc_EndPrint);
            this.PDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDoc_PrintPage);
            this.PDoc.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.PDoc_QueryPageSettings);
            // 
            // PD
            // 
            this.PD.UseEXDialog = true;
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBTeachers);
            this.Controls.Add(this.LBStudents);
            this.Controls.Add(this.CBClass);
            this.Controls.Add(this.CBSchool);
            this.Controls.Add(this.LTeachers);
            this.Controls.Add(this.LStudents);
            this.Controls.Add(this.LClass);
            this.Controls.Add(this.LSchool);
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
        private System.Windows.Forms.Label LSchool;
        private System.Windows.Forms.Label LClass;
        private System.Windows.Forms.Label LStudents;
        private System.Windows.Forms.Label LTeachers;
        private System.Windows.Forms.ComboBox CBSchool;
        private System.Windows.Forms.ComboBox CBClass;
        private System.Windows.Forms.ListBox LBStudents;
        private System.Windows.Forms.ListBox LBTeachers;
        private System.Windows.Forms.ToolStripMenuItem MIPrint;
        private System.Windows.Forms.PrintPreviewDialog PPD;
        private System.Drawing.Printing.PrintDocument PDoc;
        private System.Windows.Forms.PrintDialog PD;
    }
}

