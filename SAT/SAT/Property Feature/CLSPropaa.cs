using System;

namespace SAT.Property_Feature
{
    class CLSPropaaER
    {
        private int _rno;
        private string _Sname;
        private double _m1 = 0, _m2 = 0;

        public int Rno
        {
            get
            {
                return _rno;
            }
            set
            {
                _rno = value;
            }
        }
        public string Sname
        {
            get
            {
                return _Sname;
            }
            set
            {
                _Sname = value;
            }
        }
        public double M1
        {
            get
            {
                return _m1;
            }
            set
            {
                _m1 = value;
            }
        }
        public double M2
        {
            get
            {
                return _m2;
            }
            set
            {
                _m2 = value;
            }
        }
        public double Total
        {
            get
            {
                return _m1 + _m2;
            }
           
        }
        public double Average
        {
            get
            {
                return Total / 2;
            }

        }

        public string Result
        {
            get
            {
                return _m1 > 34.4 && _m2 > 34.4 ? "Pass" : "Fail";
            }
        }
    }
    class CLSPropaa
    {
        public static void Main()
        {
            CLSPropaaER er = new CLSPropaaER();

            er.Rno = 1001;
            er.Sname = "xx";
            er.M1 = 36;
            er.M2 = 63;


            Console.WriteLine(er.Rno);
            Console.WriteLine(er.Sname);
            Console.WriteLine(er.M1);
            Console.WriteLine(er.M2);
            Console.WriteLine(er.Total);
            Console.WriteLine(er.Average);
            Console.WriteLine(er.Result);


        }
    }
}
/*
1001
xx
36
63
99
49.5
Pass
 */
