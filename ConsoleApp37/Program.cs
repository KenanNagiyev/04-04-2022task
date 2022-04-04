using System;
using System.Reflection;
using ConsoleApp37.Models;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Bicycle b = new Bicycle();
            Plane p = new Plane();
            #region RemainOilAmount
            Console.WriteLine("Avtomobilin yag tutumunu daxil edin:");
            c.TankSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Avtomobilin cari yagini daxil edin:");
            c.CurrenOil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Avtomobilin yag tutumunun tam dolmasi ucun lazim olan yag:");
            Console.WriteLine(c.RemainOilAmount(5, 2));
            Console.WriteLine("------------");
            Console.WriteLine("Teyyarenin yag tutumunu daxil edin:");
            p.TankSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Teyyarenin cari yagini daxil edin:");
            p.CurrenOil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Teyyarenin yag tutumunun tam dolmasi ucun lazim olan yag:");
            Console.WriteLine(p.RemainOilAmount(5, 2));
            Console.WriteLine("-------------");
            #endregion
            #region AvarageSpeed
            Console.WriteLine("Avtomobilin getdiyi yolu daxil edin:");
            c.DrivePath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Avtomobilin getdiyi vaxti daxil edin:");
            c.DriveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("avtomobilin orta sureti");
            Console.WriteLine(c.AverageSpeed(450, 6));
            Console.WriteLine("--------------------");
            Console.WriteLine("Velosipedin getdiyi yolu daxil edin:");
            b.DrivePath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Velosipedin getdiyi vaxti daxil edin:");
            b.DriveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Velosipedin orta sureti");
            Console.WriteLine(b.AverageSpeed(10, 1));
            Console.WriteLine("-------------------");
            Console.WriteLine("Teyyarenin getdiyi yolu daxil edin:");
            p.DrivePath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Teyyarenin getdiyi vaxti daxil edin:");
            p.DriveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("teyyarenin orta sureti");
            Console.WriteLine(p.AverageSpeed(1000, 10));
            Console.WriteLine("----------------");
            #endregion
            #region reflection
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (var item in assembly.GetTypes()) 
            {
                foreach (var i in item.GetMembers())
                {
                    Console.WriteLine(i);
                }
            }
            #endregion


        }
    }
}
