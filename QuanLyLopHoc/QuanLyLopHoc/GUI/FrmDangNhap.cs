using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyLopHoc.BLL;
using QuanLyLopHoc.GUI;

namespace QuanLyLopHoc
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (txtDangnhap.TextLength == 0)
            {
                txtDangnhap.Focus();
                return;
            }
            if (txtMatkhau.TextLength == 0)
            {
                txtMatkhau.Focus();
                return;
            }
            if (user.Connect())
            {
                if (user.CheckUser(txtDangnhap.Text, txtMatkhau.Text) > 0)
                {
                    FrmUngDungQuanLyLopHoc frm = new FrmUngDungQuanLyLopHoc();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra tên tài khoản và mật khẩu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn hủy đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
