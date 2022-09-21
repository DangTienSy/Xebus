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
using QuanLyBanVeXe.Print;
namespace QuanLyBanVeXe
{
    
    public partial class frmBanVe : Form
    {
        Connection x = new Connection();
        DataSet ds_khachhang = new DataSet();
        DataSet ds = new DataSet();
        
        public frmBanVe()
        {
            
            InitializeComponent();
            DataTable kh = x.ExecuteData("SELECT *FROM KHACHHANG");
            dgvBanVe.DataSource = kh;

            SqlDataAdapter da_tuyen = new SqlDataAdapter("SELECT * FROM TUYENXE ", x.cn);
            da_tuyen.Fill(ds, "TUYENXE");
            cbbTenTuyen.DataSource = ds.Tables["TUYENXE"];
            cbbTenTuyen.DisplayMember = "TENTUYEN";
            cbbTenTuyen.ValueMember = "ID_TUYENXE";
     
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
       
        private void Ketnoidl()
        {
            string load = "SELECT *FROM TUYENXE";
            SqlDataAdapter da_tuyen = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_tuyen.Fill(ds, "TUYENXE");
            dgvTuyen.DataSource = ds.Tables["TUYENXE"];
            dgvTuyen.Columns.Add("SOVECON", "Số Vé Còn");
            for (int i = 0; i < dgvTuyen.Rows.Count; i++)
            {
                int sovecon = 0;
                for (int j = 0; j < dgvBanVe.Rows.Count; j++)
                {

                    if (dgvTuyen.Rows[i].Cells[0].Value.ToString() == dgvBanVe.Rows[j].Cells[3].Value.ToString())
                    {
                        //MessageBox.Show(dgvTuyen.Rows[i].Cells[4].Value.ToString());
                        //MessageBox.Show(dgvBanVe.Rows[i].Cells[6].Value.ToString());
                        sovecon = int.Parse(dgvTuyen.Rows[i].Cells[4].Value.ToString()) - int.Parse(dgvBanVe.Rows[j].Cells[6].Value.ToString());
                        dgvTuyen.Rows[i].Cells[5].Value = sovecon;

                    }
                }
            }
        }
        private void Ketnoidlkhachhang()
        {
            string load = "SELECT *FROM KHACHHANG";
            SqlDataAdapter da_khachhang = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_khachhang.Fill(ds, "KHACHHANG");
            dgvBanVe.DataSource = ds.Tables["KHACHHANG"];
        }
      
        private void frmBanVe_Load(object sender, EventArgs e)
        {
            btnBanVe.Enabled = true ;
            btnXoa.Enabled = false;
            Ketnoidlkhachhang();
            Ketnoidl();
            dgvBanVe.Hide();
            dgvTuyen.Show();
            button2.Enabled = false;
            grpSearch.Enabled = false;
            grpThongTin.Enabled = false;
        }
        public bool Ktra_KhoaChinh(string pId_Khachhang, string pTuyen, string PNgayDi)
        {
            x.KetNoi();
            string selectString = "select*  from KHACHHANG where ID_KHACHHANG=N'" + pId_Khachhang + "', TUYEN=N'" + pTuyen + "', NGAYDI=N'" + PNgayDi + "' ";
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
        private void btnBanVe_Click(object sender, EventArgs e)
        {
            string tong = (200000 * int.Parse(txtSoVe.Text)).ToString();
            MessageBox.Show(tong, "Tổng Tiền Thanh Toán");
            //   try
            //{
            //    //txtTime.Text = DateTime.Now.ToString();
            //    if (txtIDKhachHang.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo");
            //        txtIDKhachHang.Focus();
            //        return;
            //    }
            //    if (txtTenKhachHang.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn phải nhập Tên khách hàng", "Thông báo");
            //        txtTenKhachHang.Focus();
            //        return;
            //    }
            //    if (txtSDT.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo");
            //        txtSDT.Focus();
            //        return;
            //    }
           
            //    if (txtSoVe.Text == string.Empty)
            //    {
            //        MessageBox.Show("Bạn phải chọn số lượng Vé bán", "Thông báo");
            //        txtSoVe.Focus();
            //        return;
            //    }
            //    if (Ktra_KhoaChinh(txtIDKhachHang.Text, cbbTenTuyen.Text, dtpNgayKhoiHanh.Text) == false)
            //    {
            //        MessageBox.Show("Khách Hàng đã đặt vé,hãy nhập mã khách hàng khác!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    SqlDataAdapter sqlda_Tuyen = new SqlDataAdapter("select * from KHACHHANG", x.cn);
            //    sqlda_Tuyen.Fill(ds_khachhang, "KHACHHANG");
            //    DataRow newrow = ds_khachhang.Tables["KHACHHANG"].NewRow();

            //    newrow["ID_KHACHHANG"] = txtIDKhachHang.Text;
            //    newrow["TEN_KHACHHANG"] = txtTenKhachHang.Text;
            //    newrow["SDT_KHACHHANG"] = int.Parse(txtSDT.Text);
            //    newrow["TUYEN"] = cbbTenTuyen.Text;
            //    newrow["NGAYDI"] = dtpNgayKhoiHanh.Text;
            //    newrow["THOIGIANDI"] = cbbGioKhoiHanh.SelectedItem.ToString(); ;
            //    newrow["SOVEMUA"] = int.Parse(txtSoVe.Text);


            //    ds_khachhang.Tables["KHACHHANG"].Rows.Add(newrow);
            //    SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(sqlda_Tuyen);
            //    sqlda_Tuyen.Update(ds_khachhang, "KHACHHANG");
            //    //dgvTuyen.DataSource = ds_khachhang.Tables["KHACHHANG"];

            //    string update = "update TUYENXE SET SOVE= SOVE-'" + txtSoVe.Text + "'WHERE TENTUYEN=N'" + cbbTenTuyen.Text + "'and NGAYDI='" + dtpNgayKhoiHanh.Text + "'and THOIGIANDI='" + cbbGioKhoiHanh.Text + "'";
            //    SqlDataAdapter da_ve = new SqlDataAdapter(update, x.cn);
            //    da_ve.Fill(ds, "TUYENXE");
            //    Ketnoidl();
            //    btnBanVe.Text = (200000 * int.Parse(txtSoVe.Text)).ToString();

            //    SqlDataAdapter sqlda_HoaDon = new SqlDataAdapter("select * from CHITIETHD", x.cn);
            //    sqlda_HoaDon.Fill(ds, "CHITIETHD");
            //    DataRow newrow1 = ds.Tables["CHITIETHD"].NewRow();

            //    newrow1["ID_KHACHHANG"] = txtIDKhachHang.Text;
            //    newrow1["SOLUONGVE"] = int.Parse(txtSoVe.Text);
            //    newrow1["NGAYDI"] = dtpNgayKhoiHanh.Text;
            //    newrow1["TONGTIEN"] = int.Parse(btnBanVe.Text);

            //    ds.Tables["CHITIETHD"].Rows.Add(newrow1);
            //    SqlCommandBuilder cmdbuilder1 = new SqlCommandBuilder(sqlda_HoaDon);
            //    sqlda_HoaDon.Update(ds, "CHITIETHD");

            //    MessageBox.Show("Lưu dữ liệu khách hàng và Hóa đơn thành công!");
            //}
            //   catch
            //   {
            //       MessageBox.Show("Lưu dữ liệu thất bại");
            //   }
        }

        private void PassData(object sender)
        {

            cbbTenTuyen.Text = ((TextBox)sender).Text;
            string loadtuyen = "select ID_TUYENXE,TENTUYEN,NGAYDI,THOIGIANDI,SOGHE from TUYENXE where ID_TUYENXE=N'" + cbbTenTuyen.SelectedValue.ToString() + "' ";
            SqlDataAdapter da_loadtuyen = new SqlDataAdapter(loadtuyen, x.cn);
            DataSet dss = new DataSet();
            da_loadtuyen.Fill(dss, "TUYENXE");
            dgvTuyen.DataSource = dss.Tables["TUYENXE"];

            cbbTenTuyen.DataSource = dss.Tables["TUYENXE"];
            cbbTenTuyen.DisplayMember = "TENTUYEN";   

        }

        private void cbbTenTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string loadtuyen = "SELECT ID_TUYENXE,TENTUYEN,NGAYDI,THOIGIANDI where ID_TUYENXE='" + cbbTenTuyen.Text + "' ";
            //SqlDataAdapter da_loadtuyen = new SqlDataAdapter(loadtuyen, x.cn);
            //DataSet dss = new DataSet();
            //da_loadtuyen.Fill(dss, "TUYENXE");
            //dgvTuyen.DataSource = dss.Tables["TUYENXE"];

            //cbbTenTuyen.DataSource = dss.Tables["TUYENXE"];
            //cbbTenTuyen.DisplayMember = "TENTUYEN";
            //cbbTenTuyen.ValueMember = "ID_TUYENXE";
        }
       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimTuyenXe TimTuyen = new FrmTimTuyenXe();
            TimTuyen.passControl = new FrmTimTuyenXe.PassControl(PassData);
            TimTuyen.Show();         
        }
        private void cbbTenTuyen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string loadtuyen = "SELECT TENTUYEN,NGAYDI,THOIGIANDI,SOVE where TENTUYEN='" + cbbTenTuyen.Text + "' ";
            SqlDataAdapter da_loadtuyen = new SqlDataAdapter(loadtuyen, x.cn);
            DataSet dss = new DataSet();
            da_loadtuyen.Fill(dss, "TUYENXE");
            dgvTuyen.DataSource = dss.Tables["TUYENXE"];

            cbbTenTuyen.DataSource = dss.Tables["TUYENXE"];
            cbbTenTuyen.DisplayMember = "TENTUYEN";
        }
        private void dgvTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cbbTenTuyen.Text = dgvTuyen.CurrentRow.Cells[1].Value.ToString();
            dtpNgayKhoiHanh.Value = DateTime.Parse(dgvTuyen.CurrentRow.Cells[2].Value.ToString());
            cbbGioKhoiHanh.Text = dgvTuyen.CurrentRow.Cells[3].Value.ToString();
        }
        private void txtSoVe_TextChanged(object sender, EventArgs e)
        {
            if (dgvTuyen.Enabled == true)
            {
                string soghe = dgvTuyen.CurrentRow.Cells[4].Value.ToString();
                if (int.Parse(txtSoVe.Text) > int.Parse(soghe))
                {
                    MessageBox.Show("Không còn đủ ghế !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoVe.Focus();
                    return;
                }
            }
        }
        private void txtSoVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //private void PassData1(object sender1)
        //{
        //    txtLoaiGhe.Text = ((ComboBox)sender1).SelectedItem.ToString();
        //}
        //private void btnChonGhe_Click(object sender, EventArgs e)
        //{
        //    frmGheXe gx = new frmGheXe();
        //    gx.passControl1 = new frmGheXe.PassControl(PassData1);
        //    gx.Show();
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvTuyen.Show();
            dgvBanVe.Show();
            btnSua.Enabled = true;
            txtIDKhachHang.Text = "KH";
          
            dtpNgayKhoiHanh.Text = DateTime.Now.ToString();
            grpSearch.Enabled = true;
            grpThongTin.Enabled = true;      
        }

       
        private void grpThongTin_Enter(object sender, EventArgs e)
        {

        }






        private void dgvTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                x.cn.Open();
                string makhachhang = dgvBanVe.CurrentRow.Cells[0].Value.ToString();
                SqlCommand deletecmd = new SqlCommand("Delete from KHACHHANG WHERE ID_KHACHHANG=N'" + makhachhang + "'", x.cn);
                deletecmd.CommandType = CommandType.Text;
                deletecmd.ExecuteNonQuery();
                x.cn.Close();
                MessageBox.Show("Thành Công !!!");
                Ketnoidlkhachhang();

            }
            catch
            {
                MessageBox.Show("Thất Bại !!!");
            }
        }

        private void dgvBanVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDKhachHang.Text = dgvBanVe.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvBanVe.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvBanVe.CurrentRow.Cells[2].Value.ToString();
            cbbTenTuyen.Text = dgvBanVe.CurrentRow.Cells[3].Value.ToString();
            dtpNgayKhoiHanh.Text = dgvBanVe.CurrentRow.Cells[4].Value.ToString();
            cbbGioKhoiHanh.Text = dgvBanVe.CurrentRow.Cells[5].Value.ToString();
            txtSoVe.Text = dgvBanVe.CurrentRow.Cells[6].Value.ToString();
        }
        private bool KTraNhap()
        {
            string ktra = string.Empty;
            bool temp = true;
            if (txtIDKhachHang.Text == string.Empty)
            {
                temp = false;
                ktra += " (ID Khách Hàng)";
            }
            if (txtTenKhachHang.Text == string.Empty)
            {
                temp = false;
                ktra += " (Tên Khách Hàng)";
            }
            if (txtSDT.Text == string.Empty)
            {
                temp = false;
                ktra += " (SDT)";
            }
            if (txtSoVe.Text == string.Empty)
            {
                temp = false;
                ktra += " (Số Vé Mua)";
            }
            if (cbbTenTuyen.Text == string.Empty)
            {
                temp = false;
                ktra += " (Mã Tuyến)";
            }
            if (ktra != string.Empty)
                MessageBox.Show("Bạn thiếu " + ktra);
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIDKhachHang.Enabled)
            {
                if (KTraNhap())
                {
                    if (x.KTKhoaChinh("KHACHHANG WHERE ID_KHACHHANG=N'" + txtIDKhachHang.Text + "'"))
                    {
                        MessageBox.Show("Khách Hàng Đã Tồn Tại");
                        return;
                    }
                    string sql = "INSERT INTO KHACHHANG VALUES (N'" + txtIDKhachHang.Text + "',N'" + txtTenKhachHang.Text + "',N'" + txtSDT.Text + "',N'" + cbbTenTuyen.SelectedValue + "',N'" + dtpNgayKhoiHanh.Value + "',N'" + cbbGioKhoiHanh.Text + "',N'" + txtSoVe.Text + "')";
                    x.ThucThiSQL(sql);
                    dgvBanVe.DataSource = x.ExecuteData("SELECT * FROM KHACHHANG");
                    MessageBox.Show("Thành công!");
                    dgvTuyen.Hide();
                    grpSearch.Enabled = false;
                    grpThongTin.Enabled = false;
                }
            }
            else
            {
                if (KTraNhap())
                {
                    x.ThucThiSQL("UPDATE KHACHHANG SET TEN_KHACHHANG=N'" + txtTenKhachHang.Text + "', SDT_KHACHHANG=N'" + txtSDT.Text + "', ID_TUYENXE=N'" + cbbTenTuyen.SelectedValue.ToString() + "', NGAYDI=N'" + dtpNgayKhoiHanh.Value + "', THOIGIANDI=N'" + cbbGioKhoiHanh.Text + "', SOVEMUA=N'" + txtSoVe.Text + "' WHERE ID_KHACHHANG=N'" + txtIDKhachHang.Text + "'");
                    grpSearch.Enabled = false;
                    grpThongTin.Enabled = false;
                    MessageBox.Show("Thành công!");
                    dgvBanVe.Enabled = true;
                }

            }
           

           
        }

        private void dgvBanVe_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnBanVe.Enabled = true;
            grpSearch.Enabled = true;
            grpThongTin.Enabled = true;
            txtIDKhachHang.Enabled = false;
            dgvBanVe.Enabled = false;
            
        }

      

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBanVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanVe bv = new BanVe();
            bv.Show();
        }

        


       



        



       




    }
}
