using System.Xml.Schema;

namespace Week1TestClass.CSharpSyntax
{
    public static class Admin
    {
        public static List<object> InnerJoin(List<User> users, List<Car> cars)
        {
            var innerJoin  = from user in users
                             join car in cars on user.Id equals car.UserId
                             select new { UserName = $"{user.FirstName} {user.LastName}", CarModel = car.Model, CarFuelType = car.FuelType };
            return innerJoin.ToList<object>();
        }

        public static List<object> LeftJoin(List<User> users, List<Car> cars)
        {
            var leftJoin = from user in users
                           join car in cars on user.Id equals car.UserId into userCars
                           from car in userCars.DefaultIfEmpty()
                           select new { UserName = $"{user.FirstName} {user.LastName}", CarModel = car?.Model, CarFuelType = car?.FuelType };
            return leftJoin.ToList<object>();
        }

        // TODO: Implement the right join and full outer join methods here


        public static List<object> Group(List<Car> cars)
        {
            var groupResult = from car in cars
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
    }
}