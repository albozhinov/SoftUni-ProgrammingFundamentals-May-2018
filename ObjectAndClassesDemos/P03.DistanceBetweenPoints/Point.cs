namespace P03.DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}
