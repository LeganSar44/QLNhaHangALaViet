using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangALaViet
{
    public partial class frmHoaDon : Form
    {

        
        private PrintPreviewDialog prnPreview;
        private List<DataRow> orderDetails;

        string connectionString = "Data Source=LAPTOP-78LVMDCQ\\SQLEXPRESS;Initial Catalog=QL_ALaViet;Integrated Security=True;Encrypt=False;";

        public frmHoaDon()
        {
            InitializeComponent();
          
            LoadOrders();
            prnDoc = new PrintDocument();
            prnPreview = new PrintPreviewDialog();
            prnDoc.PrintPage += new PrintPageEventHandler(PrintInvoice);
        }

        private void LoadOrders()
        {
            DataTable orders = GetOrders();
            foreach (DataRow row in orders.Rows)
            {
                ucOrder orderControl = new ucOrder
                {
                    OrderID = (int)row["OrderID"],
                    TableNumber = row["TableNumber"].ToString(),
                    WaiterName = row["WaiterName"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]).ToString("dd/MM/yyyy HH:mm:ss"),
                    ProductName = row["ProductName"].ToString(),
                    Quantity = (int)row["Quantity"],
                    TotalAmount = row["Total"].ToString() + " đ"
                };
                orderControl.BtnIn.Click += (s, e) => PrintInvoiceSetup(orderControl.OrderID);
                flpOrders.Controls.Add(orderControl);
            }
        }


        private void PrintInvoiceSetup(int orderId)
        {
            // Truy vấn thông tin chi tiết hóa đơn dựa trên orderId
            DataTable orderDetails = new DataTable();
            string query = "SELECT od.ProductName, od.Quantity, od.Price, od.Total, o.OrderID FROM OrderDetails od INNER JOIN Orders o ON od.OrderID = o.OrderID WHERE od.OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(orderDetails);
                    }
                }
            }

            // Store orderDetails for printing
            this.orderDetails = orderDetails.AsEnumerable().ToList();

            // Show print preview dialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = prnDoc;
            previewDialog.ShowDialog();
        }

        private void PrintInvoice(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int topMargin = e.MarginBounds.Top;
            int bottomMargin = e.MarginBounds.Bottom;
            int currentY = topMargin;

            // Set background color
            Color backgroundColor = Color.FromArgb(238, 236, 222);
            Brush backgroundBrush = new SolidBrush(backgroundColor);
            g.FillRectangle(backgroundBrush, e.MarginBounds);

            // Load custom font "Asap"
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("R:\\App_Details\\Visual_Studio\\WorkSpace_C_Sharp\\QLNhaHangALaViet\\asap\\Asap-Regular.ttf"); // Đường dẫn đến file font "Asap"
            Font asapFont = new Font(pfc.Families[0], 18, FontStyle.Regular);

            // Thêm logo vào hóa đơn
            Image logo = Image.FromFile("R:\\App_Details\\Visual_Studio\\WorkSpace_C_Sharp\\QLNhaHangALaViet\\Resources\\logo1.png"); // Đường dẫn đến file logo
            int logoWidth = 300;
            int logoHeight = 100;
            g.DrawImage(logo, leftMargin, currentY, logoWidth, logoHeight);
            currentY += logoHeight + 20; // Tăng khoảng cách

            // Set title
            string title = "HÓA ĐƠN BÁN HÀNG";
            Font titleFont = new Font(pfc.Families[0], 32, FontStyle.Bold);
            Brush titleBrush = new SolidBrush(Color.FromArgb(19, 93, 96));
            g.DrawString(title, titleFont, titleBrush, leftMargin, currentY);
            currentY += (int)titleFont.GetHeight(g) + 20; // Tăng khoảng cách

            // Vẽ đường gạch ngang phân cách
            Pen separatorPen = new Pen(Color.FromArgb(19, 93, 96), 2);
            g.DrawLine(separatorPen, leftMargin, currentY, rightMargin, currentY);
            currentY += 20; // Tăng khoảng cách

            // Set order details
            Font headerFont = new Font(pfc.Families[0], 18, FontStyle.Bold);
            Font bodyFont = new Font(pfc.Families[0], 18, FontStyle.Regular);
            Brush headerBrush = new SolidBrush(Color.FromArgb(19, 93, 96));
            Brush bodyBrush = Brushes.Black;

            g.DrawString($"Mã hóa đơn: {orderDetails.First()["OrderID"]}", headerFont, headerBrush, leftMargin, currentY);
            currentY += (int)headerFont.GetHeight(g) + 10; // Tăng khoảng cách
            g.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", headerFont, headerBrush, leftMargin, currentY);
            currentY += (int)headerFont.GetHeight(g) + 20; // Tăng khoảng cách

            // Vẽ đường gạch ngang phân cách
            g.DrawLine(separatorPen, leftMargin, currentY, rightMargin, currentY);
            currentY += 20; // Tăng khoảng cách

            // Set table headers
            g.DrawString($"{"Tên sản phẩm",-20} {"SL",-5} {"Giá",-10} {"Tổng",-10}", headerFont, headerBrush, leftMargin, currentY);
            currentY += (int)headerFont.GetHeight(g) + 20; // Tăng khoảng cách

            // Draw order items
            foreach (var row in orderDetails)
            {
                g.DrawString($"{row["ProductName"],-20} {row["Quantity"],-5} {row["Price"],-10} {row["Total"],-10}", bodyFont, bodyBrush, leftMargin, currentY);
                currentY += (int)bodyFont.GetHeight(g) + 10; // Tăng khoảng cách
            }

            // Vẽ đường gạch ngang phân cách
            g.DrawLine(separatorPen, leftMargin, currentY, rightMargin, currentY);
            currentY += 20; // Tăng khoảng cách

            // Draw total amount
            decimal totalAmount = orderDetails.Sum(r => r.Field<decimal>("Total"));
            g.DrawString($"Tổng cộng: {totalAmount,35} đ", headerFont, headerBrush, leftMargin, currentY);
            currentY += (int)headerFont.GetHeight(g) + 40; // Tăng khoảng cách

            // Định nghĩa thông tin liên hệ
            string contactInfo = "Chủ cửa hàng: Lê Văn Hoàng -- Co-founder: Hòa và Tài\n" +
                                 "Địa chỉ: Phú Hòa, Bình Dương\n" +
                                 "SĐT: 0111293449\n" +
                                 "Email: hoang@gmail.com\n" +
                                 "Website: AlaViet.com";

            Font contactFont = new Font(pfc.Families[0], 14, FontStyle.Regular);
            Brush contactBrush = new SolidBrush(Color.FromArgb(19, 93, 96));


            // Tính toán vị trí để vẽ thông tin liên hệ ở cuối trang
            SizeF contactSize = g.MeasureString(contactInfo, contactFont);
            int contactY = bottomMargin - (int)contactSize.Height - 60; // Cách lề dưới 60px
            g.DrawString(contactInfo, contactFont, contactBrush, leftMargin, contactY);

            // Vẽ lời cảm ơn
            string thankYouMessage = "Cảm ơn quý khách đã ủng hộ!";
            Font thankYouFont = new Font(pfc.Families[0], 22, FontStyle.Italic);
            Brush thankYouBrush = new SolidBrush(Color.DarkRed);
            int thankYouX = leftMargin + (int)((e.MarginBounds.Width - g.MeasureString(thankYouMessage, thankYouFont).Width) / 2); // Ép kiểu float về int
            int thankYouY = contactY - (int)thankYouFont.GetHeight(g) - 20; // Cách phía trên thông tin liên hệ 20px
            g.DrawString(thankYouMessage, thankYouFont, thankYouBrush, thankYouX, thankYouY);

            e.HasMorePages = false;
        }


        private DataTable GetOrders()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT o.OrderID, o.TableNumber, o.WaiterName, o.OrderDate, od.ProductName, od.Quantity, od.Price, od.Total FROM Orders o INNER JOIN OrderDetails od ON o.OrderID = od.OrderID GROUP BY o.OrderID, o.TableNumber, o.WaiterName, o.OrderDate, od.ProductName, od.Quantity, od.Price, od.Total";

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
