using System;
using System.Linq.Expressions;
// if , if - else switch case
// 2 looping/ iternation 
// while, do while, for , foreach
//int age;
//Console.WriteLine("Enter your age ");
//age = Convert.ToInt32(Console.ReadLine());
//if (age >= 18)
//    Console.WriteLine("You are eligible for voting");
//else
//    Console.WriteLine(" You are not eligible for voting ");
// swicth case use for multiple choice 
// switch case stmnt can take data type char , int or enum but it can not accept float or double 
//int day;
//char opt;
//Console.WriteLine("Today is .....\nenter 1-7 number for day of week 1 for Mon .... ");
//day = Convert.ToInt32(Console.ReadLine());
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Today is Monday ");
//        break;
//    case 2:
//        Console.WriteLine("Today is Tuesday ");
//        break;
//    case 3:
//        Console.WriteLine("Today is Wednesday ");
//        break;
//    case 4:
//        Console.WriteLine("Today is Thursday ");
//        break;
//    case 5:
//        Console.WriteLine("Today is Friday ");
//        break;
//    case 6:
//        Console.WriteLine("Today is Saturday ");
//        break;
//       case 7:
//        Console.WriteLine("Today is Sunday");
//        break;
//    default: Console.WriteLine("Invalid Key Pressed");
//        break;
//}
// looping
//while loop
//int i = 11, n,sum=0;
//Console.WriteLine("To show sum of 1 to n , enter value of n");
//n=Convert.ToInt32(Console.ReadLine());
//while(i <= 10)
//{
//    sum += i;// sum=sum+i
//    i++;// i=i+1
//}

//Console.WriteLine($"sum 1 to 10 = {sum}");
//do 
//{
//    sum += i;// sum=sum+i
//    i++;// i=i+1
//}while(i <= 10);

//Console.WriteLine($"sum 1 to 10 = {sum}");
// for loop
int i,j;
for (i=100, j = 1; j <= 100;i--, j++)
{
    Console.Write($"j {j}  ");
    Console.Write(".......");
    Console.WriteLine($"i {i}  ");
}
Console.ReadKey();
