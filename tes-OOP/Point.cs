using System;
namespace tesOOP
{
    public class Point // *
    {
		public readonly int X; //default access modifier is private if it's not declared
		public readonly int Y; //readonly so the value didn't change when looping program

		public Point(int x, int y) //harus sama *, general constructor
		{
			X = x;
			Y = y;
		}

        public int distanceTo(int x, int y) //ditempatin disini karena banyak pake point
        {
            double xDiffSquared = Math.Pow((X - x), 2);
            int yDiffSquared = (Y - y) * (Y - y);

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }

        public int distanceTo(Point point) //overloading
        {
            return distanceTo(point.X, point.Y);
        }
    }
}
