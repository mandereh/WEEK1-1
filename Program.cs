using Week1TestClass.CSharpSyntax;
using Week1TestClass.ReferenceFolder;

internal class Program
{
    private static void Main(string[] args)
    {
        Submarine sedanSuv = new SedanSUV(); // On this right side, there is a part of Submarine class
        //SedanSUV sedanSUV = new Submarine(); // This line will cause a compile-time error.. Because ther is no part of SedanSUV on this part.
        sedanSuv.Dive();

        
        var car = new Car("Gasoline", 50, "Petrol", "Sedan", new DateTime(2020, 1, 1));
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