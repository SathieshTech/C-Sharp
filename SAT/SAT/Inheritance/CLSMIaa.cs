using System;
/*
 example for Multilevel inheritance with Constructor and Destructor features
 */
namespace satprj.Inheritance
{
    public class CLSMLIaa
    {
        public CLSMLIaa()
        {
            Console.WriteLine("CONSTRUCTOR: CLSMLIaa");
        }
        ~CLSMLIaa()
        {
            Console.WriteLine("Destructor: CLSMLIaa");
        }
    }
    class CLSMLIab : CLSMLIaa
    {
        public CLSMLIab()
        {
            Console.WriteLine("CONSTRUCTOR: CLSMLIab");
        }
        ~CLSMLIab()
        {
            Console.WriteLine("Destructor: CLSMLIab");
        }
    }
    class CLSMLIac : CLSMLIab
    {
        public CLSMLIac()
        {
            Console.WriteLine("CONSTRUCTOR: CLSMLIac");
        }
        ~CLSMLIac()
        {
            Console.WriteLine("Destructor: CLSMLIac");
        }
    }
    class CLSMIad
    {
        public static void Main()
        {
            new CLSMLIac();
        }
    }
}
/*
CONSTRUCTOR: CLSMLIaa
CONSTRUCTOR: CLSMLIab
CONSTRUCTOR: CLSMLIac
Destructor: CLSMLIac
Destructor: CLSMLIab
Destructor: CLSMLIaa
*/

