using Microsoft.VisualBasic;
using Week1TestClass.CSharpSyntax;
using Week1TestClass.CSharpSyntax.Interfaces;

namespace Week1TestClass.ReferenceFolder
{
    public class TestDrive
    {
        public TestDrive(ICar car)
        {
            Car = car;
        }
        public ICar Car { get; set; } //= new Car("Gasoline", "Kerosene");
    }
}