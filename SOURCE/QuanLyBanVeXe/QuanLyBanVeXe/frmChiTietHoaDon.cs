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
    public partial class frmChiTietHoaDon : Form
    {
        Connection x = new Connection();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT *FROM CHITIETHD");
            dgvChiTietHoaDon.DataSource = dt;
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
            //if (x.KTKhoaChinh("CHITIETHD WHERE ID_CHITIETHD= '" + txtIDChiTietHD.Text + "'"))
            //{
            //    MessageBox.Show("Hóa Đơn Đã Tồn Tại");
            //    return;
            //}
            //string sql = "INSERT INTO CHITIETHD(ID_CHITIETHD,ID_HOADON,ID_XE,SOLUONGVE,LOAIGHE,ID_NV,ID_KHACHHANG,NGAYDAT,TONGTIEN) VALUES (N'" + txtIDChiTietHD.Text + "',N'" + txtIDHoaDon.Text + "',N'" + txtIDXe.Text + "',N'" + int.Parse(txtSoLuongVe.Text) + "',N'" + txtLoaiGhe.Text + "',N'" + txtIDNhanVien.Text + "',N'" + txtIDKhachHang.Text + "',N'" + dtpNgayDat.Value.ToShortDateString()+ "',N'" + txtTongTien.Text + "')";
            //x.ThucThiSQL(sql);
            //DataTable dt = x.ExecuteData("SELECT *FROM CHITIETHD");
            //dgvChiTietHoaDon.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("DELETE FROM CHITIETHD WHERE ID_CHITIETHD=N'" + dgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString() + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM CHITIETHD");
            dgvChiTietHoaDon.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("UPDATE CHITIETHD SET ID_HOADON='" + cbbIDHoaDon.SelectedValue.ToString() + "', ID_XE=N'" + cbbIDXe.SelectedValue.ToString() + "', SOLUONGVE=N'" + txtSoLuongVe.Text + "', LOAIGHE=N'" + cbbLoaiGhe.SelectedValue.ToString() + "', ID_NV=N'" + cbbIDNhanVien.SelectedValue.ToString() + "', ID_KHACHHANG=N'" + cbbIDKhachHang.SelectedValue.ToString() + "', NGAYDAT=N'" + dtpNgayDat.Text + "', TONGTIEN=N'" + txtTongTien.Text + "' WHERE ID_CHITIETHD='" + txtIDChiTietHD.Text + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM CHITIETHD");
            dgvChiTietHoaDon.DataSource = dt;
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDChiTietHD.Text = dgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
            cbbIDHoaDon.Text = dgvChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
            cbbIDXe.Text = dgvChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongVe.Text = dgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
            cbbLoaiGhe.Text = dgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString();
            cbbIDNhanVien.Text = dgvChiTietHoaDon.CurrentRow.Cells[5].Value.ToString();
            cbbIDKhachHang.Text = dgvChiTietHoaDon.CurrentRow.Cells[6].Value.ToString();
            dtpNgayDat.Text = dgvChiTietHoaDon.CurrentRow.Cells[7].Value.ToString();
            txtTongTien.Text = dgvChiTietHoaDon.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainAdmin frm = new frmMainAdmin();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

      
        
       

    }
}
