using System.Windows.Forms;

namespace Quizofiszki
{
    partial class BazaPytan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.CheckBox checkBoxCorrectAnswers0;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswers0;
        private System.Windows.Forms.TextBox textBoxAnswers1;
        private System.Windows.Forms.TextBox textBoxAnswers2;
        private System.Windows.Forms.TextBox textBoxAnswers3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxCorrectAnswers1;
        private System.Windows.Forms.CheckBox checkBoxCorrectAnswers2;
        private System.Windows.Forms.CheckBox checkBoxCorrectAnswers3;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer4;

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
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.checkBoxCorrectAnswers0 = new System.Windows.Forms.CheckBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswers0 = new System.Windows.Forms.TextBox();
            this.textBoxAnswers1 = new System.Windows.Forms.TextBox();
            this.textBoxAnswers2 = new System.Windows.Forms.TextBox();
            this.textBoxAnswers3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxCorrectAnswers1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrectAnswers2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrectAnswers3 = new System.Windows.Forms.CheckBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonNewTest = new System.Windows.Forms.Button();
            this.buttonDeleteTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AllowUserToAddRows = false;
            this.dataGridViewQuestions.AllowUserToDeleteRows = false;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(12, 243);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.ReadOnly = true;
            this.dataGridViewQuestions.RowHeadersWidth = 62;
            this.dataGridViewQuestions.RowTemplate.Height = 28;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(1033, 667);
            this.dataGridViewQuestions.TabIndex = 2;
            // 
            // checkBoxCorrectAnswers0
            // 
            this.checkBoxCorrectAnswers0.AutoSize = true;
            this.checkBoxCorrectAnswers0.Location = new System.Drawing.Point(1023, 65);
            this.checkBoxCorrectAnswers0.Name = "checkBoxCorrectAnswers0";
            this.checkBoxCorrectAnswers0.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCorrectAnswers0.TabIndex = 3;
            this.checkBoxCorrectAnswers0.UseVisualStyleBackColor = true;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(12, 32);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(942, 26);
            this.textBoxQuestion.TabIndex = 4;
            // 
            // textBoxAnswers0
            // 
            this.textBoxAnswers0.Location = new System.Drawing.Point(42, 65);
            this.textBoxAnswers0.Name = "textBoxAnswers0";
            this.textBoxAnswers0.Size = new System.Drawing.Size(975, 26);
            this.textBoxAnswers0.TabIndex = 5;
            // 
            // textBoxAnswers1
            // 
            this.textBoxAnswers1.Location = new System.Drawing.Point(42, 97);
            this.textBoxAnswers1.Name = "textBoxAnswers1";
            this.textBoxAnswers1.Size = new System.Drawing.Size(975, 26);
            this.textBoxAnswers1.TabIndex = 6;
            // 
            // textBoxAnswers2
            // 
            this.textBoxAnswers2.Location = new System.Drawing.Point(42, 133);
            this.textBoxAnswers2.Name = "textBoxAnswers2";
            this.textBoxAnswers2.Size = new System.Drawing.Size(975, 26);
            this.textBoxAnswers2.TabIndex = 7;
            // 
            // textBoxAnswers3
            // 
            this.textBoxAnswers3.Location = new System.Drawing.Point(42, 165);
            this.textBoxAnswers3.Name = "textBoxAnswers3";
            this.textBoxAnswers3.Size = new System.Drawing.Size(975, 26);
            this.textBoxAnswers3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pytanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Poprawna \r\nodpowiedź";
            // 
            // checkBoxCorrectAnswers1
            // 
            this.checkBoxCorrectAnswers1.AutoSize = true;
            this.checkBoxCorrectAnswers1.Location = new System.Drawing.Point(1023, 98);
            this.checkBoxCorrectAnswers1.Name = "checkBoxCorrectAnswers1";
            this.checkBoxCorrectAnswers1.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCorrectAnswers1.TabIndex = 15;
            this.checkBoxCorrectAnswers1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorrectAnswers2
            // 
            this.checkBoxCorrectAnswers2.AutoSize = true;
            this.checkBoxCorrectAnswers2.Location = new System.Drawing.Point(1023, 132);
            this.checkBoxCorrectAnswers2.Name = "checkBoxCorrectAnswers2";
            this.checkBoxCorrectAnswers2.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCorrectAnswers2.TabIndex = 16;
            this.checkBoxCorrectAnswers2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorrectAnswers3
            // 
            this.checkBoxCorrectAnswers3.AutoSize = true;
            this.checkBoxCorrectAnswers3.Location = new System.Drawing.Point(1023, 170);
            this.checkBoxCorrectAnswers3.Name = "checkBoxCorrectAnswers3";
            this.checkBoxCorrectAnswers3.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCorrectAnswers3.TabIndex = 17;
            this.checkBoxCorrectAnswers3.UseVisualStyleBackColor = true;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddQuestion.Location = new System.Drawing.Point(12, 197);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(138, 40);
            this.buttonAddQuestion.TabIndex = 18;
            this.buttonAddQuestion.Text = "Dodaj pytanie";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonDeleteQuestion
            // 
            this.buttonDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteQuestion.Location = new System.Drawing.Point(156, 197);
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.Size = new System.Drawing.Size(138, 40);
            this.buttonDeleteQuestion.TabIndex = 20;
            this.buttonDeleteQuestion.Text = "Usuń pytanie";
            this.buttonDeleteQuestion.UseVisualStyleBackColor = false;
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.buttonDeleteQuestion_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(860, 197);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(185, 40);
            this.buttonSelectFile.TabIndex = 21;
            this.buttonSelectFile.Text = "Wybierz plik z testem";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonNewTest
            // 
            this.buttonNewTest.Location = new System.Drawing.Point(669, 197);
            this.buttonNewTest.Name = "buttonNewTest";
            this.buttonNewTest.Size = new System.Drawing.Size(185, 40);
            this.buttonNewTest.TabIndex = 22;
            this.buttonNewTest.Text = "Dodaj nowy test";
            this.buttonNewTest.UseVisualStyleBackColor = true;
            this.buttonNewTest.Click += new System.EventHandler(this.buttonNewTest_Click);
            // 
            // buttonDeleteTest
            // 
            this.buttonDeleteTest.Location = new System.Drawing.Point(478, 197);
            this.buttonDeleteTest.Name = "buttonDeleteTest";
            this.buttonDeleteTest.Size = new System.Drawing.Size(185, 40);
            this.buttonDeleteTest.TabIndex = 23;
            this.buttonDeleteTest.Text = "Usuń istniejący test";
            this.buttonDeleteTest.UseVisualStyleBackColor = true;
            this.buttonDeleteTest.Click += new System.EventHandler(this.buttonDeleteTest_Click);
            // 
            // BazaPytan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 922);
            this.Controls.Add(this.buttonDeleteTest);
            this.Controls.Add(this.buttonNewTest);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonDeleteQuestion);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.checkBoxCorrectAnswers3);
            this.Controls.Add(this.checkBoxCorrectAnswers2);
            this.Controls.Add(this.checkBoxCorrectAnswers1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnswers3);
            this.Controls.Add(this.textBoxAnswers2);
            this.Controls.Add(this.textBoxAnswers1);
            this.Controls.Add(this.textBoxAnswers0);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.checkBoxCorrectAnswers0);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Name = "BazaPytan";
            this.Text = "Baza Pytań";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSelectFile;
        private Button buttonNewTest;
        private Button buttonDeleteTest;
    }
}
