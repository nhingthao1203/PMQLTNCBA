using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTNCBA
{
    public partial class SelectCourse : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private object row;
        public SelectCourse()
        {
            InitializeComponent();
        }

        private void SelectCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.lTCSDLDataSet.Mon);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.lTCSDLDataSet.Khoa);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.lTCSDLDataSet.Lop);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.lTCSDLDataSet.KetQua);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.lTCSDLDataSet.KyThi);

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
            {
                string tenkt = comboBox1.Text.ToString();
                string mamon = comboBox2.Text.ToString();
                string doituong = "";
                if (radioButton1.Checked)
                {
                    doituong = "Lớp 10";
                }
                else if(radioButton2.Checked)
                {
                    doituong = "Lớp 11";
                }
                else
                {
                    doituong = "Lớp 12";
                }
                
                conn.Open();
                string sql = "select * from KyThi where TenKT = @TenKT AND MaMon = @MaMon AND DoiTuong = @DoiTuong"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenKT", tenkt);
                cmd.Parameters.AddWithValue("@MaMon", mamon);
                cmd.Parameters.AddWithValue("@DoiTuong", doituong);


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    thongtinsv.MaKyThi = reader["MaKyThi"].ToString();
                    Thi thi = new Thi();
                    thi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không tồn tại kỳ thi này trên hệ thống!");
                }
                reader.Close();

            }
        }
    }
}
