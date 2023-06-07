using System;
using System.Collections.Generic;
using System.Collections;
namespace SAT.uStatement_category
{
    class CLSartwocoll
    {
        static void Display(List<string>LstobjT)
        {
            Console.WriteLine("\n" + LstobjT.Capacity);
            foreach (string strobj in LstobjT)
                Console.WriteLine(strobj);
        }
        public static void Main()
        {
            List<string> Lstobj = new List<string>(new string[] { "BOX", "FOX" });
            Display(Lstobj);
            Lstobj.AddRange(Lstobj);
            Display(Lstobj);
            Lstobj.RemoveRange(2, 2);
            Display(Lstobj);
            Lstobj.InsertRange(1, new string[] { "xx", "x" });
            Display(Lstobj);

            string[] strobj = Lstobj.GetRange(0, 2).ToArray();
            Lstobj = new List<string>(strobj);
            Display(Lstobj);

        }
    }
}
/*
 
2
BOX
FOX

4
BOX
FOX
BOX
FOX

4
BOX
FOX

4
BOX
xx
x
FOX

2
BOX
xx 
 */
