using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace PMTNCBA
{
    public partial class Dangky : Form

    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public object ConfigurationManager { get; private set; }

        public Dangky()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)// check mat khau 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                string mk1 = textBox2.Text;
                string mk2 = textBox3.Text;
                string queryCount = "SELECT COUNT(*) FROM ThiSinh";
                cmd.Connection = conn;
                cmd.CommandText = queryCount;
                int currentCount = (int)cmd.ExecuteScalar();
                // Tạo MaTS mới dựa trên số lượng hiện có
                string maTS = "TS" + (currentCount + 1).ToString("D3"); // Ví dụ: TS001, TS002, ...
                if (!CheckAccount(mk1) || !CheckAccount(mk2))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường");
                    return;
                }

                if (mk1 != mk2)
                {
                    MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!");
                    return;
                }
                string tenDangNhap = textBox1.Text;

                // Truy vấn kiểm tra tên đăng nhập
                string query = "SELECT COUNT(*) FROM ThiSinh WHERE DN = @DN1";
                cmd.Parameters.AddWithValue("@DN1", tenDangNhap);
                cmd.Connection = conn;
                cmd.CommandText = query;

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại trong cơ sở dữ liệu.");
                }
                // Thêm các tham số vào SqlCommand
                //cmd.Parameters.Add("@MK", SqlDbType.NVarChar).Value = mk1;
                //cmd.Connection = conn;

                // Thực hiện truy vấn
                string query1 = "INSERT INTO THISINH (MaTS, Ten, DN, Lop,Khoa, MK,NgaySinh) " +
                                   "VALUES (@MaTS, @Ten, @DN, @Lop,@Khoa, @MK, @NgaySinh)";
                cmd.Parameters.AddWithValue("@MaTS", maTS);
                cmd.Parameters.AddWithValue("@Ten", textBox6.Text);
                cmd.Parameters.AddWithValue("@DN", textBox1.Text);
                cmd.Parameters.AddWithValue("@Lop", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Khoa", comboBox2.Text);
                cmd.Parameters.AddWithValue("@MK", mk1);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Connection = conn;
                cmd.CommandText = query1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công!");
                Dangnhap dangnhap = new Dangnhap(); 
                dangnhap.Show();
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void tácGảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TG tg = new TG();
            tg.Show();
            this.Hide();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.lTCSDLDataSet.Khoa);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.lTCSDLDataSet.Lop);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.lTCSDLDataSet.KetQua);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.ThiSinh' table. You can move, or remove it, as needed.
            this.thiSinhTableAdapter.Fill(this.lTCSDLDataSet.ThiSinh);

        }
    }
}
