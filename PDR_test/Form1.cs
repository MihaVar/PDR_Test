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
//ініціалізація змінних

        int question_count;
        int correct_answers;
        int wrong_answers;
//змінні з кількістю питань, правильними та неправильними відповідями

        string[] array;
//змінна з кількістю питань

        int correct_answers_number;
        int selected_response;
//змінні для роботи з radiobutton

        private bool results_shown = false;
//змінна для визначення чи тест завершено

        int grade = 0;
//змінна з оцінкою

        System.IO.StreamReader Read;
//змінна для зчитування питань

//запуск форми, ініціалізація таймера
        public Form1()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Tick += new EventHandler(timertick);
            tm.Interval = 1000;
        }
        
//змінні для таймера
        Timer tm = null;
        int startValue = 0;

        int numericUpDownHour = 0;
        int numericUpDownMin = 30;
        int numericUpDownSec = 0;

//конвертація часу в текст
        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
        

//функція для роботи таймера 
        void timertick(object sender, EventArgs e)
        {
            if (startValue != 0)
            {
                timer.Text = Int2StringTime(startValue);
                startValue--;
            } //таймер працює, поки startValue не дорівнює нулю
            else if (results_shown == true)
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
            } //якщо тест був завершений, таймер зупиняється
            else 
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                DialogResult time_end;
                time_end = MessageBox.Show("Ви вичерпали весь свій час", "Час вичерпано!", MessageBoxButtons.OK);
                if (time_end == DialogResult.OK)
                {
                    results();
                } 
            } //якщо час було вичерпано користувачу виводить messagebox, а після нього результати

        }

//запуск тесту
        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001); //вивід кириличних символів
            try
            {
                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\questions.txt", Encoding);
                this.Text = Read.ReadLine();
                //програма зчитує текст, потрібний для тесту, з текстового файлу, розташованого в одній директорії з виконавчим файлом

                question_count = 0;
                correct_answers = 0;
                wrong_answers = 0;
                //виставлення значення змінних

                array = new String[21]; 
                //розмір тесту (питання)
            }
            catch (Exception)
            {  
                MessageBox.Show("Помилка в зчитуванні файлу!");
            } //виключення, якщо з файлом будуть проблеми
            question();

        }

//функція для питань
        void question()
        {
            lblQuestion.Text = Read.ReadLine();
          
            rdbtnAnswer_1.Text = Read.ReadLine();
            rdbtnAnswer_2.Text = Read.ReadLine();
            rdbtnAnswer_3.Text = Read.ReadLine();
          
            correct_answers_number = int.Parse(Read.ReadLine());
            //зчитування тексту питання, варіантів відповідей та правильної відповіді з файлу

            rdbtnAnswer_1.Checked = false;
            rdbtnAnswer_2.Checked = false;
            rdbtnAnswer_3.Checked = false;
            //варіанти відповідей не об
       
            btnNext.Enabled = false; 
            //якщо відповідь не буде обрана, продовжити тест не можна

            question_count += 1;
            //з кожним питанням змінна збільшується
          
            if (Read.EndOfStream == true) btnNext.Text = "Завершити";
            //коли файл дійшов кінця, кнопка при натисканні завершить тест

            switch(question_count)//вивід зображень для деяких питань
            {
                case 5:
                    Image img_q5 = Image.FromFile(@"img\" + "q5.jpg");
                    pctrbox_question.Image = img_q5;//програма шукає зображення по зазначеному шляху й змінює зображення
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
                    break;//якщо питання не передбачає зображення, в picturebox зображення немає
            };

            
        }

//функція для перевірки radiobutton
        void checkstatus(object sender, EventArgs e)
        {
            btnNext.Enabled = true; //якщо варіант відповіді обраний, кнопка "далі" доступна для натискання
            RadioButton toggle = (RadioButton)sender;
            var tmp = toggle.Name;
            //перевірка роботи radiobutton

            selected_response = int.Parse(tmp.Substring(12));
            //зчитування правильної відповіді
        }

//функція, що виводить результати
        void results()
        {

            grade += (correct_answers * 5); //підрахунок файлів
            Read.Close(); //зчитування закінчується
            results_shown = true; //визначає що тест завершено

            pnlTimer.Visible = false;
            pnlAnswers.Visible = false;
            pctrbox_question.Visible = false;
            //таймер та варіанти відповідей ховаються

            if (results_shown == true)
            {
                btnStart.Text = "Почати спочатку";
                btnStart.Visible = true;
            }//вивід кнопки початку тесту та зміна її функціоналу на перепроходження тесту

            lblQuestion.Location = new Point(440, 63);//напис з текстом питання переноситься на центр

            
            if (correct_answers >= 18)
            {
                lblQuestion.Text = String.Format("Тестування завершено.\n" +
                        "Правильних відповідей: " + correct_answers + " з 20.\n" +
                        "Набрані бали: " + grade + " %.\n\n" +
                        "Вітаємо! Ви склали тест!");
            }//вивід результатів тесту при успішному складанні, зміна напису з текстом питання на результат

            else
            {
                lblQuestion.Text = String.Format("Тестування завершено.\n" +
                    "Правильних відповідей: " + correct_answers + " з 20.\n" +
                    "Набрані бали: " + grade + " %\n\n" +
                    "Ви не склали тест. ");
            }//вивід результатів тесту, зміна напису з текстом питання на результат
            pnlButtons.Visible = false;
            //кнопки з вибором наступного питання та достроковою здачею тесту ховаються

            var Str = "Список неправильних відповідей на питання " +
                      ":\n\n";
            for (int i = 1; i <= wrong_answers; i++)
            {
                Str = Str + array[i] + "\n";
            }
            //запис питань, на які була дана неправильна відповідь
           
            if (wrong_answers != 0) MessageBox.Show(Str, "Тестування завершено."); //вивід messagebox з питаннями, на які була дана неправильна відповідь

            else if (wrong_answers == 0) MessageBox.Show("Ви не дали правильну відповідь на жодне з питань.", "Провалено"); //вивід messagebox у випадку якщо користувач не відповів правильно на жодне з питань

            if (question_count == 1) MessageBox.Show("Ви не відповіли на жодне з питань.", "Провалено"); //вивід messagebox у випадку якщо користувач не пішов далі першого питання


        }

//кнопка з переходом до наступного питання
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number) correct_answers = correct_answers + 1;//збільшення кількості балів у разі правильної відповіді на питання

            if (selected_response != correct_answers_number)
            {
                wrong_answers = wrong_answers + 1;
                
                array[wrong_answers] = lblQuestion.Text;
            }//у випадку неправильної відповіді на питання кількість неправильних відповідей збільшується і записується у список неправильних відповідей
            if (btnNext.Text == "Завершити") results();//у разі надання відповідей на всі питання при натисканні кнопки виводяться результати 
            if (btnNext.Text == "Наступне питання") question();//якщо користувач відповів не на всі питання, йому виводить наступне

        }

//кнопка дострокового завершення тесту
        private void btnEnd_Click(object sender, EventArgs e)
        {
            results();
        }//при натисканні користувачу виводить результати


        private void Form1_Load(object sender, EventArgs e)
        {
            btnNext.Text = "Наступне питання";
            btnEnd.Text = "Завершити тестування";
            btnStart.Text = "Почати тестування";

            rdbtnAnswer_1.CheckedChanged += new EventHandler(checkstatus);
            rdbtnAnswer_2.CheckedChanged += new EventHandler(checkstatus);
            rdbtnAnswer_3.CheckedChanged += new EventHandler(checkstatus);
        }//при загрузці форми текст на кнопках змінюється, а варіанти відповідей підв'язуються до функції з їхньою перевіркою

//кнопка для початку тестування
        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult start_test;//задання початкового messagebox з інформацією про тест
            start_test = MessageBox.Show("Тест складається з 20 питань з загальних положень правил дорожнього руху. У вас є пів години на те, щоб відповісти на всі питання.\n\nПід варіантами відповідей будуть дві кнопки: ліва кнопка відповідає за перехід до наступного питання, а права дозволяє завершити тест достроково.\n\nЩоб скласти тест, необхідно щонайменше 90 відсотків правильних відповідей.", "Початок", MessageBoxButtons.OK);
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
            }//вивід тесту, вивід та запуск таймера

            if (btnStart.Text == "Почати спочатку")
            {
                lblQuestion.Location = new Point(30, 18);
                pnlButtons.Visible = true;
                btnNext.Text = "Наступне питання";
                pnlAnswers.Visible = true;
                btnEnd.Enabled = true;
                grade = 0;
                correct_answers = 0;
                wrong_answers = 0;
            }//повторний вивід тесту, обнулення оцінки, правильних та правильних відповідей

        }

//кнопка виходу з додатку
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//після натискання додаток закривається
    }
}
