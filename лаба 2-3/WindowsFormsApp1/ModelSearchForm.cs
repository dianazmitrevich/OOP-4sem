using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModelSearchForm : Form
    {
        public PlaneInfo[] planeArray = new PlaneInfo[] { };
        public PlaneInfo[] result = new PlaneInfo[] { };

        public ModelSearchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            if (Regex.IsMatch(textBox1.Text, @"s$"))
            {
                foreach (PlaneInfo i in planeArray)
                {
                    if (i.PlaneModel.Contains(textBox1.Text))
                    {
                        result.Append(i);
                        textBox2.Text += i.PlaneModel + " " + i.PlaneID + "\r\n";
                    }
                }
            }
        }
    }
}
