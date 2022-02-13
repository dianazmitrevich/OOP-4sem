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
        private Circle getMinElement;
        private Circle getMaxElement;

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

            getMinElement = (from radius in this.list select radius).Min();
            getMaxElement = (from radius in this.list select radius).Max();
        }

        // методы для сортировки
        private List<Circle> SortingMethod(Comparison<Circle> parameters)
        {
            list.Sort(parameters);
            return list;
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            ComparingMethod comparingMethod = SortingMethod;
            comparingMethod((firstRadius, secondRadius) =>
            {
                if (firstRadius.Radius < secondRadius.Radius) return 1;
                else if (firstRadius.Radius == secondRadius.Radius) return 0;
                else return -1;
            });
            this.ShowList(this.list);
        }

        private void AscendingSortButton_Click(object sender, EventArgs e)
        {
            ComparingMethod comparingMethod = SortingMethod;
            comparingMethod((firstRadius, secondRadius) =>
            {
                if (firstRadius.Radius > secondRadius.Radius) return 1;
                else if (firstRadius.Radius == secondRadius.Radius) return 0;
                else return -1;
            });
            this.ShowList(this.list);
        }
        // ----

        // запросы
        private void MinQueryButton_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
                ListBoxItems.Items.Add($"Минимальный элемент - круг с радиусом {getMinElement.Radius}");
        }

        private void MaxQueryButton_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
                ListBoxItems.Items.Add($"Максимальный элемент - круг с радиусом {getMaxElement.Radius}");
        }

        private void RangeQueryButton_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
            {
                ListBoxItems.Items.Add($"Диапазон значений = от {this.getMinElement.Radius} до {this.getMaxElement.Radius}");
            }
        }
        // ----
    }
}
