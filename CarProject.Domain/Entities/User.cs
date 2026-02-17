using CarProject.Domain.Structs;
using static CarProject.Domain.Enums.DomainEnums;

namespace CarProject.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Occupation Occupation { get; set; }
        public List<Car>? Cars { get; set; } // Then it simply denotes that he has the capability to own multiple cars.
        public UserAddress? Address { get; set; }


        public User(int id, Gender gender, Occupation occupation, string firstName, string lastName, DateTime dateOfBirth, int age = 0)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Occupation = occupation;
            DateOfBirth = dateOfBirth;
        }

        public User() { }
    }
}