using System;


namespace SAT
{
    class TCab
    {
        public static void Main()
        {
            string s = "fox";
            int i = 0;
            int.TryParse(s, out i);
            Console.WriteLine(i + "-" + i.GetType());
            Console.WriteLine(s + "-" + s.GetType());
        }
    }
}
