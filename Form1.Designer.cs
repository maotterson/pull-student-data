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
            this.textCourseNum = new System.Windows.Forms.TextBox();
            this.labelCourseNum = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(56, 63);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token";
            // 
            // textToken
            // 
            this.textToken.Location = new System.Drawing.Point(59, 80);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(383, 20);
            this.textToken.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(59, 128);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(383, 31);
            this.button.TabIndex = 2;
            this.button.Text = "Fetch Data";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textCourseNum
            // 
            this.textCourseNum.Location = new System.Drawing.Point(59, 31);
            this.textCourseNum.Name = "textCourseNum";
            this.textCourseNum.Size = new System.Drawing.Size(383, 20);
            this.textCourseNum.TabIndex = 4;
            // 
            // labelCourseNum
            // 
            this.labelCourseNum.AutoSize = true;
            this.labelCourseNum.Location = new System.Drawing.Point(56, 14);
            this.labelCourseNum.Name = "labelCourseNum";
            this.labelCourseNum.Size = new System.Drawing.Size(80, 13);
            this.labelCourseNum.TabIndex = 3;
            this.labelCourseNum.Text = "Course Number";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 230);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Ready!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 252);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textCourseNum);
            this.Controls.Add(this.labelCourseNum);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form1";
            this.Text = "Course Student Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textCourseNum;
        private System.Windows.Forms.Label labelCourseNum;
        private System.Windows.Forms.Label labelStatus;
    }
}

