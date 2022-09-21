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
    public partial class frmChiTietTuyenXe : Form
    {
        Connection x = new Connection();
        DataSet ds = new DataSet();
        public frmChiTietTuyenXe()
        {
            InitializeComponent();
            DataTable dt = x.ExecuteData("SELECT *FROM TUYENXE");
            dgvTuyenXe.DataSource = dt;
        }
        private void frmChiTietTuyenXe_Load(object sender, EventArgs e)
        {
      
            string load = "select * from TUYENXE ";
            SqlDataAdapter da_tuyen = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_tuyen.Fill(ds, "TUYENXE");
            dgvTuyenXe.DataSource = ds.Tables["TUYENXE"];

            txtIDTuyen.Enabled = false;
            txtTenTuyen.Enabled = false;
            txtSoGhe.Enabled = false;
            dtpNgayKhoiHanh.Enabled = false;
            cbbThoiGianDi.Enabled = false;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDT()
        {
            string load = "select * from TUYENXE ";
            SqlDataAdapter da_tuyen = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_tuyen.Fill(ds, "TUYENXE");
            dgvTuyenXe.DataSource = ds.Tables["TUYENXE"];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //{
            //    if (x.KTKhoaChinh("TUYENXE WHERE ID_TUYENXE=N'" + txtIDTuyen.Text + "'"))
            //    {
            //        MessageBox.Show("Tuyến Xe Đã Tồn Tại");
            //        return;
            //    }
            //    string sql = "INSERT INTO TUYENXE(ID_TUYENXE,TENTUYEN,NGAYDI,THOIGIANDI,SOGHE) VALUES (N'" + txtIDTuyen.Text + "',N'" + txtTenTuyen.Text + "',N'" + dtpNgayKhoiHanh.Text + "',N'" + mtxtGioKhoiHanh.Text + "')";
            //    x.ThucThiSQL(sql);
            //    DataTable dt = x.ExecuteData("SELECT *FROM TUYENXE");
            //    dgvTuyenXe.DataSource = dt;
            //}
            txtIDTuyen.Enabled = true;
            txtTenTuyen.Enabled = true;
            txtSoGhe.Enabled = true;
            dtpNgayKhoiHanh.Enabled = true;
            cbbThoiGianDi.Enabled = true;
            btnThem.Enabled = false;



            txtIDTuyen.Clear();
            txtTenTuyen.Clear();
            txtSoGhe.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                x.ThucThiSQL("DELETE FROM TUYENXE WHERE ID_TUYENXE=N'" + dgvTuyenXe.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dt = x.ExecuteData("SELECT *FROM TUYENXE");
                dgvTuyenXe.DataSource = dt;
            }
            catch {
                MessageBox.Show("Bạn chưa xóa Xe");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            x.ThucThiSQL("UPDATE TUYENXE SET TENTUYEN='" + txtTenTuyen.Text + "',NGAYDI=N'" + dtpNgayKhoiHanh.Text + "',THOIGIANDI= '" + cbbThoiGianDi.Text + "',SOGHE= '"+txtSoGhe.Text+"' WHERE ID_TUYENXE='" + txtIDTuyen.Text + "'");
            DataTable dt = x.ExecuteData("SELECT *FROM TUYENXE");
            dgvTuyenXe.DataSource = dt;
            txtTenTuyen.Enabled = true;
            txtSoGhe.Enabled = true;
            dtpNgayKhoiHanh.Enabled = true;
            cbbThoiGianDi.Enabled = true;
            txtIDTuyen.Enabled = false;
        }

        private void dgvTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x.cn.Open();
            int current = dgvTuyenXe.CurrentRow.Index;
            string matuyen = Convert.ToString(dgvTuyenXe.Rows[current].Cells[0].Value.ToString());
            string ngaydi = Convert.ToString(dgvTuyenXe.Rows[current].Cells[2].Value.ToString());
            string thoigiandi = Convert.ToString(dgvTuyenXe.Rows[current].Cells[3].Value.ToString());


            string select = "Select * from TUYENXE WHERE ID_TUYENXE='" + matuyen + "' and NGAYDI='" + ngaydi + "' and THOIGIANDI='" + thoigiandi + "'";
            SqlCommand selectcmd = new SqlCommand(select, x.cn);
            SqlDataReader read = selectcmd.ExecuteReader();
            while (read.Read())
            {
                txtIDTuyen.Text = read[0].ToString();
                txtTenTuyen.Text = read[1].ToString();
                dtpNgayKhoiHanh.Text = read[2].ToString();
                cbbThoiGianDi.Text = read[3].ToString();
                txtSoGhe.Text = read[4].ToString();
            }
            x.cn.Close();
            
        }


        private void btnFrmXe_Click(object sender, EventArgs e)
        {
        }

        public bool Ktra_KhoaChinh(string pId_Tuyen, string pNgayDi, string pGioDi)
        {
            x.KetNoi();
            string selectString = "select*  from TUYENXE where ID_TUYENXE='" + pId_Tuyen + "' and NGAYDI='" + pNgayDi + "'and THOIGIANDI='" + pGioDi + "'";
            SqlCommand cmd = new SqlCommand(selectString, x.cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Close();
                x.cn.Close();
                return false;
            }
            else
            {
                rdr.Close();
                x.cn.Close();
                return true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtIDTuyen.Enabled == true)
            {
                if (txtIDTuyen.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập mã tuyến", "Thông báo");
                    txtIDTuyen.Focus();
                    return;
                }
                if (txtTenTuyen.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập tên tuyến", "Thông báo");
                    txtTenTuyen.Focus();
                    return;
                }
                if (dtpNgayKhoiHanh.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải chọn ngày đi", "Thông báo");
                    dtpNgayKhoiHanh.Focus();
                    return;
                }
                if (cbbThoiGianDi.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải chọn thời gian đi", "Thông báo");
                    cbbThoiGianDi.Focus();
                    return;
                }
                if (txtSoGhe.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải chọn số lượng vé phù hợp cho chuyến xe", "Thông báo");
                    txtSoGhe.Focus();
                    return;
                }
                if (Ktra_KhoaChinh(txtIDTuyen.Text, dtpNgayKhoiHanh.Text, cbbThoiGianDi.Text) == false)
                {
                   
                }
                try
                {
                    SqlDataAdapter sqlda_Tuyen = new SqlDataAdapter("select * from TUYENXE", x.cn);
                    DataSet ds = new DataSet();

                    sqlda_Tuyen.Fill(ds, "TUYENXE");
                    DataRow newrow = ds.Tables["TUYENXE"].NewRow();

                    newrow["ID_TUYENXE"] = txtIDTuyen.Text;
                    newrow["TENTUYEN"] = txtTenTuyen.Text;
                    newrow["NGAYDI"] = dtpNgayKhoiHanh.Text;
                    newrow["THOIGIANDI"] = cbbThoiGianDi.Text;
                    newrow["SOGHE"] = int.Parse(txtSoGhe.Text);

                    ds.Tables["TUYENXE"].Rows.Add(newrow);
                    SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(sqlda_Tuyen);
                    sqlda_Tuyen.Update(ds, "TUYENXE");
                    dgvTuyenXe.DataSource = ds.Tables["TUYENXE"];
                    MessageBox.Show("Thành Công");
                }
                catch
                {
                    MessageBox.Show("Tuyến này đã tồn tại, Mời nhập thông tin Tuyến mới", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                   // MessageBox.Show("Thất Bại");
                }
            }
            else if (txtIDTuyen.Enabled == false)
            {
                try
                {
                    x.cn.Open();


                    int current = dgvTuyenXe.CurrentCell.RowIndex;
                    string matuyen = Convert.ToString(dgvTuyenXe.Rows[current].Cells[0].Value.ToString());
                    string ngaydi = Convert.ToString(dgvTuyenXe.Rows[current].Cells[2].Value.ToString());
                    string thoigiandi = Convert.ToString(dgvTuyenXe.Rows[current].Cells[3].Value.ToString());

                    string update = "Update TUYENXE SET TENTUYEN='" + txtTenTuyen.Text + "',NGAYDI='" + dtpNgayKhoiHanh.Text + "',THOIGIANDI='" + cbbThoiGianDi.SelectedItem.ToString() + "',SOGHE='" + txtSoGhe.Text + "' where ID_TUYENXE='" + matuyen + "' and NGAYDI='" + ngaydi + "' and THOIGIANDI='" + thoigiandi + "'";
                    SqlCommand deletecmd = new SqlCommand(update, x.cn);
                    deletecmd.CommandType = CommandType.Text;
                    deletecmd.ExecuteNonQuery();
                   x.cn.Close();
                    MessageBox.Show("Thành công");
                    LoadDT();
                }
                catch
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            btnThem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanLyXe qlx = new frmQuanLyXe();
            qlx.Show();
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

        private void txtSoGhe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoGhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


      
    }
}
