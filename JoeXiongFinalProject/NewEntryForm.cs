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
    public partial class NewEntryForm : Form
    {
        internal Vehicle newVehicle { get; set; } // get and set newVehicle from overloaded constructor

        public NewEntryForm()
        {
            InitializeComponent();
        }

        private MainForm mf = null;

        public NewEntryForm(Vehicle vehicle, Form mainForm) {
            InitializeComponent();
            this.newVehicle = vehicle;  // Directly updates vehicle object created from MainForm
            mf = mainForm as MainForm;  // Allows update real time on main form
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears text forms and restores focus to newMakeTextBox.
            newMakeTextBox.Clear();
            newModelTextBox.Clear();
            newYearTextBox.Clear();
            oilGradeDropDownBox.Text = "";
            newMileageTextBox.Clear();
            oilChangeCheck.Checked = false;
            oilFilterChangeCheck.Checked = false;
            newMakeTextBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

                long mileage = 0;
                int year = 0;
                bool goodYear = true;
                bool goodMile = true;
                DateTime date = DateTime.Now;
            //Take text information from textbox and store 
            // into newVehicle object.
                long.TryParse(newMileageTextBox.Text.ToString(), out mileage);
                int.TryParse(newYearTextBox.Text.ToString(), out year);

                newVehicle.dateEntered = date.ToShortDateString();
                newVehicle.Make = newMakeTextBox.Text.ToString().Trim();
                newVehicle.Model = newModelTextBox.Text.ToString().Trim();
                newVehicle.oilType = oilGradeDropDownBox.Text.ToString().Trim();
                newVehicle.Mileage = mileage;
                newVehicle.Year = year;

                newVehicle.oilChange = oilChangeCheck.Checked;
                if (newVehicle.oilChange == true)
                {
                    newVehicle.oilChangeDate = date.ToShortDateString();
                }

                                   
                newVehicle.filterChanged = oilFilterChangeCheck.Checked;
                if (newVehicle.filterChanged == true)
                {
                    newVehicle.filterChangeDate = date.ToShortDateString();
                }

                
                // error catching
                if (newVehicle.Make == "")
                {
                    MessageBox.Show("Please enter a valid vehicle make.");
                }

                if (newVehicle.Model == "")
                {
                    MessageBox.Show("Please enter a valid vehicle model.");
                }

                if (!int.TryParse(newYearTextBox.Text, out year) || year < 0 || year > 9999)
                {
                    MessageBox.Show("Please enter a valid year.");
                goodYear = false;
                }

                if (!long.TryParse(newMileageTextBox.Text, out mileage) || mileage < 0)
                {
                    MessageBox.Show("Please enter a valid milage number.");
                goodMile = false;
                }

                if (newVehicle.oilType == "")
                {
                    MessageBox.Show("Please enter a valid vehicle oil type.");
                }



            // Adds item to itemList in MainForm
            if (newMakeTextBox.Text.ToString() == "" || newModelTextBox.Text.ToString() == ""
            || goodMile == false || goodYear == false || newVehicle.oilType == "")
            {
                MessageBox.Show("Some fields are invalid please try again.");
            }
            else {
                this.mf.AddItemToList(newVehicle.Make + " " + newVehicle.Model);
                this.mf.AddItemToFile(newVehicle.PrintInfo());
                MessageBox.Show("Entry added succesfully.");

            }

           
        }
    }
}
