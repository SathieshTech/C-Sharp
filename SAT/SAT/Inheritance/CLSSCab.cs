using System;

/*
 title:
 example for storage clause are 'static' and 'non-static'

 non-static alias name is instance
 */

namespace SAT.Inheritance
{
    class CLSSCaa
    {
        public int x;
        public static int y;
    }
    class CLSSCab
    {
        public static void Main()
        {
            CLSSCaa a1 = new CLSSCaa();
            CLSSCaa a2 = new CLSSCaa();
            CLSSCaa a3 = new CLSSCaa();

            Console.WriteLine(a1.x);
            Console.WriteLine(a2.x);
            Console.WriteLine(a3.x);

            Console.WriteLine(CLSSCaa.y);

            a1.x = 5;
            a2.x = 10;
            a3.x = 15;
            CLSSCaa.y = 3;

            Console.WriteLine(a1.x);
            Console.WriteLine(a2.x);
            Console.WriteLine(a3.x);

            Console.WriteLine(CLSSCaa.y);

        }
    }
}
/*
0
0
0
0
5
10
15
3
 */
