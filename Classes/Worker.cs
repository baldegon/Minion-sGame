using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Worker : Ciclope
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
