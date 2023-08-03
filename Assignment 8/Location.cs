using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString() => $"{X}::{Y}::{Z}";


        public static bool operator ==(Location left, Location right) => (left.X == right.X && left.Y == right.Y && left.Z == right.Z); 
        public static bool operator !=(Location left, Location right) => (left.X != right.X || left.Y != right.Y || left.Z != right.Z); 
    }
}
