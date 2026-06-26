namespace CyberSecurityBotGUI
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
            lblTable = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            lstChat = new ListBox();
            btnTestDB = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            dtpReminder = new DateTimePicker();
            btnAddTask = new Button();
            dgvTasks = new DataGridView();
            btnViewTassks = new Button();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            lblFeedback = new Label();
            lblScore = new Label();
            btnSubmitAnswer = new Button();
            btnStartQuiz = new Button();
            rbOptionD = new RadioButton();
            rbOptionC = new RadioButton();
            rbOptionB = new RadioButton();
            rbOptionA = new RadioButton();
            lblQuestion = new Label();
            tabPage4 = new TabPage();
            btnShowLog = new Button();
            lstActivityLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTable.ForeColor = Color.Cyan;
            lblTable.Location = new Point(250, 74);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(348, 46);
            lblTable.TabIndex = 0;
            lblTable.Text = "CyberSecurityBot";
            lblTable.Click += lblTable_Click_1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(18, 419);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(729, 31);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(753, 416);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lstChat
            // 
            lstChat.BackColor = Color.Black;
            lstChat.ForeColor = Color.Lime;
            lstChat.FormattingEnabled = true;
            lstChat.ItemHeight = 25;
            lstChat.Location = new Point(18, 134);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(992, 279);
            lstChat.TabIndex = 4;
            // 
            // btnTestDB
            // 
            btnTestDB.Location = new Point(721, 387);
            btnTestDB.Name = "btnTestDB";
            btnTestDB.Size = new Size(112, 34);
            btnTestDB.TabIndex = 5;
            btnTestDB.Text = "Test Database";
            btnTestDB.UseVisualStyleBackColor = true;
            btnTestDB.Click += btnTestDB_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(27, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(27, 96);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 7;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(27, 157);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(300, 31);
            dtpReminder.TabIndex = 8;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(27, 216);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 9;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(27, 437);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.Size = new Size(806, 182);
            dgvTasks.TabIndex = 10;
            // 
            // btnViewTassks
            // 
            btnViewTassks.Location = new Point(27, 276);
            btnViewTassks.Name = "btnViewTassks";
            btnViewTassks.Size = new Size(112, 34);
            btnViewTassks.TabIndex = 11;
            btnViewTassks.Text = "View Tasks";
            btnViewTassks.UseVisualStyleBackColor = true;
            btnViewTassks.Click += btnViewTassks_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(27, 333);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(112, 34);
            btnDeleteTask.TabIndex = 12;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(27, 387);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(112, 34);
            btnCompleteTask.TabIndex = 13;
            btnCompleteTask.Text = "Mark Completed";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(123, 129);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(876, 771);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTable);
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(lstChat);
            tabPage1.Controls.Add(txtInput);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 733);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(txtTitle);
            tabPage2.Controls.Add(dgvTasks);
            tabPage2.Controls.Add(btnViewTassks);
            tabPage2.Controls.Add(btnTestDB);
            tabPage2.Controls.Add(btnDeleteTask);
            tabPage2.Controls.Add(btnCompleteTask);
            tabPage2.Controls.Add(txtDescription);
            tabPage2.Controls.Add(dtpReminder);
            tabPage2.Controls.Add(btnAddTask);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 733);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.PapayaWhip;
            tabPage3.Controls.Add(lblFeedback);
            tabPage3.Controls.Add(lblScore);
            tabPage3.Controls.Add(btnSubmitAnswer);
            tabPage3.Controls.Add(btnStartQuiz);
            tabPage3.Controls.Add(rbOptionD);
            tabPage3.Controls.Add(rbOptionC);
            tabPage3.Controls.Add(rbOptionB);
            tabPage3.Controls.Add(rbOptionA);
            tabPage3.Controls.Add(lblQuestion);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(868, 733);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(74, 510);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(87, 25);
            lblFeedback.TabIndex = 8;
            lblFeedback.Text = "Feedback";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(73, 457);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(102, 25);
            lblScore.TabIndex = 7;
            lblScore.Text = "Score: 0/10";
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Location = new Point(188, 376);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(112, 34);
            btnSubmitAnswer.TabIndex = 6;
            btnSubmitAnswer.Text = "Submit Answer";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(70, 376);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(112, 34);
            btnStartQuiz.TabIndex = 5;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // rbOptionD
            // 
            rbOptionD.AutoSize = true;
            rbOptionD.Location = new Point(74, 289);
            rbOptionD.Name = "rbOptionD";
            rbOptionD.Size = new Size(111, 29);
            rbOptionD.TabIndex = 4;
            rbOptionD.TabStop = true;
            rbOptionD.Text = "Option D";
            rbOptionD.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            rbOptionC.AutoSize = true;
            rbOptionC.Location = new Point(73, 241);
            rbOptionC.Name = "rbOptionC";
            rbOptionC.Size = new Size(109, 29);
            rbOptionC.TabIndex = 3;
            rbOptionC.TabStop = true;
            rbOptionC.Text = "Option C";
            rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            rbOptionB.AutoSize = true;
            rbOptionB.Location = new Point(74, 194);
            rbOptionB.Name = "rbOptionB";
            rbOptionB.Size = new Size(108, 29);
            rbOptionB.TabIndex = 2;
            rbOptionB.TabStop = true;
            rbOptionB.Text = "Option B";
            rbOptionB.UseVisualStyleBackColor = true;
            rbOptionB.CheckedChanged += rbOptionB_CheckedChanged;
            // 
            // rbOptionA
            // 
            rbOptionA.AutoSize = true;
            rbOptionA.Location = new Point(74, 147);
            rbOptionA.Name = "rbOptionA";
            rbOptionA.Size = new Size(110, 29);
            rbOptionA.TabIndex = 1;
            rbOptionA.TabStop = true;
            rbOptionA.Text = "Option A";
            rbOptionA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(74, 40);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(213, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question will appear here";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnShowLog);
            tabPage4.Controls.Add(lstActivityLog);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(868, 733);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnShowLog
            // 
            btnShowLog.Location = new Point(31, 177);
            btnShowLog.Name = "btnShowLog";
            btnShowLog.Size = new Size(112, 34);
            btnShowLog.TabIndex = 1;
            btnShowLog.Text = "Show Activity Log";
            btnShowLog.UseVisualStyleBackColor = true;
            btnShowLog.Click += btnShowLog_Click;
            // 
            // lstActivityLog
            // 
            lstActivityLog.FormattingEnabled = true;
            lstActivityLog.ItemHeight = 25;
            lstActivityLog.Location = new Point(31, 42);
            lstActivityLog.Name = "lstActivityLog";
            lstActivityLog.Size = new Size(764, 129);
            lstActivityLog.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1050, 850);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "CyberSecurityBot";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTable;
        private TextBox txtInput;
        private Button btnSend;
        private ListBox lstChat;
        private Button btnTestDB;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dtpReminder;
        private Button btnAddTask;
        private DataGridView dgvTasks;
        private Button btnViewTassks;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RadioButton rbOptionC;
        private RadioButton rbOptionB;
        private RadioButton rbOptionA;
        private Label lblQuestion;
        private TabPage tabPage4;
        private Label lblScore;
        private Button btnSubmitAnswer;
        private Button btnStartQuiz;
        private RadioButton rbOptionD;
        private Label lblFeedback;
        private Button btnShowLog;
        private ListBox lstActivityLog;
    }
}
