using System;
using System.Data;
using System.Data.SqlClient;

namespace SAT.ADO.NET
{
    class CLSSSSelab
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

                Console.WriteLine("\nEmployee Salary Allowances table column name");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrysel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);

                sqlcmd = new SqlCommand(qrysel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "emp");
                dt = ds.Tables["emp"];

                int cc = dt.Columns.Count;
                for (int c = 0; c < cc; c++)
                {
                    Console.Write(dt.Columns[c].ColumnName + "\t");
                }
                Console.WriteLine();
            }
            catch (Exception e)
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
Employee Salary Allowances table column name
eid     ename   esal    da      hra     pf      gpay    npay
 */
