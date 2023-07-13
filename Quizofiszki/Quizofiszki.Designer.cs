namespace Quizofiszki
{
    partial class Quizofiszki
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionsData = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionsData
            // 
            this.QuestionsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.QuestionsData.Location = new System.Drawing.Point(81, 31);
            this.QuestionsData.Name = "QuestionsData";
            this.QuestionsData.Size = new System.Drawing.Size(183, 45);
            this.QuestionsData.TabIndex = 0;
            this.QuestionsData.Text = "Przejdź do bazy pytań";
            this.QuestionsData.UseVisualStyleBackColor = false;
            this.QuestionsData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Quiz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quiz.Location = new System.Drawing.Point(270, 31);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(183, 45);
            this.Quiz.TabIndex = 1;
            this.Quiz.Text = "Przejdź do quizu";
            this.Quiz.UseVisualStyleBackColor = false;
            this.Quiz.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 103);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.QuestionsData);
            this.Name = "Form1";
            this.Text = "Quizofiszki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuestionsData;
        private System.Windows.Forms.Button Quiz;
    }
}

