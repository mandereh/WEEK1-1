using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1TestClass.CSharpSyntax
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Occupation Occupation { get; set; }
        public Car? Car { get; set; }
        public UserAddress? Address  { get; set; }


        public User(Gender gender, Occupation occupation, string firstName, string lastName, DateTime dateOfBirth, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Occupation = occupation;
            DateOfBirth = dateOfBirth;
        }

        public User() {}

                // Demonstrating LINQ
        public List<User> GetAdultUsers(List<User> users)
        {
            var adultUsers = from user in users
                             where user.Age >= 18
                             select user;

            // Demonstrating the check without LINQ
            // List<User> adultUsersWithoutLinq = new List<User>();
            // foreach (var user in users)
            // {
            //     if (user.Age >= 18)
            //     {
            //         adultUsersWithoutLinq.Add(user);
            //     }
            // }

            // return adultUsersWithoutLinq;

            return adultUsers.ToList();
        }
    }

    public struct UserAddress
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
    }


    public record UserDto(string FirstName, string LastName, DateTime dateOfBirth, int Age);

    public enum Gender
    {
        Male,
        Female
    }

    public enum Occupation
    {
        Student,
        Engineer,
        Teacher,
        Doctor,
        Artist
    }
}