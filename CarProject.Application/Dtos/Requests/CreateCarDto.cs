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

    public record CarDimensionsDto(double Length, double Width, double Height);
}