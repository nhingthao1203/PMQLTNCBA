using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace PMTNCBA
{
    public partial class Dangnhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        
        public Dangnhap()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void tCUQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            
            

        }
        


        private void button2_Click(object sender, EventArgs e)
        {

            string constr = "Data Source=KA\\NHI1203;Initial Catalog=LTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open(); // Mở kết nối trước khi thực hiện truy vấn

                if (radioButton1.Checked == false)
                {
                    sql = "select count(*) from NhanVien where DN = '" + textBox1.Text + "'and MK = '" + textBox2.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    int val = (int)cmd.ExecuteScalar();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (val == 1)
                    {

                        thongtinnv.DN = textBox1.Text.ToString();
                        thongtinnv.GV = true;
                        Giaodien giaodien = new Giaodien();
                        giaodien.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, nếu bạn Sinh Viên vui lòng chọn ô Sinh Viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //Nếu là sinh viên
                else
                {
                    sql = "select count(*) from ThiSinh where DN ='" + textBox1.Text + "' and MK = '" + textBox2.Text + "' ";
                    cmd = new SqlCommand(sql, conn);
                    int val = (int)cmd.ExecuteScalar();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (val == 1)
                    {

                        thongtinsv.SV = true;
                        thongtinsv.DN = textBox1.Text.ToString();
                        Giaodien giaodien = new Giaodien();
                        giaodien.Show();
                        this.Hide();

                        // mở form thông tin

                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Đảm bảo đóng kết nối sau khi hoàn tất thao tác
                }
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ phòng quản lý để được cấp lại mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TG tg = new TG();
            tg.Show();
            this.Hide();
        }

        public override int GetHashCode()
        {
            int hashCode = -88866093;
            hashCode = hashCode * -1521134295 + CanRaiseEvents.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<EventHandlerList>.Default.GetHashCode(Events);
            hashCode = hashCode * -1521134295 + EqualityComparer<ISite>.Default.GetHashCode(Site);
            hashCode = hashCode * -1521134295 + EqualityComparer<IContainer>.Default.GetHashCode(Container);
            hashCode = hashCode * -1521134295 + DesignMode.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<AccessibleObject>.Default.GetHashCode(AccessibilityObject);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AccessibleDefaultActionDescription);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AccessibleDescription);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AccessibleName);
            hashCode = hashCode * -1521134295 + AccessibleRole.GetHashCode();
            hashCode = hashCode * -1521134295 + AllowDrop.GetHashCode();
            hashCode = hashCode * -1521134295 + Anchor.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoSize.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScrollOffset.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<LayoutEngine>.Default.GetHashCode(LayoutEngine);
            hashCode = hashCode * -1521134295 + BackColor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Image>.Default.GetHashCode(BackgroundImage);
            hashCode = hashCode * -1521134295 + BackgroundImageLayout.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<BindingContext>.Default.GetHashCode(BindingContext);
            hashCode = hashCode * -1521134295 + Bottom.GetHashCode();
            hashCode = hashCode * -1521134295 + Bounds.GetHashCode();
            hashCode = hashCode * -1521134295 + CanFocus.GetHashCode();
            hashCode = hashCode * -1521134295 + CanRaiseEvents.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSelect.GetHashCode();
            hashCode = hashCode * -1521134295 + Capture.GetHashCode();
            hashCode = hashCode * -1521134295 + CausesValidation.GetHashCode();
            hashCode = hashCode * -1521134295 + ClientRectangle.GetHashCode();
            hashCode = hashCode * -1521134295 + ClientSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CompanyName);
            hashCode = hashCode * -1521134295 + ContainsFocus.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ContextMenu>.Default.GetHashCode(ContextMenu);
            hashCode = hashCode * -1521134295 + EqualityComparer<ContextMenuStrip>.Default.GetHashCode(ContextMenuStrip);
            hashCode = hashCode * -1521134295 + EqualityComparer<Control.ControlCollection>.Default.GetHashCode(Controls);
            hashCode = hashCode * -1521134295 + Created.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<CreateParams>.Default.GetHashCode(CreateParams);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cursor>.Default.GetHashCode(Cursor);
            hashCode = hashCode * -1521134295 + EqualityComparer<ControlBindingsCollection>.Default.GetHashCode(DataBindings);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cursor>.Default.GetHashCode(DefaultCursor);
            hashCode = hashCode * -1521134295 + DefaultMargin.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultMaximumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultMinimumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultPadding.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultSize.GetHashCode();
            hashCode = hashCode * -1521134295 + DeviceDpi.GetHashCode();
            hashCode = hashCode * -1521134295 + DisplayRectangle.GetHashCode();
            hashCode = hashCode * -1521134295 + IsDisposed.GetHashCode();
            hashCode = hashCode * -1521134295 + Disposing.GetHashCode();
            hashCode = hashCode * -1521134295 + Dock.GetHashCode();
            hashCode = hashCode * -1521134295 + DoubleBuffered.GetHashCode();
            hashCode = hashCode * -1521134295 + Enabled.GetHashCode();
            hashCode = hashCode * -1521134295 + Focused.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Font>.Default.GetHashCode(Font);
            hashCode = hashCode * -1521134295 + FontHeight.GetHashCode();
            hashCode = hashCode * -1521134295 + ForeColor.GetHashCode();
            hashCode = hashCode * -1521134295 + Handle.GetHashCode();
            hashCode = hashCode * -1521134295 + HasChildren.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            hashCode = hashCode * -1521134295 + IsHandleCreated.GetHashCode();
            hashCode = hashCode * -1521134295 + InvokeRequired.GetHashCode();
            hashCode = hashCode * -1521134295 + IsAccessible.GetHashCode();
            hashCode = hashCode * -1521134295 + IsMirrored.GetHashCode();
            hashCode = hashCode * -1521134295 + Left.GetHashCode();
            hashCode = hashCode * -1521134295 + Location.GetHashCode();
            hashCode = hashCode * -1521134295 + Margin.GetHashCode();
            hashCode = hashCode * -1521134295 + MaximumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + MinimumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Control>.Default.GetHashCode(Parent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductVersion);
            hashCode = hashCode * -1521134295 + RecreatingHandle.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Region>.Default.GetHashCode(Region);
            hashCode = hashCode * -1521134295 + RenderRightToLeft.GetHashCode();
            hashCode = hashCode * -1521134295 + ResizeRedraw.GetHashCode();
            hashCode = hashCode * -1521134295 + Right.GetHashCode();
            hashCode = hashCode * -1521134295 + RightToLeft.GetHashCode();
            hashCode = hashCode * -1521134295 + ScaleChildren.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ISite>.Default.GetHashCode(Site);
            hashCode = hashCode * -1521134295 + Size.GetHashCode();
            hashCode = hashCode * -1521134295 + TabIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + TabStop.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Tag);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + Top.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Control>.Default.GetHashCode(TopLevelControl);
            hashCode = hashCode * -1521134295 + ShowKeyboardCues.GetHashCode();
            hashCode = hashCode * -1521134295 + ShowFocusCues.GetHashCode();
            hashCode = hashCode * -1521134295 + UseWaitCursor.GetHashCode();
            hashCode = hashCode * -1521134295 + Visible.GetHashCode();
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IWindowTarget>.Default.GetHashCode(WindowTarget);
            hashCode = hashCode * -1521134295 + PreferredSize.GetHashCode();
            hashCode = hashCode * -1521134295 + Padding.GetHashCode();
            hashCode = hashCode * -1521134295 + CanEnableIme.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultImeMode.GetHashCode();
            hashCode = hashCode * -1521134295 + ImeMode.GetHashCode();
            hashCode = hashCode * -1521134295 + ImeModeBase.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScroll.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScrollMargin.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScrollPosition.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScrollMinSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<CreateParams>.Default.GetHashCode(CreateParams);
            hashCode = hashCode * -1521134295 + DisplayRectangle.GetHashCode();
            hashCode = hashCode * -1521134295 + HScroll.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<HScrollProperties>.Default.GetHashCode(HorizontalScroll);
            hashCode = hashCode * -1521134295 + VScroll.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<VScrollProperties>.Default.GetHashCode(VerticalScroll);
            hashCode = hashCode * -1521134295 + EqualityComparer<DockPaddingEdges>.Default.GetHashCode(DockPadding);
            hashCode = hashCode * -1521134295 + AutoScaleDimensions.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScaleFactor.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScaleMode.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoValidate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<BindingContext>.Default.GetHashCode(BindingContext);
            hashCode = hashCode * -1521134295 + CanEnableIme.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Control>.Default.GetHashCode(ActiveControl);
            hashCode = hashCode * -1521134295 + EqualityComparer<CreateParams>.Default.GetHashCode(CreateParams);
            hashCode = hashCode * -1521134295 + CurrentAutoScaleDimensions.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Form>.Default.GetHashCode(ParentForm);
            hashCode = hashCode * -1521134295 + EqualityComparer<IButtonControl>.Default.GetHashCode(AcceptButton);
            hashCode = hashCode * -1521134295 + EqualityComparer<Form>.Default.GetHashCode(ActiveMdiChild);
            hashCode = hashCode * -1521134295 + AllowTransparency.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScale.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScaleBaseSize.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoScroll.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoSize.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoSizeMode.GetHashCode();
            hashCode = hashCode * -1521134295 + AutoValidate.GetHashCode();
            hashCode = hashCode * -1521134295 + BackColor.GetHashCode();
            hashCode = hashCode * -1521134295 + FormBorderStyle.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IButtonControl>.Default.GetHashCode(CancelButton);
            hashCode = hashCode * -1521134295 + ClientSize.GetHashCode();
            hashCode = hashCode * -1521134295 + ControlBox.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<CreateParams>.Default.GetHashCode(CreateParams);
            hashCode = hashCode * -1521134295 + DefaultImeMode.GetHashCode();
            hashCode = hashCode * -1521134295 + DefaultSize.GetHashCode();
            hashCode = hashCode * -1521134295 + DesktopBounds.GetHashCode();
            hashCode = hashCode * -1521134295 + DesktopLocation.GetHashCode();
            hashCode = hashCode * -1521134295 + DialogResult.GetHashCode();
            hashCode = hashCode * -1521134295 + HelpButton.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Icon>.Default.GetHashCode(Icon);
            hashCode = hashCode * -1521134295 + IsMdiChild.GetHashCode();
            hashCode = hashCode * -1521134295 + IsMdiContainer.GetHashCode();
            hashCode = hashCode * -1521134295 + IsRestrictedWindow.GetHashCode();
            hashCode = hashCode * -1521134295 + KeyPreview.GetHashCode();
            hashCode = hashCode * -1521134295 + Location.GetHashCode();
            hashCode = hashCode * -1521134295 + MaximizedBounds.GetHashCode();
            hashCode = hashCode * -1521134295 + MaximumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<MenuStrip>.Default.GetHashCode(MainMenuStrip);
            hashCode = hashCode * -1521134295 + Margin.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<MainMenu>.Default.GetHashCode(Menu);
            hashCode = hashCode * -1521134295 + MinimumSize.GetHashCode();
            hashCode = hashCode * -1521134295 + MaximizeBox.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Form[]>.Default.GetHashCode(MdiChildren);
            hashCode = hashCode * -1521134295 + EqualityComparer<Form>.Default.GetHashCode(MdiParent);
            hashCode = hashCode * -1521134295 + EqualityComparer<MainMenu>.Default.GetHashCode(MergedMenu);
            hashCode = hashCode * -1521134295 + MinimizeBox.GetHashCode();
            hashCode = hashCode * -1521134295 + Modal.GetHashCode();
            hashCode = hashCode * -1521134295 + Opacity.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Form[]>.Default.GetHashCode(OwnedForms);
            hashCode = hashCode * -1521134295 + EqualityComparer<Form>.Default.GetHashCode(Owner);
            hashCode = hashCode * -1521134295 + RestoreBounds.GetHashCode();
            hashCode = hashCode * -1521134295 + RightToLeftLayout.GetHashCode();
            hashCode = hashCode * -1521134295 + ShowInTaskbar.GetHashCode();
            hashCode = hashCode * -1521134295 + ShowIcon.GetHashCode();
            hashCode = hashCode * -1521134295 + ShowWithoutActivation.GetHashCode();
            hashCode = hashCode * -1521134295 + Size.GetHashCode();
            hashCode = hashCode * -1521134295 + SizeGripStyle.GetHashCode();
            hashCode = hashCode * -1521134295 + StartPosition.GetHashCode();
            hashCode = hashCode * -1521134295 + TabIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + TabStop.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + TopLevel.GetHashCode();
            hashCode = hashCode * -1521134295 + TopMost.GetHashCode();
            hashCode = hashCode * -1521134295 + TransparencyKey.GetHashCode();
            hashCode = hashCode * -1521134295 + WindowState.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<SqlConnection>.Default.GetHashCode(conn);
            hashCode = hashCode * -1521134295 + EqualityComparer<SqlDataAdapter>.Default.GetHashCode(da);
            hashCode = hashCode * -1521134295 + EqualityComparer<SqlCommand>.Default.GetHashCode(cmd);
            hashCode = hashCode * -1521134295 + EqualityComparer<DataTable>.Default.GetHashCode(dt);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sql);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(constr);
            hashCode = hashCode * -1521134295 + EqualityComparer<IContainer>.Default.GetHashCode(components);
            hashCode = hashCode * -1521134295 + EqualityComparer<TextBox>.Default.GetHashCode(textBox1);
            hashCode = hashCode * -1521134295 + EqualityComparer<TextBox>.Default.GetHashCode(textBox2);
            hashCode = hashCode * -1521134295 + EqualityComparer<RadioButton>.Default.GetHashCode(radioButton1);
            hashCode = hashCode * -1521134295 + EqualityComparer<RadioButton>.Default.GetHashCode(radioButton2);
            hashCode = hashCode * -1521134295 + EqualityComparer<Button>.Default.GetHashCode(button2);
            hashCode = hashCode * -1521134295 + EqualityComparer<Label>.Default.GetHashCode(label1);
            hashCode = hashCode * -1521134295 + EqualityComparer<Button>.Default.GetHashCode(button1);
            hashCode = hashCode * -1521134295 + EqualityComparer<MenuStrip>.Default.GetHashCode(menuStrip1);
            hashCode = hashCode * -1521134295 + EqualityComparer<ToolStripMenuItem>.Default.GetHashCode(tCUQuizToolStripMenuItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<ToolStripMenuItem>.Default.GetHashCode(côngCụToolStripMenuItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<ToolStripMenuItem>.Default.GetHashCode(trợGiúpToolStripMenuItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<Label>.Default.GetHashCode(label2);
            hashCode = hashCode * -1521134295 + EqualityComparer<Label>.Default.GetHashCode(label3);
            hashCode = hashCode * -1521134295 + EqualityComparer<Label>.Default.GetHashCode(label4);
            return hashCode;
        }
    }
}
