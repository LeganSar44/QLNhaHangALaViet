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
    using System.Windows;
using System.Data.OleDb;

namespace QLNhaHangALaViet
        {
            public partial class frmDsmathang : Form
            {
                private frmHome frmHomeInstance;
                  private frmThemMatHang frmThemMatHangInstance;

        public frmDsmathang(frmHome frmHomeInstance)
                {
                    InitializeComponent();
                    this.frmHomeInstance = frmHomeInstance;
            frmThemMatHangInstance = new frmThemMatHang(frmHomeInstance);

            frmThemMatHangInstance.DataInserted += FrmThemMatHangInstance_DataInserted;
            
            

        }


        private void FrmThemMatHangInstance_DataInserted(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemMHang_DSmathang_Click(object sender, EventArgs e)
                {
            frmThemMatHangInstance = new frmThemMatHang(frmHomeInstance);
            frmHomeInstance.openChildForm(frmThemMatHangInstance);
        }



        public void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
            string query = "SELECT imagePath, TenMatHang, MoTa, GiaTaiNhaHang FROM dbo.MatHang";

            string defaultImagePath = "R:\\App_Details\\Visual_Studio\\WorkSpace_C_Sharp\\QLNhaHangALaViet\\Resources\\picture.png";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        DataGridViewDanhSachMatHang.Columns.Clear();

                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn.HeaderText = "Hình ảnh";
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        DataGridViewDanhSachMatHang.Columns.Add(imageColumn);

                        DataGridViewDanhSachMatHang.Columns.Add("TenMatHang", "Tên Mặt Hàng");
                        DataGridViewDanhSachMatHang.Columns.Add("MoTa", "Mô Tả");
                        DataGridViewDanhSachMatHang.Columns.Add("GiaTaiNhaHang", "Giá Tại Nhà Hàng");

                        Image image = null;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string imagePath = row["imagePath"].ToString();

                            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                            {
                                image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                image = Image.FromFile(defaultImagePath);
                            }
                            DataGridViewDanhSachMatHang.Rows.Add(image, row["TenMatHang"], row["MoTa"], row["GiaTaiNhaHang"]);
                        }
                    }
                }
            }
        }




        private void frmDsmathang_Load_1(object sender, EventArgs e)
            {
                LoadData();
            }
            
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchString = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchString))
            {
                DataGridViewDanhSachMatHang.Rows.Clear();
                DataGridViewDanhSachMatHang.Columns.Clear(); 
                LoadData();
            }
            else
            {
                string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
                string query = "SELECT imagePath, TenMatHang, MoTa, GiaTaiNhaHang FROM dbo.MatHang WHERE TenMatHang LIKE @search";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DataGridViewDanhSachMatHang.Rows.Clear();
                                
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string imagePath = row["imagePath"].ToString();
                                Image image = null;

                                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                                {
                                    image = Image.FromFile(imagePath);
                                }

                                DataGridViewDanhSachMatHang.Rows.Add(image, row["TenMatHang"], row["MoTa"], row["GiaTaiNhaHang"]);
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
                frmLuuY_ImportExcel frmLuuY_ImportExcel = new frmLuuY_ImportExcel(this);
            frmLuuY_ImportExcel.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGridViewDanhSachMatHang.SelectedRows.Count > 0)
            {
                  
                    int rowIndex = DataGridViewDanhSachMatHang.SelectedRows[0].Index;
                    string tenMatHang = DataGridViewDanhSachMatHang.Rows[rowIndex].Cells["TenMatHang"].Value.ToString();

                    // Delete the row from the database
                    string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
                    string query = "DELETE FROM dbo.MatHang WHERE TenMatHang = @tenMatHang";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@tenMatHang", tenMatHang);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    // Remove the row from the DataGridView
                    DataGridViewDanhSachMatHang.Rows.RemoveAt(rowIndex);
                snkDsmh.Show(this, "Xoá mặt hàng thành công!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                    3000, "");
                
            }
            else
            {
                snkDsmh.Show(this, "Vui lòng chọn mặt hàng cần xóa!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error
                    , 3000,"");
            }
        }
    }
}
