using System;
using System.Data;
using System.Data.SqlClient;

namespace SAT.ADO.NET
{
    class CLSSSSelad
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrysel = null, eid = null;

            try
            {
                qrysel = "select * from emp";

                Console.WriteLine("\nEmployee Salary Allowances for show rows");


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
                    Console.Write(dt.Columns[c].ColumnName);

                    if (c > 1)
                    {
                        Console.Write("\t\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine();
                int rc = dt.Rows.Count;

                for (int r = 0; r < rc; r++)
                {
                    for (int c = 0; c < cc; c++)
                    {
                        Console.Write(dt.Rows[r][c] + "\t");
                    }
                    Console.WriteLine();
                }
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
 Employee Salary Allowances for show rows
eid     ename   esal            da              hra             pf              gpay            npay
101     x1      850000.00       127500.000000   170000.000000   297500.000000   1147500.000000  850000.000000
102     x6      580000.00       87000.000000    116000.000000   203000.000000   783000.000000   580000.000000
103     x8      4500000.00      675000.000000   900000.000000   1575000.000000  6075000.000000  4500000.000000
104     x10     650000.00       97500.000000    130000.000000   227500.000000   877500.000000   650000.000000
105     x2      1000000.00      150000.000000   200000.000000   350000.000000   1350000.000000  1000000.000000
 */
