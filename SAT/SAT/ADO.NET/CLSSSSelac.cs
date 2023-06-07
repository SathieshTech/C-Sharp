using System;
using System.Data;
using System.Data.SqlClient;

namespace SAT.ADO.NET
{
    class CLSSSSelac
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
                Console.WriteLine("for show specific rows");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrysel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);

                sqlcmd = new SqlCommand(qrysel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "emp");
                dt = ds.Tables["emp"];
                Console.WriteLine("\n1st row (index:0),7 columns value");
                Console.Write(dt.Rows[0][0] + "\t");
                Console.Write(dt.Rows[0][1] + "\t");
                Console.Write(dt.Rows[0][2] + "\t");
                Console.Write(dt.Rows[0][3] + "\t");
                Console.Write(dt.Rows[0][4] + "\t");
                Console.Write(dt.Rows[0][5] + "\t");
                Console.Write(dt.Rows[0][6] + "\t");
                Console.WriteLine(dt.Rows[0][7]);

                Console.WriteLine("\n4th row (index:3),7 columns value");
                Console.Write(dt.Rows[3][0] + "\t");
                Console.Write(dt.Rows[3][1] + "\t");
                Console.Write(dt.Rows[3][2] + "\t");
                Console.Write(dt.Rows[3][3] + "\t");
                Console.Write(dt.Rows[3][4] + "\t");
                Console.Write(dt.Rows[3][5] + "\t");
                Console.Write(dt.Rows[3][6] + "\t");
                Console.WriteLine(dt.Rows[3][7]);

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
 
    
Employee Salary Allowancesfor show specific rows

1st row (index:0),7 columns value
101     x1      850000.00       127500.000000   170000.000000   297500.000000   1147500.000000  850000.000000

4th row (index:3),7 columns value
104     x10     650000.00       97500.000000    130000.000000   227500.000000   877500.000000   650000.000000
 */
