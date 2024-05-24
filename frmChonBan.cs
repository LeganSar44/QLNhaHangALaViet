using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangALaViet
{
    public partial class frmChonBan : Form
    {
        public string SelectedTable { get; private set; }
        public frmChonBan()
        {
            InitializeComponent();
        }

        private void frmChonBan_Load(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM dbo.table_food";
        
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 1";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 2";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 3";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 4";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 5";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 6";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 7";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 8";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 9";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 10";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 11";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan16_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 16";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan14_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 14";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan15_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 15";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 12";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            SelectedTable = "Bàn 13";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
