using System;
using System.Data.SqlClient;

namespace SAT.ADO.NET
{
    class CLSSSInsaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryIns = null, ename = null, esal = null;

            try
            {
                qryIns = "insert into emp";
                qryIns += " (ename,esal) values";
                qryIns += " (@ename,@esal);";

                Console.WriteLine("\nEmployee Salary Allowances for make a row");

                Console.Write("\nName: ");
                ename = Console.ReadLine();

                Console.Write("\nSalary: ");
                esal = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryIns, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@ename", ename);
                sqlcmd.Parameters.AddWithValue("@esal", esal);

                int afrs = sqlcmd.ExecuteNonQuery();

                if (afrs>0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }else
                {
                    Console.WriteLine("\nAffected 0 row");
                }
            }catch(Exception e)
            {
                Console.WriteLine("Err.: " + e.Message);
            }finally
            {
                sqlcnn.Close();
            }
        }
    }
}
/*
 input-1:
 Employee Salary Allowances for make a row

Name: x1

Salary: 5000000
output-1:
Affected 1 row
input-2
Employee Salary Allowances for make a row

Name: x2

Salary: 1000000
otput-2
Affected 1 row
 */
