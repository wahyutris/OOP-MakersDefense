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
        protected virtual int stepSize { get; } = 1; //protected anaknya bisa ngambil data dari ortunya, tapi kelas lain
        //public int Health { get; private set; } = 2;
        public virtual int Health { get; protected set; } = 2;

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

        public virtual void Move() //karena anaknya make method yang sama atau modif2 dikit, dikasih virtual
		{
            _pathStep += stepSize;
        }

        public MapLocation Location // *
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }

        public virtual void decreaseHealth(int factor) //karena anaknya make method yang sama atau modif2 dikit, dikasih virtual
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
