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

   
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect=null;

        public ucProduct()
        {
           
            InitializeComponent();
            this.Click += new EventHandler(OnProductClick);
            foreach (Control control in this.Controls)
            {
                control.Click += new EventHandler(OnProductClick);
            }
            txtImage.Click += new EventHandler(OnProductClick);


        }

       // public event EventHandler onSelect = null;
        public int id { get; set; }
        public string PPrice { get; set; }

        public string PCategory { get; set; }

        public string PDescription { get; set; }
        public string PName
        {
            get
            {
                return lblName.Text;

            }
            set { lblName.Text = value; }
        }


        public Image PImage
        {
            get
            {
                return txtImage.Image;

            }
            set { txtImage.Image = value; }
        }

        private void OnProductClick(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void txtImage_Click(object sender, EventArgs e)
        {

        }
    }
}
