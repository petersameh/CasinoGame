namespace Casino
{
    public partial class Form1 : Form
    {
        public static List<Question> Questions { get; set; }
        public static Stack<Question> QuestionsHistory { get; set; } = new Stack<Question>();
        public static int NextQuestionNumber { get; set; }
        public static int CurrentQuestionNumber { get; set; }
        public static int Player1Score { get; set; }
        public static int Player2Score { get; set; }
        public static int Player3Score { get; set; }
        public static int TurnNumber { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            Questions = ExcelHelper.ReadResource("Resources/GameQuestions.xlsx");
            Questions = Extensions.Shuffle(Questions);
            btn_Next_Click(sender, e);
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Questions.Count == NextQuestionNumber)
            {
                MessageBox.Show("We ran out of questions");
            }
            else
            {
                TurnNumber++;
                ProceedTurn(Questions[NextQuestionNumber]);
                NextQuestionNumber++;
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (NextQuestionNumber > 1)
            {

                NextQuestionNumber--;
                var question = QuestionsHistory.Pop();
                TurnNumber--;
                ProceedTurn(question);
            }
            else
                MessageBox.Show("No history yet");
        }

        private void ProceedTurn(Question question)
        {
            SetDefaultScores();

            HideAnswerButton();
            PrintQuestionsProgress();
            PrintQuestion(question.QuestionText);
            ShowImageBox(question);
            PrintAnswer(question);

            AddHistory();
            CurrentQuestionNumber = NextQuestionNumber == 0? 0 : NextQuestionNumber - 1;
        }

        private void PrintAnswer(Question question)
        {
            if (question.Answer != "null")
            {
                txtBox_Answer.Text = question.Answer;
            }
            else
                txtBox_Answer.Text = "";
        }

        private void ShowImageBox(Question question)
        {
            if (question.Type == "Flags" || question.Type == "SongInScene")
            {
                Image i = Image.FromFile(question.SourceFile);
                picbox_Flags.Image = i;
                picbox_Flags.Show();
            }
            else
                picbox_Flags.Hide();
        }

        private static void AddHistory()
        {
            if (NextQuestionNumber > 0)
                QuestionsHistory.Push(Questions[CurrentQuestionNumber]);
        }

        private void CheckWinnerEveryTurn()
        {
            if (Player1Score == 10)
            {
                MessageBox.Show($"{txtBox_Player1.Text} is the Winner!");
            }
            else if (Player2Score == 10)
            {
                MessageBox.Show($"{txtBox_Player2.Text} is the Winner!");
            }
            else if (Player3Score == 10)
            {
                MessageBox.Show($"{txtBox_Player3.Text} is the Winner!");
            }
        }

        private void PrintQuestion(string questionText)
        {
            txtBox_Question.Text = questionText;
        }

        private void PrintQuestionsProgress()
        {
            lbl_QuestionTotal.Text = $"{TurnNumber} out of {Questions.Count.ToString()}";
        }

        private void SetDefaultScores()
        {
            lbl_Player1Score.Text = Player1Score.ToString();
            lbl_Player2Score.Text = Player2Score.ToString();
            lbl_Player3Score.Text = Player3Score.ToString();
        }

        private void btn_ShowAnswer_Click(object sender, EventArgs e)
        {
            ToggleShowAnswerButton();

        }

        private void ToggleShowAnswerButton()
        {
            if (txtBox_Answer.Visible)
            {
                txtBox_Answer.Hide();
                btn_ShowAnswer.Text = "Show";
            }
            else
            {
                txtBox_Answer.Show();
                btn_ShowAnswer.Text = "Hide";
            }
        }
        private void HideAnswerButton()
        {
            if (txtBox_Answer.Visible)
            {
                txtBox_Answer.Hide();
                btn_ShowAnswer.Text = "Show";
            }
        }

        private void btn_HideAnswer_Click(object sender, EventArgs e)
        {
            txtBox_Answer.Hide();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            btn_ShowAnswer.Hide();
            picbox_Flags.Hide();
            txtBox_Question.Clear();
            txtBox_Answer.Clear();
            Questions = new List<Question>();
            NextQuestionNumber = 0;

            Player1Score = 0;
            Player2Score = 0;
            Player3Score = 0;

            lbl_Player1Score.Text = "";
            lbl_Player2Score.Text = "";
            lbl_Player3Score.Text = "";
        }

        private void btn_Player1Plus_Click(object sender, EventArgs e)
        {
            Player1Score++;
            PrintScorePlayer1();
            CheckWinnerEveryTurn();


        }

        private void PrintScorePlayer1()
        {
            lbl_Player1Score.Text = Player1Score.ToString();
        }
        private void PrintScorePlayer2()
        {
            lbl_Player2Score.Text = Player2Score.ToString();
        }
        private void PrintScorePlayer3()
        {
            lbl_Player3Score.Text = Player3Score.ToString();
        }

        private void btn_Player1Minus_Click(object sender, EventArgs e)
        {
            Player1Score--;
            PrintScorePlayer1();
        }

        private void btn_Player2Plus_Click(object sender, EventArgs e)
        {
            Player2Score++;
            PrintScorePlayer2();
            CheckWinnerEveryTurn();

        }

        private void btn_Player2Minus_Click(object sender, EventArgs e)
        {
            Player2Score--;
            PrintScorePlayer2();
        }

        private void btn_Player3Plus_Click(object sender, EventArgs e)
        {
            Player3Score++;
            PrintScorePlayer3();
            CheckWinnerEveryTurn();

        }

        private void btn_Player3Minus_Click(object sender, EventArgs e)
        {
            Player3Score--;
            PrintScorePlayer3();
        }
    }
}
