using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyLopHoc.GUI
{
    public partial class FrmUngDungQuanLyLopHoc : Form
    {
        public FrmUngDungQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void mnuStrip_Sanpham_Click(object sender, EventArgs e)
        {
            FrmQuanLyLopHoc frm = new FrmQuanLyLopHoc();
            frm.Show();
            this.Hide();

        }

        private void mnuStrip_close_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
