using System;
using System.Collections;


namespace SAT.araylist
{
    class CLSaddaa
    {
        public static void Main()
        {
            ArrayList ALObj = new ArrayList();
            ALObj.Add("Box");
            ALObj.Add(11);
            ALObj.Add(true);

            foreach (var v1 in ALObj)
                Console.WriteLine(v1);
        }
    }
}
/*
Box
11
True
 */
