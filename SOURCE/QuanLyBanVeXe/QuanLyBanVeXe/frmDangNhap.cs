using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace QuanLyBanVeXe
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Connection ketnoi = new Connection();

        private void exit(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void ClearGrp(GroupBox grp)
        {
            foreach (Control ct in grp.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ct;
                    t.Clear();
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtMatKhau.TextLength == 0 || this.txtMatKhau.TextLength == 0)
            {
                this.lbl_thongbao.ForeColor = Color.Red;
                this.lbl_thongbao.Text = "Bạn chưa nhập User hoặc Pass";
            }
            else
            {
                DataTable dulieu = ketnoi.ExecuteData("select * from DANGNHAP where TK ='" + txtTenID.Text + "' and MK='" + txtMatKhau.Text + "' ");
                if (dulieu.Rows.Count > 0) // nêu hợp lệ thì cho phép đăng nhập
                {
                    frmMainNguoiDung frmND = new frmMainNguoiDung();
                    frmMainAdmin frmAdmin = new frmMainAdmin();
                    if (dulieu.Rows[0]["Quyen"].ToString() == "admin")
                    {
                        frmAdmin.Show();
                        frmDangNhap DN = new frmDangNhap();
                        DN.Close();
                    }
                    else
                    {
                        frmND.Show();
                        frmAdmin.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại vui lòng xem lại! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmDangNhap dn = new frmDangNhap();
            dn.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTenID.Clear();
            this.txtMatKhau.Clear();
            this.txtTenID.Focus();
            this.lbl_thongbao.ResetText();
        }
        public static string Encrypt_md5(string p)
        {

            MD5CryptoServiceProvider mdcsp = new MD5CryptoServiceProvider();
            byte[] b = System.Text.Encoding.UTF8.GetBytes(p);
            b = mdcsp.ComputeHash(b);
            StringBuilder s = new StringBuilder();
            foreach (byte by in b)
            {
                s.Append(by.ToString("x2").ToLower());
            }
            return s.ToString();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

       

      


    }
}



