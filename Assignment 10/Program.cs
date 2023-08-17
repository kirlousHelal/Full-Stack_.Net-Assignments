using System.Collections.Generic;
using System.Linq;
using System;
using L2O___D09;
using static L2O___D09.ListGenerators;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var res = ProductList.Where(i => i.UnitsInStock == 0).Select(p => new { ProductName = p.ProductName, UnitPrice = p.UnitPrice });

            var maxPrice = ProductList.Max(p => p.UnitPrice);
            var minPrice = ProductList.Min(p => p.UnitPrice);

            var nameMax = ProductList.Where(p => p.UnitPrice == maxPrice).Select(p => new { p.ProductName, p.UnitPrice });
            var nameMin = ProductList.Where(p => p.UnitPrice == minPrice).Select(p => new { p.ProductName, p.UnitPrice });


            //res = from p in ProductList
            //      where p.UnitsInStock == 0
            //      select p;

            foreach (var unit in nameMax)
            {
                Console.WriteLine(unit);
            }

            Console.WriteLine("------------------------------");

            foreach (var unit in nameMin)
            {
                Console.WriteLine(unit);
            }

            Console.WriteLine("------------------------------");

            List<string> Names = new List<string>() { "Kiro dasf", "dalia ewr", "david helal" };

            var ress = Names.SelectMany(fn => fn.Split(' '));

            foreach (var item in ress)
            {
                Console.WriteLine(item);
            }
        }
    }
}