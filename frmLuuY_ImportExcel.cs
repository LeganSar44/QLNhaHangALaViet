using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace QLNhaHangALaViet
{
    public partial class frmLuuY_ImportExcel : Form
    {
        private frmDsmathang frmDsmathangInstance;
        public frmLuuY_ImportExcel(frmDsmathang frmDsmathangInstance)
        {
            InitializeComponent();
            this.frmDsmathangInstance = frmDsmathangInstance;

        }

        



        private void btnImport_Click(object sender, EventArgs e)
        {
           

        }
    }
}
