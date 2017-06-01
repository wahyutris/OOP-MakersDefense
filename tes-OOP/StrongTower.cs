using System;
namespace tesOOP
{
    public class StrongTower : Tower
    {
        public override int _power { get; protected set; } = 2;

        public StrongTower(MapLocation Location) : base(Location)
        {
        }
    }
}
