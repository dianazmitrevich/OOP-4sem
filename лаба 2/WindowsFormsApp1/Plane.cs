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
    public partial class Plane : Form
    {
        private PlaneInfo[] plane = new PlaneInfo[] { };
        private string ModelPlane;
        private string planeID;
        private string planeType;
        private string loadCapacity;
        private string planeYear;

        public Plane()
        {
            InitializeComponent();
        }

        // ----
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // ---

        private void AddPlaneButton_Click(object sender, EventArgs e)
        {
            if(!fieldsInputValidation())
            {
                MessageBox.Show("Проверьте чтобы были заполнены все поля!");
            }

            PlaneInfo element = new PlaneInfo(planeID, planeType, ModelPlane, PlaneCapacityNumeric.Value.ToString(), loadCapacity, planeYear, PlaneDateService.Value);

            this.plane = this.plane.Append(element).ToArray();
            this.ClearForm();
        }

        private bool fieldsInputValidation()
        {
            if (PlaneIDTextBox.Text == "") return false;
            else if (PlaneTypeComboBox.SelectedIndex == 0) return false;
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
        }

        private void RadioButtonAirbusOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonAirbusOption.Checked) ModelPlane = Convert.ToString(RadioButtonAirbusOption.Text);
        }
        private void RadioButtonBoeingOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonBoeingOption.Checked) ModelPlane = Convert.ToString(RadioButtonBoeingOption.Text);
        }
        private void PlaneIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PlaneIDTextBox.Text != "") planeID = PlaneIDTextBox.Text;
        }
        private void PlaneTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlaneTypeComboBox.SelectedIndex != 0) planeType = (string)PlaneTypeComboBox.SelectedItem;
        }
        private void LoadCapacityCkeckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadCapacityCkeckbox.SelectedIndex != 0) loadCapacity = LoadCapacityCkeckbox.Items.ToString();
        }
        private void PlaneYearMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (PlaneYearMaskedTextBox.Text != "") planeYear = PlaneYearMaskedTextBox.Text.ToString();
        }

        // ----
        private void PlaneCapacityNumeric_ValueChanged(object sender, EventArgs e) { }
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
