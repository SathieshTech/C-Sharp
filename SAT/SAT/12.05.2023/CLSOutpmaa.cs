using System;
namespace SAT._12._05._2023
{
    class CLSOutpmaa
    {
        public static void uSum(int i,int j,out int k)
        {
            k = i + j;
        }
        public static void uFLnames(string fullname,out string fname,out string Lname)
        {
            int bsi = fullname.IndexOf(" ");

            if(bsi==-1)
            {
                fname = fullname;
                Lname = null;
                return;
            }

            fname = fullname.Substring(0, bsi).Trim();
            Lname = fullname.Substring(bsi).Trim();
        }
        public static void Main()
        {
            int x = 0;
            uSum(2, 5, out x);
            Console.WriteLine(x);
            string fullname = "raja raghu raman", sonname = null, fathername = null;
            uFLnames(fullname, out sonname, out fathername);
            Console.WriteLine(sonname);
            Console.WriteLine(fathername);


            Console.WriteLine("abcdABCDefghABCD".IndexOf("A"));
            Console.WriteLine("abcdABCDefghABCD".LastIndexOf("A"));

            Console.WriteLine("abcdABCDefghABCD".Substring(0, 8));
            Console.WriteLine("abcdABCDefghABCD".Substring(10));


        }

    }
}
/*
 7
raja
raghu raman

4    
12
abcdABCD
ghABCD

 */
