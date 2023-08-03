using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeXiongFinalProject
{
    public class Vehicle
    {

        // Default Constructor
        public Vehicle()
        {
            Make = "";
            Model = "";
            Mileage = 0;
            prevMilage = 0;
            Year = 0;
            oilChange = false;
            oilChangeMiles = 0;
            oilChangeDate = "";
            prevOilChangeDate = "";
            filterChangeDate = "";
            prevFilterChangeDate = "";
            filterChangeMiles = 0;
            filterChanged = false;
            oilType = "";
            dateEntered = "";
            previousDateEntered = "";
            nextDate = "";




        }

        // Getter and Setter for properties.
        public string Make { get; set; }
        public string Model { get; set; }
        public long Mileage { get; set; }
        public long prevMilage { get; set; }
        public int Year { get; set; }

        public bool oilChange { get; set; }
        public int oilChangeMiles { get; set; }
        public string oilChangeDate { get; set; }
        public string prevOilChangeDate { get; set; }

        public string prevFilterChangeDate { get; set; }
        public string filterChangeDate { get; set; }
        public int filterChangeMiles { get; set; }
        public string oilType { get; set; }
        public bool filterChanged { get; set; }

        public string dateEntered { get; set; }
        public string previousDateEntered { get; set; }
        public string nextDate { get; set; }

        public string PrintInfo()
        {

            return Make + "," + Model + "," + Mileage + ","
            + Year + "," + oilType + "," + oilChange + ","
            + filterChanged + "," + dateEntered + "," + previousDateEntered + ","
            + prevMilage + "," + oilChangeDate + "," + prevOilChangeDate +
            "," + filterChangeDate + "," + prevFilterChangeDate + ",";
        }


        // Checks milage and compares with old milage if > 3k need oil change.
        public bool NeedOilChange(long Mileage)
        {
            this.Mileage = Mileage;

            if (this.Mileage >= (Mileage + 3000))
            {
                return true;
            }
            return false;

        }

        // Check when oil filter last changed if false set filterChangeMiles to 6k after current milage.
        public long OilFilter(long Mileage)
        {
            this.Mileage = Mileage;
            this.filterChanged = filterChanged;

            if (this.filterChanged == false)
            {
                this.Mileage += 6000;
            }

            return this.Mileage;
        }

    }
}



