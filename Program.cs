using Week1TestClass.CSharpSyntax;
using Week1TestClass.ReferenceFolder;

internal class Program
{
    private static void Main(string[] args)
    {
        var car = new Car("Gasoline", 50, "Petrol", "Sedan", new DateTime(2020, 1, 1));
        car.CarReport("Before");

        var testDrive = new TestDrive(car);
        testDrive.Car.Start();
        testDrive.Car.Drive();
        testDrive.Car.ActivateSystemControl("Left");
        Console.WriteLine($"Here is the resulting value of fuel after activating system control: {testDrive.Car.FuelType}");
        testDrive.Car.AverageFuelConsumption = 5.5;
        testDrive.Car.DistanceTraveled = 120;
        testDrive.Car.Stop();

        testDrive.Car.CarReport("After");

        

        

        //Console.WriteLine("Hello, World!");
    }
}