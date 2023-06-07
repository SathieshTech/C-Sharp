using System;
using System.Data.SqlClient;
namespace SAT.ADO.NET
{
    class CLSSSDelaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryDel = null, eid = null;

            try
            {
                qryDel = "delete from emp";
                qryDel += " where eid=@eid";
                Console.WriteLine("\nEmployee salary allowances for erase a row");
                Console.Write("\nID: ");
                eid = Console.ReadLine();

               

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryDel, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@eid", eid);
                

                int afrs = sqlcmd.ExecuteNonQuery();

                if (afrs > 0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }
                else
                {
                    Console.WriteLine("\nAffected 0 row");
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
 Employee salary allowances for erase a row

ID: 107

Affected 1 row

    Employee salary allowances for erase a row

ID: 106

Affected 1 row
 
 */
