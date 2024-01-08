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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMTNCBA
{
    public partial class QL : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private object row;
        public QL()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO KyThi ( MaMon, TenKT, DoiTuong, MaNV, TGLamBai, TGMoDe, TGDongDe, TongSoCau, TLDe, TLKho, TDDe, TDKho, TienLui, Chat, MatKhau) " +
                "VALUES ( @MaMon, @TenKT, @DoiTuong, @MaNV, @TGLamBai, @TGMoDe, @TGDongDe, @TongSoCau, @TLDe, @TLKho, @TDDe, @TDKho, @TienLui, @Chat, @MatKhau)";

            using (SqlCommand cmd = new SqlCommand(query1, conn))
            {
                //cmd.Parameters.AddWithValue("@MaKyThi", textBox2.Text);
                cmd.Parameters.AddWithValue("@MaMon", comboBox2.Text);
                cmd.Parameters.AddWithValue("@TenKT", textBox4.Text);
                cmd.Parameters.AddWithValue("@DoiTuong", comboBox3.Text);
                cmd.Parameters.AddWithValue("@MaNV", textBox3.Text);
                cmd.Parameters.AddWithValue("@TGLamBai", Convert.ToInt32(numericUpDown1.Value)); // Chuyển đổi giá trị numericUpDown sang kiểu int
                cmd.Parameters.AddWithValue("@TGMoDe", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@TGDongDe", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@TongSoCau", Convert.ToInt32(numericUpDown2.Value)); // Chuyển đổi giá trị numericUpDown sang kiểu int
                cmd.Parameters.AddWithValue("@TLDe", trackBar1.Value);
                cmd.Parameters.AddWithValue("@TLKho", trackBar3.Value);

                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@TDDe", 1);
                    cmd.Parameters.AddWithValue("@TDKho", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TDDe", Convert.ToInt32(numericUpDown3.Value)); // Chuyển đổi giá trị numericUpDown sang kiểu int
                    cmd.Parameters.AddWithValue("@TDKho", Convert.ToInt32(numericUpDown5.Value)); // Chuyển đổi giá trị numericUpDown sang kiểu int
                }

                cmd.Parameters.AddWithValue("@TienLui", checkBox2.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Chat", checkBox1.Checked ? 1 : 0);
                if (checkBox3.Checked)
                {
                    cmd.Parameters.AddWithValue("@MatKhau", textBox5.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MatKhau", DBNull.Value);
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thông tin thành công!");
            }

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void QL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.lTCSDLDataSet.Mon);
            constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            string manhanvien = thongtinnv.MNV;
            using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
            {
                conn.Open();
                string sql = "select * from NhanVien where MaNV = @MaNV"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", manhanvien);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader vào các label
                    label1.Text = reader["Ten"].ToString();
                    label2.Text = reader["DonViCongTac"].ToString();
                    //label63.Text = reader["DN"].ToString();


                }

                reader.Close();
            }
        }

        private void nhómTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TG tg = new TG();
            tg.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);

                try
                {
                    conn.Open();

                    string mamon = comboBox1.Text;
                    using (SqlConnection newConn = new SqlConnection(constr))
                    {
                        newConn.Open();
                        string sql = "SELECT * FROM KyThi where MaMon = @MaMon";
                        SqlCommand newCmd = new SqlCommand(sql, newConn);
                        newCmd.Parameters.AddWithValue("@MaMon", mamon);

                        using (SqlDataReader newReader = newCmd.ExecuteReader()) // Mở DataReader mới
                        {
                            if (newReader.HasRows)
                            {
                                DataTable newDt = new DataTable();
                                newDt.Load(newReader); // Đọc dữ liệu vào DataTable

                                // Hiển thị dữ liệu trong DataGridView
                                dataGridView1.DataSource = newDt;
                            }
                        }
                    }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Đóng kết nối ban đầu
                }

            }
    }
}

