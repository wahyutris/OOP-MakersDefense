using System;
namespace tesOOP
{
    public class Level
    {
        private Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            //loping sampai semua invader mati atau invader menang
            int remainingInvader = _invaders.Length;

            while(remainingInvader > 0)
            {
                //Lalu tower cek jarak dengan invader
                foreach(Tower tower in Towers)
                    tower.FireToInvader(_invaders);
                
                //Kalau masih ada invader, invader maju
                remainingInvader = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.isActive)
                    {
                        invader.Move();
                        if (invader.HasScored) return false;
                        remainingInvader++;
                    }
                }
			}
            return true;
        }
    }
}
