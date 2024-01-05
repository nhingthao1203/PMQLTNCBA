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
    }
}
