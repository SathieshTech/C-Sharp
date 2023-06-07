using System;
using System.Collections;


namespace SAT.asaa

{
    class CLSASaa
    {
        public void udshow(int? i)
        {
            if(i==null)
            {
                return;
            }
            Console.WriteLine(i);
        }

        public static void Main()
        {
            ArrayList aL = new ArrayList();
            aL.Add("56.5");

            Console.WriteLine("{0}:{1}", aL[0], aL.GetType());

            string s = aL[0] as string;
            Console.WriteLine("{0} : {1}", s, s.GetType());

            CLSASaa aa = new CLSASaa();
            aa.udshow(null);
            aa.udshow(9);
        }
    }
}
/*
56.5:System.Collections.ArrayList
56.5 : System.String
9
 */
