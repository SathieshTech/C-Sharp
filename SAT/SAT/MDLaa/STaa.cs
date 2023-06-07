using System;

namespace SAT
{
    class STaa
    {
        public static void Main()
        {
            Console.WriteLine("enter employee info");
            string ip = null;

            Console.Write("ID :\t");
            ip = Console.ReadLine();

            int eid = 0;
            int.TryParse(ip, out eid);

            Console.Write("Name :\t");
            string ename = Console.ReadLine();
            Console.Write("salary :\t");
            ip = Console.ReadLine();
            double esal = 0;
            double.TryParse(ip, out esal);
            double tax10 = 0, tax20 = 0, tax30 = 0, taxtot = 0, npay = 0;

            if (esal > 1000000)
            {
                tax10 = 25000;
                tax20 = 100000;
                tax30 = (esal - 1000000) * 30.0 / 100;
            }else if(esal>500000)
            {
                tax10 = 25000;
                tax20 = (esal - 500000) * 20.0 / 100;
            }
            else if (esal>250000)
            {
                tax10 = (esal - 250000) * 10.0 / 100;

            }
            else if(esal<0)
            {
                esal = 0;
            }
            taxtot = tax10 + tax20 + tax30;
            npay = esal - taxtot;
            Console.WriteLine("\n employee salary tax info\n");
            Console.WriteLine("ID :\t" + eid);
            Console.WriteLine("Name :\t" + ename);
            Console.WriteLine("Salary :\t" + esal);
            Console.WriteLine("Tax10%:\t" + tax10);
            Console.WriteLine("Tax20% :\t" + tax20);
            Console.WriteLine("Tax30% :\t" + tax30);
            Console.WriteLine("Total tax :\t" + taxtot);
            Console.WriteLine("Netpay :\t" + npay);




        }
       
    }
}
