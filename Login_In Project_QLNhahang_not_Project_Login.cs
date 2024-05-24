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
namespace QLNhaHangALaViet
{
    public partial class Login_In_Project_QLNhahang_not_Project_Login : Form
    {

        string strcon = @"Data Source=LAPTOP-78LVMDCQ\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=true;";
        SqlConnection con = null;
        int cnt = 0;
        public Login_In_Project_QLNhahang_not_Project_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return;
            }

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string querry = "SELECT password FROM dbo.[TaiKhoan] WHERE id = @id";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@id", txtUser.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có Id này!");
                    return;
                }

                string password = dt.Rows[0]["password"].ToString();

                if (password != txtPass.Text)
                {
                    MessageBox.Show("Sai mật khẩu! lần " + cnt);
                    cnt++;
                    if (cnt >= 3)
                    {
                        Close();
                    }
                    return;

                }


                MessageBox.Show("Đăng nhập thành công!");

                var homeform = new frmHome();
                homeform.SetUserRole(selectedRole);
                homeform.Show();
                this.Hide();


            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picHide.Visible = true;
            txtPass.PasswordChar = '\0';
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picHide.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtUser.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private string selectedRole = string.Empty;

        private void dropdownVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRole = dropdownVaiTro.SelectedItem.ToString();

        }
    }
}
