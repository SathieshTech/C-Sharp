using System;
namespace SAT._12._05._2023
{
    class CLSseaaa
    {
        public CLSseaaa()
        {
            Console.WriteLine("Constructor : CLSseaaa");
        }
        ~CLSseaaa()
        {
            Console.WriteLine("Destructor : CLSseaaa");
        }
    }
        sealed class CLSseaab : CLSseaaa
        {
        public CLSseaab()
        {
            Console.WriteLine("Constructor : CLSseaab");
        }
        ~CLSseaab()
            {
            Console.WriteLine("Destructor : CLSseaab");
        }
        class CLSsealedaa
        {
            public static void Main()
            {
                new CLSseaab();
            }
        }


    }
}
/*
 Constructor : CLSseaaa
Constructor : CLSseaab
Destructor : CLSseaab
Destructor : CLSseaaa
 */
