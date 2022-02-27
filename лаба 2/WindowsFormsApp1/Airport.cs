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

namespace WindowsFormsApp1
{
    public partial class Airport : Form
    {
        private PlaneInfo[] plane = new PlaneInfo[] { };
        private string ModelPlane;

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

        private void AddManufacturerButton_Click(object sender, EventArgs e)
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
        // ----

        /*
        private void WriteInfoButton_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer writeFile = new DataContractJsonSerializer(typeof(PlaneInfo[]));
            using (FileStream fs = new FileStream("PlaneInfo.json", FileMode.OpenOrCreate))
            {
                writeFile.WriteObject(fs, this.plane);
            }
        }
        */
    }
}
