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

        namespace QLNhaHangALaViet
        {
            public partial class frmDsmathang : Form
            {
                private frmHome frmHomeInstance;
                  private frmThemMatHang frmThemMatHangInstance;
        public frmDsmathang(frmHome frmHomeInstance, frmThemMatHang frmThemMatHangInstance)
                {
                    InitializeComponent();
                    this.frmHomeInstance = frmHomeInstance;
            this.frmThemMatHangInstance = frmThemMatHangInstance;
            frmThemMatHangInstance.DataInserted += FrmThemMatHangInstance_DataInserted;
        }

        private void FrmThemMatHangInstance_DataInserted(object sender, EventArgs e)
        {
            // Load lại dữ liệu khi sự kiện DataInserted được kích hoạt
            LoadData();
        }

        private void btnThemMHang_DSmathang_Click(object sender, EventArgs e)
                {
                    frmHomeInstance.openChildForm(new frmThemMatHang (frmHomeInstance));
                }



        public void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
            string query = "SELECT imagePath, TenMatHang, MoTa, GiaTaiNhaHang FROM dbo.MatHang";

            string defaultImagePath = "R:\\App_Details\\Visual_Studio\\WorkSpace_C_Sharp\\QLNhaHangALaViet\\Resources\\Default.jpg";
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

            // Kiểm tra xem chuỗi tìm kiếm có rỗng không
            if (string.IsNullOrEmpty(searchString))
            {
                // Nếu rỗng, xóa toàn bộ dữ liệu hiện có trong DataGridView và gọi lại hàm LoadData()
                DataGridViewDanhSachMatHang.Rows.Clear();
                DataGridViewDanhSachMatHang.Columns.Clear(); // Clear previous columns
                LoadData();
            }
            else
            {
                // Nếu không rỗng, thực hiện truy vấn tìm kiếm
                string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
                string query = "SELECT imagePath, TenMatHang, MoTa, GiaTaiNhaHang FROM dbo.MatHang WHERE TenMatHang LIKE @search";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho truy vấn tìm kiếm
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Xóa toàn bộ dữ liệu hiện có trong DataGridView
                            DataGridViewDanhSachMatHang.Rows.Clear();
                                
                            // Thêm dữ liệu tìm kiếm mới vào DataGridView
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

       
    }
}
