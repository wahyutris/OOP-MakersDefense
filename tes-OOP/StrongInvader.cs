using System;
namespace tesOOP
{
    public class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 3;

        public StrongInvader(Path path) : base(path)
        {
        }
    }
}
