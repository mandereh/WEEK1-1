using static CarProject.Domain.Enums.DomainEnums;

namespace CarProject.Application.Implementation
{
    public class CreateCarDto
    {
        public FuelTypes FuelType { get; set; }
        public int FuelLiter { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public CarDimensionsDto CarDimentions { get; set; }
    }

    // DTO used for full updates (PUT)
    public class UpdateCarDto
    {
        public FuelTypes FuelType { get; set; }
        public int FuelLiter { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public CarDimensionsDto CarDimentions { get; set; }
    }

    // DTO used for patching only the fuel level
    public class UpdateCarFuelDto
    {
        public int FuelLiter { get; set; }
    }

    public record CarDimensionsDto(double Length, double Width, double Height);
}