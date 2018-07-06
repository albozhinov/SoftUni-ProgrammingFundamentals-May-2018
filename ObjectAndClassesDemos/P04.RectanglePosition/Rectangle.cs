namespace P04.RectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; } 
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left && Right <= other.Right && Top <= other.Top && Bottom <= other.Bottom;
        }
    }
}
//o r1.Left ≥ r2.Left
//o   r1.Right ≤ r2.Right
//o   r1.Top ≤ r2.Top
//o   r1.Bottom ≤ r2.Bottom
