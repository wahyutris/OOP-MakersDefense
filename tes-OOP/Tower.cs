using System;
namespace tesOOP
{
    public class Tower
    {
        private readonly MapLocation _location;
        //private const int _range = 1;
        public virtual int _range { get; protected set; } = 1;
        //private const int _power = 1;
        public virtual int _power { get; protected set; } = 1;
        private static Random randomgenerator = new Random();
        //public const double _accuracy = 0.75;
        public virtual double _accuracy { get; protected set; } = 0.75;

        public Tower(MapLocation Location)
        {
            _location = Location;
        }

        public void FireToInvader(Invader[] invaders)
        {
            foreach(var satuInvader in invaders)
            {
                if (satuInvader.isActive && _location.inRangeOf(satuInvader.Location, _range))
                {
                    if (_accuracy >= randomgenerator.NextDouble())
                    {
                        satuInvader.decreaseHealth(_power);
                        Console.WriteLine("Shoot on invader success with range {0}, power {1}, and accuracy {2}", _range, _power, _accuracy);

                        if (satuInvader.isNeutralized)
                            Console.WriteLine("Invader died");
                    }
                    else Console.WriteLine("Shoot on invader missed");

                    break;
                }
            }
        }
    }
}
