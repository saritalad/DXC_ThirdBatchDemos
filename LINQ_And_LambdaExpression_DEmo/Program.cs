using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ_And_LambdaExpression_DEmo
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers= { 91, 22, 43, 4, 50, 62,78,7,4 };    
        //    //linq query
        //    var result1=(from n in numbers
        //                   orderby n
        //                select n).Reverse();
        //    foreach (var n in result1) { Console.Write(n +"," ); }
        //    Console.WriteLine(".....................................");
        //    var result2 = from n in numbers
        //                  where n < 50
        //                  select n;
        //    Console.WriteLine("numbers <50 ..................");
        //    foreach (var n in result2) { Console.Write(n + ","); }
        //    string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        //    Console.WriteLine(  "\n................................");
        //    var result3 = (from d in digits
        //                  where d[1] == 'i'
        //                  select d).Reverse();
        //    foreach(string d in result3) { Console.Write(d+" "); }
        //    Console.WriteLine("..... Aggregate functions.................................................");

        //    Console.WriteLine($" \n count ={numbers.Count()} \nSum ={numbers.Sum()} \n Max={numbers.Max()} \n Min = {numbers.Min()} \n Average ={numbers.Average()}");
        //    int[] ArrayA = { 7, 3, 4,700, 60, 700, 11, 2,45, 2 };
        //    int[] ArrayB = { 7, 3, 8, 2, 60, 89, 34, 89, 100 };
        //    var Union= ArrayA.Union(ArrayB);
        //    Console.WriteLine("Union :combines arrays ");
        //    foreach (int a in Union) { Console.Write(a+ " "); }
        //    Console.WriteLine("................................");
        //    Console.WriteLine("Intersect takes common numbers ");
        //    var Intersect=ArrayA.Intersect(ArrayB);
        //    foreach (int a in Intersect) { Console.Write(a + " "); }
        //    var distinct= ArrayA.Distinct();
        //    Console.WriteLine("distinct  :repeatition is avoided  ");
        //    foreach (int a in distinct) { Console.Write(a + " "); }
        //    string[] words = { "believe", "relief", "receipt", "field" };
        //    var EafterI = words.Any(w => w.Contains("ie"));
        //    // Any keyword stands for OR operator 
        //    Console.WriteLine("\n Is there any word containing ie combination?"+EafterI);
        //    var IafterE = words.All(w => w.Contains("ei"));
        //    // All keyword stands for AND operator 
        //    Console.WriteLine("\n Are all words containing ei combination?" + IafterE);
        //    Console.ReadKey();
        //}
    }
}
