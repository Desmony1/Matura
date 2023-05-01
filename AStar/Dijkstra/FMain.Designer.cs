namespace Dijkstra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.CMSmain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MIstart = new System.Windows.Forms.ToolStripMenuItem();
            this.MIend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MIdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MIDebugging = new System.Windows.Forms.ToolStripMenuItem();
            this.MIPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.MSmain = new System.Windows.Forms.MenuStrip();
            this.MIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MINew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MISave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MILanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.MIGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.MIEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.LTotal = new System.Windows.Forms.Label();
            this.CMSmain.SuspendLayout();
            this.MSmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMSmain
            // 
            this.CMSmain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIstart,
            this.MIend,
            this.toolStripMenuItem1,
            this.MIdelete,
            this.toolStripMenuItem4,
            this.MIDebugging});
            this.CMSmain.Name = "CMSmain";
            resources.ApplyResources(this.CMSmain, "CMSmain");
            // 
            // MIstart
            // 
            this.MIstart.Name = "MIstart";
            resources.ApplyResources(this.MIstart, "MIstart");
            this.MIstart.Click += new System.EventHandler(this.MIstart_Click);
            // 
            // MIend
            // 
            this.MIend.Name = "MIend";
            resources.ApplyResources(this.MIend, "MIend");
            this.MIend.Click += new System.EventHandler(this.MIend_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MIdelete
            // 
            this.MIdelete.Name = "MIdelete";
            resources.ApplyResources(this.MIdelete, "MIdelete");
            this.MIdelete.Click += new System.EventHandler(this.MIdelete_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // MIDebugging
            // 
            this.MIDebugging.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIPrint,
            this.MIAnimation});
            this.MIDebugging.Name = "MIDebugging";
            resources.ApplyResources(this.MIDebugging, "MIDebugging");
            // 
            // MIPrint
            // 
            this.MIPrint.Name = "MIPrint";
            resources.ApplyResources(this.MIPrint, "MIPrint");
            this.MIPrint.Click += new System.EventHandler(this.MIPrint_Click);
            // 
            // MIAnimation
            // 
            this.MIAnimation.Name = "MIAnimation";
            resources.ApplyResources(this.MIAnimation, "MIAnimation");
            this.MIAnimation.Click += new System.EventHandler(this.MIAnimation_Click);
            // 
            // MSmain
            // 
            this.MSmain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIFile});
            resources.ApplyResources(this.MSmain, "MSmain");
            this.MSmain.Name = "MSmain";
            this.MSmain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MSmain_ItemClicked);
            // 
            // MIFile
            // 
            this.MIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MINew,
            this.toolStripMenuItem2,
            this.MIOpen,
            this.MISave,
            this.toolStripMenuItem3,
            this.MIExit,
            this.MILanguage});
            this.MIFile.Name = "MIFile";
            resources.ApplyResources(this.MIFile, "MIFile");
            // 
            // MINew
            // 
            this.MINew.Name = "MINew";
            resources.ApplyResources(this.MINew, "MINew");
            this.MINew.Click += new System.EventHandler(this.MINew_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // MIOpen
            // 
            this.MIOpen.Name = "MIOpen";
            resources.ApplyResources(this.MIOpen, "MIOpen");
            this.MIOpen.Click += new System.EventHandler(this.MIOpen_Click);
            // 
            // MISave
            // 
            this.MISave.Name = "MISave";
            resources.ApplyResources(this.MISave, "MISave");
            this.MISave.Click += new System.EventHandler(this.MISave_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // MIExit
            // 
            this.MIExit.Name = "MIExit";
            resources.ApplyResources(this.MIExit, "MIExit");
            this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // MILanguage
            // 
            this.MILanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIGerman,
            this.MIEnglish});
            this.MILanguage.Name = "MILanguage";
            resources.ApplyResources(this.MILanguage, "MILanguage");
            // 
            // MIGerman
            // 
            this.MIGerman.Checked = true;
            this.MIGerman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MIGerman.Name = "MIGerman";
            resources.ApplyResources(this.MIGerman, "MIGerman");
            this.MIGerman.Click += new System.EventHandler(this.MIGerman_Click);
            // 
            // MIEnglish
            // 
            this.MIEnglish.Name = "MIEnglish";
            resources.ApplyResources(this.MIEnglish, "MIEnglish");
            this.MIEnglish.Click += new System.EventHandler(this.MIEnglish_Click);
            // 
            // LTotal
            // 
            resources.ApplyResources(this.LTotal, "LTotal");
            this.LTotal.Name = "LTotal";
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.MSmain);
            this.MainMenuStrip = this.MSmain;
            this.Name = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseUp);
            this.CMSmain.ResumeLayout(false);
            this.MSmain.ResumeLayout(false);
            this.MSmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMSmain;
        private System.Windows.Forms.ToolStripMenuItem MIstart;
        private System.Windows.Forms.ToolStripMenuItem MIend;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MIdelete;
        private System.Windows.Forms.MenuStrip MSmain;
        private System.Windows.Forms.ToolStripMenuItem MIFile;
        private System.Windows.Forms.ToolStripMenuItem MINew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MIOpen;
        private System.Windows.Forms.ToolStripMenuItem MISave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MIExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MIDebugging;
        private System.Windows.Forms.ToolStripMenuItem MIPrint;
        private System.Windows.Forms.ToolStripMenuItem MIAnimation;
        private System.Windows.Forms.ToolStripMenuItem MILanguage;
        private System.Windows.Forms.ToolStripMenuItem MIGerman;
        private System.Windows.Forms.ToolStripMenuItem MIEnglish;
        private System.Windows.Forms.Label LTotal;
    }
}

