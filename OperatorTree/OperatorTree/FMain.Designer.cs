
namespace OperatorTree
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
            this.MSAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lValidation = new System.Windows.Forms.Label();
            this.lPrefix = new System.Windows.Forms.Label();
            this.lInfix = new System.Windows.Forms.Label();
            this.lPostfix = new System.Windows.Forms.Label();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.MSAdd.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSAdd
            // 
            this.MSAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorToolStripMenuItem,
            this.operandToolStripMenuItem});
            this.MSAdd.Name = "MSAdd";
            this.MSAdd.Size = new System.Drawing.Size(122, 48);
            this.MSAdd.Text = "Hinzufügen";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.operatorToolStripMenuItem.Text = "Operator";
            this.operatorToolStripMenuItem.Click += new System.EventHandler(this.operatorToolStripMenuItem_Click);
            // 
            // operandToolStripMenuItem
            // 
            this.operandToolStripMenuItem.Name = "operandToolStripMenuItem";
            this.operandToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.operandToolStripMenuItem.Text = "Operand";
            this.operandToolStripMenuItem.Click += new System.EventHandler(this.operandToolStripMenuItem_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(600, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.toolStripMenuItem1,
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem2,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(180, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(180, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // lValidation
            // 
            this.lValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lValidation.AutoSize = true;
            this.lValidation.ForeColor = System.Drawing.Color.Black;
            this.lValidation.Location = new System.Drawing.Point(12, 293);
            this.lValidation.Name = "lValidation";
            this.lValidation.Size = new System.Drawing.Size(47, 13);
            this.lValidation.TabIndex = 2;
            this.lValidation.Text = "not valid";
            // 
            // lPrefix
            // 
            this.lPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPrefix.AutoSize = true;
            this.lPrefix.Location = new System.Drawing.Point(12, 316);
            this.lPrefix.Name = "lPrefix";
            this.lPrefix.Size = new System.Drawing.Size(32, 13);
            this.lPrefix.TabIndex = 3;
            this.lPrefix.Text = "prefix";
            // 
            // lInfix
            // 
            this.lInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lInfix.AutoSize = true;
            this.lInfix.Location = new System.Drawing.Point(12, 329);
            this.lInfix.Name = "lInfix";
            this.lInfix.Size = new System.Drawing.Size(25, 13);
            this.lInfix.TabIndex = 4;
            this.lInfix.Text = "infix";
            // 
            // lPostfix
            // 
            this.lPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPostfix.AutoSize = true;
            this.lPostfix.Location = new System.Drawing.Point(12, 342);
            this.lPostfix.Name = "lPostfix";
            this.lPostfix.Size = new System.Drawing.Size(37, 13);
            this.lPostfix.TabIndex = 5;
            this.lPostfix.Text = "postfix";
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAnimation});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "View";
            // 
            // miAnimation
            // 
            this.miAnimation.CheckOnClick = true;
            this.miAnimation.Name = "miAnimation";
            this.miAnimation.Size = new System.Drawing.Size(180, 22);
            this.miAnimation.Text = "Animation";
            this.miAnimation.Click += new System.EventHandler(this.miAnimation_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lPostfix);
            this.Controls.Add(this.lInfix);
            this.Controls.Add(this.lPrefix);
            this.Controls.Add(this.lValidation);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.LocationChanged += new System.EventHandler(this.FMain_LocationChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseUp);
            this.Resize += new System.EventHandler(this.FMain_Resize);
            this.MSAdd.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MSAdd;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operandToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Label lValidation;
        private System.Windows.Forms.Label lPrefix;
        private System.Windows.Forms.Label lInfix;
        private System.Windows.Forms.Label lPostfix;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miAnimation;
    }
}

