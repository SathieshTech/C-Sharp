using System;


namespace SAT
{
    class EHaa
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("welcome");
               int i= 10, j = 0;
                Console.WriteLine(i / j);
                Console.WriteLine("THANKS");
            }catch(Exception e)
            {
                Console.WriteLine("err.:" + e.Message);
            }
            Console.WriteLine("VISIT AGAIN...");
        }
    }
}
