using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp37.Interfaces;

namespace ConsoleApp37.Models
{
    class Bicycle:Vehicle,IWheel
    {
        public string PedalKind { get; set; }
        public double WheelThickness { get ; set ; }

        public override double AverageSpeed(double drivetime, double drivepath)
        {
            return DrivePath / DriveTime;
        }
    }
}
