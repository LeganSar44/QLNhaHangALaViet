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
    public partial class frmBaoCaoDT : Form
    {

        string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;Encrypt=False;";

        public frmBaoCaoDT()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            DataTable dt = GetRevenueData();

            chartRevenue.Series.Clear();
            chartRevenue.Titles.Add("Báo cáo doanh thu theo Tháng");

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            chartRevenue.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["Month"], row["TotalRevenue"]);
            }
        }
        private DataTable GetRevenueData()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT DATEPART(MONTH, OrderDate) AS Month, SUM(TotalAmount) AS TotalRevenue FROM Orders GROUP BY DATEPART(MONTH, OrderDate) ORDER BY Month";

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
