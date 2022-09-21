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
    public partial class frmQuanLyXe : Form
    {
        DataSet ds = new DataSet();
        public frmQuanLyXe()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT *FROM XE");
            dgvXe.DataSource = dt;
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
        private void Load_Combobox()
        {
            DataSet ds = new DataSet();
            string selectString = "SELECT*FROM TUYENXE";
            SqlDataAdapter ada = new SqlDataAdapter(selectString, x.cn);
            ada.Fill(ds, "TUYENXE");
            cbbMaTuyen.DataSource = ds.Tables["TUYENXE"];
            cbbMaTuyen.DisplayMember = "ID_TUYENXE";
            cbbMaTuyen.ValueMember = "ID_TUYENXE";
        }
        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            grpXe.Focus();
            Load_Combobox();
            string load = "select * from XE ";
            SqlDataAdapter da_xe = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_xe.Fill(ds, "XE");
            dgvXe.DataSource = ds.Tables["XE"];

            DataColumn[] key = new DataColumn[3];
            key[0] = ds.Tables["XE"].Columns[0];
            key[1] = ds.Tables["XE"].Columns[1];
            key[2] = ds.Tables["XE"].Columns[2];
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (x.KTKhoaChinh("XE WHERE ID_XE='" + txtBienSo.Text + "'"))
            {
                MessageBox.Show("Lưu Ý: Xe Đã Tồn Tại");
                return;
            }
            string sql = "INSERT INTO XE(ID_XE,TEN_XE,ID_TUYENXE) VALUES (N'" + txtBienSo.Text + "',N'" + txtTenXe.Text + "',N'"+cbbMaTuyen.Text+"')";
            x.ThucThiSQL(sql);
            DataTable dt = x.ExecuteData("SELECT *FROM XE");
            dgvXe.DataSource = dt;
            txtBienSo.Clear();
            txtTenXe.Clear();
   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("DELETE FROM XE WHERE ID_XE=N'" + dgvXe.CurrentRow.Cells[0].Value.ToString() + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM XE");
            dgvXe.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            x.ThucThiSQL("UPDATE XE SET TEN_XE= '" + txtTenXe.Text+ "',ID_TUYENXE= '"+ cbbMaTuyen.Text +"' WHERE ID_XE= '" + txtBienSo.Text + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM XE");
            dgvXe.DataSource = dt;
            txtBienSo.Clear();
            txtTenXe.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBienSo.Text = dgvXe.CurrentRow.Cells[0].Value.ToString();
            txtTenXe.Text = dgvXe.CurrentRow.Cells[1].Value.ToString();
            cbbMaTuyen.Text = dgvXe.CurrentRow.Cells[2].Value.ToString();
        }

        //private void btnFrmGheXe_Click(object sender, EventArgs e)
        //{
        //    frmGheXe ghexe = new frmGheXe();
        //    ghexe.Show();
        //}


        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grpXe_Enter(object sender, EventArgs e)
        {
            txtBienSo.Focus();
        }

      
      
      




    }
}
