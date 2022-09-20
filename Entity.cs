using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public abstract class Entity
    {
        protected string name;
        protected bool dead;
        protected int HP;
        protected int MaxDamage;
        protected int MinDamage;
        protected Random random = new Random();
       
        public Entity(string name)
        {
            this.name = name;
        }

        public void Attack(Entity oneEntity)
        {
            int damages = random.Next(MinDamage, MaxDamage);
            oneEntity.LoseHP(damages);

            Console.WriteLine(this.name + " (" + this.HP + ")" + " attack : " + oneEntity.name);
            Console.WriteLine(oneEntity.name + " lost " + damages + " HP");
            Console.WriteLine(oneEntity.name + " has " + oneEntity.HP + " left");

            if(oneEntity.dead)
            {
                Console.WriteLine(oneEntity.name + " is dead");
            }
        }

        public void LoseHP(int HPLost)
        {
            this.HP -= HPLost;
            if(this.HP <= 0)
            {
                this.HP = 0;
                dead = true;
            }
        }


        public bool Dead()
        {
            return this.dead;
        }
    }
}
