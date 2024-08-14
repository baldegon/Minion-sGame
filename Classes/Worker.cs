using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Worker : Minion
    {
        Fruit fruta = new Fruit();
        public int Strength { get; set; }

        public List<string> Tools = new List<string>();
        public Worker()
        {
            Expertise = 20;
            Stamina = 100;
            Strength = ((Stamina + Expertise) / 2);
            Tools.Add("Martillo");
            Tools.Add("Destornillador");
            Tools.Add("Soldadora");
            
        }

        public void RecuperarPs(string name)
        {
            if(Stamina <= 40 || Stamina == 0)
            {
                fruta.Banana();
            }
        }
    }
}
