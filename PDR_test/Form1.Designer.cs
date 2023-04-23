namespace PDR_test
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
            this.components = new System.ComponentModel.Container();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.TextBox();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.SystemColors.Control;
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Location = new System.Drawing.Point(155, 50);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(698, 350);
            this.pnlStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(297, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Розпочати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(108, 33);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(480, 29);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "ТЕСТУВАННЯ З ПРАВИЛ ДОРОЖНЬОГО РУХУ (ПДР)";
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(29, 13);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(135, 20);
            this.timer.TabIndex = 1;
            this.timer.Text = "00:00:00";
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 481);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.pnlStart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timer;
    }
}

