using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp37.Interfaces;
namespace ConsoleApp37.Models
{
     class Car : Vehicle, ITransmission, IEngine,IWheel
    {
        public int DoorCount { get; set; }
        public string VinCode { get; set; }
        public string TransmissionKind { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get ; set ; }
        public double CurrenOil { get ; set ; }
        public string fuelType { get ; set ; }
        public double WheelThickness { get; set ; }
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
