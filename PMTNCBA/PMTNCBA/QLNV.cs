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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMTNCBA
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.lTCSDLDataSet2.NhanVien);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TG tg = new TG();
            tg.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                string queryCount = "SELECT COUNT(*) FROM NhanVien";
                cmd.Connection = conn;
                cmd.CommandText = queryCount;
                int currentCount = (int)cmd.ExecuteScalar();
                // Tạo MaTS mới dựa trên số lượng hiện có
                string maNV = "NV" + (currentCount + 1).ToString("D3"); // Ví dụ: TS001, TS002, ...
                // Tạo MaTS mới dựa trên số lượng hiện có

                // Thực hiện truy vấn
                string query1 = "INSERT INTO NhanVien (MaNV, Ten, DN, DonViCongTac, MK, NgaySinh, PhanQuyen, Quyen) " +
                    "VALUES (@MaNV, @Ten, @DN, @DonViCongTac, @MK, @NgaySinh, @PhanQuyen, @Quyen)";
                cmd.CommandText = query1;
                cmd.Connection = conn;

                // Thử từng tham số để xác định tham số nào gây ra lỗi
                cmd.Parameters.AddWithValue("@MaTS", maNV);
                cmd.Parameters.AddWithValue("@Ten", textBox1.Text);
                cmd.Parameters.AddWithValue("@DN", textBox21.Text);
                cmd.Parameters.AddWithValue("@DonViCongTac", comboBox9.Text);
                cmd.Parameters.AddWithValue("@MK", textBox22.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker5.Value);
                //cmd.Parameters.AddWithValue("@TrangThai", 1);
                //cmd.Parameters.AddWithValue("@Quyen", 1);

                //// Xử lý từng tham số một để xác định lỗi
                //try
                //{
                cmd.Parameters.Add("@Quyen", SqlDbType.Bit).Value = radioButton6.Checked ? false : true;
                cmd.Parameters.AddWithValue("@PhanQuyen",2);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Đã xảy ra lỗi ở tham số: " + ex.Message);
                //}

              
                // ... (Các dòng code cuối không thay đổi)
                cmd.Connection = conn;
                cmd.CommandText = query1;
                cmd.ExecuteNonQuery();
                // Refresh để hiển thị dữ liệu mới
                MessageBox.Show("Thêm thông tin thành công!");
                dataGridView2.Refresh();
                RefreshDataGridView();
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
        private void RefreshDataGridView()
        {
            // Viết mã để tải lại dữ liệu từ cơ sở dữ liệu vào DataGridView
            // Sau khi thêm dữ liệu mới, bạn có thể gọi phương thức này để cập nhật DataGridView
            // Ví dụ: Làm mới DataSource của DataGridView từ cơ sở dữ liệu
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            string query = "SELECT * FROM NhanVien";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy ra dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Kết nối đến cơ sở dữ liệu SQL Server
                SqlConnection connection = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                // Giả sử cột ID nằm ở cột đầu tiên (index 0) trong DataGridView
                string idToDelete = (selectedRow.Cells[0].Value).ToString();

                // Câu truy vấn SQL để xóa dữ liệu từ bảng với ID tương ứng
                string query = "DELETE FROM NhanVien WHERE MaNV = @IDToDelete";

                command.Parameters.AddWithValue("@IDToDelete", idToDelete);
                command.Connection = connection;
                command.CommandText = query;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Xóa dòng được chọn khỏi DataGridView

                dataGridView2.Rows.Remove(selectedRow);
                RefreshDataGridView();
                // Assume dt is your DataTable
                MessageBox.Show("Xóa thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dataGridView1.DataSource = dt; // Gán lại nguồn dữ liệu
                dataGridView2.Refresh(); // Refresh để hiển thị dữ liệu mới

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            comboBox9.Text = row.Cells[5].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox22.Text = row.Cells[3].Value.ToString();
            textBox21.Text = row.Cells[2].Value.ToString();
            dateTimePicker5 = row.Cells[4].Value as DateTimePicker;
            //if (row.Cells[8].Value.ToString() == "")
            //{
            //    radioButton6.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
            //    radioButton6.Refresh();
            //}
        }
    }
}
