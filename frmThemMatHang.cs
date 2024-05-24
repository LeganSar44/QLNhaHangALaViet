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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace QLNhaHangALaViet
    {
        public partial class frmThemMatHang : Form
        {
        public event EventHandler DataInserted;


        private frmHome frmHomeInstance;
       
        public frmThemMatHang(frmHome frmHomeInstance )
            {
                InitializeComponent();
                this.frmHomeInstance = frmHomeInstance;
            }

       

            private void btnTaiHinhAnh_Click(object sender, EventArgs e)
            {
               OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ptbTaiHinhAnh.ImageLocation = openFileDialog.FileName;
                    txtDuongDan.Text = openFileDialog.FileName;
                }

             }

        

            private void btnLuu_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtNhapTenMh.Text) ||
                    drdLoaiMh.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaVon.Text) ||
                    drdDonvi.SelectedItem == null ||
                    drdDanhMuc.SelectedItem == null || // Kiểm tra danh mục
                    drdMenu.SelectedItem == null) // Kiểm tra menu
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenMh = txtNhapTenMh.Text;
                string loaiMh = drdLoaiMh.SelectedItem.ToString();
                double giaBan = double.Parse(txtGiaBan.Text);
                double giaVon = double.Parse(txtGiaVon.Text);
                string donVi = drdDonvi.SelectedItem.ToString();
                string danhMuc = drdDanhMuc.SelectedItem.ToString(); // Lấy giá trị danh mục
                string menu = drdMenu.SelectedItem.ToString(); // Lấy giá trị menu
                string hinhAnh = txtDuongDan.Text;
                string moTa = txtNhapMoTA.Text;

                string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
                string query = "INSERT INTO MatHang (TenMatHang, LoaiMatHang, GiaTaiNhaHang, GiaVon, Donvi, DanhMuc, Menu, imagePath, MoTa) VALUES (@TenMatHang, @LoaiMatHang, @GiaTaiNhaHang, @GiaVon, @Donvi, @DanhMuc, @Menu, @imagePath, @MoTa)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenMatHang", tenMh);
                        command.Parameters.AddWithValue("@LoaiMatHang", loaiMh);
                        command.Parameters.AddWithValue("@GiaTaiNhaHang", giaBan);
                        command.Parameters.AddWithValue("@GiaVon", giaVon);
                        command.Parameters.AddWithValue("@Donvi", donVi);
                        command.Parameters.AddWithValue("@DanhMuc", danhMuc);
                        command.Parameters.AddWithValue("@Menu", menu);
                        command.Parameters.AddWithValue("@imagePath", hinhAnh);
                        command.Parameters.AddWithValue("@MoTa", moTa);

                      //  try
                       // {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thêm mặt hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    OnDataInserted();
                    //  }
                    // catch (Exception ex)
                    // {
                    //     MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  }

                }
                }
            }
        protected virtual void OnDataInserted()
        {
            DataInserted?.Invoke(this, EventArgs.Empty);
        }

        private void lblBack_Click(object sender, EventArgs e)
            {
               
                frmHomeInstance.openChildForm(this);
                    this.Close();
                
            }
        }
    }
