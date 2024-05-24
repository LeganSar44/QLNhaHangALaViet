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
    public partial class uc_3dot : UserControl
    {
     

        public uc_3dot()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("Bạn có chắc chắn muốn thoát","Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Form parentForm = this.FindForm();
                parentForm.Close();
            }
        }

        private void ptbMin_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm.WindowState == FormWindowState.Maximized || parentForm.WindowState == FormWindowState.Normal)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
            else
            {
                parentForm.WindowState = FormWindowState.Normal;

            }
        }
        private void ptbMax_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm.WindowState == FormWindowState.Minimized || parentForm.WindowState == FormWindowState.Normal)
            {
                parentForm.WindowState = FormWindowState.Maximized;
            }
            else if (parentForm.WindowState == FormWindowState.Maximized)
            {
                parentForm.WindowState = FormWindowState.Normal;
            }
        }

      

        
    }
}
