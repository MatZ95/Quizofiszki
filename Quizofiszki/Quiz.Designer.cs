namespace Quizofiszki
{
    partial class Quiz
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
            this.questionLabel1 = new System.Windows.Forms.Label();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel1
            // 
            this.questionLabel1.AutoSize = true;
            this.questionLabel1.Location = new System.Drawing.Point(12, 9);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(51, 20);
            this.questionLabel1.TabIndex = 0;
            this.questionLabel1.Text = "label1";
            // 
            // answerButton2
            // 
            this.answerButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answerButton2.Location = new System.Drawing.Point(548, 126);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(517, 153);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(12, 285);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(517, 153);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(548, 285);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(517, 153);
            this.answerButton4.TabIndex = 4;
            this.answerButton4.Text = "button4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButton4_Click);
            // 
            // answerButton1
            // 
            this.answerButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answerButton1.Location = new System.Drawing.Point(12, 126);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(517, 153);
            this.answerButton1.TabIndex = 5;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nextButton.Location = new System.Drawing.Point(887, 83);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(178, 37);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Dalej";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answerButton1);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.questionLabel1);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button nextButton;
    }
}
