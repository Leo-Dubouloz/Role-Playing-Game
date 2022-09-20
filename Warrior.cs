using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public class Warrior : Character
    {
        
        public Warrior(string name) : base(name)
        {
            HP = 150;
            MaxDamage = 12;
            MinDamage = 8;
        }
    }
}
