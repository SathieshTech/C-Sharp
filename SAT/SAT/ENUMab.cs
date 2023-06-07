using System;

namespace SAT
{
    class ENUMab
    {
        enum CCName
        {
            agriculture,domestic,commercial
        }
        public static void Main()
        {
            Console.WriteLine(typeof(CCName));
            Console.WriteLine(Enum.IsDefined(typeof(CCName), 0));
            Console.WriteLine(Enum.IsDefined(typeof(CCName), 1));
            Console.WriteLine(Enum.IsDefined(typeof(CCName), 2));
            Console.WriteLine(Enum.IsDefined(typeof(CCName), 3));
        }
    }
}
/*
  SAT.ENUMab+CCName
True
True
True
False
*/