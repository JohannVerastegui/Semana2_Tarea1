﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Tarea1
{
    internal class EnemyMelee : Enemy
    {
        private int armor;
        public EnemyMelee(int health, int damage, int armor)
            : base(health, damage)
        {
            this.armor = armor;
        }

        public override void Attack()
        {
            Console.WriteLine("Ataque del enemigo melee");
        }

        public int GetArmor()
        {
            return armor;
        }

        public int ReceiveDamageFromPlayer(int playerDamage)
        {
            int actualDamage = Math.Max(0, playerDamage - armor);
            Health -= actualDamage;
            return Health;
        }
    }
}
