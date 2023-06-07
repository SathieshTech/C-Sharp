using System;
using System.Data;
using System.Data.SqlClient;

namespace SAT.ADO.NET
{
    class CLSSSSelaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrysel = null;

            try
            {
                qrysel = "select * from emp";

                Console.Write("\nEmployee Salary Allowances");
                Console.WriteLine("for show no. of columns and rows\n");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrysel, sqlcnn);

                sqlcmd = new SqlCommand(qrysel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "emp");
                dt = ds.Tables["emp"];

                Console.WriteLine("No.of column: " + dt.Columns.Count);
                Console.WriteLine("No.of rows:" + dt.Rows.Count);

            } catch(Exception e)
            {
                Console.WriteLine("Err.: " + e.Message);
            }
            finally
            {
                sqlcnn.Close();
            }
        }
    }
}
/*

Employee Salary Allowances for show no. of columns and rows

No.of column: 8
No.of rows:5 
 
 */
