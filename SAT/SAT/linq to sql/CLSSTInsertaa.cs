using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace SAT.linq_to_sql
{
    class CLSSTInsertaa
    {
        public static void Main()
        {
            CLSSTaa st = new CLSSTaa();
            st.ename = "x9";
            st.esal = 900000;

            DataContext dc = new DataContext(CLSCnStr.forstdb);
            dc.GetTable<CLSSTaa>().InsertOnSubmit(st);
            dc.SubmitChanges();
            Console.WriteLine("1 row affected");

        }   
    }
}
/*
 1 row affected
 */
