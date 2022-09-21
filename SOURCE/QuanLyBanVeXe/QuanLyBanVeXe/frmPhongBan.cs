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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT *FROM PHONGBAN");
            dgvPhongBan.DataSource = dt;
        }
        Connection x = new Connection();
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

        private void btnThem_Click(object sender, EventArgs e)
        {       
            if (x.KTKhoaChinh("PHONGBAN WHERE ID_PHONG='" + txtIDPhong.Text + "'"))
            {
                MessageBox.Show("Lưu Ý: Phòng Đã Tồn Tại");
                return;
            }
            string sql = "INSERT INTO PHONGBAN(ID_PHONG,TENPHONG) VALUES (N'" + txtIDPhong.Text + "',N'" + txtTenPhong.Text + "')";
            x.ThucThiSQL(sql);
            DataTable dt = x.ExecuteData("SELECT *FROM PHONGBAN");
            dgvPhongBan.DataSource = dt;
            txtIDPhong.Clear();
            txtTenPhong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("DELETE FROM PHONGBAN WHERE ID_PHONG=N'" + dgvPhongBan.CurrentRow.Cells[0].Value.ToString() + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM PHONGBAN");
            dgvPhongBan.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("UPDATE PHONGBAN SET TENPHONG= '" + txtTenPhong.Text + "' WHERE ID_PHONG= '" + txtIDPhong.Text + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM PHONGBAN");
            dgvPhongBan.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDPhong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
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
