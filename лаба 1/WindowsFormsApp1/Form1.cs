using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string CurrentNumber = "";
        private double SavedNumber = 0;
        private double Exponent = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // для сохранения и вывода числа
        private void button1_Click_1 (object sender, EventArgs e) => this.CurrentNumber = Convert.ToString(this.TextBox.Text);
        private void button2_Click (object sender, EventArgs e) => TextBox.Text = this.CurrentNumber;
        // ----

        // ----
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        // ----

        // кнопки для цифр
        private void Num0Button_Click (object sender, EventArgs e) => TextBox.Text += 0;
        private void Num1Button_Click (object sender, EventArgs e) => TextBox.Text += 1;
        private void Num2Button_Click (object sender, EventArgs e) => TextBox.Text += 2;
        private void Num3Button_Click (object sender, EventArgs e) => TextBox.Text += 3;
        private void Num4Button_Click (object sender, EventArgs e) => TextBox.Text += 4;
        private void Num5Button_Click (object sender, EventArgs e) => TextBox.Text += 5;
        private void Num6Button_Click (object sender, EventArgs e) => TextBox.Text += 6;
        private void button1_Click (object sender, EventArgs e) => TextBox.Text += 7;
        private void Num8Button_Click (object sender, EventArgs e) => TextBox.Text += 8;
        private void Num9Button_Click (object sender, EventArgs e) => TextBox.Text += 9;
        // ----

        // методы для других кнопок
        private void ClearButton_Click (object sender, EventArgs e) => TextBox.Text = "";

        /*private void DotButton_Click(object sender, EventArgs e)
        {
            if(!TextBox.Text.EndsWith(".") && TextBox.Text.Length > 0) TextBox.Text += ".";
            else if (TextBox.Text == "") TextBox.Text += "0.";
        }*/

        private void DeletePreviousNumButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "") TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Sin(num));
            }
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Cos(num));
            }
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Tan(num));
            }
        }

        private void CtgButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(1 / Math.Tan(num));
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Sqrt(num));
            }
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Pow(num, 1 / 3.0));
            }
        }

        private void PositiveNegativeButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                double num = Convert.ToDouble(TextBox.Text);
                num = -num;
                TextBox.Text = Convert.ToString(num);
            }
        }
        // ----

        // методы для кнопки возведения в степень
        private void ExponentationButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "") SaveNumber();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            GetExponent();
            TextBox.Text = Convert.ToString(Math.Pow(this.SavedNumber, this.Exponent));
        }

        private void SaveNumber()
        {
            this.SavedNumber = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }
        
        private void GetExponent()
        {
            this.Exponent = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }
        // ----
    }
}
