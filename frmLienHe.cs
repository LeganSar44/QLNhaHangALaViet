using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;

using GMap.NET.WindowsForms.Markers;

namespace QLNhaHangALaViet
{
    public partial class frmLienHe : Form
    {
        public frmLienHe()
        {
            InitializeComponent();
        }

        private void frmLienHe_Load(object sender, EventArgs e)
        {

            InitializeMap();

        }

        private void btnPhoneCall_Click(object sender, EventArgs e)
        {

        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            string url = "https://zalo.me/0908306406";
            OpenUrl(url);
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/messages/t/107261878751456";
            OpenUrl(url);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi mở trang web: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            double latitude;
            double longitude;

            if (double.TryParse(txtViDo.Text, out latitude) && double.TryParse(txtKinhDo.Text, out longitude))
            {
                map.Position = new PointLatLng(latitude, longitude);
                map.Zoom = 10; // Thiết lập mức zoom
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tọa độ hợp lệ.");
            }
        }

      

        private void InitializeMap()
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(10.972134929923865, 106.66308272883815); // Tọa độ nhà hàng của bạn
            map.MinZoom = 5;
            map.MaxZoom = 20;
            map.Zoom = 15;
            map.Dock = DockStyle.Fill;
            map.Manager.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache"; // Thư mục cache

            // Cấu hình để bản đồ có thể kéo và zoom bằng chuột
            map.MouseWheelZoomEnabled = true;
            map.DragButton = MouseButtons.Left;

            // Đặt một marker tại vị trí nhà hàng
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(10.972028115015396, 106.66307727307368), GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            map.MouseWheel += new MouseEventHandler(Map_MouseWheel);

            map.MouseClick += new MouseEventHandler(Map_MouseClick);
        }
        private void Map_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
                string url = $"https://www.google.com/maps/place/Nh%C3%A0+H%C3%A0ng+A+La+Vi%E1%BB%87t/@10.9720127,106.6630682,15z/data=!4m6!3m5!1s0x3174d1fc5d59a723:0x45d4d86e02c8103f!8m2!3d10.9720127!4d106.6630682!16s%2Fg%2F11t7r6ktnv?entry=ttu";
                OpenUrl(url);
            }
        }

        private void map_OnMapDrag_1()
        {
            map.Refresh();
        }
    }
}
