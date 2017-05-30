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
            Console.WriteLine("----------- CHECKIN IN MAP -------------");
            Point point = new Point(4,2);
            bool isOnMap = map.onMap(point);
            Console.WriteLine(isOnMap);
            Console.WriteLine();

            //checking distanceTo method
            Console.WriteLine("----------- DISTANCE IN MAP -------------");
            Console.WriteLine(point.distanceTo(5, 6));
            Point point2 = new Point(5, 5);
            Console.WriteLine(point.distanceTo(point2));
            Console.WriteLine();

            //INHERITANCE
            Console.WriteLine("----------- INHERITANCE IN MAP -------------");
            MapLocation point3 = new MapLocation(8, 5);
			isOnMap = map.onMap(point3);
			Console.WriteLine(isOnMap);
            Console.WriteLine("Jarak = {0}", point3.distanceTo(7, 5));
            //Console.WriteLine("aa" is string);
            Console.WriteLine(point3 is Point);
            Console.WriteLine(point2 is MapLocation);
            Console.WriteLine();
        }
    }
}
