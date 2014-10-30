namespace BasisPracticeUsing3Layer
{
    partial class MainUI
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
            this.courseUIButton = new System.Windows.Forms.Button();
            this.studentInfoButton = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseUIButton
            // 
            this.courseUIButton.Location = new System.Drawing.Point(20, 32);
            this.courseUIButton.Name = "courseUIButton";
            this.courseUIButton.Size = new System.Drawing.Size(163, 37);
            this.courseUIButton.TabIndex = 0;
            this.courseUIButton.Text = "Course UI";
            this.courseUIButton.UseVisualStyleBackColor = true;
            this.courseUIButton.Click += new System.EventHandler(this.courseUIButton_Click);
            // 
            // studentInfoButton
            // 
            this.studentInfoButton.Location = new System.Drawing.Point(20, 75);
            this.studentInfoButton.Name = "studentInfoButton";
            this.studentInfoButton.Size = new System.Drawing.Size(163, 34);
            this.studentInfoButton.TabIndex = 1;
            this.studentInfoButton.Text = "Student UI";
            this.studentInfoButton.UseVisualStyleBackColor = true;
            this.studentInfoButton.Click += new System.EventHandler(this.studentInfoButton_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(20, 115);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(163, 35);
            this.enrollButton.TabIndex = 2;
            this.enrollButton.Text = "Enrollment";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enrollButton);
            this.groupBox1.Controls.Add(this.studentInfoButton);
            this.groupBox1.Controls.Add(this.courseUIButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main UI";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 186);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button courseUIButton;
        private System.Windows.Forms.Button studentInfoButton;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}