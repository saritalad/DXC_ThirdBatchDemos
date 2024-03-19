using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleAppCollections
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] my = new int[10];
        //    ArrayList myaarlist = new ArrayList();
        //    myaarlist.Add(10);// value type is converted to object type 
        //    myaarlist.Add(25.90f);// called boxing
        //    myaarlist.Add(Math.PI);
        //    myaarlist.Add(DateTime.Now);
        //    myaarlist.Add('c');
        //    myaarlist.Add("India");
        //    myaarlist.Add(new Student { Id=1,Name="Bill"});
        //    //foreach (object o   in myaarlist) {
        //    //    // unboxing is the process where object type is converted to value (original) type 
        //    //    Console.WriteLine(o);
        //    //}
        //    // Stack
        //    Stack mystack = new Stack();// LIFO Last in First Out 
        //    mystack.Push(new Student { Id = 2, Name = "Mill" });
        //    mystack.Push(100);
        //    mystack.Push(23.89m);
        //    mystack.Push("Bharat");
        //    mystack.Push(0.000987);
        //    Console.WriteLine("size of Stack " + mystack.Count);
        //    Console.WriteLine(mystack.Pop());
        //    Console.WriteLine(mystack.Pop());// to remove 
        //    Console.WriteLine(mystack.Peek());// to observe / to read 
        //    Console.WriteLine(mystack.Pop());
        //    //Queue  First In Fist Out    FIFO
        //    //Queue myq = new Queue();
        //    //myq.Enqueue(new Student { Id = 3, Name = "Nill" });
        //    //myq.Enqueue(2000);
        //    //myq.Enqueue("Himalaya");
        //    //myq.Enqueue(25.50m);
        //    //myq.Enqueue('f');
        //    //myq.Enqueue(true);
        //    //Console.WriteLine("size of Queue " + myq.Count);
        //    //Console.WriteLine(myq.Dequeue());
        //    //Console.WriteLine(myq.Dequeue());

        //    //Hashtable myhashtable=new Hashtable();
        //    //myhashtable.Add(1, "One");
        //    //myhashtable.Add(2, "Two");
        //    //myhashtable.Add(3, "Three");
        //    //myhashtable.Add(4,new Student() { Id=4,Name="Jill"});
        //    //// myhashtable.Add(null, "five");
        //    //myhashtable.Add(5, null);
        //    //foreach(DictionaryEntry entry in myhashtable)
        //    //    Console.WriteLine(entry.Key+ "  "+entry.Value);

        //    // Generic Collections
        //    List<string> fruits=new List<string>();
        //    fruits.Add("Orange");
        //    fruits.Add("Mango");
        //    fruits.Add("Grapes");
        //    fruits.Add("Apple");
        //   // fruits.Add(100); no boxing , only homogeneous data accepted 
        //   //foreach(string f in fruits)
        //   // {
        //   //     Console.WriteLine(f);
        //   // }
        //   //fruits.Sort();
        //   // Console.WriteLine("Sorted List of Fruits ");
        //   // foreach (string f in fruits)
        //   // {
        //   //     Console.WriteLine(f);
        //   // }
        //    // stack but Generic
        //    Stack<int> genstack=new Stack<int>();
        //       genstack.Push(1);
        //        genstack.Push(20);
        //        genstack.Push(30);
        //    genstack.Push(78);
        //    Console.WriteLine("Data from Generic stack ");
        //    Console.WriteLine(genstack.Pop());
        //    Console.WriteLine(genstack.Pop());
        //    // Queue generic 

        //    Queue<Student> genq = new Queue<Student>();
        //    genq.Enqueue(new Student { Id = 1, Name = "bill" });
        //    genq.Enqueue(new Student { Id = 2, Name = "Mill" });
        //    genq.Enqueue(new Student { Id = 3, Name = "Jill" });
        //    genq.Enqueue(new Student { Id = 4, Name = "Nill" });
        //    Console.WriteLine("Data from Generic Queue ");
        //    Console.WriteLine(genq.Dequeue());
        //    Console.WriteLine(genq.Dequeue());
        //    Dictionary<int, string> mydic = new Dictionary<int, string>();
        //    mydic.Add(1, "one");
        //    mydic.Add(2, "two");
        //    mydic.Add(3, "Three");
        //    mydic.Add(4,"four");
        //    Console.WriteLine("value having key 3:" + mydic[3]);

        //    foreach(KeyValuePair<int, string> kvp in mydic)
        //        Console.WriteLine("key {0} and value {1}",kvp.Key ,kvp.Value);


        //}
    }
}
