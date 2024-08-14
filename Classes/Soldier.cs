using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Soldier : Minion
    {
        
        public int GunDamage { get; set; }
        public int Stamina { get;set; }
        public int Strength {  get; set; }
        public Soldier()
        {
            Stamina = 100;
            Strength = (Stamina / 2) + 2;
            Expertise = 50;
        }




    }
}
