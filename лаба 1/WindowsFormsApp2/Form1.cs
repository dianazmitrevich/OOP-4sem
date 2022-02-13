using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Circle> list = new List<Circle>();
        private delegate List<Circle> ComparingMethod(Comparison<Circle> parameters);
        
        // ----
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        // ----

        private void ShowList(List<Circle> list)
        {
            ListBoxItems.Items.Clear();
            for (int i = 0; i < list.Count; i++)
                ListBoxItems.Items.Add(list[i].ToString());
        }

        private void GenerateTheCollectionButton_Click(object sender, EventArgs e)
        {
            this.list.Clear();
            Random randomNum = new Random();
            for (int i = 0; i < Convert.ToInt32(CollectionSizeInput.Text); i++)
                this.list.Add(new Circle(randomNum.Next(100)));
            this.ShowList(this.list);
        }
    }
}
