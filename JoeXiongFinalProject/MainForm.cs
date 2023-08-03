/* Joe Xiong - Professor Luscomb Section 390 CSYS 2613 C# Programming
 * Car Oil and Filter Maintence Log
 * --This program allows user to add new vehicles to the log.
 * They can also edit entries should mistakes be made.
 * They can also delete entries should they no longer have the vehicle.
 * Next Maintenance displays mileage and date for both oil and oil filter change.
 **/
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JoeXiongFinalProject
{
    public partial class MainForm : Form
    {
        // Global variables.
        List<Vehicle> vehicles = new List<Vehicle>();
        StreamWriter outputFile;
        StreamReader inputFile;

        public MainForm()
        {
            InitializeComponent();         
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form.

            
            this.Close();
        }

        public void newEntryButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();    // Creates new instance of Vehicle.
            NewEntryForm newEntry = new NewEntryForm(vehicle,this); // Creates new instance of New Vehicle Entry

            newEntry.ShowDialog(); // Shows New Vehicle Entry form.

            vehicles.Add(vehicle);
                    
        }

        public void AddItemToFile(string text) {

            // Add items to file.
            outputFile = File.AppendText("CarInfo.txt");
            outputFile.WriteLine(text);
            outputFile.Flush();
            outputFile.Close();
           
        }

        public void AddItemToList(string text)
        {
            // Adds item to ListBox
            vehicleListBox.Items.Add(text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load file information into list box
            if (File.Exists("CarInfo.txt"))
            {
                inputFile = File.OpenText("CarInfo.txt");
                
                char[] delim = { ',' };
                string line;
                string[] input;



                while (!inputFile.EndOfStream)
                {
                    Vehicle newCar = new Vehicle();
                    line = inputFile.ReadLine();
                    input = line.Split(delim);

                    newCar.Make = input[0];
                    newCar.Model = input[1];
                    long.TryParse(input[2], out long carMileage);
                    newCar.Mileage = carMileage;
                    int.TryParse(input[3], out int carYear);
                    newCar.Year = carYear;

                    newCar.oilType = input[4];
                    bool.TryParse(input[5], out bool oilChanged);
                    newCar.oilChange = oilChanged;
                    bool.TryParse(input[6], out bool filterChanged);
                    newCar.filterChanged = filterChanged;

                    DateTime date, prevDate;

                    DateTime.TryParse(input[7], out date);
                    newCar.dateEntered = date.ToShortDateString();
                                  
                    DateTime.TryParse(input[8], out prevDate);
                    newCar.previousDateEntered = prevDate.ToShortDateString();
                                   
                    long.TryParse(input[9], out long prevMile);
                    newCar.prevMilage = prevMile;

                    DateTime.TryParse(input[10], out date);
                    newCar.oilChangeDate = date.ToShortDateString();

                    DateTime.TryParse(input[11], out prevDate);
                    newCar.prevOilChangeDate = prevDate.ToShortDateString();

                    DateTime.TryParse(input[12], out date);
                    newCar.filterChangeDate = date.ToShortDateString();

                    DateTime.TryParse(input[13], out prevDate);
                    newCar.prevFilterChangeDate = prevDate.ToShortDateString();

                    

                    vehicles.Add(newCar);                   
                  
                    vehicleListBox.Items.Add(newCar.Make+ " " + newCar.Model);                 

                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("No CarInfo.txt detected. Creating a new file.");
                
            }

            updateVehicle.Enabled = false;
            deleteVehicle.Enabled = false;
            showStatus.Enabled = false;


        }

        private void deleteVehicle_Click(object sender, EventArgs e)
        {
            int selectedCar = vehicleListBox.SelectedIndex; // selected car index in listbox

                vehicles.RemoveAt(selectedCar); // Removes vehicle info string from vehicle List.              
                vehicleListBox.Items.RemoveAt(selectedCar); // removes vehicle from listbox

                string[] newList = new string[vehicles.Count()]; // declare new list with size of vehicle count

                for (int i = 0; i < vehicles.Count(); i++)
                {
                    string info = vehicles[i].PrintInfo();  // convert every item in vehicles list to a string
                    newList[i] = info;  // and store it in newList string array
                }
                File.WriteAllLines("CarInfo.txt", newList); // overwrites all lines with new information from newList.
          
        }

        private void updateVehicle_Click(object sender, EventArgs e)
        {
            int selectedCar = vehicleListBox.SelectedIndex;
 
    
                Vehicle vehicle = new Vehicle(); // Create new vehicle
                vehicle = vehicles[selectedCar];
                EditForm editCar = new EditForm(vehicle, this, selectedCar);

                editCar.ShowDialog();

                vehicles[selectedCar] = vehicle;
                UpdateItemToFile();           

        }

        public void UpdateItemToFile() {
            string[] newList = new string[vehicles.Count()]; // declare new list with size of vehicle count

            for (int i = 0; i < vehicles.Count(); i++)
            {
                string info = vehicles[i].PrintInfo();  // convert every item in vehicles list to a string
                newList[i] = info;  // and store it in newList string array
            }
            File.WriteAllLines("CarInfo.txt", newList); // overwrites all lines with new information from newList.


        }

        public void UpdateItemToList(string make, string model, int selectedCar)
        {
            vehicleListBox.Items.RemoveAt(selectedCar);
            string info = make + " " + model;
            vehicleListBox.Items.Insert(selectedCar, info);
            
        }

        private void showStatus_Click(object sender, EventArgs e)
        {
            int selectedVehicle = vehicleListBox.SelectedIndex;

                Vehicle maintVehicle = new Vehicle();
                maintVehicle = vehicles[selectedVehicle];

                Status maint = new Status(maintVehicle);

                maint.ShowDialog();          

        }

        private void vehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleListBox.SelectedIndex >= 0) {
                updateVehicle.Enabled = true;
                deleteVehicle.Enabled = true;
                showStatus.Enabled = true;
            }
            else
            {
                updateVehicle.Enabled = false;
                deleteVehicle.Enabled = false;
                showStatus.Enabled = false;
            }
        }
    }
}
