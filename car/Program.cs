namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Brand = "Volvo";
            myCar.Color = "Red";
            myCar.Year = 2020;
            myCar.HorsePower = 250;
            myCar.Gears = 6;
            myCar.EngineOn = true;

            Console.WriteLine($"Brand: {myCar.Brand}");
            Console.WriteLine($"Color: {myCar.Color}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"HorsePower: {myCar.HorsePower}");
            Console.WriteLine($"Gears: {myCar.Gears}");
            Console.WriteLine($"Engine On: {myCar.EngineOn}");
            Console.ReadLine();

        }
    }
}
