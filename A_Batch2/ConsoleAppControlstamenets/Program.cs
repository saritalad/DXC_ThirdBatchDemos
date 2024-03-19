using System;

namespace ConsoleAppControlstamenets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Selection Control Statements
            // if, if else , swicth case statements
            //int age;
            //Console.WriteLine("Enter your age ");
            //age=Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("You are eligible for voting ");
            //    Console.WriteLine($"age ={age}");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for voting");
            //    Console.WriteLine($"age ={age}");
            //}
            // switch case: multiple choice 
            // the case values can be char, int, enum and string, but it can not have float 
            // or double 
            //int month;
            //Console.WriteLine("enter number for current month");
            //  month=Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine(" January");
            //        break;
            //    case 2:
            //        Console.WriteLine(" February");
            //        break;
            //    case 3:
            //        Console.WriteLine(" March");
            //        break;
            //        case 4: Console.WriteLine(" April");
            //        break;
            //    default: Console.WriteLine("Invalid month number !try again");
            //        break;
            //}
            //Looping : repetition/ iteration
            // while, do while , for, foreach

            //int i = 11,sum=0,n;
            ////Console.WriteLine("To find sum of 1 to n numbers enter value of n");
            ////n=Convert.ToInt32(Console.ReadLine());
            //while (i <= 10)
            //{
            //    Console.Write(i + " ");
            //    sum += i; // sum=sum+i
            //    i++;
            //}
            //Console.WriteLine($"\nsum = {sum}");
            // do while Loop
            //do
            //{// at least once execute
            //    Console.Write(i + " ");
            //    sum += i; // sum=sum+i
            //    i++;
            //} while (i <= 10); 
            // Console.WriteLine($"\nsum = {sum}");

            // for loop
            int i, j;
            for(i=1, j=100; j > 0;i++, j--)
            {
                Console.Write($"{i} ");
                Console.Write("....");
                Console.WriteLine($"{j} ");
            }
        }
    }
}
