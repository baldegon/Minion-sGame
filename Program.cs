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
            Console.Write("Queres comer una fruta para recuperar stamina? Puede elegir entre Banana, Manzana y Uva ");
            string opcion = Console.ReadLine();

            if (opcion != (string)(opcion))
            {
                Console.WriteLine("Ingrese una fruta valida.");
            }
            Maid.RecuperarPs(opcion);
            Console.Write("");


            //fixMachine.AllowMinionWork(minionProfession);
            //Console.WriteLine(minionProfession);

            //Console.WriteLine("Press a key to continue...");
            //Console.ReadKey();

            
            //labors.FixTheMachine();

            

        }
    }
}
