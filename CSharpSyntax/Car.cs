using Week1TestClass.CSharpSyntax.Interfaces;

namespace Week1TestClass.CSharpSyntax
{
    public partial class Car : SedanSUV, ICar
    {
        public FuelTypes FuelType { get; set; }
        public int FuelLiter { get; set; } //Integer (Primitive data type)
        public string Model { get; set; }
        // Take the Mileage as example of encapsulation
        private int Mileage { get; set; } = 0; //Integer (Primitive data type)
        public int MileageOnReport
        {
            get
            {
                return Mileage;
            }
            private set
            {
                Mileage = value;
            }
        }
        public int DistanceTraveled { get; set; } //Integer (Primitive data type)
        public double AverageFuelConsumption { get; set; } // Double (Primitive data type)
        public CarDimensions Dimensions { get; set; } // Struct
        public int UserId { get; set; } // Foreign key to User for storing the id of the owner
        public FuelTypes ChangeFfuel
        {
            get
            {
                return FuelType;
            }
            set
            {
                FuelType = value;
            }
        }

        public Car(FuelTypes fuelType,
                   int fuelLiter,
                   FuelTypes changeFfuel,
                   string model,
                   DateTime manufactureDate,
                   CarDimensions carDimentions)
        {
            FuelType = fuelType;
            FuelLiter = fuelLiter;
            ChangeFfuel = changeFfuel;
            ManufactureDate = manufactureDate;
            Model = model;
            Dimensions = carDimentions;
        }

        public Car() {}

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

        public void Drive(string mode) // Method
        {
            Console.WriteLine($"The car is {mode} driving.");
        }

        public void Drive(string mode, string offset) // Method
        {
            Console.WriteLine($"The car is {mode} driving.");
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
            if (!string.IsNullOrEmpty(FuelType.ToString()))
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
                Mileage += (int)mileage; // Explicit typecasting

                //Mileage = Mileage / 0; // This will cause an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetAverageFuelConsuptionAndDistance(double averageFuelConsumption, int distanceTraveled)
        {
            AverageFuelConsumption = averageFuelConsumption;
            DistanceTraveled = distanceTraveled;
        }

        public void Purchase(User user)
        {
            UserId = user.Id; // This is just to demonstrate the use of parameter in struct, it does not have any real functionality
            Console.WriteLine($"The car is purchased by {user.FirstName} {user.LastName}");
        }

        // Aruguments and parameters aka Signature or inputs 

        // Demonstrating Enums 
        public enum FuelTypes
        {
            Petrol,
            Diesel,
            Electric,
            Hybrid
        }
    }

    //Struct vs Class:
    // - Structs are value types and are stored on the stack, while classes are reference types and are stored on the heap.
    // - Structs do not support inheritance, while classes do.

    // Demonstrating Struct

    public struct CarDimensions
    {
        public double Length; // in meters
        public double Width;  // in meters
        public double Height; // in meters

        public CarDimensions(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public bool ActivateSystemControl(string direction)
        {
            throw new NotImplementedException();
        }

        public void CarReport(string beforeOrAfter)
        {
            throw new NotImplementedException();
        }

        public void DisplayDimensions()
        {
            Console.WriteLine($"Car Dimensions - Length: {Length}m, Width: {Width}m, Height: {Height}m");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Drive(string mode)
        {
            throw new NotImplementedException();
        }

        public void SetAverageFuelConsuptionAndDistance(double averageFuelConsumption, int distanceTraveled)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}