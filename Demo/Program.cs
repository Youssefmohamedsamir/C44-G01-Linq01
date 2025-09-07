using Demo.Anonymoys_Type;
using Demo.ExtentionMethods;
using System.Xml.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable

            #region Var
            var Name = "Ahmed"; //Implicit Type
            // Compiler Will Detect Ites Type At Compile Time based on Initial Value

            //Data = 10; //Invalid Type
            //After Initialization, You Cannot Change Its Type

            //var X = null; // Invalid
            //var Y; // Invalid

            Name = "Ali"; //Valid 
            #endregion

            #region dynamic

            //dynamic Data = "Ali";// valid
            ////CLR will Detect Its Type At Runtime

            ////Based On Ites Last Assigned Value

            //Data = 10; //Valid

            //Data = null; //Valid

            //Data = true; //Valid

            //dynamic X; //Valid
            //// Can Declare Without Initialization




            #endregion

            //for (var i = 0; i < 10; i++){  }
            //foreach (var item in Name){}

            #endregion

            #region Extention Methods
            //int Number = 123456;
            //int ReversedNumber = Extentions.Reverse(Number);
            //ReversedNumber = Number.Reverse(); //Extension Method Syntax


            #endregion

            #region Anonymous Types

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 5000 };
            //object E01 = new { Id = 1, Name = "Ahmed", Salary = 5000 };
            //Console.WriteLine(E01.Id);//Invalid


            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 5000 };
            //Console.WriteLine(E01.Name);//Valid

            //int X = 10;
            //Console.WriteLine(X.GetType()); // Int32

            //Console.WriteLine(E01.GetType().Name);//f__AnonymousType0`3
            //                                      //E01.Name = "Ali"; //Invalid
            //                                      //object Created From anonymous Type is Immutable object
            //var E02 = new { Id = E01.Id, Name = "Ali", Salary = E01.Salary };//Till C# 9
            //Console.WriteLine(E02);
            //Console.WriteLine(E02.Name);
            //Console.WriteLine(E02.GetType().Name);

            //var E03 = E01 with { Name = "Mohamed" };//From C# 10
            //Console.WriteLine(E03);
            //Console.WriteLine(E03.Name);
            //Console.WriteLine(E03.GetType().Name);

            //var E04 = new { E01.Name, E01.Salary , E01.Id };//From C# 10
            //Console.WriteLine(E04.GetType());
            //Console.WriteLine(E04.GetType().Name);

            //The Same Anonymous Type As Long As :
            // 1- Have The Same Property Names[Case Sensitive]
            // 2- In The Same Order




            #endregion

            #region What is Linq
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Even = Numbers.Where(N => N % 2 == 0).ToList();

            //foreach (var item in Even)
            //{
            //    Console.WriteLine(item);// 2 , 4 , 6 , 8 , 10
            //}


            #endregion

            #region Linq Syntax

            #region Method Syntax
            //List<int> Number = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// 1. Method Synatax [Fluent]
            //// 1.1 Call LINQ Operatours As Static Methods [Class - Member Methods]
            //var Even = Enumerable.Where(Number, X => X % 2 == 0);

            //foreach (var item in Even)
            //{
            //    Console.WriteLine(item);// 2 , 4 , 6 , 8 , 10
            //}

            // 1.2 Call LinQ Operators As Object Member Methods [Extention Methods] Redable more

            //Even = Number.Where(X => X % 2 == 0);

            //foreach (var item in Even)
            //{
            //    Console.WriteLine(item);// 2 , 4 , 6 , 8 , 10
            //}
            #endregion

            #region Query Syntax
            //List<int> Number = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Must Started With 'from' And Must Ended With keyword 'select' Or 'group by'

            /*
              
            Select *
            from Number N
            Where N % 2 == 0
         
             */

            //var Even  =  from N in Number
            //             where N % 2 == 0
            //             select N;


            //foreach (var item in Even)
            //{
            //    Console.WriteLine(item);// 2 , 4 , 6 , 8 , 10
            //}



            #endregion

            #endregion

            #region Execution Wayes

            //List<int>Numbers = new List<int>() { 1, 2, 3, 4, 5 , 6 , 7 , 8 , 9 , 10 };

            //var Even = Numbers.Where(N => N % 2 == 0).ToList(); //{ Where Only } Deferred Execution
            //                                                    //  Immediate Execution { ToList() } 
            //Numbers.AddRange(11, 12, 13, 14, 15 , 16);

            //foreach (var item in Even)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Data

            #endregion

        }
    }
}
