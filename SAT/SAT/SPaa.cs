﻿using System;

namespace SAT
{
    class SPaa
    {

        public int udSum(int x, int y)
        {
            return x + y;
        }



        public static int udMinus(int x, int y)
        {
            return x - y;
        }

        public static void Main()
        {
            SPaa spa = new SPaa();
            Console.WriteLine(spa.udSum(4, 5));
            Console.WriteLine(SPaa.udMinus(8, 1));
        }
    }
}
/*
 9
7
*/