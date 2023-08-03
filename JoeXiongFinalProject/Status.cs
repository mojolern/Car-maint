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
    public partial class Status : Form
    {
        internal Vehicle statVehicle { get; set; } 

        public Status()
        {
            InitializeComponent();
        }

        public Status(Vehicle vehicle) {
            InitializeComponent();
            statVehicle = vehicle;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            // change oil after 3k miles
            long carMileChange = statVehicle.Mileage + 3000;
            carMileageTxtLabel.Text = carMileChange.ToString();

            // 3 months after date entered change oil 
            DateTime oilChange;
            DateTime.TryParse(statVehicle.dateEntered, out oilChange);
            TimeSpan oilDate = new TimeSpan(90, 0, 0, 0);

            
            
            if (oilChange.ToString() == "1/1/0001 12:00:00 AM" || oilChange.ToString() == "")
            {
                carOilChangeDateTxtLabel.Text = "N/A";
            }
            else
            {
                oilChange = oilChange.Add(oilDate);
                carOilChangeDateTxtLabel.Text = oilChange.ToString();
            }
            

            // change oil filter after 6k miles
            long carFilterMileage = statVehicle.Mileage + 6000;
            carOilFilterChangeTxtLabel.Text = carFilterMileage.ToString();

            // 6 months after initial date change oil filter
            DateTime oilFilterChange;
            DateTime.TryParse(statVehicle.dateEntered, out oilFilterChange);
            TimeSpan oilFilChange = new TimeSpan(180, 0, 0, 0);

            

            // Checks for valid date for oilfilterchange

            if (oilFilterChange.ToString() == "1/1/0001 12:00:00 AM" || oilFilterChange.ToString() == "") {
                carOilFilterChangeDateTxtLabel.Text = "N/A";
            }
            else
            {
                oilFilterChange = oilFilterChange.Add(oilFilChange);
                carOilFilterChangeDateTxtLabel.Text = oilFilterChange.ToString();
            }
            
            // checks to make sure there is a valid date for the last oil change date and last oil filter change
            if (statVehicle.oilChange == true && statVehicle.oilChangeDate != "1/1/0001 12:00:00 AM")
            {
                lastOilChange.Text = statVehicle.oilChangeDate;
            }
            else if (statVehicle.prevOilChangeDate == "1/1/0001 12:00:00 AM" || statVehicle.oilChangeDate == "1/1/0001 12:00:00 AM" || statVehicle.oilChangeDate == "")
            {
                lastOilChange.Text = "N/A";
            }
            else
            {
                lastOilChange.Text = statVehicle.prevOilChangeDate;
            }

            // oil filter
            if (statVehicle.filterChanged == true && statVehicle.filterChangeDate != "1/1/0001 12:00:00 AM") {
                lastOilFilChange.Text = statVehicle.filterChangeDate;
            }
            else if (statVehicle.prevFilterChangeDate == "1/1/0001 12:00:00 AM" || statVehicle.filterChangeDate == "1/1/0001 12:00:00 AM" || statVehicle.filterChangeDate == "")
            {
                lastOilFilChange.Text = "N/A";   
            }
            else
            {
                lastOilFilChange.Text = statVehicle.prevFilterChangeDate;
            }


        }
    }
}
