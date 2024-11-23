using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Enums;

namespace Vehicle_OOP.Entities
{
    public class Motorcycle<T> : TwoWheeler<T> where T : Vehicle
    {
        double maxPowerBPH;
        double maxTorqueNM;
        int milageKMPL;
        string forntBrake;
        string rearBrake;
        public Motorcycle(string modelNo, int yearMake, int enginCapacityInCC, int numberOfGear, VehicleType type, double maxPowerBPH, double maxTorqueNM, int milageKMPL, string forntBrake, string rearBrake) : base(modelNo, yearMake, enginCapacityInCC, numberOfGear, type)
        {

            this.MaxPowerBPH = maxPowerBPH;
            this.MaxTorqueNM = maxTorqueNM;
            this.MilageKMPL = milageKMPL;
            this.ForntBrake = forntBrake;
            this.RearBrake = rearBrake;

        }

        public double MaxPowerBPH { get => maxPowerBPH; set => maxPowerBPH = value; }
        public double MaxTorqueNM { get => maxTorqueNM; set => maxTorqueNM = value; }
        public int MilageKMPL { get => milageKMPL; set => milageKMPL = value; }
        public string ForntBrake { get => forntBrake; set => forntBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake = value; }

        public override void Cooling(string cool = "Autometic System generator")
        {
            base.Cooling(cool);
        }
        public override void GetDetails()
        {

            Console.WriteLine($"1.ModelNo:{ModelNo}\n2.Year Make:{YearMake}\n3.EngineCatacity in CC:{EnginCapacityInCC}\n4.Number of Gear:{NumberOfGear}\n5.Vehicle Type:{Type}\n6.MaxPowerBPH:{maxPowerBPH}\n7.MaxTorqueNM:{MaxTorqueNM}\n8. MilageKMPL:{milageKMPL}\n9.Fornt Brake:{forntBrake}\n10.Rear brake:{rearBrake}");
        }
        public override void Start()
        {
            Console.WriteLine("Brhum...............");
        }
    }
}
