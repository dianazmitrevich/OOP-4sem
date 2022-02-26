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
            fieldsInputValidation();
        }

        private string fieldsInputValidation()
        {
            string errorMessage = "";

            if (PlaneIDTextBox.Text == "") errorMessage = "Вы не ввели ID самолета!";
            if (!(bool)PlaneTypeComboBox.SelectedItem) errorMessage = "Вы не выбрали тип самолета!";
            if (!RadioButtonAirbusOption.Checked || !RadioButtonBoeingOption.Checked) errorMessage = "Вы не выбрали модель самолета!";
            if (PlaneYearMaskedTextBox.Text == "") errorMessage = "Вы не ввели год выпуска самолета!";

            return errorMessage;
        }

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
