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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PMTNCBA
{
    public partial class AddQ : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private object row;
        public AddQ()
        {
            InitializeComponent();
        }

        private void AddQ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.lTCSDLDataSet.Mon);
            // TODO: This line of code loads data into the 'lTCSDLDataSet1.CauHoi_Gop' table. You can move, or remove it, as needed.
            this.cauHoi_GopTableAdapter.Fill(this.lTCSDLDataSet1.CauHoi_Gop);
            // TODO: This line of code loads data into the 'lTCSDLDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.lTCSDLDataSet.Mon);
            // TODO: This line of code loads data into the 'tHITRACNGHIEMDataSet.MONTHI' table. You can move, or remove it, as needed.


        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            comboBox1.Text = row.Cells[4].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[6].Value.ToString();
            textBox3.Text = row.Cells[7].Value.ToString();
            textBox4.Text = row.Cells[8].Value.ToString();
            textBox5.Text = row.Cells[9].Value.ToString();
            if (row.Cells[10].Value.ToString()=="A")
            {
                radioButton1.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton1.Refresh();
            } else if(row.Cells[10].Value.ToString() == "B")
            {
                radioButton2.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton2.Refresh();
            }else if(row.Cells[10].Value.ToString() == "C")
            {
                radioButton3.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton3.Refresh();
            }
            else
            {
                radioButton4.Checked = true; // Đặt RadioButton có tên là radioButton1 thành được chọn
                radioButton4.Refresh();
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ra dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Kết nối đến cơ sở dữ liệu SQL Server
                SqlConnection connection = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                // Giả sử cột ID nằm ở cột đầu tiên (index 0) trong DataGridView
                int idToDelete = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Câu truy vấn SQL để xóa dữ liệu từ bảng với ID tương ứng
                string query = "DELETE FROM CauHoi_Gop WHERE MaCH = @IDToDelete";

                command.Parameters.AddWithValue("@IDToDelete", idToDelete);
                command.Connection = connection;
                command.CommandText = query;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Xóa dòng được chọn khỏi DataGridView

                dataGridView1.Rows.Remove(selectedRow);
                RefreshDataGridView();
                // Assume dt is your DataTable
                MessageBox.Show("Xóa thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dataGridView1.DataSource = dt; // Gán lại nguồn dữ liệu
                dataGridView1.Refresh(); // Refresh để hiển thị dữ liệu mới

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RefreshDataGridView()
        {
            // Viết mã để tải lại dữ liệu từ cơ sở dữ liệu vào DataGridView
            // Sau khi thêm dữ liệu mới, bạn có thể gọi phương thức này để cập nhật DataGridView
            // Ví dụ: Làm mới DataSource của DataGridView từ cơ sở dữ liệu
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            string query = "SELECT * FROM CauHoi_Gop";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien(); 
            giaodien.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();

                // Sử dụng một truy vấn UPDATE thay vì INSERT để chỉnh sửa dữ liệu đã tồn tại
                string queryUpdate = "UPDATE CauHoi_Gop SET NoiDung = @NoiDung, HinhThucCH = @HinhThucCH, MaMon = @MaMon, DoKho = @DoKho, " +
                                     "DapAn_A = @DapAn_A, DapAn_B = @DapAn_B, DapAn_C = @DapAn_C, DapAn_D = @DapAn_D, DapAn = @DapAn WHERE MaCH = @MaCH";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;


                cmd.Parameters.AddWithValue("@NoiDung", textBox1.Text);
                cmd.Parameters.AddWithValue("@HinhThucCH", "TN");
                cmd.Parameters.AddWithValue("@MaMon", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DoKho", "1");
                cmd.Parameters.AddWithValue("@DapAn_A", textBox2.Text);
                cmd.Parameters.AddWithValue("@DapAn_B", textBox3.Text);
                cmd.Parameters.AddWithValue("@DapAn_C", textBox4.Text);
                cmd.Parameters.AddWithValue("@DapAn_D", textBox5.Text);

                if (radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "A");
                }
                else if (radioButton2.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "B");
                }
                else if (radioButton3.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "C");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DapAn", "D");
                }
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int idToFix = Convert.ToInt32(selectedRow.Cells[0].Value);
                // Đặt giá trị của khoá chính để xác định dòng cần chỉnh sửa
                cmd.Parameters.AddWithValue("@MaCH", idToFix);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thông tin thành công!");

                // Sau khi chỉnh sửa thành công, có thể cần cập nhật lại DataGridView nếu bạn muốn hiển thị dữ liệu mới nhất
                // Load lại dữ liệu vào DataGridView tại đây (nếu cần)
                RefreshDataGridView();
                dataGridView1.Refresh(); // Refresh để hiển thị dữ liệu mới
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

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Bạn đang sở dụng tính năng này!");

        }

        private void hệThốngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void nhómTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TG tg = new TG();
            tg.Show();
            this.Hide();
        }

        private void trợGiúpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
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
                string queryCount = "SELECT * FROM CauHoi_Gop";
                cmd.Connection = conn;
                cmd.CommandText = queryCount;
                int currentCount = (int)cmd.ExecuteScalar();

                // Thực hiện truy vấn
                string query1 = "INSERT INTO CauHoi_Gop (NoiDung, HinhThucCH, MaMon, DoKho,DapAn_A, DapAn_B,DapAn_C,DapAn_D,DapAn) " +
                                   "VALUES (@NoiDung, @HinhThucCH, @MaMon, @DoKho,@DapAn_A, @DapAn_B,@DapAn_C,@DapAn_D,@DapAn)";
                cmd.Parameters.AddWithValue("@NoiDung", textBox1.Text);
                cmd.Parameters.AddWithValue("@HinhThucCH", "TN");
                cmd.Parameters.AddWithValue("@MaMon", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DoKho", "1");
                cmd.Parameters.AddWithValue("@DapAn_A", textBox2.Text);
                cmd.Parameters.AddWithValue("@DapAn_B", textBox3.Text);
                cmd.Parameters.AddWithValue("@DapAn_C", textBox4.Text);
                cmd.Parameters.AddWithValue("@DapAn_D", textBox5.Text);
                if (radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "A");
                }
                else if (radioButton2.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "B");
                }
                else if (radioButton3.Checked)
                {
                    cmd.Parameters.AddWithValue("@DapAn", "C");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DapAn", "D");
                }
                cmd.Connection = conn;
                cmd.CommandText = query1;
                cmd.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.Refresh(); // Refresh để hiển thị dữ liệu mới
                MessageBox.Show("Thêm thông tin thành công!");
                
                



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

