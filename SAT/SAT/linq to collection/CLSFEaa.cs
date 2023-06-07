using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.linq_to_collection
{
    class CLSFEaa
    {
        public static void Main()
        {


            List<CLSERaa> erLst = new List<CLSERaa>()
            {
                new CLSERaa {rno=1001,sname="x5",m1=56.5,m2=63 },
                 new CLSERaa {rno=1002,sname="x1",m1=74,m2=56 },
                  new CLSERaa {rno=1003,sname="x3",m1=20,m2=54 }
        };
            foreach (CLSERaa er in erLst)
            {
                string sr = "\n{0,4}\t{1,3}\t{2,5}\t{4,6}\t{5,5}\t{6,4}\n";
                Console.WriteLine(sr, er.rno, er.sname, er.m1, er.m2, er.Total, er.Average, er.Result);
            }
        }
    }

}
/*
 1001     x5      56.5    119.5  59.75   Pass


1002     x1        74      130     65   Pass


1003     x3        20       74     37   Fail

 */
