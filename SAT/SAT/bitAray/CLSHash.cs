using System;
using System.Collections.Generic;
using System.Collections;

namespace SAT.bitAray
{
    class CLSHash
    {
        public static void Main()
        {
            Hashtable HTObj = new Hashtable();
            HTObj["BOX"] = 11;
            HTObj[22] = "FOX";
            Console.WriteLine(HTObj["BOX"]);
            Console.WriteLine(HTObj[22]);
        }
    }
}
/*
 11
FOX
 */
