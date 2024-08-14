using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Maid : Biclope
    {
        Fruit fruta = new Fruit();

        public int Stamina { get ; set; }
        
        public int Expertise { get;set; }


        public Maid()
        {
            this.MinionType = MinionType;
            this.Stamina = 100;
            this.Expertise = 50;
        }

        string opcion = string.Empty;

        public void RecuperarPs(string opcion)
        {
            if (Stamina <= 40 || Stamina == 0)
            {
                switch (opcion)
                {
                    case "Banana":
                        Stamina += 10;
                        Console.WriteLine($"Se recuperaron 10P de Stamina, Total: {Stamina}");
                        break;
                    case "Manzana":
                        Stamina += 5;
                        Console.WriteLine($"Se recuperaron 5P de Stamina, Total: {Stamina}");
                        break;
                    case "Uva":
                        Stamina += 1;
                        Console.WriteLine($"Se recuperaron 1P de Stamina, Total: {Stamina}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
