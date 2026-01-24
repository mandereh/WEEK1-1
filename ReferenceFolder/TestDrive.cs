using Week1TestClass.CSharpSyntax;

namespace Week1TestClass.ReferenceFolder
{
    public class TestDrive
    {
        public TestDrive(Car car)
        {
            Car = car;
        }
        public Car Car { get; set; } //= new Car("Gasoline", "Kerosene");
    }
}