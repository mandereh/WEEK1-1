using System.Reflection.Metadata.Ecma335;

namespace Week1TestClass.CSharpSyntax
{
    public partial class Car
    {
        public string FuelType { get; set; }
        public int FuelLiter { get; set; } //Integer (Primitive data type)
        public string Model { get; set; }
        public int Mileage { get; set; } = 0; //Integer (Primitive data type)
        public int DistanceTraveled { get; set; } //Integer (Primitive data type)
        public double AverageFuelConsumption { get; set; } // Double (Primitive data type)
        public string ChangeFfuel
        {
            get
            {
                return FuelType;
            }
            set
            {
                FuelType = value.ToUpper();
            }
        }

        public Car(string fuelType, int fuelLiter, string changeFfuel, string model, DateTime manufactureDate)
        {
            FuelType = fuelType;
            FuelLiter = fuelLiter;
            ChangeFfuel = changeFfuel;
            ManufactureDate = manufactureDate;
            Model = model;
        }

        public void Start() // Method
        {
            string message = "The car is staring";
            Console.WriteLine(message);
        }

        public void Stop() // Method
        {
            Console.WriteLine("The car is stopping.");
            CalculateMileage();
        }

        public void Drive() // Method
        {
            Console.WriteLine("The car is driving.");
        }

        // public void TurnRight() // Method
        // {
        //     Console.WriteLine("The car is turning right.");
        // }

        // public void TurnLeft() // Method
        // {
        //     Console.WriteLine("The car is turning left.");
        // }

        // Boolean (Is also a primitive data type) it can be true or false
        public bool ActivateSystemControl(string direction)
        {
            if (!string.IsNullOrEmpty(FuelType))
            {
                Console.WriteLine($"Here is the real value of fuel: {FuelType}, meaning the car can turn {direction}");
                Turn(direction);
                return true;
            }
            else
            {
                Console.WriteLine("The car cannot turn due to no fuel.");
                return false;
            }
        }

        private void Turn(string direction) // Method with parameter
        {
            Console.WriteLine($"The car is turning {direction}");
        }

        public void CarReport(string beforeOrAfter) // Method
        {
            Console.WriteLine($"Test Drive Report {beforeOrAfter}\nFuel: {FuelType}, Fuel Liter: {FuelLiter}, Model: {Model}, Mileage: {Mileage}, Manufacture Date: {ManufactureDate}");
        }

        private void CalculateMileage()
        {
            try
            {
                var newLiter = FuelLiter - AverageFuelConsumption; // Implicit typecasting
                FuelLiter = (int)newLiter; // Explicit typecasting

                var mileage = DistanceTraveled + (int)AverageFuelConsumption; // Explicit typecasting
                Mileage = (int)mileage; // Explicit typecasting

                Mileage = Mileage / 0; // This will cause an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Aruguments and parameters aka Signature or inputs 
    }
}