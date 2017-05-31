using System;
namespace tesOOP
{
    public class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;

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
                    satuInvader.decreaseHealth(1);
                    break;
                }
            }
        }
    }
}
