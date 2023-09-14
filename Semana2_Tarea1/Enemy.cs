using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Tarea1
{
    internal class Enemy
    {
        public int Health { get; protected set; }
        public int Damage { get; protected set; }

        public Enemy(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public virtual void Attack()
        {
            Console.WriteLine("Ataque del enemigo generico");
        }

        public int ReceiveDamage(int damage)
        {
            Health -= damage;
            return Health;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
