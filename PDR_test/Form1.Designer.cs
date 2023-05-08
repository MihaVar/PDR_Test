namespace PDR_test
{
    partial class Form1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.rdbtnAnswer_2 = new System.Windows.Forms.RadioButton();
            this.rdbtnAnswer_3 = new System.Windows.Forms.RadioButton();
            this.rdbtnAnswer_1 = new System.Windows.Forms.RadioButton();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pctrbox_question = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlTest.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbox_question)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblQuestion.Location = new System.Drawing.Point(30, 18);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Питання";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(119, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(178, 57);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Наступне питання";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.timer.Location = new System.Drawing.Point(137, 8);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(95, 23);
            this.timer.TabIndex = 6;
            this.timer.Text = "00:00:00";
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnStart.Location = new System.Drawing.Point(247, 492);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 50);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Розпочати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnExit.Location = new System.Drawing.Point(847, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnd.Location = new System.Drawing.Point(519, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(184, 56);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Завершити тестування";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // rdbtnAnswer_2
            // 
            this.rdbtnAnswer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdbtnAnswer_2.Location = new System.Drawing.Point(2, 78);
            this.rdbtnAnswer_2.Name = "rdbtnAnswer_2";
            this.rdbtnAnswer_2.Size = new System.Drawing.Size(794, 75);
            this.rdbtnAnswer_2.TabIndex = 2;
            this.rdbtnAnswer_2.TabStop = true;
            this.rdbtnAnswer_2.Text = "Варіант 2";
            this.rdbtnAnswer_2.UseVisualStyleBackColor = true;
            // 
            // rdbtnAnswer_3
            // 
            this.rdbtnAnswer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdbtnAnswer_3.Location = new System.Drawing.Point(2, 153);
            this.rdbtnAnswer_3.Name = "rdbtnAnswer_3";
            this.rdbtnAnswer_3.Size = new System.Drawing.Size(794, 75);
            this.rdbtnAnswer_3.TabIndex = 3;
            this.rdbtnAnswer_3.TabStop = true;
            this.rdbtnAnswer_3.Text = "Варіант 3";
            this.rdbtnAnswer_3.UseVisualStyleBackColor = true;
            // 
            // rdbtnAnswer_1
            // 
            this.rdbtnAnswer_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdbtnAnswer_1.Location = new System.Drawing.Point(3, 3);
            this.rdbtnAnswer_1.Name = "rdbtnAnswer_1";
            this.rdbtnAnswer_1.Size = new System.Drawing.Size(794, 75);
            this.rdbtnAnswer_1.TabIndex = 1;
            this.rdbtnAnswer_1.TabStop = true;
            this.rdbtnAnswer_1.Text = "Варіант 1";
            this.rdbtnAnswer_1.UseVisualStyleBackColor = true;
            // 
            // pnlTest
            // 
            this.pnlTest.AllowDrop = true;
            this.pnlTest.Controls.Add(this.pnlAnswers);
            this.pnlTest.Controls.Add(this.lblQuestion);
            this.pnlTest.Location = new System.Drawing.Point(12, 57);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(817, 347);
            this.pnlTest.TabIndex = 7;
            this.pnlTest.Visible = false;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_1);
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_3);
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_2);
            this.pnlAnswers.Location = new System.Drawing.Point(15, 114);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(799, 230);
            this.pnlAnswers.TabIndex = 6;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.label1);
            this.pnlTimer.Controls.Add(this.timer);
            this.pnlTimer.Location = new System.Drawing.Point(1031, 12);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(235, 39);
            this.pnlTimer.TabIndex = 7;
            this.pnlTimer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Час на виконання:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblStart.Location = new System.Drawing.Point(356, 13);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(566, 31);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Тестування з правил дорожнього руху (ПДР)";
            // 
            // pctrbox_question
            // 
            this.pctrbox_question.Location = new System.Drawing.Point(847, 171);
            this.pctrbox_question.Name = "pctrbox_question";
            this.pctrbox_question.Size = new System.Drawing.Size(416, 233);
            this.pctrbox_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbox_question.TabIndex = 7;
            this.pctrbox_question.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnEnd);
            this.pnlButtons.Location = new System.Drawing.Point(12, 410);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(817, 67);
            this.pnlButtons.TabIndex = 11;
            this.pnlButtons.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 554);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pctrbox_question);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlTest);
            this.Name = "Form1";
            this.Text = "Тестування з ПДР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            this.pnlAnswers.ResumeLayout(false);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbox_question)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.RadioButton rdbtnAnswer_2;
        private System.Windows.Forms.RadioButton rdbtnAnswer_3;
        private System.Windows.Forms.RadioButton rdbtnAnswer_1;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pctrbox_question;
        private System.Windows.Forms.Panel pnlButtons;
    }
}

