using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.linq_to_collection
{
    class CLSSelctaa
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
                     select row;
            foreach(var row in ds)
            {
                Console.Write("\n{0,4}\t{1,4}", row.rno, row.sname);
                Console.Write("\t{0,5}\t{1,5}", row.m1, row.m2);
                Console.Write("\t{0,6}\t{1,5}\t{2,4}\n", row.Total, row.Average,row.Result);
            }
        }
    }
}
/*
1001      x5     56.5      63    119.5  59.75   Pass
1002      x1       74      56      130     65   Pass
1003      x3       20      54       74     37   Fail
*/