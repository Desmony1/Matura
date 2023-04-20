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
            this.CMSmain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MIstart = new System.Windows.Forms.ToolStripMenuItem();
            this.MIend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MIdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MIprint = new System.Windows.Forms.ToolStripMenuItem();
            this.MSmain = new System.Windows.Forms.MenuStrip();
            this.MIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MINew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MISave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MIExit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MIprint});
            this.CMSmain.Name = "CMSmain";
            this.CMSmain.Size = new System.Drawing.Size(177, 106);
            // 
            // MIstart
            // 
            this.MIstart.Name = "MIstart";
            this.MIstart.Size = new System.Drawing.Size(176, 24);
            this.MIstart.Text = "Startknoten";
            this.MIstart.Click += new System.EventHandler(this.MIstart_Click);
            // 
            // MIend
            // 
            this.MIend.Name = "MIend";
            this.MIend.Size = new System.Drawing.Size(176, 24);
            this.MIend.Text = "Endknoten";
            this.MIend.Click += new System.EventHandler(this.MIend_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // MIdelete
            // 
            this.MIdelete.Name = "MIdelete";
            this.MIdelete.Size = new System.Drawing.Size(176, 24);
            this.MIdelete.Text = "Löschen";
            this.MIdelete.Click += new System.EventHandler(this.MIdelete_Click);
            // 
            // MIprint
            // 
            this.MIprint.Name = "MIprint";
            this.MIprint.Size = new System.Drawing.Size(176, 24);
            this.MIprint.Text = "Print Nachbarn";
            this.MIprint.Click += new System.EventHandler(this.MIprint_Click);
            // 
            // MSmain
            // 
            this.MSmain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIFile});
            this.MSmain.Location = new System.Drawing.Point(0, 0);
            this.MSmain.Name = "MSmain";
            this.MSmain.Size = new System.Drawing.Size(800, 28);
            this.MSmain.TabIndex = 1;
            this.MSmain.Text = "menuStrip1";
            // 
            // MIFile
            // 
            this.MIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MINew,
            this.toolStripMenuItem2,
            this.MIOpen,
            this.MISave,
            this.toolStripMenuItem3,
            this.MIExit});
            this.MIFile.Name = "MIFile";
            this.MIFile.Size = new System.Drawing.Size(59, 24);
            this.MIFile.Text = "Datei";
            // 
            // MINew
            // 
            this.MINew.Name = "MINew";
            this.MINew.Size = new System.Drawing.Size(224, 26);
            this.MINew.Text = "Neu";
            this.MINew.Click += new System.EventHandler(this.MINew_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // MIOpen
            // 
            this.MIOpen.Name = "MIOpen";
            this.MIOpen.Size = new System.Drawing.Size(224, 26);
            this.MIOpen.Text = "Öffnen";
            this.MIOpen.Click += new System.EventHandler(this.MIOpen_Click);
            // 
            // MISave
            // 
            this.MISave.Name = "MISave";
            this.MISave.Size = new System.Drawing.Size(224, 26);
            this.MISave.Text = "Speichern unter";
            this.MISave.Click += new System.EventHandler(this.MISave_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // MIExit
            // 
            this.MIExit.Name = "MIExit";
            this.MIExit.Size = new System.Drawing.Size(224, 26);
            this.MIExit.Text = "Beenden";
            this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MSmain);
            this.MainMenuStrip = this.MSmain;
            this.Name = "FMain";
            this.Text = "Dijkstra";
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
        private System.Windows.Forms.ToolStripMenuItem MIprint;
        private System.Windows.Forms.MenuStrip MSmain;
        private System.Windows.Forms.ToolStripMenuItem MIFile;
        private System.Windows.Forms.ToolStripMenuItem MINew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MIOpen;
        private System.Windows.Forms.ToolStripMenuItem MISave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MIExit;
    }
}

