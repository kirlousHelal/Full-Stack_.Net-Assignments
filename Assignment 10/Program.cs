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

            #region Test Query and fluent syntax
            //var res = ProductList.Where(i => i.UnitsInStock == 0).Select(p => new { ProductName = p.ProductName, UnitPrice = p.UnitPrice });

            //var maxPrice = ProductList.Max(p => p.UnitPrice);
            //var minPrice = ProductList.Min(p => p.UnitPrice);

            //var nameMax = ProductList.Where(p => p.UnitPrice == maxPrice).Select(p => new { p.ProductName, p.UnitPrice });
            //var nameMin = ProductList.Where(p => p.UnitPrice == minPrice).Select(p => new { p.ProductName, p.UnitPrice });


            ////res = from p in ProductList
            ////      where p.UnitsInStock == 0
            ////      select p;

            //foreach (var unit in nameMax)
            //{
            //    Console.WriteLine(unit);
            //}

            //Console.WriteLine("------------------------------");

            //foreach (var unit in nameMin)
            //{
            //    Console.WriteLine(unit);
            //}

            //Console.WriteLine("------------------------------");

            //List<string> Names = new List<string>() { "Kiro dasf", "dalia ewr", "david helal" };

            //var ress = Names.SelectMany(fn => fn.Split(' '));

            //foreach (var item in ress)
            //{
            //    Console.WriteLine(item);
            //}

            //var lst = Enumerable.Range(0, 100).ToList();

            //var t = lst.GetRange(1,10); 
            #endregion


            #region 1. Find all products that are out of stock.
            //var outRes = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in outRes)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var inStock = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);
            //foreach (var item in inStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res =Arr.Where((s,i)=> s.Length < i);
            //foreach (var s in res) { Console.WriteLine(s); }
            #endregion


            #region 1. Get first Product out of Stock 
            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(res);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var res = ProductList.FirstOrDefault(p => p.UnitPrice == 1000);
            //Console.WriteLine(res?.ProductName ?? "NA");

            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(x => x > 5).OrderBy(x => x).Where((x, i) => i == 1).FirstOrDefault();
            ////foreach (int i in res) { Console.WriteLine(i); }
            //Console.WriteLine(res);
            #endregion

            #region 1. Find the unique Category names from Product List
            //var res = ProductList.Select(p=>p.Category).Distinct();
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var r1 = ProductList.Select(p => p.ProductName).Select(p => p[0]).Distinct();
            //var r2 = CustomerList.Select(p => p.CompanyName).Select(p => p[0]).Distinct();

            //var r3 = r1.Union(r2);
            //foreach (var item in r3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var r1 = ProductList.Select(p => p.ProductName).Select(p => p[0]).Distinct();
            //var r2 = CustomerList.Select(p => p.CompanyName).Select(p => p[0]).Distinct();

            //var r3 = r1.Intersect(r2);
            //foreach (var item in r3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var r1 = ProductList.Select(p => p.ProductName).Select(p => p[0]).Distinct();
            //var r2 = CustomerList.Select(p => p.CompanyName).Select(p => p[0]).Distinct();

            //var r3 = r1.Except(r2);
            //foreach (var item in r3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //var r1 = ProductList.Select(p => p.ProductName).Select(p => p[^4..^1]);
            //var r2 = CustomerList.Select(p => p.CompanyName).Select(p => p[^4..^1]);

            //var r3 = r1.Concat(r2);
            //foreach (var item in r3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Count(i => i % 2 != 0);
            //Console.WriteLine(res);

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var res = CustomerList.Select(i => i.Orders.Count()).ToList();
            //foreach (var order in res) { Console.WriteLine(order); }
            #endregion

            #region 3. Return a list of categories and how many products each has
            var res = ProductList.Select(i => i.Category.Count()).ToList();
            foreach (var order in res) { Console.WriteLine(order); }

            #endregion
        }
    }
}