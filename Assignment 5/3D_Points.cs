using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class _3D_Points : IComparable, ICloneable
    {
        static int count;

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3D_Points()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public _3D_Points(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public override string ToString()
        {
            return $"Point {++count} Coordinates:   ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3D_Points ob = (_3D_Points)obj;
            if (this.X > ob.X && this.Y > ob.Y) return 1;
            else if (this.X < ob.X && this.Y < ob.Y) return -1;
            else return 0;
        }

        public object Clone()
        {
            return new _3D_Points() { X = this.X, Y = this.Y, Z = this.Z };
        }

        public static bool operator ==(_3D_Points P1, _3D_Points P2)
        {
            if (P1.X == P2.X && P1.Y == P2.Y && P1.Z == P2.Z)
                return true;
            return false;

        }
        public static bool operator !=(_3D_Points P1, _3D_Points P2)
        {
            if (P1.X != P2.X || P1.Y != P2.Y || P1.Z != P2.Z)
                return false;
            return true;
        }
    }
}
