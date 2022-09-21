using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXe.Print
{
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
        }

        private void BanVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVEXEDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLVEXEDataSet.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
