using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Maid : Minion
    {


        public int stamina { get; set; }
        
        public Maid()
        {
            this.MinionType = MinionType;
            this.stamina = 100;
        }
    }
}
