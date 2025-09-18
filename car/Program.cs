namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            car mclaren = new car();
            mclaren.Manufacturer = "McLaren";
            mclaren.Color = "Orange";
            mclaren.ModelYear = 2023;
            mclaren.HorsePower = 800;
            mclaren.Gears = 7;
            mclaren.EngineOn = true;
            mclaren.MaxSpeed = 350;
            mclaren.Type = car.CarType.Gasoline; 

            car fiat = new car();
            fiat.Manufacturer = "Fiat";
            fiat.Color = "White";
            fiat.ModelYear = 2018;
            fiat.HorsePower = 120;
            fiat.Gears = 5;
            fiat.EngineOn = false;
            fiat.MaxSpeed = 180;
            fiat.Type = car.CarType.Diesel;

            mclaren.ShowInfo();
            mclaren.Drive();
            mclaren.Honk();
            mclaren.Fuel();

            fiat.ShowInfo();
            fiat.Drive();
            fiat.Honk();
            fiat.Fuel();

            fiat.IsFasterThan(otherCar: mclaren);

        }
    }
}
