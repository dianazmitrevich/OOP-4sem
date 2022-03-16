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
    public partial class CapacitySearchForm : Form
    {
        public PlaneInfo[] planeArray = new PlaneInfo[] { };
        public PlaneInfo[] result = new PlaneInfo[] { };

        public CapacitySearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Airport f1 = this.Owner as Airport;
            int border = Convert.ToInt32(textBox1.Text);
            foreach (PlaneInfo i in planeArray)
            {
                if (Convert.ToInt32(i.PlaneCapacity) >= border)
                {
                    result.Append(i);
                    textBox3.Text += i.PlaneID + " " + i.PlaneType + " " + i.PlaneCapacity + "\r\n";
                }
            }
        }
    }
}
