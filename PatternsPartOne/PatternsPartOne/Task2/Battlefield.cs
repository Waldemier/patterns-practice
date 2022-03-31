using PatternsPartOne.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartOne.Task2
{
    public class Battlefield
    {
        public List<Swordman> Swordmans { get; set; } = new List<Swordman>();
        public List<Archer> Archers { get; set; } = new List<Archer>();

        public void BegginFight() 
        {
            Parallel.Invoke(() => Parallel.ForEach(Swordmans, x => x.Attack()), 
                () => Parallel.ForEach(Archers, x => x.Attack()));
        }
    }
}
