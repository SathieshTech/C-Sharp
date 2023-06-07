using System;
using System.Collections;
namespace SAT.bitAray
{
    class CLSbitaryac
    {
        
        static void Display(BitArray BAObj)
        {
            foreach(bool b in BAObj)
            {
                Console.Write(b ? 1 : 0);
            }
            Console.WriteLine("\n");
        }
        static void Main()
        {
            BitArray BAObja = new BitArray(6);

            BAObja[0] = true;
            BAObja[1] = true;
            BAObja.Set(5, true);

            Display(BAObja);
            BitArray BAObjb = new BitArray(6);
            BAObjb[5] = true;
            Display(BAObjb);
            BAObja.And(BAObjb);
            Display(BAObja);
        }
    }
}
/*
110001

000001

000001 
  
 */
