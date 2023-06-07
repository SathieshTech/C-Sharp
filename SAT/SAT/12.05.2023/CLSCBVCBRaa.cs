using System;

namespace SAT._12._05._2023
{
    class CLSCBVCBRaa
    {
        public static void uSwap(int i,int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;

            Console.WriteLine("swap[i] : " + i);
            Console.WriteLine("swap[j]: " + j);
        }
        public static void uExchange(ref int i,ref int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;

            Console.WriteLine("Exchange[i] : " + i);
            Console.WriteLine("Exchange[j]: " + j);
        }
        public static void Main()
        {
            int a = 5, b = 2;
            int x = 4, y = 9;

            Console.WriteLine("Before swap[a]:" + a);
            Console.WriteLine("Before swap[b]:" + b);
            uSwap(a, b);
            Console.WriteLine("After swap[a]:" + a);
            Console.WriteLine("After swap[b]:" + b);

            Console.WriteLine("Before Exchange[x]:" + x);
            Console.WriteLine("Before Exchange[y]:" + y);
            uExchange(ref x, ref y);
            Console.WriteLine("After Exchange[x]:" + x);
            Console.WriteLine("After Exchange[y]:" + y);
        }
    }
}
/*
 Before swap[a]:5
Before swap[b]:2
swap[i] : 2
swap[j]: 5
After swap[a]:5
After swap[b]:2
Before Exchange[x]:4
Before Exchange[y]:9
Exchange[i] : 9
Exchange[j]: 4
After Exchange[x]:9
After Exchange[y]:4 
 */
