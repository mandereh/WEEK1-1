using CarProject.Application.Dtos.Responses;
using CarProject.Application.Interface;
using CarProject.Application.Utility;
using CarProject.Domain.Entities;
using CarProject.Domain.Structs;

namespace CarProject.Application.Implementation
{
    public class CarService : ICarService
    {
        public List<Car> CarStore = new List<Car>();
        public void Start() // Method
        {
            string message = "The car is staring";
            Console.WriteLine(message);
        }

        public void Stop(Car car) // Method
        {
            Console.WriteLine("The car is stopping.");
            CalculateMileage(car);
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
        public bool ActivateSystemControl(Car car, string direction)
        {
            if (!string.IsNullOrEmpty(car.FuelType.ToString()))
            {
                Console.WriteLine($"Here is the real value of fuel: {car.FuelType}, meaning the car can turn {direction}");
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

        public void CarReport(Car car, string beforeOrAfter) // Method
        {
            Console.WriteLine($"Test Drive Report {beforeOrAfter}\nFuel: {car.FuelType}, Fuel Liter: {car.FuelLiter}, Model: {car.Model}, Mileage: {car.MileageOnReport}, Manufacture Date: {car.ManufactureDate}");
        }

        private void CalculateMileage(Car car)
        {
            try // Code that might fail. There might be possible exceptions which we don not know,, yet we will like to controll or manage them.
            {
                var newLiter = car.FuelLiter - car.AverageFuelConsumption; // Implicit typecasting
                car.FuelLiter = (int)newLiter; // Explicit typecasting

                var mileage = car.DistanceTraveled + (int)car.AverageFuelConsumption; // Explicit typecasting
                car.Mileage += (int)mileage; // Explicit typecasting

                //Mileage = Mileage / 0; // This will cause an exception
            }
            catch (NullReferenceException ex) // This is how we catch the exception, and we can manage the exception in this block of code, for example, we can log the exception or return a default value.
            {
                Console.WriteLine($"An error occurred while calculating mileage: {ex.Message}");
                //Mileage = 0; // Set mileage to a default value in case of an error
            }
            finally
            {
                Console.WriteLine("This is the finally block, it will always be executed regardless of whether an exception is thrown or not.");
            }
        }

        public void SetAverageFuelConsuptionAndDistanceC(Car car, double averageFuelConsumption, int distanceTraveled)
        {
            car.AverageFuelConsumption = averageFuelConsumption;
            car.DistanceTraveled = distanceTraveled;
        }

        public void Purchase(User user, Car car)
        {
            car.UserId = user.Id; // This is just to demonstrate the use of parameter in struct, it does not have any real functionality
            Console.WriteLine($"The car is purchased by {user.FirstName} {user.LastName}");
        }

        public ResponseModel<CarResponseDto> CreateCar(CreateCarDto createCarDto)
        {
            var carItem = new Car
            {
                FuelType = createCarDto.FuelType,
                FuelLiter = createCarDto.FuelLiter,
                Model = createCarDto.Model,
                ManufactureDate = createCarDto.ManufactureDate,
                Dimensions = new CarDimensions(createCarDto.CarDimentions.Length, createCarDto.CarDimentions.Width, createCarDto.CarDimentions.Height)
            };

            PersistCar(carItem);

            var response = new ResponseModel<CarResponseDto>
            {
                IsSuccess = true,
                Message = "Car created successfully",
                Data = new CarResponseDto
                {
                    FuelType = carItem.FuelType.ToString(),
                    FuelLiter = carItem.FuelLiter,
                    Model = carItem.Model,
                    ManufactureDate = carItem.ManufactureDate,
                    CarDimentions = new CarDimensionsDto(carItem.Dimensions.Length, carItem.Dimensions.Width, carItem.Dimensions.Height)
                }
            };

            return response;


        }


        public void PersistCar(Car car)
        {
            CarStore.Add(car);
        }

        public ResponseModel<List<CarResponseDto>> GetAllCars()
        {
            var carItems = CarStore.Select(car => new CarResponseDto
            {
                FuelType = car.FuelType.ToString(),
                FuelLiter = car.FuelLiter,
                Model = car.Model,
                ManufactureDate = car.ManufactureDate,
                CarDimentions = new CarDimensionsDto(car.Dimensions.Length, car.Dimensions.Width, car.Dimensions.Height)
            }).ToList();

            return new ResponseModel<List<CarResponseDto>>
            {
                IsSuccess = true,
                Message = "Cars retrieved successfully",
                Data = carItems
            };
        }
    }
}