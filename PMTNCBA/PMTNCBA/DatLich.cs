using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMTNCBA
{
    public partial class DatLich : Form
    {
        public DatLich()
        {
            InitializeComponent();
        }

        private void DatLich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.BaoCaoLoi' table. You can move, or remove it, as needed.
            this.baoCaoLoiTableAdapter.Fill(this.lTCSDLDataSet.BaoCaoLoi);
            textBox2.Text = thongtinsv.MSV;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();

                string query1 = "INSERT INTO BaoCaoLoi (Loai,MoTa,MaTS,TinhTrang) " +
                                   "VALUES (@Loai,@MoTa,@MaTS,@TinhTrang)";
                cmd.Parameters.AddWithValue("@Loai", comboBox1.Text);
                cmd.Parameters.AddWithValue("@MoTa", textBox1.Text);
                cmd.Parameters.AddWithValue("@MaTS", textBox2.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", "Chưa xử lý");
                cmd.Connection = conn;
                cmd.CommandText = query1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hệ thống đã ghi nhân báo lỗi!");
                Giaodien giaodien = new Giaodien();
                giaodien.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
