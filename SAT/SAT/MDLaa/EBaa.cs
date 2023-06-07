using System;
namespace SAT
{
    enum Consumercategory
    {
        Agriculture,Domestic,Commercial
    }
    class EBaa
    {
        public static void Main()
        {
            int cid = 0;
            Console.WriteLine("\nConsumer ID:");
            int.TryParse(Console.ReadLine(), out cid);

            int pread = 0;
            Console.WriteLine("\nConsumer Previous reading:");
            int.TryParse(Console.ReadLine(), out pread);

            int cread = 0;
            Console.WriteLine("\nConsumer Current reading:");
            int.TryParse(Console.ReadLine(), out cread);

            if (cread < pread)

            {
                Console.WriteLine("Invalid reading...");
                return;
            }
            Consumercategory cc = Consumercategory.Commercial;
            Console.Write("\nConsumer category");
            Console.Write("\n0. Agriculture");
            Console.Write("\n1. domestic");
            Console.Write("\n2. commercial");
            Console.WriteLine("\n[0, 1 or 2]: ");

            int i = 2;
            int.TryParse(Console.ReadLine(), out i);

            if (Enum.IsDefined(typeof(Consumercategory), i) == false)
            {
                Console.WriteLine("Invalid : Consumer Category");
                return;
            }
            int nread = cread - pread;

            if (nread < 0)
            {
                Console.WriteLine("Invalid : Net Reading");
                return;
            }
            int cuu100 = 0, cuu200 = 0, cuu400 = 0, cua400 = 0;
            if (nread > 400)
            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = 200;
                cua400 = nread - 400;
            }
            else if (nread > 200)

            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = nread - 200;
            }
            else if (nread>100)
                {
                cuu100 = 100;
                cuu200 = nread - 100;
            }
            else if (nread>0)
            {
                cuu100 = nread;
            }
            double puau100 = 0, puau200 = 0, puau400 = 0, puaa400 = 0;
            double cuau100 = 0, cuau200 = 0, cuau400 = 0, cuaa400=0;
            double mc = 0, taxp = 0, taxa = 0, npay = 0;

            cc = (Consumercategory)i;

            if(cc==Consumercategory.Agriculture)
            {
                puau100 = 0.25;
                puau200 = 0.50;
                puau400 = 1.50;
                puaa400 = 2.00;
                mc = 12.50;
                taxp = 2.5;
            
            }
            else if (cc==Consumercategory.Domestic)
                {
                puau100 = 0.50;
                puau200 = 1.00;
                puau400 = 3.00;
                puaa400 = 6.00;
                mc = 25.00;
                taxp = 5.0;
            }
            else if (cc==Consumercategory.Commercial)
            {
                puau100 = 1.00;
                puau200 = 2.00;
                puau400 = 6.00;
                puaa400 = 10.00;
                mc = 200.00;
                taxp = 7.5;

            }
            cuau100 = puau100 * cuu100;
            cuau200 = puau200 * cuu200;
            cuau400 = puau400 * cuu400;
            cuaa400 = puaa400 * cua400;

            taxa = (taxp / 100) * cuaa400;
            npay = cuau100 + cuau200 + cuau400 +cuaa400+ taxa + mc;

            Console.WriteLine("Consumer Net reading:" + nread);
            if(cuau100>0)
            {
                Console.WriteLine("Per unit amount upto 100:" + puau100);
                Console.WriteLine("Consume unit upto 100:" + cuu100);
                Console.WriteLine("consume unit amount upto 100:" + cuau100);
            }
            if (cuau200>0)
            {
                Console.WriteLine("Per unit amount upto 200:" + puau200);
                Console.WriteLine("Consume unit upto 200:" + cuu200);
                Console.WriteLine("consume unit amount upto 200:" + cuau200);
            }
            if(cuau400>0)
            {
                Console.WriteLine("Per unit amount upto 100:" + puau400);
                Console.WriteLine("Consume unit upto 100:" + cuu400);
                Console.WriteLine("consume unit amount upto 100:" + cuau400);
            }
         
            if(cuaa400>0)
            {
                Console.WriteLine("Per unit amount upto 100:" + puaa400);
                Console.WriteLine("Consume unit upto 100:" + cua400);
                Console.WriteLine("consume unit amount upto 100:" + cuaa400);

                Console.WriteLine("Tax amount :" + taxa);
            }
            Console.WriteLine("Meter charge:" + mc);
            Console.WriteLine("Net pay:" + npay);

        }
    }
}


/*
 //Agriculture
 Consumer ID:
1001

Consumer Previous reading:
0

Consumer Current reading:
50

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
0
Consumer Net reading:50
Per unit amount upto 100:0.25
Consume unit upto 100:50
consume unit amount upto 100:12.5
Meter charge:12.5
Net pay:25

 Consumer ID:
1002

Consumer Previous reading:
0

Consumer Current reading:
150

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
0
Consumer Net reading:150
Per unit amount upto 100:0.25
Consume unit upto 100:100
consume unit amount upto 100:25
Per unit amount upto 200:0.5
Consume unit upto 200:50
consume unit amount upto 200:25
Meter charge:12.5
Net pay:62.5

    Consumer ID:
1003

Consumer Previous reading:
0

Consumer Current reading:
350

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
0
Consumer Net reading:350
Per unit amount upto 100:0.25
Consume unit upto 100:100
consume unit amount upto 100:25
Per unit amount upto 200:0.5
Consume unit upto 200:100
consume unit amount upto 200:50
Per unit amount upto 100:1.5
Consume unit upto 100:150
consume unit amount upto 100:225
Meter charge:12.5
Net pay:312.5

 //domestic   
Consumer ID:
1004

Consumer Previous reading:
0

Consumer Current reading:
550

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
0
Consumer Net reading:550
Per unit amount upto 100:0.25
Consume unit upto 100:100
consume unit amount upto 100:25
Per unit amount upto 200:0.5
Consume unit upto 200:100
consume unit amount upto 200:50
Per unit amount upto 100:1.5
Consume unit upto 100:200
consume unit amount upto 100:300
Per unit amount upto 100:2
Consume unit upto 100:150
consume unit amount upto 100:300
Tax amount :7.5
Meter charge:12.5
Net pay:395
*/

/*
 Consumer ID:
1005

Consumer Previous reading:
0

Consumer Current reading:
50

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
1
Consumer Net reading:50
Per unit amount upto 100:0.5
Consume unit upto 100:50
consume unit amount upto 100:25
Meter charge:25
Net pay:50

Consumer ID:
1006

Consumer Previous reading:
0

Consumer Current reading:
150

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
1
Consumer Net reading:150
Per unit amount upto 100:0.5
Consume unit upto 100:100
consume unit amount upto 100:50
Per unit amount upto 200:1
Consume unit upto 200:50
consume unit amount upto 200:50
Meter charge:25
Net pay:125

    Consumer ID:
1007

Consumer Previous reading:
0

Consumer Current reading:
350

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
1
Consumer Net reading:350
Per unit amount upto 100:0.5
Consume unit upto 100:100
consume unit amount upto 100:50
Per unit amount upto 200:1
Consume unit upto 200:100
consume unit amount upto 200:100
Per unit amount upto 100:3
Consume unit upto 100:150
consume unit amount upto 100:450
Meter charge:25
Net pay:625

    
Consumer ID:
1008

Consumer Previous reading:
0

Consumer Current reading:
550

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
1
Consumer Net reading:550
Per unit amount upto 100:0.5
Consume unit upto 100:100
consume unit amount upto 100:50
Per unit amount upto 200:1
Consume unit upto 200:100
consume unit amount upto 200:100
Per unit amount upto 100:3
Consume unit upto 100:200
consume unit amount upto 100:600
Per unit amount upto 100:6
Consume unit upto 100:150
consume unit amount upto 100:900
Tax amount :45
Meter charge:25
Net pay:820


    //commercial
    Consumer ID:
1009

Consumer Previous reading:
0

Consumer Current reading:
50

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
2
Consumer Net reading:50
Per unit amount upto 100:1
Consume unit upto 100:50
consume unit amount upto 100:50
Meter charge:200
Net pay:250

Consumer ID:
1010

Consumer Previous reading:
0

Consumer Current reading:
150

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
2
Consumer Net reading:150
Per unit amount upto 100:1
Consume unit upto 100:100
consume unit amount upto 100:100
Per unit amount upto 200:2
Consume unit upto 200:50
consume unit amount upto 200:100
Meter charge:200
Net pay:400

Consumer ID:
1011

Consumer Previous reading:
0

Consumer Current reading:
350

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
2
Consumer Net reading:350
Per unit amount upto 100:1
Consume unit upto 100:100
consume unit amount upto 100:100
Per unit amount upto 200:2
Consume unit upto 200:100
consume unit amount upto 200:200
Per unit amount upto 100:6
Consume unit upto 100:150
consume unit amount upto 100:900
Meter charge:200
Net pay:1400

Consumer ID:
1012

Consumer Previous reading:
0

Consumer Current reading:
550

Consumer category
0. Agriculture
1. domestic
2. commercial
[0, 1 or 2]:
2
Consumer Net reading:550
Per unit amount upto 100:1
Consume unit upto 100:100
consume unit amount upto 100:100
Per unit amount upto 200:2
Consume unit upto 200:100
consume unit amount upto 200:200
Per unit amount upto 100:6
Consume unit upto 100:200
consume unit amount upto 100:1200
Per unit amount upto 100:10
Consume unit upto 100:150
consume unit amount upto 100:1500
Tax amount :112.5
Meter charge:200
Net pay:1812.5
 */
