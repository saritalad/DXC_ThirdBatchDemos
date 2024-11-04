using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_And_LambdaExpression_DEmo
{
    internal class Program1
    {
        //static void Main(string[] args)
        //{
        //    List<Person> listPersonsInCity = new List<Person>();

        //    listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
        //    listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
        //    listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
        //    listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
        //    listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
        //    listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
        //    listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
        //    listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
        //    listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));
        //    Console.WriteLine( ".....................................................................");
        //    Console.WriteLine("people having age <60 ");
        //    //foreach (Person p  in listPersonsInCity.FindAll(e=>e.Age<60).ToList().Take(2))
        //    //{

        //    //    Console.WriteLine(p.Name + " "+p.Age);
        //    //}
        
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine("\n Checking whether any person is teen-ager or not...");
        //    if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
        //    {
        //        Console.WriteLine(" Yes, we have some teen-agers in the list");
        //    }
        //    Console.WriteLine( ".............Check if age of all people is above 10 or not ..............");

        //    Console.WriteLine("\n Checking whether a person having name 'SAM' exists or not...");
        //    if (listPersonsInCity.Exists(e => e.Name == "SAM"))
        //    {
        //        Console.WriteLine(" Yes, A person having name  'SAM' exists in our list");
        //    }

        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine("\n Checking the index position of a person having name 'Smith' ...");
        //    int indexForSmith = listPersonsInCity.FindIndex(e => e.Name == "Smith");
        //    Console.WriteLine(" In the list, The index position of a person having name 'Smith' is : " + indexForSmith);

        //    Console.WriteLine(".............................................");
        //    Console.WriteLine(" Max age of a person"  );
        //    int maxage= listPersonsInCity.Max(e=>e.Age);
        //    Console.WriteLine($"Max  Age of a person is {maxage}");
        //    Person p = listPersonsInCity.First(m => m.Age == (listPersonsInCity.Max(e => e.Age)));
        //    Console.WriteLine(" The most aged person in our list is: " + p.Name + " whose age is: " + p.Age);
        //    List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
        //    // Will contain { 1, 2, 4 } 
        //    Console.WriteLine("please take numbers from beginiing till they are less than 5\n once you find number >= 5 stop taking ");
        //    IEnumerable<int> result = ints.TakeWhile(theInt => theInt < 5);
        //   foreach(int i in result)
        //        Console.WriteLine(i);
        //    //SkipWhile()
        //    List<int> I = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
        //    // Will contain { 4, 8, 4, 2, 1 } 
        //    Console.WriteLine("please skip numbers from beginning till they are not equal to 4 once u find number equql to 4 \n stop skipping and take all numbers " );
        //    IEnumerable<int> skipresult = I.SkipWhile(theInt => theInt != 4);
        //    Console.WriteLine("numbers from begining are skipped because they satisfy the condition  till 4 after that all numbers are taken ");
        //    foreach(int i in skipresult)
        //        Console.WriteLine(i);
        //}
    }
}