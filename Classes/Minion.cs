using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{ 
    internal class Minion
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public string MinionType { get; set; }
        public string Role { get; set; }
        public int Expertise { get; set; }

        public Minion() 
        {
            this.Stamina = Stamina;
            this.MinionType = MinionType;
            this.Role = Role;
            this.Expertise = Expertise;

            MinionType = string.Empty;
            Strength = 100;
            Stamina = 100;
            Expertise = 100;
        }

        

    }
}
