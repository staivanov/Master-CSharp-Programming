namespace Section10.Struct
{
    internal struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: {X} - {Y}");
        }


        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            double pointsResult = (dx * dx) + (dy * dy);
            double result = Math.Sqrt(pointsResult);

            return result;
        }   
    }
}
