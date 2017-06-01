using System;
namespace tesOOP
{
    public class LongRangeTower : Tower
    {
        public override int _range { get; protected set; } = 2;

        public LongRangeTower(MapLocation Location) : base(Location)
        {
        }
    }
}
