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
namespace QuanLyBanVeXe
{
    public partial class frmQuanLyKhachHang : Form
    {
        Connection x = new Connection();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT ID_KHACHHANG,SDT_KHACHHANG,TEN_KHACHHANG FROM KHACHHANG");
            dgvQLKhachHang.DataSource = dt;
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

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (x.KTKhoaChinh("KHACHHANG WHERE ID_KHACHHANG='" + txtID.Text + "'"))
            {
                MessageBox.Show("Khách Hàng Đã Tồn Tại");

                return;
            }
            string sql = "INSERT INTO KHACHHANG(ID_KHACHHANG,SDT_KHACHHANG,TEN_KHACHHANG) VALUES (N'" + txtID.Text + "',N'" + txtSDT.Text + "',N'" + txtTenKH.Text + "')";
            x.ThucThiSQL(sql);
            DataTable dt = x.ExecuteData("SELECT ID_KHACHHANG,SDT_KHACHHANG,TEN_KHACHHANG FROM KHACHHANG");
            dgvQLKhachHang.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("DELETE FROM KHACHHANG WHERE ID_KHACHHANG=N'" + dgvQLKhachHang.CurrentRow.Cells[0].Value.ToString() + "'");
            DataTable dt = x.ExecuteData("SELECT ID_KHACHHANG,SDT_KHACHHANG,TEN_KHACHHANG FROM KHACHHANG");
            dgvQLKhachHang.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("UPDATE KHACHHANG SET SDT_KHACHHANG='" + txtSDT.Text + "', TEN_KHACHHANG=N'" + txtTenKH.Text + "' WHERE ID_KHACHHANG='" + txtID.Text + "'");
            DataTable dt = x.ExecuteData("SELECT ID_KHACHHANG,SDT_KHACHHANG,TEN_KHACHHANG FROM KHACHHANG");
            dgvQLKhachHang.DataSource = dt;
        }

        private void dgvQLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvQLKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtSDT.Text = dgvQLKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtTenKH.Text = dgvQLKhachHang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
           
        }
    }
}
