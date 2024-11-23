using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Enums;

namespace Vehicle_OOP.Entities
{
    public class Car<T> : FourWheeler<T>
    {
        int numberOfSeat;
        int numberOfDoor;


        public Car(string modelNo, int yearMake, int enginCapacityInCC, int numberOfGear, VehicleType type, int numberOfSeat, int numberOfDoor) : base(modelNo, yearMake, enginCapacityInCC, numberOfGear, type)
        {
            this.NumberOfSeat = numberOfSeat;
            this.NumberOfDoor = numberOfDoor;
        }

        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor = value; }
        public override void GetDetails()
        {
            Console.WriteLine($"1.ModelNo:{ModelNo}\n2.Year Make:{YearMake}\n3.EngineCatacity ii CC:{EnginCapacityInCC}\n4.Number of Gear:{NumberOfGear}\n5.Vehicle Type:{Type}\n6.Number of Seat:{NumberOfSeat}\n7.Number of Door:{NumberOfDoor}");
        }
        public override void GetDesign()
        {
            Console.WriteLine("Very good Car Design");
        }
    }
}
