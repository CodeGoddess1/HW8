using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Car;
using FleetSim.Objects.Enum;


namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Car> Cars = new Queue<Car>();


            Cars . Enqueue (new Car ( 1999, "VW", "Rabbit",color.red));
            Cars . Enqueue (new Car ( 2017, "Chevrolet", "Impala",color.blue));
            Cars . Enqueue (new Car ( 2000, "Audi", "A4",color.red));
            Cars . Enqueue (new Car ( 1991, "Ford", "Taurus",color.white));
            Cars . Enqueue (new Car ( 2016, "Cadillac", "Escalade",color.blue));

            for (int i = 0; i < 10; i++)
            {
                Random radm = new Random();
                foreach (Car car in Cars)
                {
                    car.Mileage += radm.Next(5000, 15000);
                    car.TuneUp();

                    System.Console.WriteLine($"{car.Make}   {car.Model}   {car.myColor}   {car.Year}   {car._VinNumber}");
                    System.Console.WriteLine();
                }
                



            }
            
            System.Console.WriteLine();
            System.Console.ReadLine();

        }
    }
}
