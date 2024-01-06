using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTNCBA
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void linktimch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Visible=true;
            label4.Text = "*Tìm kiếm câu hỏi" + Environment.NewLine + "1.Nhập thông tin tìm kiếm (mã câu hỏi hoặc mã môn) vào ô tìm kiếm " + Environment.NewLine + "2.Thông tin sẽ hiện ra bảng danh sách câu hỏi ở bên dưới" + Environment.NewLine + "3.Chọn tên môn thi tương ứng để lọc các câu hỏi theo từng môn";

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            giaodien.Show();
            this.Hide();
        }

        private void linkthemch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Text = "*Thêm câu hỏi " + Environment.NewLine + "1.Nhấp chuột vào Thêm " + Environment.NewLine + "2.nhập thông tin vào các ô tương ứng " + Environment.NewLine + "3.sau khi nhập đầy đủ thông tin thì nhấp chuột vào Lưu";
        }

        private void linksuach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Text = "*Sửa câu hỏi " + Environment.NewLine + "1.nhấp vào câu hỏi cần sửa " + Environment.NewLine + "2.thông tin câu hỏi sẽ hiện vào ô tương ứng" + Environment.NewLine + "3.nhấp vào Sửa " + Environment.NewLine + "4.sửa thông tin cần thay đổi" + Environment.NewLine + "5.sau khi sửa xong nhấp vào Lưu";

        }

        private void linkxoach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Text = "*Xóa câu hỏi" + Environment.NewLine + "1.nhấp vào câu hỏi cần xóa " + Environment.NewLine + " 2.thông tin câu hỏi sẽ hiện vào ô tương ứng" + Environment.NewLine + " 3.nhấp vào Xóa ";

        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thongtinnv.GV == true)
            {
                AddQ add = new AddQ();
                add.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không phải là Giáo viên!");
            }
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
    }
}
