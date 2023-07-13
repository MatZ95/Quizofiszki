using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizofiszki
{
    public partial class BazaPytan : Form
    {
        private List<Question> questions; // Lista przechowująca pytania
        private TextBox[] textBoxAnswers; // Tablica przechowująca kontrolki TextBox dla odpowiedzi
        private CheckBox[] checkBoxCorrectAnswers; // Tablica przechowująca kontrolki CheckBox dla poprawnych odpowiedzi
        private bool fileLoaded; // Flaga informująca o wczytaniu pliku
        private string filePath; // Ścieżka do pliku z pytaniami

        public BazaPytan()
        {
            InitializeComponent();
            textBoxAnswers = new TextBox[] { textBoxAnswers0, textBoxAnswers1, textBoxAnswers2, textBoxAnswers3 };
            checkBoxCorrectAnswers = new CheckBox[] { checkBoxCorrectAnswers0, checkBoxCorrectAnswers1, checkBoxCorrectAnswers2, checkBoxCorrectAnswers3 };
            fileLoaded = false; // Ustawienie początkowej wartości flagi
            DisableQuestionAdding(); // Wyłączenie dodawania pytań na starcie
            DisableQuestionDeleting(); // Wyłączenie usuwania pytań na starcie
        }

        private void BazaPytan_Load(object sender, EventArgs e)
        {
            // Ustawienie trybu zaznaczania na pełne wiersze
            dataGridViewQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Usunięcie istniejących kolumn
            dataGridViewQuestions.Columns.Clear();

            // Dodaj kolumny do DataGridView
            dataGridViewQuestions.Columns.Add("QuestionText", "Pytanie");

            for (int i = 0; i < 4; i++)
            {
                string answerColumnName = string.Format("Answer{0}", i + 1);
                dataGridViewQuestions.Columns.Add(answerColumnName, "Odpowiedź " + (i + 1));
            }

            // Dodaj kolumnę dla oznaczania poprawnych odpowiedzi
            dataGridViewQuestions.Columns.Add("Correct", "Poprawne");

            LoadQuestions(); // Wczytanie pytań z pliku tekstowego
            RefreshDataGridView(); // Odświeżenie DataGridView
            UpdateQuestionDeletingButtonState(); // Aktualizacja stanu przycisku usuwania pytań
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik z pytaniami";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                LoadQuestionsFromFile(filePath); // Wczytanie pytań z wybranego pliku tekstowego
                RefreshDataGridView(); // Odświeżenie DataGridView
                EnableQuestionAdding(); // Włączenie dodawania pytań
                EnableQuestionDeleting(); // Włączenie usuwania pytań
                fileLoaded = true; // Ustawienie flagi fileLoaded na true

                if (questions.Count >= 0)
                {
                    EnableQuestionButton(); // Włączenie przycisku "Dodaj pytanie"
                }
                else
                {
                    DisableQuestionButton(); // Wyłączenie przycisku "Dodaj pytanie"
                }

                UpdateQuestionDeletingButtonState(); // Aktualizacja stanu przycisku usuwania pytań
            }
        }

        private void DisableQuestionAdding()
        {
            buttonAddQuestion.Enabled = false; // Wyłączenie przycisku dodawania pytania
        }

        private void EnableQuestionAdding()
        {
            buttonAddQuestion.Enabled = true; // Włączenie przycisku dodawania pytania
        }

        private void EnableQuestionButton()
        {
            buttonAddQuestion.Enabled = true;
            buttonAddQuestion.Text = "Dodaj pytanie";
        }

        private void DisableQuestionButton()
        {
            buttonAddQuestion.Enabled = false;
            buttonAddQuestion.Text = "Wybierz plik z pytaniami";
        }

        private void DisableQuestionDeleting()
        {
            buttonDeleteQuestion.Enabled = false; // Wyłączenie przycisku usuwania pytania
        }

        private void EnableQuestionDeleting()
        {
            buttonDeleteQuestion.Enabled = true; // Włączenie przycisku usuwania pytania
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Nie wybrano pliku z pytaniami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string questionText = textBoxQuestion.Text;
            string[] answerTexts = new string[4];
            bool[] correctAnswers = new bool[4];

            for (int i = 0; i < 4; i++)
            {
                answerTexts[i] = textBoxAnswers[i].Text;
                correctAnswers[i] = checkBoxCorrectAnswers[i].Checked;
            }

            if (correctAnswers.Count(a => a) != 1)
            {
                MessageBox.Show("Wybierz dokładnie jedną poprawną odpowiedź.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Question question = new Question(questionText, answerTexts, correctAnswers);
            questions.Add(question);

            // Wyczyść TextBoxy i CheckBoxy po dodaniu pytania
            textBoxQuestion.Text = string.Empty;
            foreach (TextBox textBox in textBoxAnswers)
            {
                textBox.Text = string.Empty;
            }
            foreach (CheckBox checkBox in checkBoxCorrectAnswers)
            {
                checkBox.Checked = false;
            }

            // Zapisanie pytań do pliku tekstowego
            SaveQuestionsToFile(filePath);

            // Odświeżenie DataGridView
            RefreshDataGridView();
            UpdateQuestionDeletingButtonState(); // Aktualizacja stanu przycisku usuwania pytań
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewQuestions.SelectedRows[0].Index;
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewQuestions.Rows.Count)
                {
                    Question selectedQuestion = questions[selectedRowIndex];

                    // Aktualizacja danych pytania na podstawie wprowadzonych zmian
                    selectedQuestion.QuestionText = textBoxQuestion.Text;
                    for (int i = 0; i < 4; i++)
                    {
                        selectedQuestion.AnswerTexts[i] = textBoxAnswers[i].Text;
                        selectedQuestion.CorrectAnswers[i] = checkBoxCorrectAnswers[i].Checked;
                    }

                    // Zapisanie pytań do pliku tekstowego
                    SaveQuestionsToFile(filePath);

                    // Odświeżenie DataGridView
                    RefreshDataGridView();
                    UpdateQuestionDeletingButtonState(); // Aktualizacja stanu przycisku usuwania pytań
                }
            }
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewQuestions.SelectedCells[0].RowIndex;
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewQuestions.Rows.Count)
                {
                    Question selectedQuestion = questions[selectedRowIndex];

                    // Usunięcie pytania z listy
                    questions.Remove(selectedQuestion);

                    // Zapisanie pytań do pliku tekstowego
                    SaveQuestionsToFile(filePath);

                    // Odświeżenie DataGridView
                    RefreshDataGridView();
                    UpdateQuestionDeletingButtonState(); // Aktualizacja stanu przycisku usuwania pytań
                }
            }
        }

        private void dataGridViewQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedRows.Count > 0)
            {
                // Pobranie wybranego wiersza
                DataGridViewRow selectedRow = dataGridViewQuestions.SelectedRows[0];

                // Pobranie indeksu wybranego wiersza
                int selectedRowIndex = selectedRow.Index;

                // Sprawdzenie czy indeks jest prawidłowy
                if (selectedRowIndex >= 0 && selectedRowIndex < questions.Count)
                {
                    Question selectedQuestion = questions[selectedRowIndex];

                    // Wypełnienie TextBoxów i zaznaczenie odpowiednich CheckBoxów na podstawie wybranego pytania
                    textBoxQuestion.Text = selectedQuestion.QuestionText;
                    for (int i = 0; i < 4; i++)
                    {
                        textBoxAnswers[i].Text = selectedQuestion.AnswerTexts[i];
                        checkBoxCorrectAnswers[i].Checked = selectedQuestion.CorrectAnswers[i];
                    }
                }
            }
        }

        private void SaveQuestionsToFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Nie wybrano pliku z pytaniami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Question question in questions)
                {
                    string questionText = question.QuestionText;
                    string[] answerTexts = question.AnswerTexts;
                    bool[] correctAnswers = question.CorrectAnswers;

                    string line = questionText;
                    for (int i = 0; i < 4; i++)
                    {
                        line += ";" + answerTexts[i];
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        line += ";" + (correctAnswers[i] ? "1" : "0");
                    }

                    writer.WriteLine(line);
                }
            }
        }

        private void LoadQuestions(string filePath)
        {
            LoadQuestionsFromFile(filePath);
        }

        private void LoadQuestions()
        {
            LoadQuestionsFromFile(filePath);
        }

        private void LoadQuestionsFromFile(string filePath)
        {
            questions = new List<Question>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 5)
                        {
                            string questionText = parts[0];
                            string[] answerTexts = new string[4];
                            bool[] correctAnswers = new bool[4];

                            for (int i = 0; i < 4; i++)
                            {
                                answerTexts[i] = parts[i + 1];
                                correctAnswers[i] = (parts[i + 1 + 4] == "1");
                            }

                            Question question = new Question(questionText, answerTexts, correctAnswers);
                            questions.Add(question);
                        }
                    }
                }
            }
        }

        private void RefreshDataGridView()
        {
            // Usunięcie istniejących kolumn
            dataGridViewQuestions.Columns.Clear();

            // Dodaj kolumny do DataGridView
            dataGridViewQuestions.Columns.Add("QuestionText", "Pytanie");

            for (int i = 0; i < 4; i++)
            {
                string answerColumnName = string.Format("Answer{0}", i + 1);
                dataGridViewQuestions.Columns.Add(answerColumnName, "Odpowiedź " + (i + 1));
            }

            // Dodaj kolumnę dla oznaczania poprawnych odpowiedzi
            dataGridViewQuestions.Columns.Add("Correct", "Poprawne");

            // Wyczyszczenie DataGridView
            dataGridViewQuestions.Rows.Clear();

            // Wczytanie pytań do DataGridView
            foreach (Question question in questions)
            {
                int rowIndex = dataGridViewQuestions.Rows.Add();
                dataGridViewQuestions.Rows[rowIndex].Cells[0].Value = question.QuestionText;

                for (int i = 0; i < 4; i++)
                {
                    dataGridViewQuestions.Rows[rowIndex].Cells[i + 1].Value = question.AnswerTexts[i];
                }

                // Ustawienie wartości poprawnych odpowiedzi w dodatkowej kolumnie
                dataGridViewQuestions.Rows[rowIndex].Cells[5].Value = GetCorrectAnswerIndices(question);
            }
        }

        private string GetCorrectAnswerIndices(Question question)
        {
            List<int> correctIndices = new List<int>();
            for (int i = 0; i < question.CorrectAnswers.Length; i++)
            {
                if (question.CorrectAnswers[i])
                {
                    correctIndices.Add(i + 1);
                }
            }
            return string.Join(", ", correctIndices);
        }

        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Zapisz plik z testem";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (!File.Exists(filePath))
                {
                    try
                    {
                        File.Create(filePath).Dispose();
                        MessageBox.Show("Plik z testem został utworzony.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas tworzenia pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Podany plik już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Usuń plik z testem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                        MessageBox.Show("Plik z testem został usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas usuwania pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Podany plik nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateQuestionDeletingButtonState()
        {
            if (questions.Count == 0)
            {
                DisableQuestionDeleting(); // Wyłącz przycisk usuwania pytań
            }
            else
            {
                EnableQuestionDeleting(); // Włącz przycisk usuwania pytań
            }
        }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public string[] AnswerTexts { get; set; }
        public bool[] CorrectAnswers { get; set; }

        public Question(string questionText, string[] answerTexts, bool[] correctAnswers)
        {
            QuestionText = questionText;
            AnswerTexts = answerTexts;
            CorrectAnswers = correctAnswers;
        }
    }
}
