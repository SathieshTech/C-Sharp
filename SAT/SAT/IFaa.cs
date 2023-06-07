using System;

namespace SAT
{
    class IFaa
    {
        public static void Main()
        {
            int i = 5, j = 9, k = 2;
            if(i>j && i>k)
            {
                Console.WriteLine("Big number : " + i);
            }else if(j>k)
            {
                Console.WriteLine("Big number : " + j);
            }
            else
            {
                Console.WriteLine("Big number : " + k);
            }
        }
    }
}
