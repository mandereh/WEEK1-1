using CarProject.Domain.Entities;

namespace CarProject.Application.Interface
{
    public interface IAdminService
    {
        public List<object> InnerJoin(List<User> users, List<Car> cars);
        public List<object> LeftJoin(List<User> users, List<Car> cars);
        public List<object> Group(List<Car> cars);
        public List<Car> BadQuery(List<Car> cars);
        public List<Car> OptimalQuery(List<Car> cars);
        public IEnumerable<Car> GetHighMileageElectricCars(List<Car> cars);
        
    }
}