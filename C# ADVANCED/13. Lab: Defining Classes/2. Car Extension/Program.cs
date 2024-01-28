using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }

    class Car
    {
        // Public properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        // Methods
        public void Drive(double distance)
        {
            if (FuelQuantity - distance / 100 * FuelConsumption > 0)
            {
                FuelQuantity -= distance / 100 * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return ($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}");
        }
    }
}
