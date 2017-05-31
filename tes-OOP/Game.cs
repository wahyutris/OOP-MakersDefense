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
            //Console.WriteLine("----------- INHERITANCE IN MAP -------------");
			//MapLocation point3 = new MapLocation(8, 5);
			//isOnMap = map.onMap(point3);
			//Console.WriteLine(isOnMap);
			//Console.WriteLine("Jarak = {0}", point3.distanceTo(7, 5));
			//Console.WriteLine("aa" is string);
			//Console.WriteLine(point3 is Point);
			//Console.WriteLine(point2 is MapLocation);
			//Console.WriteLine();

            Console.WriteLine("----------- ENCAPSULATION -------------");
			try
            {
				//MapLocation point3 = new MapLocation(8, 5, map);
				Path path = new Path(
                new[]
				{
					new MapLocation(0, 2, map),
					new MapLocation(1, 2, map),
					new MapLocation(2, 2, map),
					new MapLocation(3, 2, map),
					new MapLocation(4, 2, map),
					new MapLocation(5, 2, map),
					new MapLocation(6, 2, map),
					new MapLocation(7, 2, map)
				});

                MapLocation location = path.getLocationAt(0); // sama dengan MapLocation location = new MapLocation(0, 2, map);

				Console.WriteLine(location.X + " , " + location.Y);
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (MDException ex)
            {
                Console.WriteLine("Exception lv2 = " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception lv3 = " + ex.Message);
            }

			
        }
    }
}
