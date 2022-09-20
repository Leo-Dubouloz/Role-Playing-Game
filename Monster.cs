using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_playing_game
{
    public class Monster : Entity
    {

        public Monster(string name) : base(name) 
        { 
            this.name = name;
            this.HP = 50;
            this.MinDamage = 5;
            this.MaxDamage = 20;
        }

    }
}
