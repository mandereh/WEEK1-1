namespace Week1TestClass.CSharpSyntax
{
    public class SedanSUV : Submarine // A parent class or base class
    {
        public string OffRoadCapability { get; set; }

        public void Fly()
        {
            Console.WriteLine("The SeadanSUV most impeccable feature is about flying.");
        }

        public override void Dive()
        {
            Console.WriteLine("The SedanSUV is sky diving.");
        }
    }
}