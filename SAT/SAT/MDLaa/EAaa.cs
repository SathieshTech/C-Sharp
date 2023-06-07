using System;


namespace SAT.MDLaa
{
    class EAaa
    {
        public static void Main()
        {
            string ip = null;

            Console.WriteLine("ID :");
            ip = Console.ReadLine();
            
           
            int eid = 0;
            int.TryParse(ip, out eid);

            Console.WriteLine("Name :");
            string ename = Console.ReadLine();

            Console.WriteLine("Salary :");
            ip = Console.ReadLine();

            double esal = 0;
            double.TryParse(ip, out esal);

            double hra=0, da=0, pf=0, gpay=0, npay = 0;

            hra = esal * (20.0 / 100);
            da = esal * (15.0 / 100);
            pf = esal * (35.0 / 100);
            gpay = esal + hra + da;
            npay = esal - pf;

            Console.WriteLine("Employee Allowanse info:");
            Console.WriteLine("Employee ID:" +eid);
            Console.WriteLine("Employee Name:" + ename);
            Console.WriteLine("Employee Salary:" + esal);
            Console.WriteLine("Houserent Allowanse:" + hra);
            Console.WriteLine("Dearness Allowanse:" + da);
            Console.WriteLine("Provident Fund:" + pf);
            Console.WriteLine("Gross Pay:" + gpay);
            Console.WriteLine("Net Pay:" + npay);

        }
    }
}
