using System;
namespace tesOOP
{
    public class Path
    {
        private readonly MapLocation[] _path; //biasanya kalau private pake underscore

        public Path(MapLocation[] path) //general constructor
        {
            _path = path;
        }

        public MapLocation getLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null; //ternary if
		}

        public int Length
        {
            get
            {
                return _path.Length;
            }
        }
    }
}
