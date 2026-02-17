using CarProject.Domain.Structs;
using static CarProject.Domain.Enums.DomainEnums;

namespace CarProject.Domain.Entities
{
    public partial class Car
    {
        public FuelTypes FuelType { get; set; }
        public int FuelLiter { get; set; } //Integer (Primitive data type)
        public string Model { get; set; }
        // Take the Mileage as example of encapsulation
        public int Mileage { get; set; } = 0; //Integer (Primitive data type)
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

        public Car() { }
    }
}