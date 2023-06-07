using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.chcked_and_unchcked
{
    class CLSchkunchkab
    {
        public static void Main()
        {
            int x = int.MinValue;
            int y = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(y);

            checked
            {
               // Console.WriteLine(--x);
            }
            checked
            {
                //Console.WriteLine(++y);
            }
        }
    }
}
/*
-2147483648
2147483647
 */
