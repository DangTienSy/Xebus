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
    public partial class frmQuanLyNguoiDung : Form
    {
        Connection x = new Connection();
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT *FROM NHANVIEN");
            dgvThongTin.DataSource = dt;
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
        private bool KTraNhap()
        {
            string ktra = string.Empty;
            bool temp = true;
            if (txtIDNV.Text == string.Empty)
            {
                temp = false;
                ktra += " (Ma Nhan Vien)";
            }
            if ( txtTenNV.Text== string.Empty)
            {
                temp = false;
                ktra += " (Tên NV)";
            }
            if (txtSoDienThoai.Text == string.Empty)
            {
                temp = false;
                ktra += " (SDT)";
            }
            if (dtpNgaySinh.Text == string.Empty)
            {
                temp = false;
                ktra += " (Ngay Sinh)";
            }
            if (cbbGioiTinh.Text == string.Empty)
            {
                temp = false;
                ktra += " (Gioi Tinh)";
            }
            if (txtDiaChi.Text == string.Empty)
            {
                temp = false;
                ktra += " (Dia Chi)";
            }
            if (dtpNgayVaoLam.Text == string.Empty)
            {
                temp = false;
                ktra += " (Ngay Vao Lam)";
            }
            if (txtLuongCoBan.Text == string.Empty)
            {
                temp = false;
                ktra += " (Luong Co Ban)";
            }
            if (cbbPhongBan.Text == string.Empty)
            {
                temp = false;
                ktra += " (Phong Ban)";
            }
            if (ktra != string.Empty)
                MessageBox.Show("Bạn thiếu " + ktra);
            return temp;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTraNhap())
            {
                if (x.KTKhoaChinh("NHANVIEN WHERE ID_NV= '" + txtIDNV.Text + "'"))
                {
                    MessageBox.Show("Nhân Viên Đã Tồn Tại");
                    return;
                }
                string sql = "INSERT INTO NHANVIEN(ID_NV,TEN_NV,GIOITINH,NGAYSINH,DIACHI,SDT,NGAYVAOLAM,LUONGCOBAN,ID_PHONG) VALUES (N'" + txtIDNV.Text + "',N'" + txtTenNV.Text + "',N'" + cbbGioiTinh.Text + "',N'" + dtpNgaySinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSoDienThoai.Text + "',N'" + dtpNgayVaoLam.Text + "',N'" + txtLuongCoBan.Text + "',N'" + cbbPhongBan.SelectedValue.ToString() + "')";
                x.ThucThiSQL(sql);
                DataTable dt = x.ExecuteData("SELECT *FROM NHANVIEN");
                dgvThongTin.DataSource = dt;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("DELETE FROM NHANVIEN  WHERE ID_NV=N'" + dgvThongTin.CurrentRow.Cells[0].Value.ToString() + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM NHANVIEN");
            dgvThongTin.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            x.ThucThiSQL("UPDATE NHANVIEN SET TEN_NV=N'" + txtTenNV.Text + "', GIOITINH=N'" + cbbGioiTinh.Text + "', NGAYSINH=N'" + dtpNgaySinh.Value + "', DIACHI=N'" + txtDiaChi.Text + "', SDT=N'" + txtSoDienThoai.Text + "', NGAYVAOLAM=N'" + dtpNgayVaoLam.Value + "', LUONGCOBAN=N'" + txtLuongCoBan.Text + "', ID_PHONG=N'" + cbbPhongBan.SelectedValue.ToString() + "' WHERE ID_NV='" + txtIDNV.Text + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM NHANVIEN");
            dgvThongTin.DataSource = dt;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Combobox()
        {
            DataSet ds = new DataSet();
            string selectString = "SELECT*FROM PHONGBAN";
            SqlDataAdapter ada= new SqlDataAdapter(selectString,x.cn);
            ada.Fill(ds,"PHONGBAN");
            cbbPhongBan.DataSource=ds.Tables["PHONGBAN"];
            cbbPhongBan.DisplayMember = "TENPHONG";
            cbbPhongBan.ValueMember = "ID_PHONG";
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            Load_Combobox();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTin.Rows.Count > 0)
            {
                txtIDNV.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
               
                txtTenNV.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                cbbGioiTinh.Text = dgvThongTin.CurrentRow.Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                txtSoDienThoai.Text = dgvThongTin.CurrentRow.Cells[5].Value.ToString();
                dtpNgayVaoLam.Text = dgvThongTin.CurrentRow.Cells[6].Value.ToString();
                txtLuongCoBan.Text = dgvThongTin.CurrentRow.Cells[7].Value.ToString();
                cbbPhongBan.Text = dgvThongTin.CurrentRow.Cells[8].Value.ToString();

            }
        }

        private void dgvThongTin_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btnFrmTaoID_Click(object sender, EventArgs e)
        {
            frmTaoID tao = new frmTaoID();
            tao.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
