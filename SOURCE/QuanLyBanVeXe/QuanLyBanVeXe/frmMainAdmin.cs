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
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
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

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.Show();
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
            frmMainAdmin main = new frmMainAdmin();
            main.Hide();
            frmBanVe frm = new frmBanVe();
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            frm.Show();
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyXe frm = new frmQuanLyXe();
            frm.Show();
        }
     

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            frm.Show();
        }

        private void ghếToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frm = new frmChiTietHoaDon();
            frm.Show();
        }

        private void chiTiếtTuyếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietTuyenXe frm = new frmChiTietTuyenXe();
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
