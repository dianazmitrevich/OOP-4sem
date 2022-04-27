using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        select d;

            this.ItemsGrid.ItemsSource = items.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            if(NameBox.Text != "" && MaterialBox.Text != "" && ColorBox.Text != "")
            {
                Item itemElement = new Item()
                {
                    Name = NameBox.Text,
                    Material = MaterialBox.Text,
                    Color = ColorBox.Text
                };

                db.Items.Add(itemElement);
                db.SaveChanges();

                MessageBox.Show("Элемент добавлен", "Добавление данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        select d;

            this.ItemsGrid.ItemsSource = items.ToList();
        }

        private int idForUpdate = 0;
        private void ItemsGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (this.ItemsGrid.SelectedIndex >= 0)
            {
                if (this.ItemsGrid.SelectedItems.Count >= 0)
                {
                    if (this.ItemsGrid.SelectedItems[0].GetType() == typeof(Item))
                    {
                        Item element = (Item)ItemsGrid.SelectedItems[0];
                        this.NameBox_U.Text = element.Name;
                        this.MaterialBox_U.Text = element.Material;
                        this.ColorBox_U.Text = element.Color;

                        idForUpdate = element.ID;
                    }
                }
            }
        }

        private void UpdateDBButton_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        where d.ID == idForUpdate
                        select d;

            Item element = items.SingleOrDefault();

            if (element != null)
            {
                element.Name = NameBox_U.Text;
                element.Material = MaterialBox_U.Text;
                element.Color = ColorBox_U.Text;

                MessageBox.Show("Элемент обновлен", "Обновление данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            db.SaveChanges();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        where d.ID == idForUpdate
                        select d;

            Item element = items.SingleOrDefault();

            if (element != null)
            {
                db.Items.Remove(element);
                MessageBox.Show("Элемент удален", "Удаление данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            db.SaveChanges();
        }

        private void Sort_1_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        where d.Name.StartsWith("П")
                        select d;

            this.ItemsGrid.ItemsSource = items.ToList();
        }

        private void Sort_2_Click(object sender, RoutedEventArgs e)
        {
            FurnitureDBEntities db = new FurnitureDBEntities();
            var items = from d in db.Items
                        where d.Color.Contains("бел")
                        select d;

            this.ItemsGrid.ItemsSource = items.ToList();
        }
    }
}