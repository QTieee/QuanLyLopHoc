using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyLopHoc.DAL;
using QuanLyLopHoc.BLL;
using QuanLyLopHoc.GUI;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class FrmQuanLyLopHoc : Form
    {
        public FrmQuanLyLopHoc()
        {
            InitializeComponent();
        }
        Lop lop;
        bool SaveFlag = true;
        private void BindingDSBanDoc()
        {
            txtMalop.DataBindings.Clear();
            txtTenlop.DataBindings.Clear();
            txtSiso.DataBindings.Clear();
            txtLoptruong.DataBindings.Clear();
            txtGiaovien.DataBindings.Clear();
            txtMakhoahoc.DataBindings.Clear();

            txtMalop.DataBindings.Add("Text", dataGridView1.DataSource, "MALOP");
            txtTenlop.DataBindings.Add("Text", dataGridView1.DataSource, "TENLOP");
            txtSiso.DataBindings.Add("Text", dataGridView1.DataSource, "SISO");
            txtLoptruong.DataBindings.Add("Text", dataGridView1.DataSource, "LOPTRUONG");
            txtGiaovien.DataBindings.Add("Text", dataGridView1.DataSource, "GIAOVIEN");
            txtMakhoahoc.DataBindings.Add("Text", dataGridView1.DataSource, "MAKH");
        }
        private void LoadDSLOP()
        {
            DataTable tblLOP;
            lop = new Lop();

            if (lop.Connect())
            {
                tblLOP = lop.GetDataSanPham();
                dataGridView1.DataSource = tblLOP;
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra tên tài khoản và mật khẩu", "Thông báo!");
            }
            dataGridView1.Columns["MALOP"].HeaderText = "Mã Lớp";
            dataGridView1.Columns["MALOP"].Width = 80;

            dataGridView1.Columns["TENLOP"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["TENLOP"].Width = 128;

            dataGridView1.Columns["SISO"].HeaderText = "Sỉ số";
            dataGridView1.Columns["SISO"].Width = 50;

            dataGridView1.Columns["LOPTRUONG"].HeaderText = "Lớp trưởng";
            dataGridView1.Columns["LOPTRUONG"].Width = 150;

            dataGridView1.Columns["GIAOVIEN"].HeaderText = "Giáo viên";
            dataGridView1.Columns["GIAOVIEN"].Width = 128;

            dataGridView1.Columns["MAKH"].HeaderText = "Mã khóa học";
            dataGridView1.Columns["MAKH"].Width = 79;

            BindingDSBanDoc();
        }

        private void FrmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLOP();
            btnLuu.Enabled = false;
        }
        // ham insert,ham update
        private int InsertLop(Lop lop)
        {
            string sqlInsert = "INSERT INTO lophoc(MALOP,TENLOP,SISO,LOPTRUONG,GIAOVIEN,MAKH)VALUES(@malop,@tenlop,@siso,@loptruong,@giaovien,@makh)";
            string[] parameters = { "@malop", "@tenlop", "@siso", "@loptruong", "@giaovien", "@makh" };
            object[] values = { txtMalop.Text, txtTenlop.Text, txtSiso.Text, txtLoptruong.Text, txtGiaovien.Text, txtMakhoahoc.Text };
            return lop.LOPHOCExecuteNonQuery(sqlInsert, parameters, values, false);
        }
        private int UpdateLop(Lop lop)
        {
            string sqlUpdate = "UPDATE lophoc SET malop=@malop,tenlop=@tenlop,siso=@siso,loptruong=@loptruong,giaovien=@giaovien,makh=@makh WHERE malop=@malop";
            string[] parameters = { "@malop", "@tenlop", "@siso", "@loptruong", "@giaovien", "@makh" };
            object[] values = { txtMalop.Text, txtTenlop.Text, txtSiso.Text, txtLoptruong.Text, txtGiaovien.Text, txtMakhoahoc.Text };
            return lop.LOPHOCExecuteNonQuery(sqlUpdate, parameters, values, false);
        }
        private void RestAll()
        {
            txtMalop.ReadOnly = false;
            txtMalop.Text = "";
            txtTenlop.Clear();
            txtSiso.Clear();
            txtLoptruong.Clear();
            txtGiaovien.Clear();
            txtMakhoahoc.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMalop.ReadOnly = false;
            RestAll();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            lop = new Lop();

            if (lop.Connect())
            {
                if (lop.CheckPK(txtMalop.Text) <= 0)
                {
                    int rec = InsertLop(lop);
                    if (rec > 0)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thông báo!");
                        LoadDSLOP();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại csdl", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã lớp đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kết nối với cở sở dữ liệu thất bại!", "Thông báo");
            }
            btnThem.Enabled = true;
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            FrmUngDungQuanLyLopHoc frm = new FrmUngDungQuanLyLopHoc();
            frm.Show();
            this.Close();
        }
        private void txtSiso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMakhoahoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}