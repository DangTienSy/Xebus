using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXe
{
    public partial class frmTaoID : Form
    {
        public frmTaoID()
        {
            InitializeComponent();
        }
        Connection x =new Connection();
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
            if (this.txtID.TextLength == 0 || this.txtMK.TextLength == 0)
            {
                this.lblthongbao.ForeColor = Color.Red;
                this.lblthongbao.Text = "Bạn chưa nhập User hoặc Pass";
            }
            else
            {
                if (x.KTKhoaChinh("DANGNHAP WHERE TK='" + txtID.Text + "'"))
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại");
                    return;
                }
                string sql = "INSERT INTO DANGNHAP (TK,MK) VALUES (N'" + txtID.Text + "',N'" + txtMK.Text + "')";
                x.ThucThiSQL(sql);
                DataTable dt = x.ExecuteData("SELECT *FROM LOAIGHEXE");
                MessageBox.Show("Tạo Thành Công");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtMK.Clear();
            this.txtID.Focus();
            this.lblthongbao.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        


    }
}
