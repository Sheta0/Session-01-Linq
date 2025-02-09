using System.ComponentModel.DataAnnotations;
using static Demo_01.ListGenerator;
namespace Demo_01
{
    internal class Program
    {
        //public static var Print(var data)
        //{
        //    Console.WriteLine(data);
        //    return data;
        //}

        public static dynamic Print(dynamic data)
        {
            Console.WriteLine(data);
            return data;
        }
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [var - dynamic]

            //// var
            //var Data01 = "Ahmed";
            //// Compiler can detect the data type of the local variable based on its initial value at compile time
            //// Must be initialized 
            //// var X = null // Invalid : Cannot initialize local value with null
            //// Data = 4; // Invalid: After initalization u can't change the local variable datatype
            //// Can't use var as a parameter or return type for methods

            //// dynamic
            //dynamic Data02 = "Ali";
            //// CLR will detect the data type of variable based on last assigned value at runtime
            //dynamic X; // Doesn't need to be initialized
            //dynamic Y = null; // Can be iniatized with null 
            //Data02 = 4; // After initalization u can change its datatype
            //// Can use var as parameter or return type 
            //// Be careful when using dynamic not recommended 
            //// Like var in JS or Object in C#

            //Data02 = 5;
            //Console.WriteLine(Data02.GetType());

            //Data02 = 5.5;
            //Console.WriteLine(Data02.GetType());

            //Data02 = 5.5f;
            //Console.WriteLine(Data02.GetType());

            //Data02 = 5.5m;
            //Console.WriteLine(Data02.GetType());


            //var X = () => Console.WriteLine("Hello World");
            //dynamic X = delegate () { Console.WriteLine("Hello World"); };

            #endregion

            #region Anonymous Type

            ////Employee E01 = new Employee { Id = 1, Name = "Ahmed", Salary = 9_000 };

            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 9_000.0m };

            ////// The Object that will be created from Anyomous Type is Immutable object (Can't change)
            //////E01.Id = 2; // Invalid

            ////Console.WriteLine(E01.GetType().Name); // AnonymousType0`3
            ////Console.WriteLine(E01);
            ////// Compiler will override ToString()  


            ////var E02 = new { Id = 20, Name = "Haerin", Salary = 10_000 }; // AnonymousType0`3
            ////Console.WriteLine(E01.GetType().Name);
            /////// Same Anonymous Type as long as : 
            /////// 1. Properties have the same name [Case Sensitive]
            /////// 2. Properties are in the same order
            /////// 3. Properties have the same data type

            ////Console.WriteLine(E01.GetHashCode());
            ////Console.WriteLine(E02.GetHashCode());

            ////if (E01.Equals(E02)) // Compiler will override Equals() method and make it compare the values of the properties
            ////    Console.WriteLine("E01 == E02");
            ////else
            ////    Console.WriteLine("E01 != E02");


            ////////var E03 = E01 

            //////var E03 = new { E01.Id, E01.Name, Salary = 12_000 };

            ////var E03 = E01 with { Salary = 12_000 }; // C# 10.0

            ////var E04 = new { Name = "omar", Id = 1, Salary = 9_000 };
            ////Console.WriteLine(E04.GetType().Name); // AnonymousType1`3

            #endregion

            #region Extension Methods
            //long X = 12345;

            ////long reversedX = IntExtentions.Reverse(X); // Class Member Method
            //long reversedX = X.Reverse(); // Extension Method
            //Console.WriteLine($"Reversed {X} is {reversedX}");
            #endregion

            #region What is LINQ
            //// LINQ : Language-Integrated Query
            ////      : +40 Extension Methods for any Data in sequence => the classes that implement IEnumerable interface
            ////      : Regardless Data Store
            ////      : [LINQ Operators] exist at Class [Enumerable]
            ////      : categorized into 13 category


            //// Sequence : any class that implements the built-in interface IEnumerable<T>
            //// 1. Local  Sequence : L2Object, L2XML
            //// 2. Remote Sequence : L2EF

            //// Input Sequence => LINQ Operator => Output Sequence
            //// Input Sequence => LINQ Operator => One Value
            ////                => LINQ Operator => One Value

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var result = Enumerable.Where(Numbers, N => N % 2 == 0);
            ////var result = Enumerable.Any(Numbers, N => N % 2 == 0);
            //var result = Enumerable.Range(1, 100); // 1 => 100

            //foreach (var n in result)
            //{
            //    Console.Write($"{n} ");
            //}
            #endregion

            #region LINQ Syntax

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// 1. Fluent Syntax
            //// 1.1 Call LINQ Operator as a Static Method Through Class "Enumerable"
            //var OddNumbers = Enumerable.Where(Numbers, N => N % 2 != 0);

            //// 1.2 Call LINQ Operator as an Extention Method [Recommended]
            //OddNumbers = Numbers.Where(N => N % 2 != 0);

            //// 2.0 Query Syntax (Query Expression) : like SQL Style
            //// start with from
            //// end with select, group by
            //OddNumbers = from N in Numbers
            //             where N % 2 != 0
            //             select N;

            //// In Some Cases, It's easier to use Query Expressions Instead of Fluent Syntax (Join, Group)

            //foreach (int n in OddNumbers)
            //{
            //    Console.Write($"{n} ");
            //}


            #endregion

            #region LINQ Execution Ways
            ////// 1. Differed Execution [Latest Version Of Data] => 10 Categories
            ////List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var OddNumbers = Numbers.Where(N => N % 2 != 0); // Differed

            ////Numbers.AddRange(new int[] { 11, 12, 13, 14 });

            ////foreach (int number in OddNumbers) // => execute the query here
            ////    Console.Write($"{number} ");

            //// 2. Immediate Execution => 3 Categories : [Element Operators, Casting Operators, Aggregate Operators]
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            //var OddNumbers = Numbers.Where(N => N % 2 != 0).ToList(); // Immediate
            //Numbers.AddRange(new int[] { 11, 12, 13, 14 });

            //foreach (int number in OddNumbers)
            //    Console.Write($"{number} ");
            #endregion

            #region Data Setup

            ////Console.WriteLine(ProductList[0]);
            ////Console.WriteLine(CustomerList[0]);

            ////var result = ProductList.Where(P => P.UnitsInStock == 0);
            //var result = CustomerList.Where(C => C.City == "Berlin");

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
        }
    }
}
