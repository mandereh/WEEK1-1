namespace CarProject.Domain.Structs
{
    public struct CarDimensions
    {
         public double Length; // in meters
        public double Width;  // in meters
        public double Height; // in meters

        public CarDimensions(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public bool ActivateSystemControl(string direction)
        {
            throw new NotImplementedException();
        }

        public void CarReport(string beforeOrAfter)
        {
            throw new NotImplementedException();
        }

        public void DisplayDimensions()
        {
            Console.WriteLine($"Car Dimensions - Length: {Length}m, Width: {Width}m, Height: {Height}m");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Drive(string mode)
        {
            throw new NotImplementedException();
        }

        public void SetAverageFuelConsuptionAndDistance(double averageFuelConsumption, int distanceTraveled)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}