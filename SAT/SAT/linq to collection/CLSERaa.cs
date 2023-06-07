using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.linq_to_collection
{
    class CLSERaa
    {
        public int rno { get; set; }
        public string sname { get; set; }
        public double m1 { get; set; }

        public double m2 { get; set; }

        public double Total
        {
            get
            {
                return m1 + m2;
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
                return m1 > 34.4 && m2 > 34.4 ? "Pass" : "Fail";
            }
        }
    }
   
    }
