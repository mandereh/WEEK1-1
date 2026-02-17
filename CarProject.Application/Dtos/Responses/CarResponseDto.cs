using CarProject.Application.Implementation;

namespace CarProject.Application.Dtos.Responses
{
    public class CarResponseDto
    {
        public string Model { get; set; }
        public int FuelLiter { get; set; }
        public string FuelType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public CarDimensionsDto CarDimentions { get; set; }
    }
}