using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Enums;
using Vehicle_OOP.Interfaces;

namespace Vehicle_OOP.Entities
{
    public class FourWheeler<T> : Vehicle, IInteriorDesign<T>
    {
        public FourWheeler(string modelNo, int yearMake, int enginCapacityInCC, int numberOfGear, VehicleType type) : base(modelNo, yearMake, enginCapacityInCC, numberOfGear, type)
        {

        }

        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int EnginCapacityInCC { get; set; }
        public override int NumberOfGear { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Abstrauct method overriden in four wheeler");
        }
        public virtual void GetDesign()
        {
            Console.WriteLine("Virtual Method");
        }

        public string[] GetInteriorDesign<T>(string data)
        {
            string[] design = data.Split(',');
            return design;
        }
    }
}
