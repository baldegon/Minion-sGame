using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minion_sGame.Classes
{
    public enum trabajo
    {
        Soldier,
        Maid,
        Worker
    }
    internal class Labors : Minion
    {

        Minion minion = new Minion();
        Soldier soldier = new Soldier();
        Worker worker = new Worker();
        //Maid Maid = new Maid();

        public string MinionType;

        public string MinionRole;

        trabajo eleccion = new trabajo();
        public Labors(Minion minion)
        {
            this.minion = minion;
            this.MinionType = minion.MinionType;
            this.MinionRole = minion.Role;
        }

        public void selectRole(string MinionRole)
        {
            Console.Write("Ingrese el rol del minion: ");
            string Rol = Console.ReadLine();

            if (Enum.TryParse<trabajo>(Rol, ignoreCase: true, out var eleccion))
            {
                switch (eleccion)
                {
                    case trabajo.Soldier:
                        FixTheMachine(Rol);
                        break;
                    case trabajo.Worker:
                        Console.WriteLine("trabajo gey worker");
                        break;
                    case trabajo.Maid:
                        Console.WriteLine("gila e?");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unknown movie");
            }


        }
        public void FixTheMachine(string MinionRole)
        {

            Console.Write("Funciona");
            bool Fixed = false;
            bool StatsRequeriments = minion.Strength > 20 && minion.Expertise > 20 && minion.Stamina > 50;
            int SoldierStats = soldier.Strength;
            /*
             * aca arriba en soldierstats hacer un array con cada uno de los stats
             * luego hacer un for o foreach para recorrerlo y guardar 
             * en una/s variables los stats, strength, stamina, expertise
             * entonces de ahi voy a poder tener los valores para poder evaluar
             * si puede o no realizar el trabajo.
             * 
             */
            bool RoleAllowed = MinionRole == "Soldier" || MinionRole == "Worker";
            ////este codigo funciona casi al final de todo, si es !Fixed ( NEGADO ) este nunca ejecuta nada.
            if (MinionRole == "Soldier")
            {
                
            }
            if (Fixed && !StatsRequeriments)
            {
                Console.WriteLine("Este minion no cumple los requisitos para realizar el trabajo");
            }
            else
            {
                Console.WriteLine("Minion Realizando el trabajo...");
                Console.WriteLine("Trabajo terminado, se ha arreglado la maquina!");
                Console.WriteLine($"La Estamina del minion {minion.Role} ha bajado a: {minion.Stamina}");
               minion.Stamina -= 60;
            }

            


            //switch (eleccion)
            //{
            //    case trabajo.Soldier:

            //        break;

            //}



            //if (RoleAllowed){
            //    Console.WriteLine("Minion Realizando el trabajo...");
            //    Console.WriteLine("Trabajo terminado, se ha arreglado la maquina!");
            //    //aca tengo el problema
            //    //hace de cuenta que elegi soldier
            //    //entonces aca tengo que poner que si o si se le baje la stamina,
            //    //pero como se yo cual pongo aca?
            //    //el soldier?, el worker? o el minion base
            //    //entonces aca es donde nose como abstraer para que se haga
            //    //el descuento de stamina para el rol del minion.
            //    //con el switch que me armo emi
            //    //tengo cada case trabajo.soldier:
            //    // soldier.stamina -= 60;
            //    //si es el worker se repite pero con el worker.
            //    soldier.Stamina -= 60;
            //    Console.WriteLine($"La Estamina del minion {MinionRole} ha bajado a: {minion.Stamina}");
                

            //}
            
            //#region switch con enum
            //////////////////////////
            ////switch (eleccion)
            ////{
            ////    case trabajo.soldado:
            ////        Console.WriteLine("la puta madre");
            ////        break;
            ////}
            /////////////////////////
            //#endregion

            //if (minion.Role == "worker")
            //{
            //    worker.Stamina -= 60;
            //    Console.WriteLine($"{worker.Stamina}");
            //}

        }

        public void cleanSector(string minionType)
        {            
            Console.WriteLine("Probando funcion limpiar sector, solo la mucama puede usarlo");

            if(minion.Stamina > 50)
            {
                Console.WriteLine($"Su Rol es: {minion.Role}, A no ser que su rol sea MUCAMA o MAID. No puede Realizar este trabajo");
            }
            else
            {
                //cual es el problema a slusionar??
                /*
                 * mira para ser sincero
                 * quiero hacer un menu que te permina seleccionar
                 * el tipo de rol, osea por input eso es facil
                 * ahora, dependiendo el input
                 * asigno el trabajo
                 * si es soldier, worker
                 * puede hacer todo
                 * si es maid limpia y arregla
                 * osea, quiero que la clase LABORS o trabajos
                 * tenga el metodo que evalue si puede hacerlo o no
                 * en caso de q cumpla todo, se ejecuta el metodo de arreglar la makina, limpiar, etc
                 * --
                 * pero ahora, tengo que agregar que cada clase tiene su restriccion, el que tiene un solo ojo pega la mitad
                 * el q tiene 2 tiene todo
                 * 
                 * 
                 * 
                 * 
                 * 
                */
            }
        }

        public void defendSector()
        {
            Console.WriteLine("Probando defender el sector, El soldado puede usar esta funcion");
        }

    }
}
