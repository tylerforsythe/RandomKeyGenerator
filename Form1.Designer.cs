namespace RandomKeyGenerator
{
    partial class RkgForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfCharacters = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtResultsBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkIncludeSpecial = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Characters:";
            // 
            // txtNumberOfCharacters
            // 
            this.txtNumberOfCharacters.Location = new System.Drawing.Point(131, 13);
            this.txtNumberOfCharacters.Name = "txtNumberOfCharacters";
            this.txtNumberOfCharacters.Size = new System.Drawing.Size(59, 20);
            this.txtNumberOfCharacters.TabIndex = 1;
            this.txtNumberOfCharacters.Text = "128";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(196, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(146, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate to &Clipboard";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtResultsBox
            // 
            this.txtResultsBox.HideSelection = false;
            this.txtResultsBox.Location = new System.Drawing.Point(12, 44);
            this.txtResultsBox.Multiline = true;
            this.txtResultsBox.Name = "txtResultsBox";
            this.txtResultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultsBox.Size = new System.Drawing.Size(979, 268);
            this.txtResultsBox.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(916, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(715, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkIncludeSpecial
            // 
            this.chkIncludeSpecial.AutoSize = true;
            this.chkIncludeSpecial.Checked = true;
            this.chkIncludeSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSpecial.Location = new System.Drawing.Point(369, 14);
            this.chkIncludeSpecial.Name = "chkIncludeSpecial";
            this.chkIncludeSpecial.Size = new System.Drawing.Size(153, 17);
            this.chkIncludeSpecial.TabIndex = 6;
            this.chkIncludeSpecial.Text = "Include &Special Characters";
            this.chkIncludeSpecial.UseVisualStyleBackColor = true;
            // 
            // RkgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 324);
            this.Controls.Add(this.chkIncludeSpecial);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResultsBox);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumberOfCharacters);
            this.Controls.Add(this.label1);
            this.Name = "RkgForm";
            this.Text = "RKG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfCharacters;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtResultsBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkIncludeSpecial;
    }
}

