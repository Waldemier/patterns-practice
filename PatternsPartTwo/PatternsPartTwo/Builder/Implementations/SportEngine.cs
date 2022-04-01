using PatternsPartTwo.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Task1.Implementations
{
    public class SportEngine : IEngine
    {
        public override string ToString()
        {
            return $"{nameof(SportEngine)}";
        }
    }
}
