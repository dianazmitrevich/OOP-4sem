using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Airport : Form
    {
        public PlaneInfo[] plane = new PlaneInfo[] { };
        public Crew[] planeCrew = new Crew[] { };
        private string ModelPlane;

        public PlaneInfo[] result = new PlaneInfo[] { };

        public Airport()
        {
            InitializeComponent();
        }

        // ----
        private void Form1_Load(object sender, EventArgs e) { }
        // ---

        private void AddPlaneButton_Click(object sender, EventArgs e)
        {
            if (isFieldNotEmpty())
            {
                PlaneInfo element = new PlaneInfo(
                    PlaneIDTextBox.Text,
                    (string)PlaneTypeComboBox.SelectedItem,
                    ModelPlane,
                    PlaneCapacityNumeric.Value.ToString(),
                    Convert.ToString(LoadCapacityCkeckbox.Text),
                    Convert.ToString(PlaneYearMaskedTextBox.Text),
                    PlaneDateService.Value);

                this.plane = this.plane.Append(element).ToArray();
                OutputBox.Text += element.ToString();
                this.ClearForm();
            }

            else MessageBox.Show("Проверьте чтобы были заполнены все поля!");
        }

        private bool isFieldNotEmpty()
        {
            if (PlaneIDTextBox.Text == "") return false;
            else if (PlaneTypeComboBox.SelectedIndex != 0 && PlaneTypeComboBox.SelectedIndex != 1 && PlaneTypeComboBox.SelectedIndex != 2) return false;
            else if (ModelPlane == "") return false;
            else if (PlaneLoadCapacityCheckbox.Text == "") return false;
            else if (PlaneYearMaskedTextBox.Text == "") return false;

            return true;
        }
        private void ClearForm()
        {
            PlaneIDTextBox.Text = "";
            PlaneTypeComboBox.Text = "";
            RadioButtonAirbusOption.Checked = false;
            RadioButtonBoeingOption.Checked = false;
            PlaneCapacityNumeric.Value = PlaneCapacityNumeric.Minimum;
            PlaneYearMaskedTextBox.Text = "";
            PlaneDateService.Value = DateTime.Now;
            ManufacturerName.Text = "";
            ManufacturerCountry.Text = "";
            MaunfacturerYear.Text = "";
            CrewSurname.Text = "";
            CrewPosition.Text = "";
            CrewAge.Value = CrewAge.Minimum;
            CrewWorkExperience.Text = "";
        }

        private void RadioButtonAirbusOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonAirbusOption.Checked) ModelPlane = Convert.ToString(RadioButtonAirbusOption.Text);
        }
        private void RadioButtonBoeingOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonBoeingOption.Checked) ModelPlane = Convert.ToString(RadioButtonBoeingOption.Text);
        }
        private void ResetBoxButton_Click(object sender, EventArgs e)
        {
            if (OutputBox.Text != "") OutputBox.Text = "";
        }

        // ----
        private void PlaneIDTextBox_TextChanged(object sender, EventArgs e) { }
        private void PlaneTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LoadCapacityCkeckbox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void PlaneYearMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void PlaneCapacityNumeric_ValueChanged(object sender, EventArgs e) { }
        // ----

        private void AddManufacturerButton_Click(object sender, EventArgs e)
        {
            if (plane.Length != 0)
            {
                if (ManufacturerName.Text != "" && ManufacturerCountry.Text != "" && MaunfacturerYear.Text != "")
                {
                    for (int i = 0; i < plane.Length; i++)
                    {
                        if (plane[i].PlaneID == ManufacturerPlaneID.Text)
                        {
                            Manufacturer element = new Manufacturer(
                                ManufacturerName.Text,
                                ManufacturerCountry.Text,
                                Convert.ToInt32(MaunfacturerYear.Text));

                            plane[i].planeManufacturer = element;

                            ClearForm();
                            OutputBox.Text += $"{element.ToString()} добавлен/изменен у карточки самолета #{plane[i].PlaneID}" + Environment.NewLine;
                        }

                        else throw new ArgumentException("Самолета с таким ID нет в стеке!");
                    }
                }

                else MessageBox.Show("Проверьте чтобы все поля поля заполнены!");
            }

            else MessageBox.Show("Ошибка: массив с самолетами пустой!");
        }

        private void AddCrewMemberButton_Click(object sender, EventArgs e)
        {
            if (plane.Length != 0)
            {
                if (CrewSurname.Text != "" && CrewPosition.Text != "" && CrewAge.Text != "" && CrewWorkExperience.Text != "")
                {
                    for (int i = 0; i < plane.Length; i++)
                    {
                        if (plane[i].PlaneID == CrewPlaneID.Text)
                        {
                            Crew element = new Crew(
                                CrewSurname.Text,
                                CrewPosition.Text,
                                Convert.ToInt32(CrewAge.Text),
                                CrewWorkExperience.Text);

                            this.planeCrew = this.planeCrew.Append(element).ToArray();
                            plane[i].planeCrew = planeCrew;

                            ClearForm();
                            OutputBox.Text += $"{element.ToString()} добавлен в экипаж самолета #{plane[i].PlaneID}" + Environment.NewLine;
                        }
                        else throw new ArgumentException("Самолета с таким ID нет в стеке!");
                    }
                }

                else MessageBox.Show("Проверьте чтобы все поля поля заполнены!");
            }

            else MessageBox.Show("Ошибка: массив с самолетами пустой!");
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            if (plane.Length != 0)
            {
                string showTypeInfo = ShowTypeInfo.Text;

                if (ShowTypeInfo.Text != "" && PlaneIDShowInfo.Text != "")
                {
                    for (int i = 0; i < plane.Length; i++)
                    {
                        if (plane[i].PlaneID == PlaneIDShowInfo.Text)
                        {
                            if (showTypeInfo == "самолете")
                            {
                                OutputBox.Text += $"Информация о самолете #{plane[i].PlaneID}:" + Environment.NewLine
                                    + plane[i].ToString() + Environment.NewLine;
                            }
                            else if (showTypeInfo == "экипаже")
                            {
                                OutputBox.Text += $"Информация об экипаже самолета #{plane[i].PlaneID}:" + Environment.NewLine;
                                for (int j = 0; j < plane[i].planeCrew.Length; j++)
                                    OutputBox.Text += plane[i].planeCrew[j] + Environment.NewLine;
                            }
                            else if (showTypeInfo == "производителе")
                            {
                                OutputBox.Text += $"Информация о производителе самолета #{plane[i].PlaneID}:" + Environment.NewLine
                                    + plane[i].planeManufacturer + Environment.NewLine;
                            }
                        }
                        else throw new ArgumentException("Самолета с таким ID нет в стеке!");
                    }
                }

                else MessageBox.Show("Проверьте чтобы все поля поля заполнены!");
            }

            else MessageBox.Show("Ошибка: массив с самолетами пустой!");
        }

        private void ShowTypeInfo_SelectedIndexChanged(object sender, EventArgs e) { }

        private void типуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSearchForm searchForm = new TypeSearchForm();
            searchForm.planeArray = plane;
            searchForm.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные были сохранены в файл!");
        }

        private void моделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelSearchForm searchForm = new ModelSearchForm();
            searchForm.planeArray = plane;
            searchForm.Show();
        }

        private void количествуМестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapacitySearchForm searchForm = new CapacitySearchForm();
            searchForm.planeArray = plane;
            searchForm.Show();
        }

        private void поIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plane.Length == 0)
            {
                throw new Exception("Стек самолетов пустой!");
            }
            var idSort = from element in plane
                         orderby element.PlaneID
                         select element;
            StringBuilder str = new StringBuilder();
            foreach (PlaneInfo i in idSort)
            {
                str.Append(Convert.ToString(i.PlaneID) + "\n");
            }
            MessageBox.Show(str.ToString());
        }

        private void поДатеТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plane.Length == 0)
            {
                throw new Exception("Стек самолетов пустой!");
            }
            var idSort = from element in plane
                         orderby element.PlaneTO
                         select element;
            StringBuilder str = new StringBuilder();
            foreach (PlaneInfo i in idSort)
            {
                str.Append(Convert.ToString(i.PlaneID) + ' ' + Convert.ToString(i.PlaneTO) + "\n");
            }
            MessageBox.Show(str.ToString());
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.2022. Разработчик Диана");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Время - " + DateTime.Now.ToString() + " | Кол-во самолетов в стеке - " + plane.Length;
        }
    }
}
