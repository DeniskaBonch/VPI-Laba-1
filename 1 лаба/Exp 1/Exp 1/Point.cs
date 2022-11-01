

namespace project
{
    class ThePoint
    {
        public double x { get; set; }
        public double y { get; set; }

        public ThePoint()
        {
            int x;
            int y;
        }

        public ThePoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public ThePoint(ThePoint point)
        {
            x = point.x;
            y = point.y;
        }

        public ThePoint Clone()
        {
            return new ThePoint(x, y);
        }

        public string Position
        {
            get { return "x = " + x + ", y = " + y; }
        }

    }
}
