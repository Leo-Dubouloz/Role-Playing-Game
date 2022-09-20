using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public class Sorcerer : Character
    {
        public Sorcerer(string name) : base(name)
        {
            HP = 100;
            MaxDamage = 22;
            MinDamage = 18;
        }
    }
}
