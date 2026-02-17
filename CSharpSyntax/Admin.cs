using System.Net.WebSockets;
using System.Xml.Schema;

namespace Week1TestClass.CSharpSyntax
{
    public static class Admin
    {
        public static List<object> InnerJoin(List<User> users, List<Car> cars)
        {
            //var newCollection = GetHighMileageElectricCars(cars);
            var innerJoin = from user in users
                            join car in cars on user.Id equals car.UserId
                            select new { UserName = $"{user.FirstName} {user.LastName}", CarModel = car.Model, CarFuelType = car.FuelType };
            return innerJoin.ToList<object>();
        }

        public static List<object> LeftJoin(List<User> users, List<Car> cars)
        {
            var leftJoin = from user in users.Where(u => u != null)
                           join car in cars.Where(c => c != null) on user.Id equals car.UserId into userCars
                           from car in userCars.DefaultIfEmpty()
                           select new { UserName = $"{user.FirstName} {user.LastName}", CarModel = car?.Model, CarFuelType = car?.FuelType };
            return leftJoin.ToList<object>();
        }

        // TODO: Implement the right join and full outer join methods here
        public static List<object> RightJoin(List<User> users, List<Car> cars)
        {
            var rightJoin = from car in cars
                            where car != null
                            join user in users.Where(u => u != null) on car.UserId equals user.Id into carUsers
                            from user in carUsers.DefaultIfEmpty()
                            select new { UserName = user != null ? $"{user.FirstName} {user.LastName}" : (string?)null, CarModel = car.Model, CarFuelType = (Car.FuelTypes?)car.FuelType };
            return rightJoin.ToList<object>();
        }

        public static List<object> FullOuterJoin(List<User> users, List<Car> cars)
        {
            var leftJoin = from user in users
                           where user != null
                           join car in cars.Where(c => c != null) on user.Id equals car.UserId into userCars
                           from car in userCars.DefaultIfEmpty()
                           select new { UserName = $"{user.FirstName} {user.LastName}", CarModel = car?.Model, CarFuelType = car?.FuelType };

            var rightJoin = from car in cars
                            where car != null
                            join user in users.Where(u => u != null) on car.UserId equals user.Id into carUsers
                            from user in carUsers.DefaultIfEmpty()
                            where user == null
                            select new { UserName = (string?)null, CarModel = car.Model, CarFuelType = (Car.FuelTypes?)car.FuelType };

            var result = new List<object>();
            result.AddRange(leftJoin);
            result.AddRange(rightJoin);
            return result;
        }


        public static List<object> Group(List<Car> cars)
        {
            var groupResult = from car in cars.Where(c => c != null)
                              group car by car.UserId into g  // The g here is a grouping of cars that share the same UserId, which means they belong to the same user.
                              select new
                              {
                                  UserId = g.Key, // Hence the key of the group is the UserId, which is the common attribute that we are grouping by.
                                  SumTotalMileage = g.Sum(car => car.MileageOnReport),
                                  OurListOfCars = (from car in g
                                                   where car.FuelType != Car.FuelTypes.Petrol
                                                   select new { car.Model, car.FuelType }).ToList(), // This will create a list of anonymous objects containing the Model and FuelType of each car in the group.
                                  //Cars = g.Select(car => new { car.Model, car.FuelType }).ToList(),
                                  CarCount = g.Count()
                              };

            //groupResult.ToList

            groupResult.ToList().ForEach(item =>
            {
                Console.WriteLine($"UserId: {item.UserId}, SumTotalMileage: {item.SumTotalMileage}, CarCount: {item.CarCount}");
                foreach (var car in item.OurListOfCars)
                {
                    Console.WriteLine($"    Car Model: {car.Model}, Fuel Type: {car.FuelType}");
                }
            });

            return groupResult.ToList<object>();
        }

        public static List<Car> BadQuery(List<Car> cars)
        {
            var badQueryResult = from car in cars
                                 where car.MileageOnReport > 100000 && car.FuelType == Car.FuelTypes.Electric
                                 select car;
            return badQueryResult.ToList();
        }

        // Writing an optimal version of the above query using method syntax

        public static List<Car> OptimalQuery(List<Car> cars)
        {
            var optimalQueryResult = cars.Where(car => car.MileageOnReport > 100000 && car.FuelType == Car.FuelTypes.Electric).ToList();
            return optimalQueryResult;
        }

        public static IEnumerable<Car> GetHighMileageElectricCars(List<Car> cars)
        {
            return cars.Where(car => car.MileageOnReport > 100000 && car.FuelType == Car.FuelTypes.Electric);
        }
    }
}