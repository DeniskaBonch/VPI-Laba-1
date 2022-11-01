namespace project
{
    class Program
    {
        static void Main()
        {
            ThePoint point = new ThePoint();
            point.MoveBy(-10, 5, -7);
            point.MoveBy(7, 2, -6);
            point.Printer();
        }
    }
}