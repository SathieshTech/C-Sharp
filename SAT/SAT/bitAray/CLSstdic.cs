using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;

namespace SAT.bitAray
{
    class CLSstdic
    {
        static void Main()
        {
            StringDictionary SDObj = new StringDictionary();
            SDObj.Add("Box", "11");
            SDObj.Add("Fox", "22");

            foreach (string strkey in SDObj.Keys)
                Console.WriteLine(strkey);
            foreach (string strval in SDObj.Values)
                Console.WriteLine(strval);
        }
        
    }
}
/*
box
fox
11
22
 */
