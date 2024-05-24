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
    public partial class frmDatBan : Form
    {
        private string selectedTable;
        private string selectedWaiter;
        private ucOrder ucOrder;

        string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;Encrypt=False;";
        private DataTable dtProductInfo;
        public frmDatBan()
        {
            InitializeComponent();
            InitializeProductInfoTable();
       
        }

        

        private void InitializeProductInfoTable()
        {
            dtProductInfo = new DataTable();
            dtProductInfo.Columns.Add("ProductName");
            dtProductInfo.Columns.Add("Quantity", typeof(int));
            dtProductInfo.Columns.Add("Price", typeof(decimal));
            dtProductInfo.Columns.Add("Total", typeof(decimal));

            bunifuDataGridViewThongTinSp.DataSource = dtProductInfo;
        }   

        private void btnAllDanhMuc_Click(object sender, EventArgs e)
        {
            LoadProducts("All");
        }

        private void btnKhaiVi_Click(object sender, EventArgs e)
        {
            LoadProducts("Khai Vị");
        }

        private void btnMonChinh_Click(object sender, EventArgs e)
        {
            LoadProducts("Món Chính");
        }

        private void btnTrangMieng_Click(object sender, EventArgs e)
        {
            LoadProducts("Tráng Miệng");
        }

        private void btnMonNuoc_Click(object sender, EventArgs e)
        {
            LoadProducts("Món Nước");
        }

        public DataTable GetProductsByCategory(string category)
        {
            DataTable dataTable = new DataTable();
            string query;

            if (category == "All")
            {
                query = "SELECT name, description, price, imagePath FROM Products";
            }
            else
            {
                query = "SELECT name, description, price, imagePath FROM Products WHERE category = @category";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (category != "All")
                    {
                        command.Parameters.AddWithValue("@category", category);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        private void LoadProducts(string category)
        {
            DataTable products = GetProductsByCategory(category);
            flpProducts.Controls.Clear(); 

            foreach (DataRow row in products.Rows)
            {
                ucProduct product = new ucProduct
                {
                    PName = row["name"].ToString(),
                    PPrice = row["price"].ToString() + " đ",
                    PCategory = category,
                    PDescription = row["description"].ToString(),
                    PImage = Image.FromFile(row["imagePath"].ToString()) 
                };
                product.onSelect += Product_onSelect;
                flpProducts.Controls.Add(product);
            }
        }

        public DataTable SearchProducts(string searchTerm)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT name, description, price, imagePath FROM Products WHERE name LIKE @searchTerm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            DataTable products = SearchProducts(searchTerm);
            flpProducts.Controls.Clear();

            foreach (DataRow row in products.Rows)
            {
                ucProduct product = new ucProduct
                {
                    PName = row["name"].ToString(),
                    PPrice = row["price"].ToString() + " đ",
                    PCategory = "All",
                    PDescription = row["description"].ToString(),
                    PImage = Image.FromFile(row["imagePath"].ToString())
                };
                product.onSelect += Product_onSelect;
                flpProducts.Controls.Add(product);
            }
        }

        private void Product_onSelect(object sender, EventArgs e)
        {
           

            if (sender is ucProduct selectedProduct)
            {
                frmProductDetail productDetailForm = new frmProductDetail
                {
                    ProductName = selectedProduct.PName,
                    ProductPrice = selectedProduct.PPrice,
                    ProductImage = selectedProduct.PImage,
                    ProductDescription = selectedProduct.PDescription
                };
                productDetailForm.ShowDialog();

                // Thêm sản phẩm vào DataTable sau khi hiển thị form chi tiết sản phẩm
                string productName = selectedProduct.PName;
                decimal productPrice = Convert.ToDecimal(selectedProduct.PPrice.Replace(" đ", ""));

                DataRow existingRow = dtProductInfo.Rows.Cast<DataRow>().FirstOrDefault(row => row["ProductName"].ToString() == productName);
                if (existingRow != null)
                {
                    int currentQuantity = (int)existingRow["Quantity"];
                    existingRow["Quantity"] = currentQuantity + 1;
                    existingRow["Total"] = (currentQuantity + 1) * productPrice;
                }
                else
                {
                    DataRow newRow = dtProductInfo.NewRow();
                    newRow["ProductName"] = productName;
                    newRow["Quantity"] = 1;
                    newRow["Price"] = productPrice;
                    newRow["Total"] = productPrice;
                    dtProductInfo.Rows.Add(newRow);
                }

            }
        }

        private void btnAnTaiBan_Click(object sender, EventArgs e)
        {
            frmChonBan frmChonBan = new frmChonBan();
            if (frmChonBan.ShowDialog() == DialogResult.OK)
            {
                selectedTable = frmChonBan.SelectedTable;
                lblBanAn.Text = selectedTable;
                lblBanAn.Visible = true;
            }

            bool waiterFormClosed = false;
            if (!string.IsNullOrEmpty(selectedTable)) // Check if table is selected
            {
                frmSelectPhucVu frmSelectPhucVu = new frmSelectPhucVu();
                frmSelectPhucVu.FormClosed += (sender2, e2) => waiterFormClosed = true; frmSelectPhucVu.ShowDialog();

                while (!waiterFormClosed)
                {
                    Application.DoEvents();
                }

                if (frmSelectPhucVu.DialogResult == DialogResult.OK)
                {
                    selectedWaiter = frmSelectPhucVu.SelectedWaiter;
                    lblPhucVu.Text = selectedWaiter;
                    lblPhucVu.Visible = true;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lblBanAn.Text = "";
            lblPhucVu.Text = "";
            lblBanAn.Visible = false;
            lblPhucVu.Visible = false;
            dtProductInfo.Clear();

            // Tùy chọn: Làm mới dữ liệu từ cơ sở dữ liệu hoặc reset thêm các thành phần khác
            LoadProducts("All");
            lblTongTien.Text = "Tổng tiền:   " + "0đ";
    }

        private void btnGuiBep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTable) || string.IsNullOrEmpty(selectedWaiter) || dtProductInfo.Rows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bàn, phục vụ và thêm sản phẩm vào giỏ hàng.");
            return;
        }

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertOrderQuery = "INSERT INTO Orders (TableNumber, WaiterName, OrderDate, TotalAmount) OUTPUT INSERTED.OrderID VALUES (@TableNumber, @WaiterName, @OrderDate, @TotalAmount)";
                    SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection, transaction);
                    orderCommand.Parameters.AddWithValue("@TableNumber", selectedTable);
                    orderCommand.Parameters.AddWithValue("@WaiterName", selectedWaiter);
                    orderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    orderCommand.Parameters.AddWithValue("@TotalAmount", dtProductInfo.AsEnumerable().Sum(row => row.Field<decimal>("Total")));

                    int orderId = (int)orderCommand.ExecuteScalar();

                    foreach (DataRow row in dtProductInfo.Rows)
                    {
                        string insertOrderDetailsQuery = "INSERT INTO OrderDetails (OrderID, ProductName, Quantity, Price, Total) VALUES (@OrderID, @ProductName, @Quantity, @Price, @Total)";
                        SqlCommand orderDetailsCommand = new SqlCommand(insertOrderDetailsQuery, connection, transaction);
                        orderDetailsCommand.Parameters.AddWithValue("@OrderID", orderId);
                        orderDetailsCommand.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                        orderDetailsCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        orderDetailsCommand.Parameters.AddWithValue("@Price", row["Price"]);
                        orderDetailsCommand.Parameters.AddWithValue("@Total", row["Total"]);
                        orderDetailsCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Lưu thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        }
        public void SetOrderDetails(string orderId, string tableNumber, string waiterName, DataTable orderDetails)
        {
            lblBanAn.Text = tableNumber;
            lblPhucVu.Text = waiterName;
            bunifuDataGridViewThongTinSp.DataSource = orderDetails;
            lblTongTien.Text = "Tổng tiền: " + orderDetails.AsEnumerable().Sum(row => row.Field<decimal>("Total")) + "đ";

            this.orderId = orderId; // Store order ID for later use
        }
        private string orderId;

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            UpdateInvoiceStatus(orderId);
        }

        private void UpdateInvoiceStatus(string orderId)
        {
            string query = "UPDATE Invoices SET Status = 'Đã thanh toán' WHERE OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Hóa đơn đã được thanh toán!");
            this.Close();
        }
        public void UpdateTongTien(decimal totalAmount)
        {
            lblTongTien.Text = "Tổng tiền: " + totalAmount.ToString() + "đ";
        }
    }
}
