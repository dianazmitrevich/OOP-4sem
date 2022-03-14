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

namespace WindowsFormsApp1.SearchFormFolder
{
    public partial class SearchForm : Form
    {
        public PlaneInfo[] Plane;

        public SearchForm()
        {
            InitializeComponent();
        }

        // ----
        private void SFname_TextChanged(object sender, EventArgs e) { }
        // ----

        private void SearchFormButton_Click(object sender, EventArgs e)
        {
            if (Plane.Length != 0)
            {
                if (SFname.Text != "")
                {
                    for (int i = 0; i < Plane.Length; i++)
                    {
                        if (SFname.Text == Plane[i].PlaneID)
                        {
                            SearchFormResult.Text += $"Информация по поиску самолета с названием (id) #{SFname.Text}:" + Environment.NewLine +
                                Plane[i].ToString();
                        }
                        else SearchFormResult.Text += "По запросу не было найдено информации!" + Environment.NewLine;
                    }
                }
                else if (SFtype.Text != "")
                {
                    for (int i = 0; i < Plane.Length; i++)
                    {
                        if (SFtype.Text == Plane[i].PlaneType)
                        {
                            SearchFormResult.Text += $"Информация по поиску самолета типа '{SFname.Text}':" + Environment.NewLine +
                                Plane[i].ToString();
                        }
                        else SearchFormResult.Text += "По запросу не было найдено информации!" + Environment.NewLine;
                    }
                }
            }
            else MessageBox.Show("Ошибка: массив с самолетами пустой!");
        }
    }
}
