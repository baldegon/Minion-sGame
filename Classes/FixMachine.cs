using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Minion_sGame.Classes
{
    internal class FixMachine
    {
        Minion minion = new Minion();
        Soldier soldier = new Soldier();
        Worker worker = new Worker();
        Maid maid = new Maid();

        public FixMachine()
        {
            this.minion = minion;
            this.soldier = soldier;
            this.worker = worker;
            this.maid = maid;
        }

        public void Fix()
        {
            bool StatsRequired;
        }
    }
}
