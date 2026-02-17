using CarProject.Application.Interface;
using CarProject.Domain.Entities;

namespace CarProject.Application.Implementation
{
    public class UserService : IUserService
    {
        public List<User> GetAdultUsers(List<User> users)
        {
            var adultUsers = from user in users
                             where user.Age >= 18
                             select user;

            return adultUsers.ToList();
        }
    }
}