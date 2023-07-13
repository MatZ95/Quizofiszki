using Quizofiszki;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quizofiszki
{
    public partial class Quiz : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int numberOfQuestionsToDisplay;

        private TextBox numberOfQuestionsTextBox;
        private Button startButton;
        private Form numberOfQuestionsDialog;

        public Quiz()
        {
            InitializeComponent();
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            ShowNumberOfQuestionsDialog();
        }

        private void ShowNumberOfQuestionsDialog()
        {
            numberOfQuestionsDialog = new Form();
            numberOfQuestionsDialog.Width = 300;
            numberOfQuestionsDialog.Height = 200;
            numberOfQuestionsDialog.StartPosition = FormStartPosition.CenterScreen;
            numberOfQuestionsDialog.Text = "Liczba pytań";

            Label questionLabel = new Label();
            questionLabel.Text = "Podaj liczbę pytań, jakie mają zostać wyświetlone:";
            questionLabel.Location = new Point(30, 30);
            questionLabel.Width = 250;
            numberOfQuestionsDialog.Controls.Add(questionLabel);

            numberOfQuestionsTextBox = new TextBox();
            numberOfQuestionsTextBox.Location = new Point(30, 70);
            numberOfQuestionsTextBox.Width = 200;
            numberOfQuestionsDialog.Controls.Add(numberOfQuestionsTextBox);

            startButton = new Button();
            startButton.Text = "Start";
            startButton.Location = new Point(30, 110);
            startButton.Click += StartButton_Click;
            numberOfQuestionsDialog.Controls.Add(startButton);

            numberOfQuestionsDialog.ShowDialog();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfQuestionsTextBox.Text, out int numberOfQuestions))
            {
                if (numberOfQuestions <= 0)
                {
                    MessageBox.Show("Liczba pytań musi być większa od zera.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadQuestions();

                if (numberOfQuestions > questions.Count)
                {
                    MessageBox.Show("W bazie nie ma wystarczającej liczby pytań.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                numberOfQuestionsToDisplay = numberOfQuestions;

                List<int> questionIndices = Enumerable.Range(0, questions.Count).ToList();
                Random random = new Random();
                questionIndices = questionIndices.OrderBy(x => random.Next()).ToList();

                questionIndices = questionIndices.Take(numberOfQuestionsToDisplay).ToList();

                currentQuestionIndex = 0;
                DisplayQuestion(questionIndices[currentQuestionIndex]);

                numberOfQuestionsDialog.Close();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wprowadzona wartość jest niepoprawna.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayQuestion(int questionIndex)
        {
            if (questionIndex >= 0 && questionIndex < questions.Count)
            {
                ResetAnswerButtonColors();

                Question question = questions[questionIndex];
                questionLabel1.Text = question.QuestionText;

                List<int> answerIndices = new List<int> { 0, 1, 2, 3 };
                Random random = new Random();
                answerIndices = answerIndices.OrderBy(x => random.Next()).ToList();

                answerButton1.Text = question.AnswerTexts[answerIndices[0]];
                answerButton2.Text = question.AnswerTexts[answerIndices[1]];
                answerButton3.Text = question.AnswerTexts[answerIndices[2]];
                answerButton4.Text = question.AnswerTexts[answerIndices[3]];
            }
        }

        private void ResetAnswerButtonColors()
        {
            answerButton1.BackColor = SystemColors.Control;
            answerButton2.BackColor = SystemColors.Control;
            answerButton3.BackColor = SystemColors.Control;
            answerButton4.BackColor = SystemColors.Control;
        }

        private void LoadQuestions()
        {
            questions = new List<Question>();

            string filePath = "pytania.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 9)
                        {
                            string questionText = parts[0];
                            string[] answerTexts = new string[4];
                            bool[] correctAnswers = new bool[4];

                            for (int i = 0; i < 4; i++)
                            {
                                answerTexts[i] = parts[i + 1];
                                correctAnswers[i] = (parts[i + 5] == "1");
                            }

                            Question question = new Question(questionText, answerTexts, correctAnswers);
                            questions.Add(question);
                        }
                    }
                }
            }
        }

        private void answerButton1_Click(object sender, EventArgs e)
        {
            CheckAnswer(answerButton1, 0);
        }

        private void answerButton2_Click(object sender, EventArgs e)
        {
            CheckAnswer(answerButton2, 1);
        }

        private void answerButton3_Click(object sender, EventArgs e)
        {
            CheckAnswer(answerButton3, 2);
        }

        private void answerButton4_Click(object sender, EventArgs e)
        {
            CheckAnswer(answerButton4, 3);
        }

        private void CheckAnswer(Button button, int index)
        {
            Question question = questions[currentQuestionIndex];
            bool[] correctAnswers = question.CorrectAnswers;

            if (correctAnswers[index])
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;
            }

            DisableAnswerButtons();
            nextButton.Enabled = true;
        }

        private void DisableAnswerButtons()
        {
            answerButton1.Enabled = false;
            answerButton2.Enabled = false;
            answerButton3.Enabled = false;
            answerButton4.Enabled = false;
        }

        private void EnableAnswerButtons()
        {
            answerButton1.Enabled = true;
            answerButton2.Enabled = true;
            answerButton3.Enabled = true;
            answerButton4.Enabled = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;

            if (currentQuestionIndex < numberOfQuestionsToDisplay)
            {
                EnableAnswerButtons();
                DisplayQuestion(currentQuestionIndex);
                ResetAnswerButtonColors();
                nextButton.Enabled = false;
            }
            else if (currentQuestionIndex == numberOfQuestionsToDisplay)
            {
                FinishQuiz();
            }
        }

        private void FinishQuiz()
        {
            this.Close();

            Form resultForm = new Form();
            resultForm.Width = 400;
            resultForm.Height = 300;
            resultForm.StartPosition = FormStartPosition.CenterScreen;
            resultForm.Text = "Wyniki";

            Label resultLabel = new Label();
            resultLabel.Text = $"Twój wynik: {CalculateScore()}/{CalculateMaxScore()}";
            resultLabel.Location = new Point(30, 30);
            resultLabel.Width = 250;
            resultForm.Controls.Add(resultLabel);

            ListBox answerListBox = new ListBox();
            answerListBox.Location = new Point(30, 70);
            answerListBox.Width = 250;
            answerListBox.Height = 150;
            resultForm.Controls.Add(answerListBox);

            for (int i = 0; i < numberOfQuestionsToDisplay; i++)
            {
                Question question = questions[i];
                bool[] correctAnswers = question.CorrectAnswers;

                string answerText = $"Pytanie {i + 1}: {GetAnswerStatus(question, correctAnswers)}";
                answerListBox.Items.Add(answerText);
            }

            Button closeButton = new Button();
            closeButton.Text = "Zamknij";
            closeButton.Location = new Point(30, 230);
            closeButton.Click += (s, e) => resultForm.Close();
            resultForm.Controls.Add(closeButton);

            resultForm.ShowDialog();
        }

        private string GetAnswerStatus(Question question, bool[] correctAnswers)
        {
            bool isCorrect = correctAnswers.All(x => x);

            if (isCorrect)
            {
                return "Poprawna";
            }
            else
            {
                return "Błędna";
            }
        }

        private int CalculateMaxScore()
        {
            return numberOfQuestionsToDisplay;
        }

        private int CalculateScore()
        {
            int score = 0;

            for (int i = 0; i < numberOfQuestionsToDisplay; i++)
            {
                Question question = questions[i];
                bool[] correctAnswers = question.CorrectAnswers;

                if (correctAnswers.All(x => x))
                {
                    score++;
                }
            }

            return score;
        }
    }
}
