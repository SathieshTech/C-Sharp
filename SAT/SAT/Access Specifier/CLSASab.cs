using System;
/*
 title:
 example for access specifier : 'private'
 */

namespace SAT.Access_Specifier
{
    class CLSASaa
    {
        private int x;
    }
    class CLSASab
    {
        public static void Main()
        {
            CLSASaa aa = new CLSASaa();
        //Console.WriteLine(aa.x);
        }
    }
}
