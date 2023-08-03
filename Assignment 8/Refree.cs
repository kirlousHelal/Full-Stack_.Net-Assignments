using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Refree
    {

        public string Name { get; set; }


       public void Look(Location loc)
        {
            Console.WriteLine($"Refree {Name} is looking At Ball in {loc}");
        }


        public override string ToString() => Name;
    }
}
