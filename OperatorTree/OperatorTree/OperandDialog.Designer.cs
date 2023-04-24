
namespace OperatorTree
{
    partial class OperandDialog
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.lOperand = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(180, 77);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(128, 36);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Abbrechen";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAccept
            // 
            this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAccept.Enabled = false;
            this.bAccept.Location = new System.Drawing.Point(31, 77);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(128, 36);
            this.bAccept.TabIndex = 6;
            this.bAccept.Text = "Akzeptieren";
            this.bAccept.UseVisualStyleBackColor = true;
            // 
            // lOperand
            // 
            this.lOperand.AutoSize = true;
            this.lOperand.Location = new System.Drawing.Point(28, 27);
            this.lOperand.Name = "lOperand";
            this.lOperand.Size = new System.Drawing.Size(68, 17);
            this.lOperand.TabIndex = 4;
            this.lOperand.Text = "Operand:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(103, 27);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(205, 22);
            this.tbNumber.TabIndex = 8;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // OperandDialog
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(356, 154);
            this.ControlBox = false;
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.lOperand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OperandDialog";
            this.Text = "Operand";
            this.Load += new System.EventHandler(this.OperandDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Label lOperand;
        private System.Windows.Forms.TextBox tbNumber;
    }
}