using System;
namespace tesOOP
{
    public class ShieldedInvader : Invader
    {
        public static Random _random = new Random();

        public ShieldedInvader(Path path) : base(path)
        {
        }

		public override void decreaseHealth(int factor) //karena ortunya virtual, anaknya override
		{
            if (_random.NextDouble() > 0.5)
                base.decreaseHealth(factor);
		}
    }
}
