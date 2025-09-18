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
        public string Color;
        public int ModelYear;
        public int HorsePower;
        public int Gears;
        public bool EngineOn;
        public int MaxSpeed;

        internal enum CarType
        {
            Electric,
            Gasoline,
            Hybrid,
            Diesel
        }

        public CarType Type; // Add a field to store the car's type

        public void ShowInfo()
        {
            Console.WriteLine($"Car Info: {Manufacturer}, {Color}, {ModelYear}, {HorsePower}");
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }
        public void Fuel()
        {
            Console.WriteLine($"Car is of type: {Type}");
            switch (Type)
            {
                case CarType.Electric:
                    Console.WriteLine("Charging the electric car.");
                    break;
                case CarType.Gasoline:
                    Console.WriteLine("Refueling with gasoline.");
                    break;
                case CarType.Hybrid:
                    Console.WriteLine("Refueling the hybrid car.");
                    break;
                case CarType.Diesel:
                    Console.WriteLine("Refueling with diesel.");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }
        }
        public void IsFasterThan(car otherCar)
        {
            if (otherCar.MaxSpeed > MaxSpeed)
            {
                Console.WriteLine($"Car {otherCar.Manufacturer} is faster than {Manufacturer}");
            }
            else if (otherCar.MaxSpeed < MaxSpeed)
            {
                Console.WriteLine($"{Manufacturer} is faster than {otherCar.Manufacturer}");
            }
            else
            {
                Console.WriteLine($"{Manufacturer} and {otherCar.Manufacturer} have the same speed.");
            }
        }
    }
}
