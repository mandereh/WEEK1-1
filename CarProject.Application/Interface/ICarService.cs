using CarProject.Application.Dtos.Responses;
using CarProject.Application.Implementation;
using CarProject.Application.Utility;
using CarProject.Domain.Entities;

namespace CarProject.Application.Interface
{
    public interface ICarService
    {
        public ResponseModel<CarResponseDto> CreateCar(CreateCarDto createCarDto);
        public ResponseModel<List<CarResponseDto>> GetAllCars();
        public void Start();
        public void Stop(Car car);
        public void Drive();
        public void Drive(string mode);
        public void Drive(string mode, string offset);
        public bool ActivateSystemControl(Car car, string direction);
        
    }
}