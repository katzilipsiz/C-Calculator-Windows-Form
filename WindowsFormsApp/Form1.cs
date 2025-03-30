using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1: Form
    {
        int num1, num2;
        int result;
        char action;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxIn1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIn1.Text is int)
            {
                num1 = Convert.ToInt32(textBoxIn1.Text);
            }
            
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "7";
                num1 = 7;
            }
            else
            {
                textBoxIn2.Text = "7";
                num2 = 7;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "8";
                num1 = 8;
            }
            else
            {
                textBoxIn2.Text = "8";
                num2 = 8;
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "9";
                num1 = 9;
            }
            else
            {
                textBoxIn2.Text = "9";
                num2 = 9;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            action = '+';
            textBoxAr.Text = Convert.ToString(action);
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            action = '*';
            textBoxAr.Text = Convert.ToString(action);
        }

        private void button_c1_Click(object sender, EventArgs e)
        {
            textBoxIn1.Text = "";
        }

        private void button_c2_Click(object sender, EventArgs e)
        {
            textBoxIn2.Text = "";
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            action = '/';
            textBoxAr.Text = Convert.ToString(action);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            action = '-';
            textBoxAr.Text = Convert.ToString(action);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "6";
                num1 = 6;
            }
            else
            {
                textBoxIn2.Text = "6";
                num2 = 6;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "5";
                num1 = 5;
            }
            else
            {
                textBoxIn2.Text = "5";
                num2 = 5;
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "4";
                num1 = 4;
            }
            else
            {
                textBoxIn2.Text = "4";
                num2 = 4;
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "1";
                num1 = 1;
            }
            else
            {
                textBoxIn2.Text = "1";
                num2 = 1;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "2";
                num1 = 2;
            }
            else
            {
                textBoxIn2.Text = "2";
                num2 = 2;
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBoxIn1.Text.Equals(""))
            {
                textBoxIn1.Text = "3";
                num1 = 3;
            }
            else
            {
                textBoxIn2.Text = "3";
                num2 = 3;
            }
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение!");
                    break;
            }

            
            textBoxOut.Text = "=";
        }

        private void textBoxIn2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIn1.Text is int)
            {
                num2 = Convert.ToInt32(textBoxIn2.Text);
            }
        }

        private void textBoxAr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            panel1.BackColor = Color.YellowGreen;
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {
            textBoxOut.Text = Convert.ToString(result);
        }
    }
}
