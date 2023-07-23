using Microsoft.Win32.SafeHandles;

namespace Assignment_5
{
    internal class Program
    {
        static int count;
        public static void readPoint(out int x, out int y, out int z)
        {
            Console.WriteLine($"Read Point Number {++count}");
            bool cX, cY, cZ;
            do
            {
                Console.Write("Please Enter The Value OF X: ");
                cX = int.TryParse(Console.ReadLine(), out x);
            } while (!cX);
            do
            {
                Console.Write("Please Enter The Value OF Y: ");
                cY = int.TryParse(Console.ReadLine(), out y);
            } while (!cY);
            do
            {
                Console.Write("Please Enter The Value OF Z: ");
                cZ = int.TryParse(Console.ReadLine(), out z);

            } while (!cZ);
        }
        static void Main(string[] args)
        {

            int x, y, z;

            //readPoint(out x, out y, out z);
            //_3D_Points P1 = new _3D_Points(x, y, z); ;
            //readPoint(out x, out y, out z);
            //_3D_Points P2 = new _3D_Points(x, y, z);

            //Console.WriteLine(P1.ToString());            
            //Console.WriteLine(P2.ToString());            

            //if(P1 == P2)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");


            //_3D_Points[] points = new _3D_Points[10];


            //points[0] = new _3D_Points() { X = 30, Y = 20, Z = 30 };
            //points[1] = new _3D_Points() { X = 20, Y = 50, Z = 60 };
            //points[2] = new _3D_Points() { X = 40, Y = 60, Z = 70 };

            ////Array.Sort(points);
            //for (int i = 0; i < points?.Length; i++)
            //{
            //    string str = points[i]?.ToString() ?? "Nothing";
            //    if (str == "Nothing") break;
            //    Console.WriteLine(str);
            //}
            //points[3] = (_3D_Points)points[0].Clone();
            //Console.WriteLine($"ID P1 is {points[0].GetHashCode()}");
            //Console.WriteLine($"ID P4 is {points[3].GetHashCode()}"); 
            //Console.WriteLine($"ID P1 is {points[0].ToString()}");
            //Console.WriteLine($"ID P4 is {points[3].ToString()}");


            //NIC n1=NIC.Instance;
            //NIC n2=NIC.Instance;

            //Console.WriteLine(n1.GetHashCode());
            //Console.WriteLine(n2.GetHashCode());

            Duration d1 = new Duration(1,10,15);
            Duration d2 = new Duration(7800);
            //Duration d3 = d1+666;
            Duration d3 = 666+d1;
            Console.WriteLine(d3.ToString());
        }
    }
}