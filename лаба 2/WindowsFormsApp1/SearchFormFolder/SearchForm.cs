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
            if (Plane.Length != 0) { }
            else MessageBox.Show("Ошибка: массив с самолетами пустой!");
        }
    }
}
