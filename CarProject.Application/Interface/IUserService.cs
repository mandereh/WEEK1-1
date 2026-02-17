using CarProject.Domain.Entities;

namespace CarProject.Application.Interface
{
    public interface IUserService
    {
         public List<User> GetAdultUsers(List<User> users);
    }
}