using System;
namespace tesOOP
{
    public class SniperTower : Tower
    {
        public override double _accuracy { get; protected set; } = 0.9;
        public SniperTower(MapLocation Location) : base(Location)
        {
            
        }
    }
}
