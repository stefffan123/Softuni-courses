using System;

namespace CarManufacturer
{
   
    class Car
    {
        // Private fields
        private string make;
        private string model;
        private int year;

        private double fuelQuantity;
        private double fuelConsumption;

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
