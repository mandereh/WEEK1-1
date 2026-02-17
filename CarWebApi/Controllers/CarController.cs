using CarProject.Application.Implementation;
using CarProject.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;
        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }


        [HttpPost("create-a-brand-new-car")]
        public IActionResult CreateBrandNewCar(CreateCarDto createCarDto)
        {
            var newCarResponse = _carService.CreateCar(createCarDto);

            return Ok(newCarResponse);
        }

        [HttpGet("get-all-cars")]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpPut("update-car/{index}")]
        public IActionResult UpdateCar(int index, UpdateCarDto updatedCarDto)
        {
            try
            {
                _carService.UpdateCar(index, updatedCarDto);
                return Ok("Car updated successfully.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPatch("update-car-fuel/{index}")]
        public IActionResult UpdateCarFuel(int index, [FromBody] UpdateCarFuelDto dto)
        {
            try
            {
                _carService.UpdateCarFuel(index, dto);
                return Ok("Car fuel updated successfully.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("delete-car/{index}")]
        public IActionResult DeleteCar(int index)
        {
            try
            {
                _carService.DeleteCar(index);
                return Ok("Car deleted successfully.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}