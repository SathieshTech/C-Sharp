using System;

namespace SAT
{
    class ERaa
    {
        public static void Main()
        {
            int rno = 1001;
            string sname = "x5";
            double m1 = 36.5, m2 = 52;
            double total = (m1 + m2), avg = (m1 + m2) / 2;
            bool result = (m1>34.4 && m2>34.4);

            Console.WriteLine("exam result info:\n");
            Console.WriteLine("Roll no:" + rno);
            Console.WriteLine("Name:" + sname);
            Console.WriteLine("Mark-1:" + m1);
            Console.WriteLine("Mark-2:" + m2);
            Console.WriteLine("Total:" + total);
            Console.WriteLine("Average:" + avg);
            Console.WriteLine("Result :\t" + (result ? "pass" : "fail"));

        }
    }
}
