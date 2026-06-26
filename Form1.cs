using System.Linq;
namespace CyberSecurityBotGUI
{
    public partial class Form1 : Form
    {
        private List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

        private int currentQuestion = 0;
        private List<string> activityLog = new List<string>();


        private int score = 0;
        private ChatBot bot = new ChatBot();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadQuizQuestions()
        {
            quizQuestions.Add(new QuizQuestion
            {
                Question = "What should you do if you receive an email asking for your password?",
                OptionA = "Reply with your password",
                OptionB = "Delete the email",
                OptionC = "Report the email as phishing",
                OptionD = "Ignore it",
                CorrectAnswer = "C",
                Explanation = "Reporting phishing emails helps prevent scams."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: You should use the same password for every account.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Each account should have its own strong password."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What does 2FA stand for?",
                OptionA = "Two-Factor Authentication",
                OptionB = "Two File Access",
                OptionC = "Twice Fast Access",
                OptionD = "Two Form Approval",
                CorrectAnswer = "A",
                Explanation = "2FA adds an extra layer of security."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "Which password is the strongest?",
                OptionA = "password123",
                OptionB = "John2006",
                OptionC = "P@55w0rd!",
                OptionD = "123456",
                CorrectAnswer = "C",
                Explanation = "Strong passwords contain uppercase, lowercase, numbers and symbols."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: Public Wi-Fi is always safe.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Public Wi-Fi can expose your data if it's not secured."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What should you do if you receive a suspicious link?",
                OptionA = "Click it",
                OptionB = "Ignore it",
                OptionC = "Report it",
                OptionD = "Forward it",
                CorrectAnswer = "C",
                Explanation = "Reporting suspicious links helps prevent scams."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What is phishing?",
                OptionA = "A hacking technique using fake messages",
                OptionB = "A fishing game",
                OptionC = "A password manager",
                OptionD = "A firewall",
                CorrectAnswer = "A",
                Explanation = "Phishing tricks users into revealing personal information."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: Antivirus software should be updated regularly.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "A",
                Explanation = "Updates protect against the latest threats."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "Which of these helps protect your privacy online?",
                OptionA = "Sharing passwords",
                OptionB = "Using strong passwords",
                OptionC = "Ignoring software updates",
                OptionD = "Clicking every link",
                CorrectAnswer = "B",
                Explanation = "Strong passwords help secure your accounts."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: Software updates improve security.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "A",
                Explanation = "Updates often fix security vulnerabilities."
            });
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;
            ProcessUserInput(userInput);

            if (string.IsNullOrWhiteSpace(userInput))
            {
                lstChat.Items.Add("Bot: Please type a message before sending.");
                return;
            }

            lstChat.Items.Add("User: " + userInput);

            // 1. SENTIMENT (FIRST CHECK)
            string sentimentResponse = bot.HandleSentiment(userInput);
            if (sentimentResponse != null)
            {
                lstChat.Items.Add("Bot: " + sentimentResponse);

                // OPTIONAL: still give a tip after emotion
                string followUp = bot.GetKeywordResponse(userInput);
                if (followUp != null)
                {
                    lstChat.Items.Add("Bot: " + followUp);

                }

                txtInput.Clear();
                return;
            }

            // 2. NAME MEMORY
            string nameResponse = bot.HandleName(userInput);
            if (nameResponse != null)
            {
                lstChat.Items.Add("Bot: " + nameResponse);
                txtInput.Clear();
                return;
            }

            // 3. INTEREST MEMORY
            string interestResponse = bot.HandleInterest(userInput);
            if (interestResponse != null)
            {
                lstChat.Items.Add("Bot: " + interestResponse);
                txtInput.Clear();
                return;
            }

            // 4. FOLLOW-UP
            string followUpResponse = bot.DetectSentiment(userInput);
            if (followUpResponse != null)
            {
                lstChat.Items.Add("Bot: " + followUpResponse);
                txtInput.Clear();
                return;
            }

            // 5. KEYWORD RESPONSE
            string response = bot.GetKeywordResponse(userInput);

            if (response != null)
            {
                response = bot.Personalise(response);
                lstChat.Items.Add("Bot: " + response);
            }
            else
            {
                lstChat.Items.Add("Bot: I'm not sure I understand. Can you rephrase that?");
            }

            txtInput.Clear();
        }

        private void btnTestDB_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Database Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTask_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                db.AddTask(
                    txtTitle.Text,
                    txtDescription.Text,
                    dtpReminder.Value);

                MessageBox.Show(
                    "Task added successfully!");
                LogActivity("Task added: " + txtTitle.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewTassks_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            dgvTasks.DataSource = db.GetTasks();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int taskID = Convert.ToInt32(
                    dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

                DatabaseHelper db = new DatabaseHelper();

                db.DeleteTask(taskID);

                MessageBox.Show("Task deleted successfully!");
                LogActivity("Task deleted.");

                dgvTasks.DataSource = db.GetTasks();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int taskID = Convert.ToInt32(
                    dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

                DatabaseHelper db = new DatabaseHelper();

                db.CompleteTask(taskID);

                MessageBox.Show("Task marked as completed!");
                LogActivity("Task marked as completed.");

                dgvTasks.DataSource = db.GetTasks();
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }

        private void lblTable_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rbOptionB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            score = 0;

            LoadQuizQuestions();

            DisplayQuestion();
            LogActivity("Quiz started.");

        }

        private void DisplayQuestion()
        {
            QuizQuestion q = quizQuestions[currentQuestion];

            lblQuestion.Text = q.Question;

            rbOptionA.Text = "A. " + q.OptionA;
            rbOptionB.Text = "B. " + q.OptionB;
            rbOptionC.Text = "C. " + q.OptionC;
            rbOptionD.Text = "D. " + q.OptionD;

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";

            if (rbOptionA.Checked) selectedAnswer = "A";
            else if (rbOptionB.Checked) selectedAnswer = "B";
            else if (rbOptionC.Checked) selectedAnswer = "C";
            else if (rbOptionD.Checked) selectedAnswer = "D";

            if (selectedAnswer == "")
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            QuizQuestion q = quizQuestions[currentQuestion];

            if (selectedAnswer == q.CorrectAnswer)
            {
                score++;
                lblFeedback.Text = "✅ Correct! " + q.Explanation;
            }
            else
            {
                lblFeedback.Text = "❌ Incorrect! " + q.Explanation;
            }

            lblScore.Text = $"Score: {score}/{quizQuestions.Count}";

            currentQuestion++;

            if (currentQuestion < quizQuestions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show($"Quiz Finished!\nYour final score is {score}/{quizQuestions.Count}");

                if (score >= quizQuestions.Count * 0.8)
                {
                    MessageBox.Show("🎉 Great job! You're a cybersecurity pro!");
                }
                else
                {
                    MessageBox.Show("📚 Keep learning to stay safe online!");
                }
                LogActivity("Quiz completed. Final score: " + score + "/" + quizQuestions.Count);

            }
        }
        private void ProcessUserInput(string input)
        {
            input = input.ToLower();

            if (input.Contains("add task") ||
                input.Contains("create task") ||
                input.Contains("new task"))
            {
                MessageBox.Show("Please use the Task Assistant tab to add a new task.");
            }
            else if (input.Contains("quiz") ||
                     input.Contains("game") ||
                     input.Contains("test me"))
            {
                MessageBox.Show("Opening the Cybersecurity Quiz...");
            }
            else if (input.Contains("reminder") ||
                     input.Contains("remind me"))
            {
                MessageBox.Show("Please add your reminder in the Task Assistant.");
            }
            else if (input.Contains("activity log") ||
                     input.Contains("what have you done for me"))
            {
                MessageBox.Show("Opening Activity Log...");
            }
            else
            {
                MessageBox.Show("I didn't quite understand that. Could you rephrase?");
            }
        }
        private void LogActivity(string action)
        {
            activityLog.Add($"{DateTime.Now:HH:mm:ss} - {action}");
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            lstActivityLog.Items.Clear();

            foreach (string item in activityLog.TakeLast(10))
            {
                lstActivityLog.Items.Add(item);
            }
        }

    }
    }





