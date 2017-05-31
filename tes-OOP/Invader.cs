using System;
namespace tesOOP
{
    public class Invader
    {
        //private MapLocation _location;

        //public MapLocation getLocation()
        //{
        //    return _location;
        //}

        //public void setLocation(MapLocation value)
        //{
        //    _location = value;
        //}

        //Kalau disingkat agar lebih elegan menjadi
        //public MapLocation location { get; private set; } //tapi sayangnya gak dipake, diganti yang ini *

        private readonly Path _path;
        private int _pathStep = 0;
        public int Health { get; private set; } = 2;

        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length; // syntetic sugar
            }
        }

        public Invader(Path path) //general constructor object
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
        }

        public MapLocation Location // *
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }

        public void decreaseHealth(int factor)
        {
            Health -= factor;
        }

        public bool isNeutralized
        {
            get
            {
                return Health <= 0;
            }
        }

        public bool isActive
        {
            get
            {
                return !(isNeutralized || HasScored);
            }
        }
    }
}
