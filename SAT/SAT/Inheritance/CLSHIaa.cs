using System;
/*
 example for Hierachial inheritance with Constructor and Destructor features
 */
namespace SAT.Inheritance
{
    class CLSHIaa
    {
        public CLSHIaa()
        {
            Console.WriteLine("Constructor : CLSHIaa");
        }
        ~CLSHIaa()
        {
            Console.WriteLine("Destructor : CLSHIaa");
        }
    }

    class CLSHIab : CLSHIaa
    {
        public CLSHIab()
        {
            Console.WriteLine("Constructor : CLSHIab");
        }
        ~CLSHIab()
        {
            Console.WriteLine("Destructor : CLSHIab");
        }
    }
    class CLSHIac : CLSHIaa
    {
        public CLSHIac()
        {
            Console.WriteLine("Constructor : CLSHIac");
        }
        ~CLSHIac()
        {
            Console.WriteLine("Destructor : CLSHIac");
        }
    }
    class CLSHIad
    { 
        public static void Main()
        {
            new CLSHIab();
            new CLSHIac();
        }
    }

}
/*
 Constructor : CLSHIaa
Constructor : CLSHIac
Constructor : CLSHIaa
Constructor : CLSHIac

Destructor : CLSHIac
Destructor : CLSHIaa
Destructor : CLSHIab
Destructor : CLSHIaa
*/