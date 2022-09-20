using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public class Archer : Character
    {

        public Archer(string name) : base(name)
        {
            HP = 110;
            MaxDamage = 25;
            MinDamage = 12;
        }

    }
}
