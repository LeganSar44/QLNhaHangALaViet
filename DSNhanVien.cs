using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangALaViet
{
    public partial class frmDsNhanVien : Form
    {
        frmHome frmHomeInstance = new frmHome();
        public frmDsNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemMoiNv frmThemMoiNv = new frmThemMoiNv(frmHomeInstance, this);
            frmThemMoiNv.Show();


        }
        private Form activeForm = null;

        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT id,HoTen, VaiTro FROM TaiKhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        datagridviewDSnv.DataSource = dataTable;
                    }
                }
            }
        }

        private void datagridviewDSnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void frmDsNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagridviewDSnv.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;";
                    string query = "DELETE FROM TaiKhoan WHERE id = @id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", datagridviewDSnv.SelectedRows[0].Cells[0].Value);

                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); 
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}