using Command.Interfaсes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    public class Latte : ICommand
    {
        Chef chef;
        public Latte(Chef chef)
        {
            this.chef = chef;
        }
        public void Execute()
        {
            chef.CookLatte();
        }
    }
}
