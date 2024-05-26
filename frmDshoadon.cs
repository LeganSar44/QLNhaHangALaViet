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
    public partial class frmDshoadon : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmDshoadon()
        {
            InitializeComponent();
            datagridDShd.CellClick += datagridDShd_CellClick;
        }
        private void LoadInvoiceList()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT OrderID, TableNumber, WaiterName, OrderDate, Status FROM Invoices";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            datagridDShd.DataSource = dataTable;
        }

        private void datagridDShd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDshoadon_Load(object sender, EventArgs e)
        {
            LoadInvoiceList();
        }

        private void datagridDShd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridDShd.Rows[e.RowIndex];
                string orderId = row.Cells["OrderID"].Value.ToString();
                string tableNumber = row.Cells["TableNumber"].Value.ToString();
                string waiterName = row.Cells["WaiterName"].Value.ToString();

                // Load order details
                DataTable orderDetails = GetOrderDetails(orderId);

                // Open frmDatBan and pass the information
                frmDatBan datBanForm = new frmDatBan();
                datBanForm.SetOrderDetails(orderId, tableNumber, waiterName, orderDetails);

                // Calculate total amount
                decimal totalAmount = orderDetails.AsEnumerable().Sum(detailRow => detailRow.Field<decimal>("Total"));

                // Update the total amount in frmDatBan
                datBanForm.UpdateTongTien(totalAmount);

                datBanForm.Show();
            }
        }

        private DataTable GetOrderDetails(string orderId)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductName, Quantity, Price, (Quantity * Price) AS Total FROM OrderDetails WHERE OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }



    }
}
