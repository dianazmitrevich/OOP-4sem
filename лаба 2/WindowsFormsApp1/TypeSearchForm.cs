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
    public partial class TypeSearchForm : Form
    {
        public PlaneInfo[] planeArray = new PlaneInfo[] { };
        public PlaneInfo[] result = new PlaneInfo[] { };

        public TypeSearchForm()
        {
            InitializeComponent();
        }

        private void SearchSF_Click(object sender, EventArgs e)
        {
            OutputBoxSF.Clear();

            if (RB3_SF.Checked)
            {
                foreach (PlaneInfo i in planeArray)
                {
                    if (i.PlaneType == "Военный")
                    {
                        result.Append(i);
                        OutputBoxSF.Text += i.PlaneID + ", " + i.PlaneType + "\r\n";
                    }
                }
            }
            else if (RB2_SF.Checked)
            {
                foreach (PlaneInfo i in planeArray)
                {
                    if (i.PlaneType == "Пассажирский")
                    {
                        result.Append(i);
                        OutputBoxSF.Text += i.PlaneID + ", " + i.PlaneType + "\r\n";
                    }
                }
            }
            else if (RB1_SF.Checked)
            {
                foreach (PlaneInfo i in planeArray)
                {
                    if (i.PlaneType == "Грузовой")
                    {
                        result.Append(i);
                        OutputBoxSF.Text += i.PlaneID + ", " + i.PlaneType + "\r\n";
                    }
                }
            }
        }
    }
}
