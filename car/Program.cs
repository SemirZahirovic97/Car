namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Manufacturer = "Volvo";
            myCar.CarColor = "Red";
            myCar.ModelYear = 2020;
            myCar.HorsePower = 250;
            myCar.Gears = 6;
            myCar.EngineOn = true;

            Console.WriteLine($"Brand: {myCar.Manufacturer}");
            Console.WriteLine($"Color: {myCar.CarColor}");
            Console.WriteLine($"Year: {myCar.ModelYear}");
            Console.WriteLine($"HorsePower: {myCar.HorsePower}");
            Console.WriteLine($"Gears: {myCar.Gears}");
            Console.WriteLine($"Engine On: {myCar.EngineOn}");
            Console.ReadLine();

        }
    }
}
