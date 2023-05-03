namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.pnlTest.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(60, 8);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(900, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(96, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Питання";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(238, 313);
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
            this.btnStart.Location = new System.Drawing.Point(223, 492);
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
            this.btnExit.Location = new System.Drawing.Point(669, 492);
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
            this.btnEnd.Location = new System.Drawing.Point(638, 313);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(184, 56);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Завершити тестування";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // rdbtnAnswer_2
            // 
            this.rdbtnAnswer_2.AutoSize = true;
            this.rdbtnAnswer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnAnswer_2.Location = new System.Drawing.Point(3, 61);
            this.rdbtnAnswer_2.Name = "rdbtnAnswer_2";
            this.rdbtnAnswer_2.Size = new System.Drawing.Size(111, 28);
            this.rdbtnAnswer_2.TabIndex = 2;
            this.rdbtnAnswer_2.TabStop = true;
            this.rdbtnAnswer_2.Text = "Варіант 2";
            this.rdbtnAnswer_2.UseVisualStyleBackColor = true;
            // 
            // rdbtnAnswer_3
            // 
            this.rdbtnAnswer_3.AutoSize = true;
            this.rdbtnAnswer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnAnswer_3.Location = new System.Drawing.Point(3, 119);
            this.rdbtnAnswer_3.Name = "rdbtnAnswer_3";
            this.rdbtnAnswer_3.Size = new System.Drawing.Size(111, 28);
            this.rdbtnAnswer_3.TabIndex = 3;
            this.rdbtnAnswer_3.TabStop = true;
            this.rdbtnAnswer_3.Text = "Варіант 3";
            this.rdbtnAnswer_3.UseVisualStyleBackColor = true;
            // 
            // rdbtnAnswer_1
            // 
            this.rdbtnAnswer_1.AutoSize = true;
            this.rdbtnAnswer_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnAnswer_1.Location = new System.Drawing.Point(3, 3);
            this.rdbtnAnswer_1.Name = "rdbtnAnswer_1";
            this.rdbtnAnswer_1.Size = new System.Drawing.Size(111, 28);
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
            this.pnlTest.Controls.Add(this.btnEnd);
            this.pnlTest.Controls.Add(this.btnNext);
            this.pnlTest.Location = new System.Drawing.Point(12, 93);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(1055, 378);
            this.pnlTest.TabIndex = 7;
            this.pnlTest.Visible = false;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_1);
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_3);
            this.pnlAnswers.Controls.Add(this.rdbtnAnswer_2);
            this.pnlAnswers.Location = new System.Drawing.Point(15, 112);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(1037, 150);
            this.pnlAnswers.TabIndex = 6;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.label1);
            this.pnlTimer.Controls.Add(this.timer);
            this.pnlTimer.Location = new System.Drawing.Point(841, 12);
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
            this.lblStart.Location = new System.Drawing.Point(268, 23);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(566, 31);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Тестування з правил дорожнього руху (ПДР)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 554);
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
            this.pnlAnswers.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
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
    }
}

