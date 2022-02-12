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
        private string memory = "";
        private string CurrentNumber = "";
        private string NumberToExp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.CurrentNumber = Convert.ToString(this.TextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = this.CurrentNumber;
        }

        // ----
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // ----

        // кнопки для цифр
        private void Num0Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 0;
        }

        private void Num1Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 1;
        }

        private void Num2Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 2;
        }

        private void Num3Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 3;
        }

        private void Num4Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 4;
        }

        private void Num5Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 5;
        }

        private void Num6Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.Text += 7;
        }

        private void Num8Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 8;
        }

        private void Num9Button_Click(object sender, EventArgs e)
        {
            TextBox.Text += 9;
        }

        // ----

        // методы для других кнопок
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "") TextBox.Text += "0.";
            else TextBox.Text += ".";
        }

        private void DeletePreviousNumButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length == 0) TextBox.Text = "";
            else TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(Math.Sin(Convert.ToDouble(a)));
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(Math.Cos(Convert.ToDouble(a)));
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(Math.Tan(Convert.ToDouble(a)));
        }

        private void CtgButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(1 / Math.Tan(Convert.ToDouble(a)));
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(Math.Pow(Convert.ToDouble(a), 0.5));
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            var a = TextBox.Text;
            TextBox.Text = Convert.ToString(Math.Pow(Convert.ToDouble(a), 3));
        }

        private void ExponentationButton_Click(object sender, EventArgs e)
        {
            this.NumberToExp = this.CurrentNumber;
            TextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ExpNum = Convert.ToDouble(TextBox.Text);
            TextBox.Text = Convert.ToString(Math.Pow(Convert.ToDouble(this.NumberToExp), ExpNum));
        }
    }
}
