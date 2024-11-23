using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Enums;
using Vehicle_OOP.Interfaces;

namespace Vehicle_OOP.Entities
{
    public class TwoWheeler<T> : Vehicle, IEnteriorDesign<T> where T : Vehicle
    {
        public TwoWheeler(string modelNo, int yearMake, int enginCapacityInCC, int numberOfGear, VehicleType type) : base(modelNo, yearMake, enginCapacityInCC, numberOfGear, type)
        {
        }

        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int EnginCapacityInCC { get; set; }
        public override int NumberOfGear { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Abstrauct method overriden in two wheeler");
        }

        public string[] GetExteriorDesign<T>(string data) where T : Vehicle
        {
            string[] design = data.Split(',');
            return design;
        }

        public virtual void Start()
        {
            Console.WriteLine("Virtual Method in two wheeler");
        }
        public virtual void Cooling(string cool = "Autometic System generator")
        {
            Console.WriteLine($"Cooling{cool}");
        }


    }
}
