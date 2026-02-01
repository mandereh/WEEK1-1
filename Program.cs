using Week1TestClass.CSharpSyntax;
using Week1TestClass.ReferenceFolder;
using static Week1TestClass.CSharpSyntax.Car;

internal class Program
{
    private static void Main(string[] args)
    {
        var notes = new Notes();

        Submarine sedanSuv = new SedanSUV(); // On this right side, there is a part of Submarine class
        //SedanSUV sedanSUV = new Submarine(); // This line will cause a compile-time error.. Because ther is no part of SedanSUV on this part.
        sedanSuv.Dive();


        //var car = new Car(FuelTypes.Diesel, 50, FuelTypes.Petrol, "Sedan", new DateTime(2020, 1, 1), carDimensions);
        var car = new Car(FuelTypes.Diesel,
                          50,
                          FuelTypes.Petrol,
                          "Sedan",
                          new DateTime(2020, 1, 1),
                          new CarDimensions { Length = 4.5, Width = 1.8, Height = 1.4 });

        var listOfUsers = new List<User>();

        User user = new User();

        var user1 = new User(Gender.Male, Occupation.Engineer, "Samuel1,", "Shonekan", new DateTime(2012, 1, 1), 12);


        //var userRecordInstance = new UserDto("Jane", "Doe", 28);

        // Demonstrating Mappings 
        var transformedUser = new UserDto(user1.FirstName, user1.LastName, user1.DateOfBirth, user1.Age);

        var user2 = new User(Gender.Male, Occupation.Engineer, "Samuel2,", "Shonekan", new DateTime(2013, 1, 1), 13);
        var user3 = new User(Gender.Male, Occupation.Engineer, "Samuel3,", "Shonekan", new DateTime(2014, 1, 1), 14);
        var user4 = new User(Gender.Male, Occupation.Engineer, "Samuel4,", "Shonekan", new DateTime(2015, 1, 1), 15);
        var user5 = new User(Gender.Male, Occupation.Engineer, "Samuel5,", "Shonekan", new DateTime(2016, 1, 1), 17);
        var user6 = new User(Gender.Male, Occupation.Engineer, "Joe,", "Zhonekan", new DateTime(2006, 1, 1), 19);
        var user7 = new User(Gender.Male, Occupation.Engineer, "Ben,", "Shonekan", new DateTime(2006, 1, 2), 19);
        var user8 = new User(Gender.Male, Occupation.Engineer, "Samuel8,", "Ahonekan", new DateTime(2006, 1, 1), 18);
        var user9 = new User(Gender.Male, Occupation.Engineer, "Samuel9,", "Ahonekan", new DateTime(2006, 1, 1), 18);
        var user10 = new User(Gender.Male, Occupation.Engineer, "Samue20,", "Ahonekan", new DateTime(2006, 1, 1), 18);
        var user11 = new User(Gender.Male, Occupation.Engineer, "Samue21,", "Ahonekan", new DateTime(2006, 1, 1), 18);

        // To duplicate Alt + Shift + DownArrow

        listOfUsers.Add(user1);
        listOfUsers.Add(user2);
        listOfUsers.Add(user3);
        listOfUsers.Add(user4);
        listOfUsers.Add(user5);
        listOfUsers.Add(user6);
        listOfUsers.Add(user7);
        listOfUsers.Add(user8);

        var adultUsers = user.GetAdultUsers(listOfUsers);


        var names = adultUsers.Select(u => u.FirstName + " " + u.LastName + " " + u.Age.ToString()).ToList();

        // Demonstrating Projection with Records

        // UserDto record to hold projected data

        // Which will create a new list of UserDto records
               // Demonstrating Ordering 

        var orderedAdultUsers = adultUsers.OrderBy(u => u.Age).ToList();

        // Demonstrating ordering by descending

        var orderedAdultUsersDesc = adultUsers.OrderByDescending(u => u.Age).ToList();

        var namesRecord = orderedAdultUsers.Select(user => new UserDto(user.FirstName, user.LastName, user.DateOfBirth, user.Age )).ToList();

        // Demonstrating Ascending Order

        var orderedNamesAsc = adultUsers.OrderBy(u => u.Age).ToList();

        // Demonstrating Alphabetically ordering the names of adult users

        var orderedNames = adultUsers.OrderBy(u => u.FirstName).ThenBy(u => u.LastName).ToList();

        // Demonstrating Dates of Birth ordering the names of adult users
        var orderedDob = adultUsers.OrderBy(u => u.DateOfBirth).ToList();

        foreach(var nameDesc in orderedDob)
        {
            Console.WriteLine($"Here is the name of adult users in descending order: {nameDesc.FirstName} {nameDesc.LastName} {nameDesc.Age}");
        }

                
        Console.WriteLine($"Here is the number of adult users: {adultUsers.Count}, which are between the ages of 18 and above.");

        foreach (var name in orderedNamesAsc)
        {
            Console.WriteLine($"Here is the name of adult users: {name}");
        }

        foreach (var nameRecord in orderedNamesAsc)
        {
            Console.WriteLine($"Here is the name from record of adult users: {nameRecord.FirstName} {nameRecord.LastName} {nameRecord.Age}");
        }


        // Demonstrating Paging

        var page = 1; // Let's us define which page we want to retrieve

        var pageSize = 3; // Let's us define how many items per page

        // Subtract 1 from the original page (1)
        var pagedAdultUsers = adultUsers.Skip(page).ToList();
        //var pagedAdultUsers = adultUsers.Skip(2).Take(3).ToList();

        Console.WriteLine($"Here is the number of paged adult users: {pagedAdultUsers.Count}, which are between the ages of 18 and above.");

        foreach (var pagedUser in pagedAdultUsers)
        {
            Console.WriteLine($"Here is the paged adult users: {pagedUser.FirstName} {pagedUser.LastName} {pagedUser.Age}");
        }


        // Demonstrating count under aggregation
        var totalUserNotAdults = listOfUsers.Where(user => user.Age < 18).Count();

        // Demonstaring sum under aggregation
        var sumOfAges = listOfUsers.Sum(user => user.Age);

        // Demonstrating min under aggregation
        var minAge = listOfUsers.Min(user => user.Age);

        // Demonstrating max under aggregation
        var maxAge = listOfUsers.Max(user => user.Age);

        // Demonstrating average under aggregation
        var averageAge = listOfUsers.Average(user => user.Age);

        Console.WriteLine($"Here is the total sum of ages of all users: {sumOfAges}");

        Console.WriteLine($"Here is the total number of users that are not adults: {totalUserNotAdults}");

        Console.WriteLine($"Here is the minimum age of all users: {minAge}");

        Console.WriteLine($"Here is the maximum age of all users: {maxAge}");

        Console.WriteLine($"Here is the average age of all users: {averageAge}");


        Console.WriteLine($"Here is the value of notes: {notes.GetDefaultValue<Car>(car)}");

        car.CarReport("Before");

        car.Fly();
        car.Dive();
        car.Dive("Underwater");

        var testDrive = new TestDrive(car);
        testDrive.Car.Start();
        testDrive.Car.Drive();
        testDrive.Car.Drive("Land");
        testDrive.Car.ActivateSystemControl("Left");
        Console.WriteLine($"Here is the resulting value of fuel after activating system control: {car.FuelType}");
        testDrive.Car.SetAverageFuelConsuptionAndDistance(5.5, 120);
        //testDrive.Car.Mileage = 300; // Directly setting Mileage to demonstrate encapsulation
        testDrive.Car.Stop();

        //testDrive.Car.Mileage = 300; // Directly setting Mileage to demonstrate encapsulation

        testDrive.Car.CarReport("After");



        //Console.WriteLine("Hello, World!");
    }
}