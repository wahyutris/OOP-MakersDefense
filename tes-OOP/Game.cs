using System;

namespace tesOOP
{
    class Game
    {
        public static void Main(string[] args)
        {
            //declare to call map class (constructor) and add initial value
			Map map = new Map(8,5);

            //declase point class
            Point point = new Point(4,2);
            bool isOnMap = map.onMap(point);
            Console.WriteLine(isOnMap);

            //checking distanceTo method
            Console.WriteLine(point.distanceTo(5, 6));
            Point point2 = new Point(5, 5);
            Console.WriteLine(point.distanceTo(point2));
        }
    }
}
