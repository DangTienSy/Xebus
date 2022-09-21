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
    public partial class frmMainNguoiDung : Form
    {
        public frmMainNguoiDung()
        {
            InitializeComponent();
        }

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

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoID frm = new frmTaoID();
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanVe frm = new frmBanVe();
            frm.Show();
        }

        private void ToolStripMenuTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimTuyenXe frm = new FrmTimTuyenXe();
            frm.Show();
        }

        private void ToolStripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
