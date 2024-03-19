using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass_Obj
{
    internal class Date
    {
        public int year { get; set; }
        public int month { get; set; }  
        public int day{get;set; }
        public Date()
        {
            day = 15;
            month = 8;
            year = 1947;
        }
        public Date(int d,int m,int y)
        {
            day=d; month=m; year=y;
        }

        public override string ToString()
        {
            return "Date:"+day+" / "+month+" / "+ year;
        }
    }
}
