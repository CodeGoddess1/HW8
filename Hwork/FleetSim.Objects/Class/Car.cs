using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.InterFace;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Class; 

namespace FleetSim.Objects.Car
{
    public class Car : Vehicle, ICar
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public Car(int year, string make, string model,color myColor)
        {
            Year = year;
            Make = make;
            Model = model;
            this.myColor = myColor;
        }
        public override void ReBuildEngine()
        {
            base.ReBuildEngine();
            System.Console.WriteLine($"Engine rebuild on {LastServicedDate}{ Model}");
        }
    }
}
