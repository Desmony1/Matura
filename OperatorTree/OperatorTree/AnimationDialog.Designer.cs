
namespace OperatorTree
{
    partial class AnimationDialog
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
            this.gbAnimation = new System.Windows.Forms.GroupBox();
            this.rbPostfix = new System.Windows.Forms.RadioButton();
            this.rbInfix = new System.Windows.Forms.RadioButton();
            this.rbPrefix = new System.Windows.Forms.RadioButton();
            this.bRun = new System.Windows.Forms.Button();
            this.gbAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnimation
            // 
            this.gbAnimation.Controls.Add(this.rbPostfix);
            this.gbAnimation.Controls.Add(this.rbInfix);
            this.gbAnimation.Controls.Add(this.rbPrefix);
            this.gbAnimation.Location = new System.Drawing.Point(16, 15);
            this.gbAnimation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnimation.Name = "gbAnimation";
            this.gbAnimation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnimation.Size = new System.Drawing.Size(153, 112);
            this.gbAnimation.TabIndex = 0;
            this.gbAnimation.TabStop = false;
            this.gbAnimation.Text = "Method";
            this.gbAnimation.Enter += new System.EventHandler(this.gbAnimation_Enter);
            // 
            // rbPostfix
            // 
            this.rbPostfix.AutoSize = true;
            this.rbPostfix.Location = new System.Drawing.Point(9, 84);
            this.rbPostfix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPostfix.Name = "rbPostfix";
            this.rbPostfix.Size = new System.Drawing.Size(69, 21);
            this.rbPostfix.TabIndex = 2;
            this.rbPostfix.TabStop = true;
            this.rbPostfix.Text = "postfix";
            this.rbPostfix.UseVisualStyleBackColor = true;
            // 
            // rbInfix
            // 
            this.rbInfix.AutoSize = true;
            this.rbInfix.Location = new System.Drawing.Point(9, 54);
            this.rbInfix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbInfix.Name = "rbInfix";
            this.rbInfix.Size = new System.Drawing.Size(53, 21);
            this.rbInfix.TabIndex = 1;
            this.rbInfix.TabStop = true;
            this.rbInfix.Text = "infix";
            this.rbInfix.UseVisualStyleBackColor = true;
            // 
            // rbPrefix
            // 
            this.rbPrefix.AutoSize = true;
            this.rbPrefix.Location = new System.Drawing.Point(9, 25);
            this.rbPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPrefix.Name = "rbPrefix";
            this.rbPrefix.Size = new System.Drawing.Size(63, 21);
            this.rbPrefix.TabIndex = 0;
            this.rbPrefix.TabStop = true;
            this.rbPrefix.Text = "prefix";
            this.rbPrefix.UseVisualStyleBackColor = true;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(44, 134);
            this.bRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(100, 28);
            this.bRun.TabIndex = 1;
            this.bRun.Text = "Starten";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // AnimationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 174);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.gbAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnimationDialog";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnimationDialog_Load);
            this.gbAnimation.ResumeLayout(false);
            this.gbAnimation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnimation;
        private System.Windows.Forms.RadioButton rbPostfix;
        private System.Windows.Forms.RadioButton rbInfix;
        private System.Windows.Forms.RadioButton rbPrefix;
        private System.Windows.Forms.Button bRun;
    }
}