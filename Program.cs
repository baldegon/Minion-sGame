using Microsoft.Win32.SafeHandles;
using Minion_sGame.Classes;
using System;

namespace Minion_sGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HERE EXECUTES ALL THE GAME WITHIN THE CODE
            //ALL THE REFERENCES COMES HERE


            //Main Game Function and Loop

            // CLASSES
            
            Minion minion = new Minion();
            Labors labors = new Labors(minion);
            Soldier soldier = new Soldier();
            Worker worker = new Worker();
            Maid Maid = new Maid();



            //Console.WriteLine("Minion's Game");
            //Console.WriteLine("Press a key to continue...");
            //Console.ReadKey();
            
            //Console.Clear();

            Console.WriteLine("---------------");
            Console.WriteLine("~ Minion's GaMe ~");
            Console.WriteLine("---------------");
            //Capturando el tipo de minion y el rol
            Console.Write("Ingrese su Tipo de Minion: ");

            minion.MinionType = Console.ReadLine();



            // ---------------------
            //Ejecucion de la tarea de arreglar maquinaria.
            labors.selectRole(minion.Role);
            //Verificando que el minion tenga energia para poder realizar el trabajo
            if(worker.Stamina < 40)
            {
                Console.WriteLine("Minion con stamina menor a 40, recuperando energia");
                Console.WriteLine("Que fruta quiere comer?: Banana, Manzana o Uva?");
                var fruta = Console.ReadLine();
                worker.RecuperarPs(fruta);
                Console.WriteLine($"Energia recuperada: 10, Stamina total del minion {minion.Role}, {worker.Stamina}");
            }

            //fixMachine.AllowMinionWork(minionProfession);
            //Console.WriteLine(minionProfession);

            //Console.WriteLine("Press a key to continue...");
            //Console.ReadKey();

            
            //labors.FixTheMachine();

            

        }
    }
}
