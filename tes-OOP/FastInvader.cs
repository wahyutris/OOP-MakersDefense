using System;
namespace tesOOP
{
    public class FastInvader : Invader
    {
        protected override int stepSize { get; } = 2; //pengganti *

        public FastInvader(Path path) : base(path)
        {
        }

		//public override void Move() // diganti yang *
		//{
		//	_pathStep += 1;
		//}
    }
}
