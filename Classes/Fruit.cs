using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    internal class Fruit
    {
        Minion minion = new Minion();
        public string? Name { get; set; }

        public Fruit()
        {
            this.Name = Name;
        }


        public void Banana() 
        {
            minion.Stamina += 10;
            Console.WriteLine("Puntos de Estamina recuperados: 10");
        }

        public void Manzana()
        {
            minion.Stamina += 5;
            Console.WriteLine("Puntos de Estamina recuperados: 5");
        }

        public void Uva()
        {
            minion.Stamina += 1;
            Console.WriteLine("Puntos de Estamina recuperados: 1");
        }

    }
}
