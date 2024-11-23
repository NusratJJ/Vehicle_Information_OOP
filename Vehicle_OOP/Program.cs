using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Entities;
using Vehicle_OOP.Enums;

namespace Vehicle_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dotask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }
        }

        private static void Dotask()
        {
            PrintCarInfo();
            PrintMotorcyleInfo();
        }

        private static void PrintMotorcyleInfo()
        {
            Console.WriteLine("*****MotorCycle Info*********");
            Console.WriteLine("---------------------------");
            Motorcycle<Vehicle> cycle = new Motorcycle<Vehicle>("Honda", 2024, 200, 5, VehicleType.Personal, 150, 12, 60, "hard Brake", "Light Brake");
            cycle.GetDetails();
            Console.WriteLine();
            cycle.Start();
            Console.WriteLine();
            cycle.Cooling();
            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("IExterior design");
            string[] design = cycle.GetExteriorDesign<Vehicle>("Tissu-Box,Pillow,Airfresher");
            for (int i = 0; i < design.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + "," + design[i].Trim());
            }
        }

        private static void PrintCarInfo()
        {
            Console.WriteLine("******Car Info************");
            Console.WriteLine("--------------------------");
            Car<Vehicle> myCar = new Car<Vehicle>("BMW_X", 2024, 2000, 6, VehicleType.Personal, 4, 4);
            myCar.GetDetails();
            Console.WriteLine();
            myCar.GetDesign();
            Console.WriteLine();
            Console.WriteLine("----Interior Design----");
            Console.WriteLine("--------------------------");
            string[] design = myCar.GetInteriorDesign<Vehicle>("Tissu-Box,Pillow,Airfresher");
            for (int i = 0; i < design.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + "," + design[i].Trim());
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
