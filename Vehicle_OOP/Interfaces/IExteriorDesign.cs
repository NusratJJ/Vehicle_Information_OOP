using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_OOP.Entities;

namespace Vehicle_OOP.Interfaces
{
    public interface IEnteriorDesign<T> where T : Vehicle
    {
        string[] GetExteriorDesign<T>(string data) where T : Vehicle;
    }
}
