namespace Week1TestClass.CSharpSyntax.Interfaces
{
    public interface ICar
    {
        void Start();
        void Stop();
        void Drive();
        void Drive(string mode); // Polymorphism - Method Overloading example
        void CarReport(string beforeOrAfter);
        bool ActivateSystemControl(string direction);
        void SetAverageFuelConsuptionAndDistance(double averageFuelConsumption, int distanceTraveled);
    }
}