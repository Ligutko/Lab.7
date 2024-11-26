using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox3.Text;
            string b = textBox2.Text;

            int a_1 = Convert.ToInt32(a);
            int b_1 = Convert.ToInt32(b);
            int ab = a_1 + b_1;

            textBox4.Text = ab.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string l1 = textBox3.Text;
            //string l2 = textBox2.Text;

            //int l1_1 = Convert .ToInt32(l1);
            //int l2_1 = Convert.ToInt32(l2);
            //int l1l2 = l1_1 + l2_1;

            //textBox4.Text = l1l2.ToString();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

         
            string a = textBox3.Text;
            string b = textBox2.Text;

            int a_1 = Convert.ToInt32(a);
            int b_1 = Convert.ToInt32(b);

           
            a_1 = 0;
            b_1 = 0;

            textBox3.Text = a_1.ToString();
            textBox2.Text = b_1.ToString();
            textBox4.Text = ""; 

        }
        //private void buttonCalculateAverage_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Отримання значень з текстових полів
        //        string x1 = textBox3.Text;
        //        string x2 = textBox2.Text;

        //        // Перетворення на числа
        //        double x1_value = Convert.ToDouble(x1);
        //        double x2_value = Convert.ToDouble(x2);

        //        // Обчислення середнього арифметичного
        //        double average = (x1_value + x2_value) / 2;

        //        // Виведення результату у текстове поле або повідомлення
        //        textBox4.Text = average.ToString();
        //    }
        //    catch (FormatException)
        //    {
        //        // Обробка помилки, якщо введено некоректні дані
        //        MessageBox.Show("Будь ласка, введіть числові значення у поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void buttonCalculateAverage_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string x1 = textBox3.Text;
                string x2 = textBox2.Text;

               
                double x1_value = Convert.ToDouble(x1);
                double x2_value = Convert.ToDouble(x2);

                
                double average = (x1_value + x2_value) / 2;

                textBox4.Text = average.ToString();
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Будь ласка, введіть числові значення у поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string x1_text = textBox3.Text;
                string x2_text = textBox2.Text;

                double x1 = Convert.ToDouble(x1_text);
                double x2 = Convert.ToDouble(x2_text);

                double numerator, denominator, y;

                if (x1 == 0)
                {
                    MessageBox.Show("x1 не може дорівнювати 0, але функція продовжить виконання з x1 = 0.1.", 
                        "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    x1 = 0.1;
                }

                if (Math.Cos(x2) == 0)
                {
                    MessageBox.Show("cos(x2) не може дорівнювати 0, але функція продовжить виконання з x2 = 1.",
                        "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    x2 = 1;
                }

                numerator = Math.Sqrt(Math.Pow(Math.Cos(x1), 3) + x2);
                denominator = Math.Pow(x1, 13) + (3 / Math.Cos(x2));
                y = numerator / denominator;

                textBox4.Text = y.ToString("F4");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть числові значення у поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //try
            //{
            //    // Отримання значень з текстових полів
            //    string x1 = textBox3.Text;
            //    string x2 = textBox2.Text;

            //    // Перетворення на числа
            //    double x1_value = Convert.ToDouble(x1);
            //    double x2_value = Convert.ToDouble(x2);

            //    // Обчислення середнього арифметичного
            //    double average = (x1_value + x2_value) / 2;

            //    // Форматування результату до 4 знаків після коми
            //    textBox4.Text = average.ToString("F4");
            //}
            //catch (FormatException)
            //{
            //    // Обробка помилок введення
            //    MessageBox.Show("Будь ласка, введіть числові значення у поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//using System;
//using System.Windows.Forms;

//namespace Lab._7
//{
//    public partial class fMain : Form
//    {
//        public fMain()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string a = textBox3.Text;
//                string b = textBox2.Text;

//                int a_1 = Convert.ToInt32(a);
//                int b_1 = Convert.ToInt32(b);
//                int ab = a_1 + b_1;

//                textBox4.Text = ab.ToString();
//            }
//            catch (FormatException)
//            {
//                MessageBox.Show("Будь ласка, введіть цілі значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            textBox3.Text = "";
//            textBox2.Text = "";
//            textBox4.Text = "";
//        }
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            textBox3.Text = ""; // Поле X1 порожнє
//            textBox2.Text = ""; // Поле X2 порожнє
//            textBox4.Text = ""; // Поле результату порожнє
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void buttonCalculateAverage_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string x1 = textBox3.Text;
//                string x2 = textBox2.Text;

//                double x1_value = Convert.ToDouble(x1);
//                double x2_value = Convert.ToDouble(x2);

//                double average = (x1_value + x2_value) / 2;

//                textBox4.Text = average.ToString("F4");
//            }
//            catch (FormatException)
//            {
//                MessageBox.Show("Будь ласка, введіть числові значення у поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}
