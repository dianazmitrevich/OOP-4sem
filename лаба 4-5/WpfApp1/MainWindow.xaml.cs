using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
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

        private void New_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            TextRange value = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (file.ShowDialog() == true)
            {
                using (FileStream fs = File.Create(file.FileName))
                {
                    string extension = System.IO.Path.GetExtension(file.FileName).ToLower();
                    if (extension == ".txt") value.Save(fs, DataFormats.Rtf);
                    else if (extension == ".rtf") value.Save(fs, DataFormats.Text);
                    else
                    {
                        MessageBox.Show(
                            "Wrong file extension!",
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
                        return;
                    }
                }
            }
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (file.ShowDialog() == true)
            {
                FileStream fs = new FileStream(file.FileName, FileMode.Open);
                TextRange range = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
                string extension = System.IO.Path.GetExtension(file.FileName).ToLower();

                if (extension != ".rtf" && extension != ".txt")
                {
                    MessageBox.Show(
                        "Wrong file extension!",
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error
                    );
                    return;
                }
                range.Load(fs, DataFormats.Rtf);
            }
        }
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

        private ResourceDictionary language= new ResourceDictionary();
        private ResourceDictionary theme = new ResourceDictionary();
        private void ChangeResource(ResourceDictionary oldResource, string newResource)
        {
            Uri newSource = new Uri(newResource);
            ResourceDictionary newResourceLang = new ResourceDictionary();
            newResourceLang.Source = newSource;
            this.Resources.MergedDictionaries.Remove(oldResource);
            this.Resources.MergedDictionaries.Add(newResourceLang);
            oldResource.Source = newSource;
        }

        private void RU_Click(object sender, RoutedEventArgs e)
        {
            this.ChangeResource(this.language, "C:/Users/diana/Desktop/OOP-4sem/лаба 4-5/WpfApp1/languages/russian.xaml");
        }
        private void EN_Click(object sender, RoutedEventArgs e)
        {
            this.ChangeResource(this.language, "C:/Users/diana/Desktop/OOP-4sem/лаба 4-5/WpfApp1/languages/english.xaml");
        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            this.ChangeResource(this.theme, "C:/Users/diana/Desktop/OOP-4sem/лаба 4-5/WpfApp1/themes/dark_theme.xaml");
        }
        private void Light_Click(object sender, RoutedEventArgs e)
        {
            this.ChangeResource(this.theme, "C:/Users/diana/Desktop/OOP-4sem/лаба 4-5/WpfApp1/themes/light_theme.xaml");
        }
        private void Color_Click(object sender, RoutedEventArgs e)
        {
            this.ChangeResource(this.theme, "C:/Users/diana/Desktop/OOP-4sem/лаба 4-5/WpfApp1/themes/color_theme.xaml");
        }
    }
}
