using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Player
    {
        public string Name{ get; set; }
        public string Team{ get; set; }


       public void Run(Location loc)
        {
            Console.WriteLine($"Player {Name} is Running @ {loc}");
        }

        public override string ToString() => $"Player : {Name} , Team : {Team}";

    }
}
