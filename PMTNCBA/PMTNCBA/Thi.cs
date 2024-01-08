using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PMTNCBA
{
    public partial class Thi : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private object row;
        public struct CauTraLoi
        {
            public string CauHoi; // Chứa nội dung của câu hỏi
            public string TraLoi; // Chứa câu trả lời của người dùng
            public bool DaTraLoi; // Chứa trạng thái đã trả lời hay chưa của câu hỏi
            public bool DapAnDung; // Thể hiện câu trả lời đã đúng hay không
        }
        private List<CauTraLoi> mangCauTraLoi; // Biến lưu trữ mảng câu trả lời

        public Thi()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Thi_Load(object sender, EventArgs e)
        {
            string makt = thongtinsv.MaKyThi;
            using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
            {
                conn.Open();
                string sql = "select * from KyThi where MaKyThi = @MaKyThi"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKyThi", makt); // Sửa tên tham số thành @MaKyThi

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc dữ liệu từ SqlDataReader vào các label
                    label6.Text = reader["TenKT"].ToString();
                    label5.Text = reader["MaMon"].ToString();
                    label4.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Hiển thị chỉ ngày/tháng/năm
                    label15.Text = thongtinsv.Ten;
                    label14.Text = thongtinsv.MSV;

                    // Thời gian click vào thi (giả sử thời điểm hiện tại là thời gian click, chỉ lấy thời gian, không lấy ngày tháng năm)
                    label7.Text = DateTime.Now.ToString("HH:mm:ss"); // Lấy giờ, phút, giây

                    // Giả sử thời gian click vào làm bài được lưu ở biến thời gian clickTime
                    DateTime clickTime = DateTime.Now;
                    label9.Text = clickTime.ToString("HH:mm:ss"); // Hiển thị thời gian click vào làm bài

                    // Lấy thời gian làm bài từ cột [TGLamBai] trong cơ sở dữ liệu (giả sử là integer là số phút)
                    int timeDuration = (int)reader["TGLamBai"];

                    // Tính thời gian đóng đề bằng cách cộng thời gian click vào làm bài với thời gian làm bài
                    DateTime closeTime = clickTime.AddMinutes(timeDuration);
                    label8.Text = closeTime.ToString("HH:mm:ss"); // Hiển thị thời gian đóng đề

                    label13.Text = reader["DoiTuong"].ToString();

                    // Lấy thời gian làm bài từ cột [TGLamBai] (giả sử là số phút)
                    // Lấy thời gian làm bài từ cột [TGLamBai] (giả sử là số phút)
                    int timeDuration1 = (int)reader["TGLamBai"];

                    // Tính thời gian kết thúc làm bài dựa trên thời gian click và thời gian làm bài
                    DateTime closeTime1 = clickTime.AddMinutes(timeDuration1);

                    // Tạo một hàm xử lý việc cập nhật label20 với thời gian còn lại
                    void UpdateCountdown(object senderObj, EventArgs eventArgs)
                    {
                        // Tính thời gian đếm ngược từ thời điểm hiện tại đến thời gian kết thúc làm bài
                        TimeSpan countdownTime = closeTime - DateTime.Now;

                        // Kiểm tra nếu thời gian đếm ngược đã kết thúc
                        if (countdownTime.TotalSeconds <= 0)
                        {
                            label20.Text = "Hết thời gian";
                            // Dừng việc cập nhật đồng hồ đếm ngược khi đã hết thời gian
                            return;
                        }

                        // Đổi đơn vị từ TimeSpan (tính bằng giây) sang chuỗi hh:mm:ss
                        label20.Text = string.Format("{0:00}:{1:00}:{2:00}",
                            countdownTime.Hours, countdownTime.Minutes, countdownTime.Seconds);
                    }

                    // Sử dụng một Timer để cập nhật đồng hồ đếm ngược mỗi giây
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000; // Cập nhật mỗi giây
                    timer.Tick += new EventHandler(UpdateCountdown);
                    timer.Start();
                    // Lấy số lượng câu hỏi từ cột SoLuongCauHoi trong bảng KyThi
                    int soLuongCauHoi = 5;// Lấy số lượng câu hỏi từ cơ sở dữ liệu - có thể là một truy vấn SQL

                    // Khởi tạo mảng câu trả lời với số lượng câu hỏi tương ứng
                    mangCauTraLoi = new List<CauTraLoi>();
                    for (int i = 0; i < soLuongCauHoi; i++)
                    {
                        mangCauTraLoi.Add(new CauTraLoi());
                    }

                }

                reader.Close();
                // Không cần đóng kết nối ngay lập tức ở đây vì bạn sẽ sử dụng nó trong phạm vi này

            }
            string mamon = label5.Text;
            using (SqlConnection conn = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế connection_string bằng chuỗi kết nối thực tế của bạn
            {
                conn.Open();
                string sql = "select top 5 * from CauHoi_Gop where MaMon = @MaMon"; // Sử dụng tham số để tránh lỗ hổng SQL Injection
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMon", mamon); // Sửa tên tham số thành @MaMon

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader); // Đọc dữ liệu từ SqlDataReader vào DataTable

                // Hiển thị dữ liệu trong DataGridView
                dataGridView1.DataSource = dataTable;
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = dataGridView1.Rows[0];
                    label23.Text = firstRow.Cells[0].Value.ToString(); // Giả sử cột đầu tiên là cột thứ 0

                    // Kiểm tra giá trị không null trước khi gán cho các control
                    if (firstRow.Cells[1].Value != null)
                        button8.Text = firstRow.Cells[1].Value.ToString();

                    if (firstRow.Cells[6].Value != null)
                        radioButton1.Text = firstRow.Cells[6].Value.ToString();

                    if (firstRow.Cells[7].Value != null)
                        radioButton2.Text = firstRow.Cells[7].Value.ToString();

                    if (firstRow.Cells[8].Value != null)
                        radioButton3.Text = firstRow.Cells[8].Value.ToString();

                    if (firstRow.Cells[9].Value != null)
                        radioButton4.Text = firstRow.Cells[9].Value.ToString();
                }

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                    label23.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                    button8.Text = row.Cells[1].Value.ToString();

                if (row.Cells[6].Value != null)
                    radioButton1.Text = row.Cells[6].Value.ToString();

                if (row.Cells[7].Value != null)
                    radioButton2.Text = row.Cells[7].Value.ToString();

                if (row.Cells[8].Value != null)
                    radioButton3.Text = row.Cells[8].Value.ToString();

                if (row.Cells[9].Value != null)
                    radioButton4.Text = row.Cells[9].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                    label23.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                    button8.Text = row.Cells[1].Value.ToString();

                if (row.Cells[6].Value != null)
                    radioButton1.Text = row.Cells[6].Value.ToString();

                if (row.Cells[7].Value != null)
                    radioButton2.Text = row.Cells[7].Value.ToString();

                if (row.Cells[8].Value != null)
                    radioButton3.Text = row.Cells[8].Value.ToString();

                if (row.Cells[9].Value != null)
                    radioButton4.Text = row.Cells[9].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private int currentRowIndex = 0; // Biến lưu chỉ số hàng hiện tại trong DataGridView
                                         // Khai báo một biến kiểu bool để kiểm tra xem người dùng đã trả lời câu hỏi hiện tại hay chưa
        private bool daTraLoi = false;

        // Một biến dùng để lưu trữ câu trả lời của người dùng
        private string cauTraLoi = "";
        private void button5_Click(object sender, EventArgs e)
        {
            if (!daTraLoi)
            {
                // Nếu người dùng chưa trả lời câu hỏi hiện tại, lưu câu trả lời
                LuuCauTraLoiHienTai();
            }

            // Chuyển đến câu hỏi tiếp theo
            ChuyenCauHoiTiepTheo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!daTraLoi)
            {
                // Nếu người dùng chưa trả lời câu hỏi hiện tại, lưu câu trả lời
                LuuCauTraLoiHienTai();
            }

            // Quay lại câu hỏi trước đó
            QuayLaiCauHoiTruocDo();
        }
        private void LuuCauTraLoiHienTai()
        {
            // Lấy thông tin câu hỏi hiện tại từ DataGridView
            DataGridViewRow currentRow = dataGridView1.Rows[currentRowIndex];
            string dapAnDung = currentRow.Cells["DapAn"].Value.ToString(); // Lấy đáp án đúng của câu hỏi

            // Kiểm tra câu trả lời của người dùng
            string cauTraLoiNguoiDung = LayCauTraLoiTuRadioButton(); // Lấy câu trả lời từ RadioButton

            // Lưu câu trả lời vào mảng tại vị trí hiện tại
            TraLoiCauHoi(currentRowIndex, cauTraLoiNguoiDung, cauTraLoiNguoiDung == dapAnDung);

            // Đánh dấu đã trả lời cho câu hỏi hiện tại
            daTraLoi = true;

            // Đếm số câu hỏi đã được trả lời
            int soCauDaTraLoi = mangCauTraLoi.Count(c => c.DaTraLoi);
            // Hiển thị số câu hỏi đã trả lời lên label19
            label19.Text = soCauDaTraLoi.ToString();
        }
        // Hàm lấy câu trả lời từ RadioButton được chọn
        private string LayCauTraLoiTuRadioButton()
        {
            if (radioButton1.Checked)
            {
                return "A";
            }
            else if (radioButton2.Checked)
            {
                return "B";
            }
            else if (radioButton3.Checked)
            {
                return "C";
            }
            else if (radioButton4.Checked)
            {
                return "D";
            }
            else
            {
                return ""; // Trả về chuỗi rỗng nếu không có RadioButton nào được chọn
            }
        }
        private void HienThiThongTinCauHoi(DataGridViewRow row)
        {
            if (row.Cells[0].Value != null)
                label23.Text = row.Cells[0].Value.ToString();

            if (row.Cells[1].Value != null)
                button8.Text = row.Cells[1].Value.ToString();

            if (row.Cells[6].Value != null)
                radioButton1.Text = row.Cells[6].Value.ToString();

            if (row.Cells[7].Value != null)
                radioButton2.Text = row.Cells[7].Value.ToString();

            if (row.Cells[8].Value != null)
                radioButton3.Text = row.Cells[8].Value.ToString();

            if (row.Cells[9].Value != null)
                radioButton4.Text = row.Cells[9].Value.ToString();

            // Xóa câu trả lời trước đó để người dùng có thể nhập câu trả lời mới
            cauTraLoi = "";
        }
        private void QuayLaiCauHoiTruocDo()
        {
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                daTraLoi = false;
                HienThiThongTinCauHoi(dataGridView1.Rows[currentRowIndex]);
                XoaCauTraLoiRadioButton();

                // Check if it's the first question and hide the back button if it is
                if (currentRowIndex == 0)
                {
                    button2.Visible = false; // Assuming button2 is the button to go back
                }

                // Always show the next button when navigating backward
                button5.Visible = true;
            }
            else
            {
                MessageBox.Show("Đã đến câu hỏi đầu tiên");
            }
        }
        private void ChuyenCauHoiTiepTheo()
        {
            if (currentRowIndex < dataGridView1.Rows.Count - 1)
            {
                currentRowIndex++;
                daTraLoi = false;
                HienThiThongTinCauHoi(dataGridView1.Rows[currentRowIndex]);
                XoaCauTraLoiRadioButton();

                // Check if it's the last question and hide the next button if it is
                if (currentRowIndex == dataGridView1.Rows.Count - 2)
                {
                    button5.Visible = false; // Assuming button5 is the button to go to the next question
                }

                // Always show the back button when navigating forward
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Đã đến câu hỏi cuối cùng");
            }
        }

        private void TraLoiCauHoi(int soThuTuCauHoi, string cauTraLoi, bool dapAnDung)
        {
            if (soThuTuCauHoi >= 0 && soThuTuCauHoi < mangCauTraLoi.Count)
            {
                // Sử dụng chỉ số thực của câu hỏi để cập nhật giá trị trong mảng câu trả lời
                CauTraLoi cauHoi = mangCauTraLoi[soThuTuCauHoi];

                // Thực hiện việc cập nhật giá trị cho câu trả lời này
                cauHoi.TraLoi = cauTraLoi;
                cauHoi.DaTraLoi = true;
                cauHoi.DapAnDung = dapAnDung;

                // Gán lại giá trị đã cập nhật vào mảng câu trả lời
                mangCauTraLoi[soThuTuCauHoi] = cauHoi;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Người dùng đã chọn đáp án A
                // Thực hiện các thao tác hoặc lưu trữ đáp án A ở đây
                // Ví dụ: lưu đáp án vào biến cauTraLoi
                cauTraLoi = "A";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                cauTraLoi = "4";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cauTraLoi = "B";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cauTraLoi = "C";
            }
        }
        private void XoaCauTraLoiRadioButton()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            int soCauDung = 0; // Số câu trả lời đúng

            // Duyệt qua danh sách câu trả lời để kiểm tra số câu trả lời đúng
            foreach (CauTraLoi cauTraLoi in mangCauTraLoi)
            {
                // Điều kiện kiểm tra câu trả lời đã đúng hay không
                if (cauTraLoi.DapAnDung)
                {
                    soCauDung++; // Tăng số câu trả lời đúng nếu câu trả lời của người dùng là đúng
                }
            }

            // Gán giá trị vào biến Diem dựa trên số câu đúng (Ví dụ: mỗi câu đúng được 1 điểm)
            double Diem = soCauDung;

            // Chuẩn bị thông tin cho truy vấn SQL INSERT
            string MaTS = "TS001";
            string MaKyThi = "2";
            string NgayThi = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"); // Format ngày giờ thành chuỗi
            int TongTGThi = 3600;
            int TGTraLoiDe = 1800;
            int TGTraLoiTrungBinh = 120;
            int Loai = 1;

            // Chuẩn bị câu truy vấn SQL INSERT với tham số
            string query = "INSERT INTO KetQua (MaTS, MaKyThi, NgayThi, Diem, TongTGThi, TGTraLoiDe, TGTraLoiTrungBinh, Loai) " +
                           "VALUES (@MaTS, @MaKyThi, @NgayThi, @Diem, @TongTGThi, @TGTraLoiDe, @TGTraLoiTrungBinh, @Loai)";

            // Tạo kết nối và command để thực thi câu truy vấn
            using (SqlConnection connection = new SqlConnection("Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True")) // Thay thế YourConnectionString bằng chuỗi kết nối thực tế của bạn
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào command
                    command.Parameters.AddWithValue("@MaTS", MaTS);
                    command.Parameters.AddWithValue("@MaKyThi", MaKyThi);
                    command.Parameters.AddWithValue("@NgayThi", NgayThi);
                    command.Parameters.AddWithValue("@Diem", Diem);
                    command.Parameters.AddWithValue("@TongTGThi", TongTGThi);
                    command.Parameters.AddWithValue("@TGTraLoiDe", TGTraLoiDe);
                    command.Parameters.AddWithValue("@TGTraLoiTrungBinh", TGTraLoiTrungBinh);
                    command.Parameters.AddWithValue("@Loai", Loai);

                    try
                    {
                        connection.Open();
                        // Thực thi truy vấn INSERT
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Nếu thêm dữ liệu thành công
                            MessageBox.Show("Đã lưu thông tin vào bảng KetQua!");
                            // Chuyển đến form khác hoặc thực hiện hành động tiếp theo tại đây
                        }
                        else
                        {
                            // Nếu không thêm được dữ liệu
                            MessageBox.Show("Lưu thông tin thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            // Hiển thị kết quả điểm số, có thể sử dụng MessageBox hoặc hiển thị trực tiếp trên form
            MessageBox.Show($"Điểm của bạn là: {soCauDung}");
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên Hệ với phòng quản lý thi để được hỗ trợ!");
        }

        private void nhómTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TG tg=new TG();
            tg.Show();
            this.Hide();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        // Sự kiện thay đổi khi người dùng trả lời câu hỏi


        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }
    }
}
