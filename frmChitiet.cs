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
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {

        }

        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string ProductPrice
        {
            get { return lblProductPrice.Text; }
            set { lblProductPrice.Text = value; }
        }

        public Image ProductImage
        {
            get { return picProductImage.Image; }
            set { picProductImage.Image = value; }
        }

        public string ProductDescription
        {
            get { return txtProductDescription.Text; }
            set { txtProductDescription.Text = value; }
        }

      

        private void lblGia_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
