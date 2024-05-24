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
    public partial class ucOrder : UserControl
    {
        private string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;Encrypt=False;";
        public event EventHandler BtnInClicked;
        public string TableNumber
        {
            get { return lblTableNumber.Text; }
            set { lblTableNumber.Text = value; }
        }

        public string WaiterName
        {
            get { return lblWaiterName.Text; }
            set { lblWaiterName.Text = value; }
        }

        public string OrderDate
        {
            get { return lblOrderDate.Text; }
            set { lblOrderDate.Text = value; }
        }

        public string TotalAmount
        {
            get { return lblTotalAmount.Text; }
            set { lblTotalAmount.Text = value; }
        }

        public new string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public int Quantity
        {
            get { return int.Parse(lblQuantity.Text); }
            set { lblQuantity.Text = value.ToString(); }
        }

        //public decimal Price
        //{
        //    get { return decimal.Parse(lblPrice.Text.Replace(" đ", "")); }
        //    set { lblPrice.Text = value.ToString() + " đ"; }
        //}

        //public decimal Total
        //{
        //    get { return decimal.Parse(lblTotal.Text.Replace(" đ", "")); }
        //    set { lblTotal.Text = value.ToString() + " đ"; }
        //}

        public int OrderID
        {
            get { return int.Parse(lblOrderID.Text); }
            set { lblOrderID.Text = value.ToString(); }
        }

      
        public ucOrder()
        {
            InitializeComponent();
            btnIn.Click += (sender, e) => BtnInClicked?.Invoke(this, EventArgs.Empty);
            btnHoanthanh.Click += BtnHoanthanh_Click;

        }

        private void BtnHoanthanh_Click(object sender, EventArgs e)
        {
            // Lưu thông tin hóa đơn vào bảng Invoices
            try
            {
                DateTime orderDate = DateTime.ParseExact(OrderDate, "dd/MM/yyyy HH:mm:ss", null);

                // Lưu thông tin hóa đơn vào bảng Invoices
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Invoices (OrderID, TableNumber, WaiterName, OrderDate, Status) VALUES (@OrderID, @TableNumber, @WaiterName, @OrderDate, @Status)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@TableNumber", TableNumber);
                        command.Parameters.AddWithValue("@WaiterName", WaiterName);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);  // Sử dụng kiểu DateTime
                        command.Parameters.AddWithValue("@Status", "Hoàn thành");

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Xóa ucOrder
                this.Parent.Controls.Remove(this);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Định dạng ngày tháng không hợp lệ. Vui lòng kiểm tra lại.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin hóa đơn vào cơ sở dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }




        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        public Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnIn
        {
            get { return btnIn; }
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {

        }
    }
}
