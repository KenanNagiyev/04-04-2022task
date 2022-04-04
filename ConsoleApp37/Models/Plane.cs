using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp37.Interfaces;
namespace ConsoleApp37.Models
{
    class Plane:Vehicle,ITransmission,IEngine
    {
        public double WingLength { get; set; }
        public string TransmissionKind { get; set ; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrenOil { get; set; }
        public string fuelType { get; set; }
        

        public override double AverageSpeed(double drivetime, double drivepath)
        {
            return DrivePath / DriveTime;
        }
        public double RemainOilAmount(double tanksize, double currenoil)
        {
            return TankSize - CurrenOil;
        }
    }
}
