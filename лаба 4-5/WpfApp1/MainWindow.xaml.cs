using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }

        private void ChangeSelectedText(DependencyProperty d, object value)
        {
            var selection = WorkField.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(d, value);
        }
        private void FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField != null)
            {
                string selectedItem = FontFamily.SelectedItem.ToString();
                ChangeSelectedText(TextElement.FontFamilyProperty, new FontFamily(Regex.Replace(selectedItem.Trim(), @".*:\s+", "")));
            }
        }
        private void FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField != null)
            {
                string selectedItem = FontSize.SelectedItem.ToString();
                ChangeSelectedText(TextElement.FontSizeProperty, Regex.Replace(selectedItem.Trim(), @".*:\s+", ""));
            }
        }
        private void FontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField != null)
            {
                string selectedItem = FontColor.SelectedItem.ToString();
                ChangeSelectedText(TextElement.ForegroundProperty, Regex.Replace(selectedItem.Trim(), @".*:\s+", ""));
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Undo();
        }
        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Redo();
        }

        private void BoldButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextElement.FontWeightProperty, "Bold");
        }
        private void BoldButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextElement.FontWeightProperty, "Regular");
        }
        private void ItalicButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextElement.FontStyleProperty, "Italic");
        }
        private void ItalicButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextElement.FontStyleProperty, "Normal");
        }
        private void UnderlineButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextBox.TextDecorationsProperty, "Underline");
        }
        private void UnderlineButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeSelectedText(TextBox.TextDecorationsProperty, "None");
        }

        private void New_Click(object sender, RoutedEventArgs e) { }
        private void Save_Click(object sender, RoutedEventArgs e) { }
        private void Open_Click(object sender, RoutedEventArgs e) { }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Copy();
        }
        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Paste();
        }

        private void WorkField_TextChanged(object sender, RoutedEventArgs e)
        {
            TextRange value = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            if (StatusNumber != null)
                StatusNumber.Content = $"Знаки - {value.Text.Length - 2}";
        }
    }
}
