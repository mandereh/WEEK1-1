namespace Week1TestClass.CSharpSyntax
{
    public class SedanSUV : Submarine // A child class or derived class, whicch inherits from the Submarine class (The father)
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