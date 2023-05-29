using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDR_test
{
    public partial class Form1 : Form
    {
//creating variables

        int question_count;
        int correct_answers;
        int wrong_answers;
//vars for questiong count, correct and wrong answers

        string[] array;
//array with questions amount

        int correct_answers_number;
        int selected_response;
//vars for radiobutton

        bool results_shown = false;
//bools for showing if test ended

        int grade = 0;
//var with grade

        System.IO.StreamReader Read;
//var for reading questions

//initialization of form and timer
        public Form1()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Tick += new EventHandler(timertick);
            tm.Interval = 1000;
        }
        
//vars for timer
        Timer tm = null;
        int startValue = 0;

        int numericUpDownHour = 0;
        int numericUpDownMin = 20;
        int numericUpDownSec = 0;

//convert time to text
        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
        

//function for timer
        void timertick(object sender, EventArgs e)
        {
            if (startValue != 0)
            {
                timer.Text = Int2StringTime(startValue);
                startValue--;
            } //timer works while startValue isn't zero
            else if (results_shown == false)
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                DialogResult time_end;
                time_end = MessageBox.Show("Ви вичерпали весь свій час", "Час вичерпано!", MessageBoxButtons.OK);
                if (time_end == DialogResult.OK)
                {
                    results();
                }
            } //if time has ended, user get message and results
            else if (results_shown == true)
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
            } //if test has ended timer stops


        }

//start of test
        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001); //encoding for cyrillic symbols
            try
            {
                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\questions.txt", Encoding);
                this.Text = Read.ReadLine();
                //app reads text from text file, placed in same directory with executable file

                question_count = 0;
                correct_answers = 0;
                wrong_answers = 0;
                //set values of variables

                array = new String[21]; 
                //size of test (questions)
            }
            catch (Exception)
            {  
                MessageBox.Show("Помилка в зчитуванні файлу!");
            } //exception in cause of troubles with text file
            question();

        }

//function for questions
        void question()
        {
            lblQuestion.Text = Read.ReadLine();
          
            rdbtnAnswer_1.Text = Read.ReadLine();
            rdbtnAnswer_2.Text = Read.ReadLine();
            rdbtnAnswer_3.Text = Read.ReadLine();
          
            correct_answers_number = int.Parse(Read.ReadLine());
            //read of question text, answers and right answer

            rdbtnAnswer_1.Checked = false;
            rdbtnAnswer_2.Checked = false;
            rdbtnAnswer_3.Checked = false;
            //answer isn't selected by default
       
            btnNext.Enabled = false; 
            //if answer isn't picked user can't go further

            question_count += 1;
            //var gets bigger with every question
          
            if (Read.EndOfStream == true) btnNext.Text = "Завершити";
            //when text file comes to end user can finish test

            switch(question_count)//images for some questions
            {
                case 5:
                    Image img_q5 = Image.FromFile(@"img\" + "q5.jpg");
                    pctrbox_question.Image = img_q5;//app search for right image by path and uses it when needed to
                    break;
                case 8:
                    Image img_q8 = Image.FromFile(@"img\" + "q8.jpg");
                    pctrbox_question.Image = img_q8;
                    break;
                case 11:
                    Image img_q11 = Image.FromFile(@"img\" + "q11.jpg");
                    pctrbox_question.Image = img_q11;
                    break;
                case 14:
                    Image img_q14 = Image.FromFile(@"img\" + "q14.jpg");
                    pctrbox_question.Image = img_q14;
                    break;
                case 17:
                    Image img_q17 = Image.FromFile(@"img\" + "q17.jpg");
                    pctrbox_question.Image = img_q17;
                    break;
                case 19:
                    Image img_q19 = Image.FromFile(@"img\" + "q19.jpg");
                    pctrbox_question.Image = img_q19;
                    break;
                default:
                    pctrbox_question.Image = null;
                    break;//if question doesn't have image picturebox is empty
            };

            
        }

//function for radiobutton check
        void checkstatus(object sender, EventArgs e)
        {
            btnNext.Enabled = true; //if answer is picked, user can continue test
            RadioButton toggle = (RadioButton)sender;
            var tmp = toggle.Name;
            //radiobutton check

            selected_response = int.Parse(tmp.Substring(12));
            //reading of right answer
        }

//function for results
        void results()
        {

            grade += (correct_answers * 5); //grade count
            Read.Close(); //reading ends
            results_shown = true; //bool states that test has ended

            pnlTimer.Visible = false;
            pnlAnswers.Visible = false;
            pctrbox_question.Visible = false;
            //timer and main test section is hidden

            if (results_shown == true)
            {
                btnStart.Text = "Почати спочатку";
                btnStart.Visible = true;
            }//user can restart test with start button 

            lblQuestion.Location = new Point(440, 63);//question text label gets to center

            
            if (correct_answers >= 18)
            {
                lblQuestion.Text = String.Format("Тестування завершено.\n" +
                        "Правильних відповідей: " + correct_answers + " з 20.\n" +
                        "Набрані бали: " + grade + " %.\n\n" +
                        "Вітаємо! Ви склали тест!");
            }//text in case of passing test

            else
            {
                lblQuestion.Text = String.Format("Тестування завершено.\n" +
                    "Правильних відповідей: " + correct_answers + " з 20.\n" +
                    "Набрані бали: " + grade + " %\n\n" +
                    "Ви не склали тест. ");
            }//text in case of simple end of test
            pnlButtons.Visible = false;
            //buttons for test are hidden

            var Str = "Список неправильних відповідей на питання " +
                      ":\n\n";
            for (int i = 1; i <= wrong_answers; i++)
            {
                Str = Str + array[i] + "\n";
            }
            //record of question, which were answered incorrect

            if (wrong_answers == 20) MessageBox.Show("Ви не дали правильну відповідь на жодне з питань.", "Провалено"); //calling messagebox in case of zero correct answers

            else if (wrong_answers != 0 && wrong_answers != 20) MessageBox.Show(Str, "Тестування завершено."); //calling messagebox with incorrectly answered questions

            else if (correct_answers == 20) MessageBox.Show("Ви правильно відповіли на всі питання!", "Відмінний результат!"); //calling messagebox in case of zero wrong answers

            if (question_count == 1) MessageBox.Show("Ви не відповіли на жодне з питань.", "Провалено"); //calling messagebox in case of ending test prematurely


        }

//button to get next question
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number) correct_answers = correct_answers + 1;//grade getting bigger in case of correct answer

            if (selected_response != correct_answers_number)
            {
                wrong_answers = wrong_answers + 1;
                
                array[wrong_answers] = lblQuestion.Text;
            }//in case of answering incorrectly amount of wrong answers gets bigger and recorded in array
            if (btnNext.Text == "Завершити") results();//in case of answering last question user can end the test
            if (btnNext.Text == "Наступне питання") question();//user gets to next question

        }

//button to end the test prematurely
        private void btnEnd_Click(object sender, EventArgs e)
        {
            results();
        }//user gets results


        private void Form1_Load(object sender, EventArgs e)
        {
            btnNext.Text = "Наступне питання";
            btnEnd.Text = "Завершити достроково";
            btnStart.Text = "Почати тестування";

            rdbtnAnswer_1.CheckedChanged += new EventHandler(checkstatus);
            rdbtnAnswer_2.CheckedChanged += new EventHandler(checkstatus);
            rdbtnAnswer_3.CheckedChanged += new EventHandler(checkstatus);
        }//when form loads buttons get their text and radiobuttons tied with their check buttons

//button to start test
        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult start_test;//messagebox with test info
            start_test = MessageBox.Show("Тест складається з 20 питань з загальних положень правил дорожнього руху. У вас є двадцять хвилин на те, щоб відповісти на всі питання.\n\nПід варіантами відповідей будуть дві кнопки: ліва кнопка відповідає за перехід до наступного питання, а права дозволяє завершити тест достроково.\n\nЩоб скласти тест, необхідно щонайменше 90 відсотків правильних відповідей.", "Початок", MessageBoxButtons.OK);
            if (start_test == DialogResult.OK)
            {            
                lblStart.Visible = false;
                pnlTest.Visible = true;
                pnlAnswers.Visible = true;
                pnlTimer.Visible = true;
                pnlButtons.Visible = true;
                startValue = 60 * 60 * (int)numericUpDownHour + 60 * (int)numericUpDownMin + (int)numericUpDownSec;
                tm.Start();
                btnStart.Visible = false;
                start();
            }//test and timer starts

            if (btnStart.Text == "Почати спочатку")
            {
                lblQuestion.Location = new Point(30, 18);
                pctrbox_question.Visible = true;
                pnlButtons.Visible = true;
                btnNext.Text = "Наступне питання";
                pnlAnswers.Visible = true;
                btnEnd.Enabled = true;
                grade = 0;
                correct_answers = 0;
                wrong_answers = 0;
                results_shown = false;
            }//start the test again

        }

//button to exit app
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//app closed after pressing button
    }
}
