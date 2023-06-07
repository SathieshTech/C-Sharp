using System;

namespace SAT.MDLaa
{
    class CLShomeaa
    {
        public static void Main()
        {
            Console.WriteLine("1.Exam result");
            Console.WriteLine("2.Salary tax");
            Console.WriteLine("3.Electricity bill");
            Console.WriteLine("4.Employee Allowanse");

            Console.WriteLine("Enter App no between 1 to 4:");

            int i = 0;
            int.TryParse(Console.ReadLine(), out i);
            
            if(!(i>=1 && i<=4))
            {
                Console.WriteLine("Ignore App no :");
                return;
            }
            if(i==1)
            {
                ERaa.Main();
                return;
            }
            if(i==2)
            {
                STaa.Main();
                return;
            }
            if (i==3)
            {
                EBaa.Main();
                return;
            }
            EAaa.Main();
        }
    }
}
