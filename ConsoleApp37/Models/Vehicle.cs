using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37.Models
{
    public abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public  double DrivePath { get; set; }

        public abstract double AverageSpeed(double drivetime, double drivepath);
        
    }
}
