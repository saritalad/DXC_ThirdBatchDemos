using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericSortedList
{
    class DecendingComparer<T> : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //SortedList<int, int> descSortedList = new SortedList<int, int>(new DecendingComparer<int>());
            //descSortedList.Add(1, 5);
            //descSortedList.Add(4, 0);
            //descSortedList.Add(3, 7);
            //descSortedList.Add(2, 2);

            //for (int i = 0; i < descSortedList.Count; i++)
            //{
            //    Console.WriteLine("key: {0}, value: {1}", descSortedList.Keys[i], descSortedList.Values[i]);
            //}
            SortedList mylist = new SortedList();
            mylist.Add(1, "g");
            mylist.Add(2, "v");
            mylist.Add(5, "d");
            mylist.Add(3, "r");
            foreach(DictionaryEntry pair in mylist)
            {
                Console.WriteLine(pair.Key+" "+pair.Value);
            }
            SortedList<int, string> Mylist = new SortedList<int, string>();
            Mylist.Add(12, "ABC");
            Mylist.Add(22, "PQR");
            Mylist.Add(52, "QWE");
            Mylist.Add(02, "WER");
            foreach(var  pair in Mylist)
                Console.WriteLine(pair.Key + " " + pair.Value);


        }


     
    }
}
