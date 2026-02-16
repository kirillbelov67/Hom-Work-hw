using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace algoritms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Cbrt(double value)
        {
            return Math.Pow(value, 1.0 / 3.0);
        }
        double f(double x)
        {
            if (radioButton1.Checked)
                return Cos(x);

            if (radioButton2.Checked)
                return x * x;

            if (radioButton3.Checked)
                return Exp(x);

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBox2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double z = Convert.ToDouble(textBox3.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            // Проверка диапазона определения acos
            if (x < -1 || x > 1)
            {
                textBox6.Text = "Ошибка: x должен быть в диапазоне [-1; 1] для arccos";
                return;
            }

            double U = Cbrt((8 + Pow(Abs(x - y), 2) + 1)
                     / (Pow(x, 2) + Pow(y, 2) + 2))
           - Exp(Abs(x - y))
             * Pow(Pow(Tan(z), 2) + 1, x);
            textBox6.Text = U.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox8.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBox7.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            double xy = x * y;
            richTextBox1.AppendText($"Вычисляем xy = {x} * {y} = {xy}\r\n");

            richTextBox1.Text += " Вычисление значения b\r\n";
            double b = 0;

            if (xy < 8)
            {
                richTextBox1.Text += "Условие: XY < 8\r\n";
                // Проверяем область определения логарифма
                double logArgument = y + f(x);
                if (logArgument <= 0)
                {
                    richTextBox1.Text += $"Ошибка: Аргумент логарифма (y + f(x)) = {logArgument} должен быть > 0!\r\n";
                    return;
                }
                b = Math.Log(Math.Abs(y + f(x))) + 3;
                richTextBox1.Text += $"b = ln|{y} + {f(x)}| + 3 = {b}\r\n";
            }
            else if (xy > 12)
            {
                richTextBox1.Text += "Условие: XY > 12\r\n";
                b = Math.Cos(f(x)) - y;
                richTextBox1.Text += $"b = cos({f(x)}) - {y} = {b}\r\n";
            }
            else
            {
                richTextBox1.Text += "Условие: иначе (8 ≤ XY ≤ 12)\r\n";
                b = Math.Sinh(f(x)) + Math.Cosh(y); // sh(x) = sinh(x), cs(y) = cosh(y)
                richTextBox1.Text += $"b = sh({f(x)}) + ch({y}) = {b}\r\n";
            }

            richTextBox1.AppendText($"Результат: k = ");

            if (checkBox1.Checked)
                richTextBox1.SelectionColor = Color.Red;
            else
                richTextBox1.SelectionColor = Color.Black;

            richTextBox1.AppendText(b.ToString());

            richTextBox1.SelectionColor = Color.Black;
        }
    }
    }

