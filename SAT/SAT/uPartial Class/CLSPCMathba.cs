using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.uPartial_Class
{
    class CLSPCMathba
    {
        public static void Main()
        {
            CLSPCMathaa aa = new CLSPCMathaa();

            Console.WriteLine(aa.i);
            Console.WriteLine(aa.j);

            aa.uMinus(8, 3);
            Console.WriteLine(aa.uSum(4, 3));
        } 
    }
}
/*
7 <- i
2 <- j
5 <-uMinus
7 <-uSum
 */
