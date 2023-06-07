using System;


namespace SAT
{
    class SPac
    {
        public static void Main()
        {
            UDCLmath Umath = new UDCLmath();
            Console.WriteLine(Umath.udmSum(1, 9));
            Umath.udmMultiply(2, 8);
            Console.WriteLine(UDCLmath.udmMinus(6, 2));
            UDCLmath.udmDivide(20, 3);
        }
    }
}
/*
 10
16
4
6
*/