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
        public Form1()
        {
            InitializeComponent();
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
    }
}
