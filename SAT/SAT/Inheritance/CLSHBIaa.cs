using System;

/*
 example for Hybrid inheritance with Constructor and Destructor features
 Hybrid inheritance is combination of Mutiple&Hierchical inheritances
 */


namespace SAT.Inheritance
{
    interface CLSHBIaa
    {
        void uAuthor();
    }
    interface ITHBIab:CLSHBIaa
    {
        void uSum(int x, int y);
        double uMinus(double x, double y);
    }
    interface ITHBIac:CLSHBIaa
    {
        int uMultiply(int x, int y);
        void uDivide(double x, double y);
    }
    class CLSHBIad: ITHBIab,ITHBIac
    {
        public CLSHBIad()
        {
            Console.WriteLine("Constructor : CLSHBIad");
        }
        ~CLSHBIad()
        {
            Console.WriteLine("Destructor : CLSHBIad");
        }
        public void uAuthor()
        {
            Console.WriteLine("Develop by CMR2SPR");
        }
        public void uSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public double uMinus(double x, double y)
        {
            return x - y;
        }
        public int uMultiply(int x, int y)
        {
            return x * y;
        }
        public void uDivide(double x, double y)
        {
            Console.WriteLine(x / y);
        }
    }
    class CLSHBIab
    {
        public static void Main()
        {
            CLSHBIad ad=new CLSHBIad();

            ad.uAuthor();

            ad.uSum(1, 9);
            Console.WriteLine(ad.uMinus(8, 5));

            Console.WriteLine(ad.uMultiply(2, 5));
            ad.uDivide(20, 3);
        }
    }
}

/*
Constructor : CLSHBIad
Develop by CMR2SPR
10
3
10
6.66666666666667
Destructor : CLSHBIad
*/