using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var familyCar = new FamilyCar(2019, "BNW", 240, "Guy Lin", 1998);
            familyCar.PrintCar();
        }
    }

    internal class FamilyCar : Car //collapse hierarchy
    {
        public void PrintCar()
        {
            Console.WriteLine($"Owner : {Owner}");

            // print CarDetail
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"MaxVelocity : {MaxVelocity}");
            Console.WriteLine($"Years : {Years}");
        }

        public FamilyCar(int years, string brand, int maxVelocity, string owner, int productionTime) : base(years, brand, maxVelocity, owner, productionTime)
        {
        }
    }

    internal class Car
    {
        public int Years { get; set; }
        public string Brand { get; set; }
        public int MaxVelocity { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; } // unused field
        public int ProductionTime { get; set; }

        public Car(int years, string brand, int maxVelocity, string owner, int productionTime)
        {
            Years = years - ProductionTime;
            Brand = brand;
            MaxVelocity = maxVelocity;
            Owner = owner;
        }

        public string ToXML()
        {
            var xml = $"<Years>{Years}</Years>" +
                    $"<Brand>{Brand}</Brand>" +
                    $"<Owner>{Owner}</Owner>";
            return xml;
        }
    }
}