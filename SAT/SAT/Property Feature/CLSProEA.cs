using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Property_Feature
{
    class CLSProEA
    {
        private int _eid;
        private string _ename;
        private double _esal;
        private double _hra;
        private double _da;
        private double _pf;
        private double _gpay;
        private double _npay;

        public int id
        {
            get
            {
                return _eid;
            }
            set
            {
                _eid = value;
            }
        }
        public string name
        {
            get
            {
                return _ename;
            }
            set
            {
                _ename = value;
            }
        }
        public double salary
        {
            get
            {
                return _esal;
            }
            set
            {
                _esal = value;
            }
        }
        public double hra
        {
            get
            {
               return _hra = _esal * 20.0 / 100;
               
            }
        }
        public double da
        {
            get
            {
               return _da = _esal * 15.0 / 100;
                 
            }
        }
        public double pf
        {
            get
            {
                return _pf = _esal * 35.0 / 100;
            }
        }
        public double gpay
        {
            get
            {
                return _gpay = _hra + _da + _esal;
            }
        }
        public double npay
        {
            get
            {
                return _npay = _esal - _pf;
            }
        }
    }
    class CLSProEAA
    {
        public static void Main()
        {
            CLSProEA EA = new CLSProEA();

            EA.id = 1001;
            EA.name = "sathiesh";
            EA.salary = 5000000;

            Console.WriteLine("ID    : \t" + EA.id);
            Console.WriteLine("Name  : \t" + EA.name);
            Console.WriteLine("Salary: \t" + EA.salary);
            Console.WriteLine("HRA   : \t" + EA.hra);
            Console.WriteLine("DA    : \t" + EA.da);
            Console.WriteLine("PF    : \t" + EA.pf);        
            Console.WriteLine("Gpay  : \t" + EA.gpay);
            Console.WriteLine("Npay  : \t" + EA.npay);
        }
    }
}
/*
 ID   :         1001
Name  :         sathiesh
Salary:         5000000
HRA   :         1000000
DA    :          750000
PF    :         1750000
Gpay  :         1750000
Npay  :         3250000
 */
