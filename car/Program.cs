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
            myCar.MaxSpeed = 240;

           

            car mclaren = new car();
            mclaren.Manufacturer = "McLaren";
            mclaren.CarColor = "Orange";
            mclaren.ModelYear = 2023;
            mclaren.HorsePower = 800;
            mclaren.Gears = 7;
            mclaren.EngineOn = true;
            mclaren.MaxSpeed = 350;

            car fiat = new car();
            fiat.Manufacturer = "Fiat";
            fiat.CarColor = "White";
            fiat.ModelYear = 2018;
            fiat.HorsePower = 120;
            fiat.Gears = 5;
            fiat.EngineOn = false;
            fiat.MaxSpeed = 180;

            mclaren.ShowInfo();
            mclaren.Drive();

            fiat.ShowInfo();
            fiat.Drive();


        }
    }
}
