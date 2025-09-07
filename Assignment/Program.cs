using Demo.Data;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static Demo.Data.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Q1

            // Note: Use ListGenerators.cs & Customers.xml
            //LINQ - Restriction Operators
            //1.Find all products that are out of stock.
            //2.Find all products that are in stock and cost more than 3.00 per unit.
            //3.Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //var Result01 = ProductList?.Where(P => P.UnitsInStock == 0);
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);  
            //}

            //var Result02 = ProductList?.Where(P => P.UnitsInStock > 3);
            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result03 = ProductList?.Where((P, I) => I < P.ProductName?.Length);
            //Console.WriteLine(Result03);

            #endregion

            #region Q2
            //LINQ - Ordering Operators
            //1.Sort a list of products by name
            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //3.Sort a list of products by units in stock from highest to lowest.
            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};
            //5.Sort first by-word length and then by a case -insensitive sort of the words in an array.       
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};


            //1.Sort a list of products by name
            //var Result = ProductList?.OrderBy(O => O.ProductName);
            //foreach (var Item in Result) 
            //{

            //    Console.WriteLine(Item);

            //}

            //var Result = from p in ProductList
            //             orderby p.ProductName
            //             select p;



            //3.Sort a list of products by units in stock from highest to lowest.

            //var Result03 = ProductList?.OrderByDescending(O => O.UnitsInStock);
            //foreach (var Item in Result03)
            //{
            //    Console.WriteLine(Item);
            //}



            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result04 = Arr.OrderBy(O => O.Length).ThenBy(O => O);
            //foreach (var Item in Result04)
            //{
            //    Console.WriteLine(Item);
            //}

            //5.Sort first by-word length and then by a case -insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result05 = Arr.OrderBy(O => O.Length).ThenBy(O => O.ToLower());
            //foreach (var Item in Result05)
            //{
            //    Console.WriteLine(Item);
            //}

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result06 = ProductList?.OrderBy(O => O.Category).ThenByDescending(O => O.UnitPrice);

            //foreach (var Item in Result06)
            //{
            //    Console.WriteLine(Item);
            //}

            //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result07 = Arr.OrderBy(O => O.Length).ThenByDescending(O => O);
            //foreach (var Item in Result07)
            //{
            //    Console.WriteLine(Item);
            //}

            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result08 = Arr.Where(A => A[1] == 'i').Reverse();
            //foreach (var Item in Result08)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region Q3
            //LINQ – Transformation Operators

            //1.Return a sequence of just the names of a list of products.
            //var ResultTran01 = from P in ProductList
            //                   select new
            //                   {
            //                       Names = P
            //                   };
            //foreach (var item in ResultTran01)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var ResultTranc = from w in words
            //                  select new
            //                  {
            //                      Upper = w.ToUpper(),
            //                      Lower = w.ToLower(),
            //                  };

            //foreach (var item in ResultTranc)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.


            //var ResultTranc = from p in ProductList
            //                  select new
            //                  {
            //                      Price = p.UnitPrice
            //                  };

            //foreach (var item in ResultTranc)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Determine if the value of int in an array matches their position in the array.
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var Result = Arr.Select((value , index) => new {value = value , index = index}).Where(A => A.value == A.index).Select(A => A.value);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion






        }
    }
}
