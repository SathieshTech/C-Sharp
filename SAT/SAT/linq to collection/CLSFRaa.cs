using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.linq_to_collection
{
    class CLSFRaa
    {
        public static void Main()
        {
            List<CLSERaa> erLst = new List<CLSERaa>()
            {
                new CLSERaa {rno=1001,sname="x5",m1=56.5,m2=63 },
                 new CLSERaa {rno=1002,sname="x1",m1=74,m2=56 },
                  new CLSERaa {rno=1003,sname="x3",m1=20,m2=54 }
          };
            var ds = from row in erLst
                     select new { row.rno, row.Result };
            foreach (var row in ds)
            {
                Console.WriteLine("\n{0,4}\t{1,4}", row.rno, row.Result);
            }
        }
    }
}
/*
 1001    Pass

1002    Pass

1003    Fail
*/
