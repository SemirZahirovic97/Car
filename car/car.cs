using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class car
    {
        public string Manufacturer;
        public string CarColor;
                public int ModelYear;
        public int HorsePower;
        public int Gears;
        public bool EngineOn;
        public int MaxSpeed;

        public void ShowInfo()
        {
            Console.WriteLine($"Car Info: {Manufacturer}, {CarColor}, {ModelYear}, {HorsePower}");
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}
