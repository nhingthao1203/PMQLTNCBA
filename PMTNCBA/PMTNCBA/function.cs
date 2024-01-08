using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PMTNCBA
{
    public struct thongtinsv
    {
        public static string DN;
        public static string MSV;
        public static string MATKHAU;
        public static bool SV = false;
        public static string MaKyThi;
        public static string Ten;
    }
  

    public struct thongtinnv
    {
        public static string DN;
        public static string MNV;
        public static string MATKHAU;
        public static bool GV = false;
    }
    internal class function
    {
        //private readonly SqlConnection con;

        //protected SqlConnection GetConnection() 
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString= "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
        //    return con;

        //}
        //public DataSet getData (String query) 
        //{
        //    SqlConnection con = GetConnection();
        //    SqlCommand cmd = con.CreateCommand ();
        //    cmd.Connection = con;
        //    cmd.CommandText = query;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill (ds);
        //    return ds;
        //}
        //public void setData(String query, String msg) 
        //{
        //    SqlConnection connection = GetConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //}

        //public SqlDataReader getforCombo(String query) 
        //{
        //    SqlConnection con = GetConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd = new SqlCommand(query,con);
        //    SqlDataReader sdr = cmd.ExecuteReader();
        //    return sdr;
        //}
    }
}
