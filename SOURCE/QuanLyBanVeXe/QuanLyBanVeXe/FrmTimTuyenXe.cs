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
    public partial class FrmTimTuyenXe : Form
    {
        Connection x = new Connection();
        DataSet ds = new DataSet();

        public delegate void PassControl(object sender);
        public PassControl passControl;
        public FrmTimTuyenXe()
        {
            InitializeComponent();
        }
        private void Ketnoidl()
        {
            string load = "SELECT ID_TUYENXE,TENTUYEN FROM TUYENXE";
            SqlDataAdapter da_tuyen = new SqlDataAdapter(load, x.cn);
            DataSet ds = new DataSet();
            da_tuyen.Fill(ds,"TUYENXE");
            dgvTimTuyen.DataSource = ds.Tables["TUYENXE"];
            
        }

        private void FrmTimTuyenXe_Load(object sender, EventArgs e)
        {
            Ketnoidl();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string load = "select  ID_TUYENXE,TENTUYEN from TUYENXE where TENTUYEN like N'%" + txtTenTuyen.Text.Trim() + "%'or TENTUYEN like N'%" + txtTenTuyen.Text.Trim() + "%'";
            dgvTimTuyen.DataSource = x.ExecuteData(load);
            MessageBox.Show(dgvTimTuyen.Rows.Count.ToString());
        }

        private void dgvTimTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn chọn tuyến này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                int current = dgvTimTuyen.CurrentRow.Index;
                string matuyen = Convert.ToString(dgvTimTuyen.Rows[current].Cells[0].Value.ToString());
                x.cn.Open();
                string select = "Select * from TUYENXE where ID_TUYENXE='" + matuyen + "'";
                SqlCommand selectcmd = new SqlCommand(select, x.cn);
                SqlDataReader read = selectcmd.ExecuteReader();
                while (read.Read())
                {
                    txtTenTuyen.Text = read[1].ToString();

                }

                if (passControl != null)
                {
                    passControl(txtTenTuyen);
                }
                x.cn.Close();
                this.Close();
            }
        }

      



    }
}
