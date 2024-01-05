using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMTNCBA
{
    public partial class Giaodien : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private object row;

        public Giaodien()
        {
            InitializeComponent();
        }

        private void Giaodien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.lTCSDLDataSet.KyThi);
            // TODO: This line of code loads data into the 'lTCSDLDataSet1.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter1.Fill(this.lTCSDLDataSet1.KyThi);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.lTCSDLDataSet.KetQua);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.lTCSDLDataSet.KyThi);
            constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            //Thong tin thoi gian hien tai
            timer1.Start();
            if (thongtinnv.GV == false)
            {
                string query = "SELECT MaTS FROM ThiSinh WHERE DN = @DN";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@DN", thongtinsv.DN); // Sử dụng tham số @DN cho truy vấn SQL

                thongtinsv.MSV = cmd1.ExecuteScalar()?.ToString();
                string masinhvien = thongtinsv.MSV;

                // Kết nối C# với cơ sở dữ liệu (conn là đối tượng SqlConnection)
                string sql = "SELECT Ten, NgaySinh, Lop, Khoa FROM ThiSinh WHERE MaTS = @MaTS"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTS", masinhvien);

                // Cung cấp giá trị cho tham số @MaTS
                SqlDataReader reader = cmd.ExecuteReader();
                // Xử lý kết quả truy vấn

                if (reader.Read())
                {
                    String doituong = "";
                    // Đọc dữ liệu từ SqlDataReader vào các label
                    label68.Text = reader["Ten"].ToString();
                    label67.Text = reader["NgaySinh"].ToString();
                    label66.Text = reader["Lop"].ToString();
                    if (reader["Khoa"].ToString() == "KHOA01")
                    {
                        doituong = "Lớp 10";
                    }
                    else if (reader["Khoa"].ToString() == "KHOA02")
                    {
                        doituong = "Lớp 11";
                    }
                    else
                    {
                        doituong = "Lớp 12";
                    }
                    reader.Close();


                    sql = "SELECT * FROM KyThi where DoiTuong = @doituong";
                    SqlCommand newCmd = new SqlCommand(sql, conn);
                    newCmd.Parameters.AddWithValue("@doituong", doituong);

                    SqlDataReader newReader = newCmd.ExecuteReader(); // Mở DataReader mới

                    // Xử lý kết quả truy vấn mới
                    if (newReader.HasRows)
                    {
                        DataTable newDt = new DataTable();
                        newDt.Load(newReader); // Đọc dữ liệu vào DataTable

                        // Hiển thị dữ liệu trong DataGridView
                        dataGridView2.DataSource = newDt;
                    }

                    // Đóng DataReader mới sau khi hoàn thành việc sử dụng nó
                    newReader.Close();
                }

                conn.Close();
            }
            else
            {
                // Cập nhật tên cột thành tên cột chính xác trong bảng NhanVien
                string query = "SELECT MaNV FROM NhanVien WHERE DN = @DN";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@DN", thongtinnv.DN); // Sử dụng tham số @DN cho truy vấn SQL

                thongtinnv.MNV = cmd1.ExecuteScalar()?.ToString();
                string manhanvien = thongtinnv.MNV;

                // Kết nối C# với cơ sở dữ liệu (conn là đối tượng SqlConnection)
                string sql = "SELECT Ten, NgaySinh, DonViCongTac FROM NhanVien WHERE MaNV = @MaNV"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", manhanvien);

                // Cung cấp giá trị cho tham số @MaNV
                SqlDataReader reader = cmd.ExecuteReader();
                // Xử lý kết quả truy vấn

                if (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader vào các label
                    label68.Text = reader["Ten"].ToString();
                    label67.Text = reader["NgaySinh"].ToString();
                    label66.Text = reader["DonViCongTac"].ToString();
                }

                reader.Close();
                conn.Close();
            }
            


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToLongTimeString();
            label19.Text = DateTime.Now.ToLongDateString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.Show();
        }

        private void dataGridView2_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kyThiTableAdapter.FillBy(this.lTCSDLDataSet.KyThi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void kyThiBindingSource8_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //thông tin buổi thi
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            label28.Text = row.Cells[2].Value.ToString();
            label27.Text = row.Cells[1].Value.ToString();
            label26.Text = row.Cells[5].Value.ToString();
            label25.Text = row.Cells[8].Value.ToString();
            label24.Text = row.Cells[3].Value.ToString();
            label23.Text = row.Cells[6].Value.ToString();
            label34.Text = row.Cells[0].Value.ToString();
            label30.Text = row.Cells[4].Value.ToString();
            label29.Text = row.Cells[7].Value.ToString();

            if (thongtinsv.SV == true)
            {
                label44.Text = row.Cells[2].Value.ToString();
                label42.Text = row.Cells[0].Value.ToString();
                string maTS = thongtinsv.MSV;
                label40.Text = maTS;
                using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
                {
                    conn.Open();
                    string sql = "select * from KetQua where MaTS = @MaTS"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTS", maTS);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        label43.Text = reader["NgayThi"].ToString();
                        label41.Text = reader["TongTGThi"].ToString();
                        label39.Text = reader["TGTraLoiTrungBinh"].ToString();
                        label22.Text = reader["Diem"].ToString();

                        if (reader["Loai"].ToString() == "1")
                        {
                            label36.Text = "Đạt";
                        }
                        else
                        {
                            label36.Text = "Không Đạt";
                        }
                    }
                    reader.Close();

                }
            }
            

            
                // Không cần đóng kết nối ngay lập tức ở đây vì bạn sẽ sử dụng nó trong phạm vi này
            
            



        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKỳThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thongtinnv.GV == true)
            {
                QL ql = new QL();
                ql.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không phải là Giáo viên!");
            } 
                
            
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_MouseClick(object sender, MouseEventArgs e)
        {
            if (thongtinnv.GV == false)
            {
                
                label1.Visible = false;
                string masinhvien = thongtinsv.MSV;
                using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
                {
                    conn.Open();
                    string sql = "select * from ThiSinh where MaTS = @MaTS"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTS", masinhvien);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Đọc dữ liệu từ SqlDataReader vào các label
                        label65.Text = reader["MaTS"].ToString();
                        label64.Text = reader["Ten"].ToString();
                        label63.Text = reader["DN"].ToString();
                        label62.Text = reader["MK"].ToString();
                        label61.Text = reader["NgaySinh"].ToString();
                        label60.Text = reader["Lop"].ToString();
                        label59.Text = reader["Khoa"].ToString();
                        if (reader["TrangThai"].ToString() == "1")
                        {
                            label58.Text = "Online";
                        }
                        else
                        {
                            label58.Text = "Offline";
                        }
                    }

                    reader.Close();
                    // Không cần đóng kết nối ngay lập tức ở đây vì bạn sẽ sử dụng nó trong phạm vi này
                }
            }
            else
            {
                label1.Visible=true;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
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
                        label65.Text = reader["MaNV"].ToString();
                        label64.Text = reader["Ten"].ToString();
                        label63.Text = reader["DN"].ToString();
                        label62.Text = reader["MK"].ToString();
                        label61.Text = reader["NgaySinh"].ToString();
                        label60.Text = reader["DonViCongTac"].ToString();
                        label59.Text = reader["PhanQuyen"].ToString();
                        label58.Text = "NULL"; // Có thể có lỗi ở đây, bạn gán label59.Text hai lần

                    }

                    reader.Close();
                    // Không cần đóng kết nối ngay lập tức ở đây vì bạn sẽ sử dụng nó trong phạm vi này
                }
            }



        }
    }
}
