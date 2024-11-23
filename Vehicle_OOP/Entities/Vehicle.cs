using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Enums;

namespace Vehicle_OOP.Entities
{
    public abstract class Vehicle
    {
        string modelNo;
        int yearMake;
        int enginCapacityInCC;
        int numberOfGear;
        VehicleType type;

        protected Vehicle(string modelNo, int yearMake, int enginCapacityInCC, int numberOfGear, VehicleType type)
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            EnginCapacityInCC = enginCapacityInCC;
            NumberOfGear = numberOfGear;
            Type = type;
        }

        public abstract string ModelNo { get; set; }
        public abstract int YearMake { get; set; }
        public abstract int EnginCapacityInCC { get; set; }
        public abstract int NumberOfGear { get; set; }
        public abstract VehicleType Type { get; set; }
        public abstract void GetDetails();
    }
}
