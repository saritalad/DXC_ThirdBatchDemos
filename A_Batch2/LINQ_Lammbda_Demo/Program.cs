using System;
using System.Linq;
using System.Net;
namespace LINQ_Lammbda_Demo
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 52, 13, 4, 59, 6, 71, 8, 90, 100, 11, };
        //    var result1= from n in numbers
        //                 where n%2==0 orderby n // orderby arrange in ascending order of numbers
        //                 select n;

        //    foreach (int n in result1)
        //    {
        //        Console.Write(" " + n);
        //    }
        //        string[] singers = { "Asha Bhosle", "Anu Malik", "Sonu Nigam", "Amit Kumar", "Shaan" };
        //        var result2=from s in singers
        //                    where s[0]=='A' orderby s// ascendeing order of names 
        //                    select s;
        //        Console.WriteLine("\n ........Names Of Singers Start with A......");
        //        foreach(var s in result2 )
        //        {
        //            Console.Write(" "+s);
        //        }
        //    Console.WriteLine("\n.......digits ...........");
        //    string[] digits= { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        //    // show only digits with 2nd letter i

        //    var result3 = (from n in digits
        //                  where n[1]=='i'
        //                  select n).Reverse();
        //    foreach(var n in result3)
        //        Console.Write(n+" ");
        //    Console.WriteLine("\n.............................................");
        //    int[] A = { 12, 3, 4, 56, 7, 87, 90, 7, 9 };
        //    int[] B = { 3, 4, 56, 87, 300, 34, 1, 5 };
        //    var result4 = A.Union(B);
        //    Console.WriteLine("...Union A and B");
        //    foreach (var n in result4)
        //        Console.Write(" "+n);
        //    Console.WriteLine("..........................");
        //    var result5 = A.Intersect(B);
        //    Console.WriteLine("..Intersect A and B");
        //    foreach (var n in result5)
        //        Console.Write(" " + n);
        //    var result6 = A.Except(B);
        //    Console.WriteLine("...Except A and B");
        //    foreach (var n in result6)
        //        Console.Write(" " + n);
        //    int[] Numbers = { 23, 34, 65, 7, 8, 90, 67, 45 };
        //    int S = Numbers.Sum();
        //     double Avg = Numbers.Average();
        //    int M=Numbers.Max();
        //    int  m =Numbers.Min();
        //    int C=Numbers.Count();
        //    Console.WriteLine($"\n Count {C} Sum{S} Maximum {M} Minimum ={m} Average {Avg} ");
        //    Console.WriteLine("\n................................");

        //    string[] words = { "believe", "relief", "receipt", "field" };
        //    // write query to  show if there is any word with sequence i after e
        //    //any operator works just like OR 
        //    var iAfterE = words.Any(w => w.Contains("ei"));
        //    Console.WriteLine("Does Array Words contain any word with ei sequence ?" + iAfterE);
        //    var iAfterEAll = words.All(w => w.Contains("ei"));
        //    // All operator works just like AND operator 
        //    Console.WriteLine("Does Array-words contain All words with ei sequence ?" + iAfterEAll);
              
        //}



        }
    }

