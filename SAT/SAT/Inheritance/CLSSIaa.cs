using System;
/*
 example for Single inheritance with Constructor and Destructor features
*/
namespace satprj.Inheritance
{
    class CLSSIaa
    {
        public CLSSIaa()
        {
            Console.WriteLine("constructor : CLSSIaa");
        }
        ~CLSSIaa()
        {
            Console.WriteLine("Destructor : CLSSIaa");
        }
    }

    class CLSSIab : CLSSIaa
    {
        public CLSSIab()
        {
            Console.WriteLine("Constructor : CLSSIab");
        }
        ~CLSSIab()
        {
            Console.WriteLine("Destructor :CLSSIab");
        }
    }

    class CLSSIac
    {
        public static void Main()
        {
            new CLSSIab();
        }
    }
}

/*
 Constructor : CLSSIaa
 Constructor : CLSSIab

 Destructor : CLSSIab
 Destructor : CLSSIaa
 */
