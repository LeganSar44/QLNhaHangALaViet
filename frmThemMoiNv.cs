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

    public partial class frmThemMoiNv : Form
    {
        private frmHome frmHomeInstance;
        public frmDsNhanVien frmDsNhanVienInstance;
        public frmThemMoiNv(frmHome frmHomeInstance, frmDsNhanVien frmDsNhanVienInstance)
        {
            InitializeComponent();
            this.frmHomeInstance = frmHomeInstance;
            this.frmDsNhanVienInstance = frmDsNhanVienInstance;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IdDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtHoTenNv.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhanMk.Text) ||
                DrdChonVaiTro.SelectedItem == null)
            {
                snackbarMatKhauKhongKhop.Show(this, "Vui lòng điền đầy đủ thông tin!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 1000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter);
                return;
            }

            if (txtXacNhanMk.Text != txtMatKhauDangNhap.Text)
            {
                snackbarMatKhauKhongKhop.Show(this, "Mật khẩu xác nhận không khớp",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,1000,"",
                     Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter);
                return;
            }

            int id = int.Parse(txt_IdDangNhap.Text); 
            string hoTen = txtHoTenNv.Text;
            string email = txtEmail.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string password = txtMatKhauDangNhap.Text;
            string vaiTro = DrdChonVaiTro.SelectedItem.ToString(); 

            string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";

            string query = "INSERT INTO TaiKhoan (id, HoTen, Email, Sodienthoai, password, VaiTro) VALUES (@id, @hoTen, @Email, @soDienThoai, @password, @vaiTro)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@hoTen", hoTen);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@vaiTro", vaiTro);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        snackbarMatKhauKhongKhop.Show(this,"Thêm nhân viên mới thành công!",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,1000,"",Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter );
                        frmDsNhanVienInstance.LoadData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void lblBack_Click(object sender, EventArgs e)
        {
            if (frmHomeInstance != null)
            {
                frmHomeInstance.openChildForm(new frmDsNhanVien());
                this.Hide();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTenNv.Text = "";
            txt_IdDangNhap.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtMatKhauDangNhap.Text = "";
            txtXacNhanMk.Text = "";
            txtHoTenNv.Focus();
        }
    }
}
