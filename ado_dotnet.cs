using System;
using System.Data.SqlClient;

namespace mycode
{
    internal class Prob
    {
        public static void Main(String[] args)
        {
            SqlConnection con;
            SqlCommand cmd;
            int i;
            con = new SqlConnection("Server=LAPTOP-00UBO9TM\\SQLEXPRESS;Database=EmpDB;Trusted_Connection=true");
            con.Open();
            cmd = new SqlCommand("insert into EmpDB values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p2", "amit");
            cmd.Parameters.AddWithValue("@p3", "HR");
            cmd.Parameters.AddWithValue("@p4", 10000);

            i = cmd.ExecuteNonQuery();
            if (i != 0)
                Console.WriteLine("Query executed successfully");
            else
                Console.WriteLine("Error in query/ connection");

            con.Close();
        }
    }
}