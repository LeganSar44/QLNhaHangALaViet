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
    public partial class frmHome : Form
    {


        public frmHome()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelTongquanSub.Visible = false;
            panelBaoCaosub.Visible = false;
            panelMatHangsub.Visible = false;
            panelNhanViensub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelTongquanSub.Visible == true)
            {
                panelTongquanSub.Visible = false;
            }
            if (panelBaoCaosub.Visible == true)
            {
                panelBaoCaosub.Visible = false;
            }
            if (panelMatHangsub.Visible == true)
            {
                panelMatHangsub.Visible = false;
            }
            if (panelNhanViensub.Visible == true)
            {
                panelNhanViensub.Visible = false;
            }
        }

        private void showsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            showsubMenu(panelTongquanSub);
        }
        #region TongQuanSub
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new TongQuan());
            
            hideSubMenu();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showsubMenu((Panel)panelBaoCaosub);
        }
        #region BaoCaoSub

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            showsubMenu(panelMatHangsub);
        }
        #region MatHangSub

        private void btnDSmatHang_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showsubMenu(panelNhanViensub);
        }
        #region NhanVienSub

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDsNhanVien());

            hideSubMenu();
        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

       
    }
}
