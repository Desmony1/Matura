
namespace OperatorTree
{
    partial class OperatorDialog
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
            this.loperator = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loperator
            // 
            this.loperator.AutoSize = true;
            this.loperator.Location = new System.Drawing.Point(22, 30);
            this.loperator.Name = "loperator";
            this.loperator.Size = new System.Drawing.Size(69, 17);
            this.loperator.TabIndex = 0;
            this.loperator.Text = "Operator:";
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.ItemHeight = 16;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cbOperator.Location = new System.Drawing.Point(98, 30);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(204, 24);
            this.cbOperator.TabIndex = 1;
            this.cbOperator.SelectedValueChanged += new System.EventHandler(this.cbOperator_SelectedValueChanged);
            // 
            // bAccept
            // 
            this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAccept.Enabled = false;
            this.bAccept.Location = new System.Drawing.Point(25, 80);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(128, 36);
            this.bAccept.TabIndex = 2;
            this.bAccept.Text = "Akzeptieren";
            this.bAccept.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(174, 80);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(128, 36);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Abbrechen";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // OperatorDialog
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(332, 163);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.loperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OperatorDialog";
            this.Text = "Operator";
            this.Load += new System.EventHandler(this.OperatorDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loperator;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
    }
}