using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public abstract class Character : Entity
    {
        private int lvl;
        private int xp;

        public Character(string name):base(name)
        {
            this.name = name;
            lvl = 1;
            xp = 0;
        }

        public void WinXP(int xp)
        {
            this.xp += xp;
            while(this.xp >= XPRequired())
            {
                lvl += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congratulations : you have reached level " + lvl + " !");

                HP += 10;
                MinDamage += 2;
                MaxDamage += 2;
            }
        }

        public void Rest()
        {
            int MaxHealthBack = 55;
            int MinHeathBack = 35;
            HP += random.Next(MinHeathBack, MaxHealthBack);

        }

        public double XPRequired()
        {
            return Math.Round(4 * (Math.Pow(lvl, 3) / 5));
        }

        public string Stats()
        {
            return this.name + "\n" +
                "HP : " + HP + "\n" +
                "XP : (" + xp + "/" + XPRequired() + ")\n" +
                "Damages : [" + MinDamage + ";" + MaxDamage + "]";
        }

    }
}
