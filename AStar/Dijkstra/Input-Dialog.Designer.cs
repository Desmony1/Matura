namespace AStar
{
    partial class FDialog
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
            this.TBInput = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.LInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(12, 39);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(210, 22);
            this.TBInput.TabIndex = 0;
            this.TBInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BOk
            // 
            this.BOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOk.Location = new System.Drawing.Point(147, 82);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(75, 23);
            this.BOk.TabIndex = 1;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(12, 82);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // LInput
            // 
            this.LInput.AutoSize = true;
            this.LInput.Location = new System.Drawing.Point(13, 13);
            this.LInput.Name = "LInput";
            this.LInput.Size = new System.Drawing.Size(38, 16);
            this.LInput.TabIndex = 3;
            this.LInput.Text = "Input:";
            this.LInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // FDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(234, 123);
            this.Controls.Add(this.LInput);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TBInput);
            this.MaximumSize = new System.Drawing.Size(252, 170);
            this.MinimumSize = new System.Drawing.Size(252, 170);
            this.Name = "FDialog";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.FDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label LInput;
    }
}