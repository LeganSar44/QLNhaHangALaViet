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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLNhaHangALaViet
{
    public partial class frmbaocaoMathang : Form
    {
        string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;Encrypt=False;";

        public frmbaocaoMathang()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            DataTable dt = GetProductData();

            chartProduct.Series.Clear();
            chartProduct.Titles.Add("Báo cáo theo mặt hàng");

            Series series = new Series("Số lượng");
            series.ChartType = SeriesChartType.Column;
            chartProduct.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["ProductName"], row["TotalQuantity"]);
            }
        }

        private DataTable GetProductData()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductName, SUM(Quantity) AS TotalQuantity FROM OrderDetails GROUP BY ProductName ORDER BY TotalQuantity DESC";

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

            return dataTable;
        }

    }
}
