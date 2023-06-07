using System;
using System.Collections;
namespace SAT.bitAray
{
    class CLSbitaryab
    {
        public static void Main()
        {
            BitArray BAObj = new BitArray(6);
            BAObj[0] = true;
            BAObj[2] = true;
            BAObj.Set(5, true);

            Console.WriteLine(BAObj.Count);
             int i = 0;
            foreach (bool b in BAObj)
            {
                if(b)
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
/*
 6
 3
 */
