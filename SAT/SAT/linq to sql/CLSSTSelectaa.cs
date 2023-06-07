using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;

namespace SAT.linq_to_sql
{
    class CLSSTSelectaa
    {
        public static void Main()
        {
            DataContext dc = new DataContext(CLSCnStr.forstdb);
            var ds = from row in dc.GetTable<CLSSTaa>()
                     select new
                     {
                         eid = row.eid,
                         ename = row.ename,
                         esal = row.esal,
                         tax10 = row.tax10,
                         tax20 = row.tax20,
                         tax30 = row.tax30,
                         ttax = row.ttax,
                         npay = row.npay
                     };
            Console.WriteLine("\nSalary tax table has records\n");

            foreach (var obj in ds)
            {
                Console.Write(" {0,4}", obj.eid);
                Console.Write(" {0,-5}", obj.ename);
                Console.Write(" {0,12}", obj.esal);
                Console.Write(" {0,12}", obj.tax10);
                Console.Write(" {0,12}", obj.tax20);
                Console.Write(" {0,12}", obj.tax30);
                Console.Write(" {0,12}", obj.ttax);
                Console.Write(" {0,12}", obj.npay);
                Console.WriteLine("\n");
            }
        }
    }
}
/*
 Salary tax table has records

 1002 x2       400000.00    25000.000        0.000        0.000    25000.000   375000.000

 1003 x3       600000.00    25000.000   100000.000        0.000   125000.000   475000.000

 1004 x5      1000000.00    25000.000   100000.000        0.000   125000.000   875000.000

 1005 x9      2500000.00    25000.000   100000.000   450000.000   575000.000  1925000.000 
 */
