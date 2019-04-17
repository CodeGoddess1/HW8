using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.InterFace;
using FleetSim.Objects.Enum;


namespace FleetSim.Objects.Class
{
    public class Vehicle : IVehicle
    {
        public string _VinNumber { get; set; }
        public int Mileage { get; set; }
        public Enum.color myColor { get; set; }
        public DateTime LastServicedDate { get; set; }
        public int LastServicedMileage { get; set; }



        public Vehicle()
        {
            _VinNumber = Guid.NewGuid().ToString();
            Mileage = 0;
            LastServicedDate = DateTime.Today;
            LastServicedMileage = 0;

        }
        public void TuneUp()
        {
            if (Mileage - LastServicedMileage >= 30000)
            {
                LastServicedDate = DateTime.Today;
                LastServicedMileage = Mileage;
                Console.WriteLine("Vehicle tuned up at" + LastServicedMileage, LastServicedDate);
            }
            if (Mileage >= 100000)
                ReBuildEngine();
        }


        virtual public void ReBuildEngine()
        {
            Mileage = 0;
            LastServicedMileage = 0;

        }
    }
}
