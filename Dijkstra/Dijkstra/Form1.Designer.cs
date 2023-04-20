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
            this.CMSmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMSmain
            // 
            this.CMSmain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIstart,
            this.MIend,
            this.toolStripMenuItem1,
            this.MIdelete});
            this.CMSmain.Name = "CMSmain";
            this.CMSmain.Size = new System.Drawing.Size(211, 110);
            // 
            // MIstart
            // 
            this.MIstart.Name = "MIstart";
            this.MIstart.Size = new System.Drawing.Size(210, 24);
            this.MIstart.Text = "Startknoten";
            this.MIstart.Click += new System.EventHandler(this.MIstart_Click);
            // 
            // MIend
            // 
            this.MIend.Name = "MIend";
            this.MIend.Size = new System.Drawing.Size(210, 24);
            this.MIend.Text = "Endknoten";
            this.MIend.Click += new System.EventHandler(this.MIend_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // MIdelete
            // 
            this.MIdelete.Name = "MIdelete";
            this.MIdelete.Size = new System.Drawing.Size(210, 24);
            this.MIdelete.Text = "Löschen";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FMain";
            this.Text = "Dijkstra";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseUp);
            this.CMSmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMSmain;
        private System.Windows.Forms.ToolStripMenuItem MIstart;
        private System.Windows.Forms.ToolStripMenuItem MIend;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MIdelete;
    }
}

