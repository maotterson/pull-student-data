namespace PullStudentData
{
    partial class Form1
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
            this.lblToken = new System.Windows.Forms.Label();
            this.textToken = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(56, 44);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token";
            // 
            // textToken
            // 
            this.textToken.Location = new System.Drawing.Point(59, 61);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(383, 20);
            this.textToken.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(59, 109);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(383, 31);
            this.button.TabIndex = 2;
            this.button.Text = "Fetch Data";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 201);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.Button button;
    }
}

