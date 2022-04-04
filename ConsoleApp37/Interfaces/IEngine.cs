using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37.Interfaces
{
    interface  IEngine
    {
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrenOil { get; set; }
        public string fuelType { get; set; }
        

        public double RemainOilAmount(double tanksize, double currenoil)
        {
            return TankSize - CurrenOil;
        }

    }
}
