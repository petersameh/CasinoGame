namespace Casino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_back = new Button();
            btn_Next = new Button();
            btn_Start = new Button();
            picbox_Flags = new PictureBox();
            btn_Reset = new Button();
            btn_ShowAnswer = new Button();
            txtBox_Question = new TextBox();
            txtBox_Answer = new TextBox();
            lbl_QuestionTotal = new Label();
            txtBox_Player1 = new TextBox();
            txtBox_Player2 = new TextBox();
            txtBox_Player3 = new TextBox();
            lbl_Player1Score = new Label();
            lbl_Player2Score = new Label();
            lbl_Player3Score = new Label();
            btn_Player1Plus = new Button();
            btn_Player2Plus = new Button();
            btn_Player3Plus = new Button();
            btn_Player1Minus = new Button();
            btn_Player2Minus = new Button();
            btn_Player3Minus = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_Flags).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(246, 480);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(317, 23);
            btn_back.TabIndex = 0;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_Back_Click;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(246, 451);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(317, 23);
            btn_Next.TabIndex = 1;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(246, 422);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(317, 23);
            btn_Start.TabIndex = 3;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // picbox_Flags
            // 
            picbox_Flags.Location = new Point(145, 167);
            picbox_Flags.Name = "picbox_Flags";
            picbox_Flags.Size = new Size(510, 230);
            picbox_Flags.TabIndex = 6;
            picbox_Flags.TabStop = false;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(246, 509);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(317, 23);
            btn_Reset.TabIndex = 7;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_ShowAnswer
            // 
            btn_ShowAnswer.Location = new Point(12, 130);
            btn_ShowAnswer.Name = "btn_ShowAnswer";
            btn_ShowAnswer.Size = new Size(776, 23);
            btn_ShowAnswer.TabIndex = 8;
            btn_ShowAnswer.Text = "Show";
            btn_ShowAnswer.UseVisualStyleBackColor = true;
            btn_ShowAnswer.Click += btn_ShowAnswer_Click;
            // 
            // txtBox_Question
            // 
            txtBox_Question.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Question.Location = new Point(12, 33);
            txtBox_Question.Name = "txtBox_Question";
            txtBox_Question.ReadOnly = true;
            txtBox_Question.Size = new Size(776, 29);
            txtBox_Question.TabIndex = 9;
            txtBox_Question.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_Answer
            // 
            txtBox_Answer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Answer.Location = new Point(12, 85);
            txtBox_Answer.Name = "txtBox_Answer";
            txtBox_Answer.ReadOnly = true;
            txtBox_Answer.Size = new Size(776, 29);
            txtBox_Answer.TabIndex = 10;
            txtBox_Answer.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_QuestionTotal
            // 
            lbl_QuestionTotal.AutoSize = true;
            lbl_QuestionTotal.Location = new Point(358, 9);
            lbl_QuestionTotal.Name = "lbl_QuestionTotal";
            lbl_QuestionTotal.Size = new Size(64, 15);
            lbl_QuestionTotal.TabIndex = 11;
            lbl_QuestionTotal.Text = "Question 1";
            // 
            // txtBox_Player1
            // 
            txtBox_Player1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Player1.Location = new Point(35, 560);
            txtBox_Player1.Name = "txtBox_Player1";
            txtBox_Player1.Size = new Size(213, 29);
            txtBox_Player1.TabIndex = 12;
            txtBox_Player1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_Player2
            // 
            txtBox_Player2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Player2.Location = new Point(309, 560);
            txtBox_Player2.Name = "txtBox_Player2";
            txtBox_Player2.Size = new Size(213, 29);
            txtBox_Player2.TabIndex = 13;
            txtBox_Player2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_Player3
            // 
            txtBox_Player3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Player3.Location = new Point(575, 560);
            txtBox_Player3.Name = "txtBox_Player3";
            txtBox_Player3.Size = new Size(213, 29);
            txtBox_Player3.TabIndex = 14;
            txtBox_Player3.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Player1Score
            // 
            lbl_Player1Score.AutoSize = true;
            lbl_Player1Score.Location = new Point(111, 603);
            lbl_Player1Score.Name = "lbl_Player1Score";
            lbl_Player1Score.Size = new Size(38, 15);
            lbl_Player1Score.TabIndex = 15;
            lbl_Player1Score.Text = "label1";
            // 
            // lbl_Player2Score
            // 
            lbl_Player2Score.AutoSize = true;
            lbl_Player2Score.Location = new Point(400, 603);
            lbl_Player2Score.Name = "lbl_Player2Score";
            lbl_Player2Score.Size = new Size(38, 15);
            lbl_Player2Score.TabIndex = 16;
            lbl_Player2Score.Text = "label1";
            // 
            // lbl_Player3Score
            // 
            lbl_Player3Score.AutoSize = true;
            lbl_Player3Score.Location = new Point(665, 603);
            lbl_Player3Score.Name = "lbl_Player3Score";
            lbl_Player3Score.Size = new Size(38, 15);
            lbl_Player3Score.TabIndex = 17;
            lbl_Player3Score.Text = "label1";
            // 
            // btn_Player1Plus
            // 
            btn_Player1Plus.Location = new Point(220, 616);
            btn_Player1Plus.Name = "btn_Player1Plus";
            btn_Player1Plus.Size = new Size(28, 23);
            btn_Player1Plus.TabIndex = 18;
            btn_Player1Plus.Text = "+";
            btn_Player1Plus.UseVisualStyleBackColor = true;
            btn_Player1Plus.Click += btn_Player1Plus_Click;
            // 
            // btn_Player2Plus
            // 
            btn_Player2Plus.Location = new Point(494, 616);
            btn_Player2Plus.Name = "btn_Player2Plus";
            btn_Player2Plus.Size = new Size(28, 23);
            btn_Player2Plus.TabIndex = 19;
            btn_Player2Plus.Text = "+";
            btn_Player2Plus.UseVisualStyleBackColor = true;
            btn_Player2Plus.Click += btn_Player2Plus_Click;
            // 
            // btn_Player3Plus
            // 
            btn_Player3Plus.Location = new Point(760, 616);
            btn_Player3Plus.Name = "btn_Player3Plus";
            btn_Player3Plus.Size = new Size(28, 23);
            btn_Player3Plus.TabIndex = 20;
            btn_Player3Plus.Text = "+";
            btn_Player3Plus.UseVisualStyleBackColor = true;
            btn_Player3Plus.Click += btn_Player3Plus_Click;
            // 
            // btn_Player1Minus
            // 
            btn_Player1Minus.Location = new Point(35, 616);
            btn_Player1Minus.Name = "btn_Player1Minus";
            btn_Player1Minus.Size = new Size(28, 23);
            btn_Player1Minus.TabIndex = 21;
            btn_Player1Minus.Text = "-";
            btn_Player1Minus.UseVisualStyleBackColor = true;
            btn_Player1Minus.Click += btn_Player1Minus_Click;
            // 
            // btn_Player2Minus
            // 
            btn_Player2Minus.Location = new Point(309, 616);
            btn_Player2Minus.Name = "btn_Player2Minus";
            btn_Player2Minus.Size = new Size(28, 23);
            btn_Player2Minus.TabIndex = 22;
            btn_Player2Minus.Text = "-";
            btn_Player2Minus.UseVisualStyleBackColor = true;
            btn_Player2Minus.Click += btn_Player2Minus_Click;
            // 
            // btn_Player3Minus
            // 
            btn_Player3Minus.Location = new Point(575, 616);
            btn_Player3Minus.Name = "btn_Player3Minus";
            btn_Player3Minus.Size = new Size(28, 23);
            btn_Player3Minus.TabIndex = 23;
            btn_Player3Minus.Text = "-";
            btn_Player3Minus.UseVisualStyleBackColor = true;
            btn_Player3Minus.Click += btn_Player3Minus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 651);
            Controls.Add(btn_Player3Minus);
            Controls.Add(btn_Player2Minus);
            Controls.Add(btn_Player1Minus);
            Controls.Add(btn_Player3Plus);
            Controls.Add(btn_Player2Plus);
            Controls.Add(btn_Player1Plus);
            Controls.Add(lbl_Player3Score);
            Controls.Add(lbl_Player2Score);
            Controls.Add(lbl_Player1Score);
            Controls.Add(txtBox_Player3);
            Controls.Add(txtBox_Player2);
            Controls.Add(txtBox_Player1);
            Controls.Add(lbl_QuestionTotal);
            Controls.Add(txtBox_Answer);
            Controls.Add(txtBox_Question);
            Controls.Add(btn_ShowAnswer);
            Controls.Add(btn_Reset);
            Controls.Add(picbox_Flags);
            Controls.Add(btn_Start);
            Controls.Add(btn_Next);
            Controls.Add(btn_back);
            Name = "Form1";
            Text = "Casino";
            ((System.ComponentModel.ISupportInitialize)picbox_Flags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_Next;
        private Button btn_Start;
        private PictureBox picbox_Flags;
        private Button btn_Reset;
        private Button btn_ShowAnswer;
        private TextBox txtBox_Question;
        private TextBox txtBox_Answer;
        private Label lbl_QuestionTotal;
        private TextBox txtBox_Player1;
        private TextBox txtBox_Player2;
        private TextBox txtBox_Player3;
        private Label lbl_Player1Score;
        private Label lbl_Player2Score;
        private Label lbl_Player3Score;
        private Button btn_Player1Plus;
        private Button btn_Player2Plus;
        private Button btn_Player3Plus;
        private Button btn_Player1Minus;
        private Button btn_Player2Minus;
        private Button btn_Player3Minus;
    }
}
