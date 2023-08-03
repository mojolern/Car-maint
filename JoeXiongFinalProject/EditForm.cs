using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeXiongFinalProject
{
    public partial class EditForm : Form
    {
        internal Vehicle editVehicle { get; set; } // get and set vehicle.
        private MainForm mf = null;
        int car;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Vehicle vehicle, Form mainForm, int carIndex) {
            InitializeComponent();
            this.editVehicle = vehicle;
            mf = mainForm as MainForm;
            car = carIndex;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            editModelTextBox.Text = editVehicle.Model;
            editMakeTextBox.Text = editVehicle.Make;
            editYearTextBox.Text = editVehicle.Year.ToString();
            editMileageTextBox.Text = editVehicle.Mileage.ToString();
            //editOilGradeTextBox.Text = editVehicle.oilType.ToString();
            oilGradeDropDownBox.Text = editVehicle.oilType.ToString();
            //oilChangeCheck.Checked = editVehicle.oilChange;
            //oilFilterChangeCheck.Checked = editVehicle.filterChanged;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            long mileage = 0;
            long prevMile = 0;
            int year = 0;
            bool goodYear = true;
            bool goodMile = true;
            DateTime date = DateTime.Now;


            editVehicle.previousDateEntered = editVehicle.dateEntered;
            editVehicle.dateEntered = date.ToShortDateString();

            prevMile = editVehicle.Mileage;

            long.TryParse(editMileageTextBox.Text.ToString(), out mileage);
            int.TryParse(editYearTextBox.Text.ToString(), out year);

            if (mileage > prevMile)
            {
                // if new entered mileage is greater than old mileage. put old mileage into prev mileage and new mileage into current vehicle mileage.

                editVehicle.prevMilage = prevMile;
                editVehicle.Mileage = mileage;
            }
            else
            {
                editVehicle.Mileage = mileage;
            }

            editVehicle.Model = editModelTextBox.Text.ToString().Trim();
            editVehicle.Make = editMakeTextBox.Text.ToString().Trim();
            editVehicle.oilType = oilGradeDropDownBox.Text.ToString().Trim();
            editVehicle.Year = year;

            editVehicle.oilChange = oilChangeCheck.Checked;
            editVehicle.prevOilChangeDate = editVehicle.oilChangeDate;
            if (editVehicle.oilChange == true)
            {
                editVehicle.oilChangeDate = date.ToShortDateString();
            }

            editVehicle.filterChanged = oilFilterChangeCheck.Checked;
            editVehicle.prevFilterChangeDate = editVehicle.filterChangeDate;
            if (editVehicle.filterChanged == true)
            {
                editVehicle.filterChangeDate = date.ToShortDateString();
            }



            // error catching
            if (editVehicle.Make == "")
            {
                MessageBox.Show("Please enter a valid vehicle make.");
            }

            if (editVehicle.Model == "")
            {
                MessageBox.Show("Please enter a valid vehicle model.");
            }

            if (!int.TryParse(editYearTextBox.Text, out year) || year < 0 || year > 9999)
            {
                MessageBox.Show("Please enter a valid year.");
                goodYear = false;
            }

            if (!long.TryParse(editMileageTextBox.Text, out mileage) || mileage < 0)
            {
                MessageBox.Show("Please enter a valid milage number.");
                goodMile = false;
            }

            if (editVehicle.oilType == "")
            {
                MessageBox.Show("Please enter a valid vehicle oil type.");
            }

            // Update vehicle.
            if (editMakeTextBox.Text.ToString() == "" || editModelTextBox.Text.ToString() == ""
            || goodMile == false || goodYear == false)
            {
                MessageBox.Show("Some fields are invalid please try again.");
            }
            else
            { 
                this.mf.UpdateItemToList(editVehicle.Make, editVehicle.Model, car);
                MessageBox.Show("Changes made successfully.");
            }
        }
    }
}
