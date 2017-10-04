using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Veri
    {

        private static SqlConnection con;
        static Veri()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
            if (con == null)
                con = new SqlConnection(connectionString);
        }

        public static DataTable GetDataTable(string sorgu, params SqlParameter[] pler)
        {
            DataTable dt = new DataTable();

            SqlCommand komut = new SqlCommand(sorgu, con);
            foreach (var item in pler)
                komut.Parameters.Add(item);
            SqlDataAdapter sda = new SqlDataAdapter(komut);

             sda.Fill(dt);
            return dt;
        }
        public static void Execute(string sorgu, params SqlParameter[] pler)
        {
            SqlCommand komut = new SqlCommand(sorgu, con);
            foreach (var item in pler)
                komut.Parameters.Add(item);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }


    }
}
