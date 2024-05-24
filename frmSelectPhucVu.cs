using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangALaViet
{
    public partial class frmSelectPhucVu : Form
    {
        public string SelectedWaiter { get; private set; }
        public frmSelectPhucVu()
        {
            InitializeComponent();
        }

        private void btnLeVanHoang_Click(object sender, EventArgs e)
        {
            SelectedWaiter = "Lê Văn Hoàng";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNguyenNgocHoa_Click(object sender, EventArgs e)
        {
            SelectedWaiter = "Nguyễn Ngọc Hòa";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLeThanhTai_Click(object sender, EventArgs e)
        {
            SelectedWaiter = "Lê Thành Tài";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
