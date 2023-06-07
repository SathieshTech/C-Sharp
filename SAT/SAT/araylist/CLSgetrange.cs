using System;
using System.Collections;
namespace SAT.araylist
{
    class CLSgetrange
    {
        public static void Main()
        {
            ArrayList ALObja = new ArrayList();
            ALObja.Add("Box");
            ALObja.Add(11);
            ALObja.Add(4.2);
            ALObja.Add(true);

            ArrayList ALObjb = ALObja.GetRange(2, 2);
            foreach (var v1 in ALObjb)
                Console.WriteLine(v1);
        }
    }
}
/*
4.2
True
 */
