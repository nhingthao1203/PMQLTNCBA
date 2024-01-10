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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.lTCSDLDataSet.Khoa);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.lTCSDLDataSet.Lop);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.ThiSinh' table. You can move, or remove it, as needed.
            this.thiSinhTableAdapter.Fill(this.lTCSDLDataSet.ThiSinh);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            // Viết mã để tải lại dữ liệu từ cơ sở dữ liệu vào DataGridView
            // Sau khi thêm dữ liệu mới, bạn có thể gọi phương thức này để cập nhật DataGridView
            // Ví dụ: Làm mới DataSource của DataGridView từ cơ sở dữ liệu
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            string query = "SELECT * FROM ThiSinh";

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
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void QLSV_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet3.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter1.Fill(this.lTCSDLDataSet3.Khoa);
            // TODO: This line of code loads data into the 'lTCSDLDataSet2.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.lTCSDLDataSet2.Lop);
            // TODO: This line of code loads data into the 'lTCSDLDataSet2.ThiSinh' table. You can move, or remove it, as needed.
            this.thiSinhTableAdapter1.Fill(this.lTCSDLDataSet2.ThiSinh);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                string queryCount = "SELECT COUNT(*) FROM ThiSinh";
                cmd.Connection = conn;
                cmd.CommandText = queryCount;
                int currentCount = (int)cmd.ExecuteScalar();
                // Tạo MaTS mới dựa trên số lượng hiện có
                string maTS = "TS" + (currentCount + 1).ToString("D3"); // Ví dụ: TS001, TS002, ...
                // Tạo MaTS mới dựa trên số lượng hiện có

                // Thực hiện truy vấn
                string query1 = "INSERT INTO ThiSinh (MaTS, Ten, DN, Lop, Khoa, MK, NgaySinh, TrangThai, Quyen) " +
                    "VALUES (@MaTS, @Ten, @DN, @Lop, @Khoa, @MK, @NgaySinh,@TrangThai, @Quyen)";
                cmd.CommandText = query1;
                cmd.Connection = conn;

                // Thử từng tham số để xác định tham số nào gây ra lỗi
                cmd.Parameters.AddWithValue("@MaTS", maTS);
                cmd.Parameters.AddWithValue("@Ten", textBox17.Text);
                cmd.Parameters.AddWithValue("@DN", textBox21.Text);
                cmd.Parameters.AddWithValue("@Lop", comboBox10.Text);
                cmd.Parameters.AddWithValue("@Khoa", comboBox9.Text);
                cmd.Parameters.AddWithValue("@MK", textBox22.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker5.Value);
                //cmd.Parameters.AddWithValue("@TrangThai", 1);
                //cmd.Parameters.AddWithValue("@Quyen", 1);

                //// Xử lý từng tham số một để xác định lỗi
                //try
                //{
                cmd.Parameters.Add("@TrangThai", SqlDbType.Bit).Value = radioButton6.Checked ? false : true;
                cmd.Parameters.Add("@Quyen", SqlDbType.Bit).Value = (radioButton9.Checked || radioButton10.Checked) ? false : true;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Đã xảy ra lỗi ở tham số: " + ex.Message);
                //}

                cmd.Parameters.AddWithValue("@Mess", (radioButton9.Checked) ? "Bạn đã bị đình chỉ tạm thời" :
                                                      (radioButton10.Checked) ? "Bạn đã bị cấm đăng nhập" : "");

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
                string query = "DELETE FROM ThiSinh WHERE MaTS = @IDToDelete";

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

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            comboBox9.Text = row.Cells[5].Value.ToString();
            comboBox10.Text = row.Cells[6].Value.ToString();
            textBox17.Text = row.Cells[1].Value.ToString();
            textBox22.Text = row.Cells[3].Value.ToString();
            textBox21.Text = row.Cells[2].Value.ToString();
            dateTimePicker5 = row.Cells[4].Value as DateTimePicker;
            if (row.Cells[8].Value.ToString() == "1")
            {
                radioButton6.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton6.Refresh();
            }
            if (row.Cells[9].Value.ToString() == "1")
            {
                radioButton9.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton9.Refresh();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
