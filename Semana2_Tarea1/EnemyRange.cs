using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Tarea1
{
    internal class EnemyRange : Enemy
    {
        private int bullets;

        public EnemyRange(int health, int damage, int bullets)
            : base(health, damage)
        {
            this.bullets = bullets;
        }

        public bool HasBullets()
        {
            return bullets > 0;
        }

        public int GetBullets()
        {
            return bullets;
        }

        public void ConsumeBullet()
        {
            if(bullets > 0)
            {
                bullets--;
            }
        }
    }
}
