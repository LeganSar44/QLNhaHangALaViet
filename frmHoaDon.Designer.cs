namespace QLNhaHangALaViet
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.prnPriview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.uc_3dot1 = new QLNhaHangALaViet.uc_3dot();
            this.SuspendLayout();
            // 
            // flpOrders
            // 
            this.flpOrders.AutoScroll = true;
            this.flpOrders.Location = new System.Drawing.Point(-1, 60);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.flpOrders.Size = new System.Drawing.Size(1534, 803);
            this.flpOrders.TabIndex = 1;
            // 
            // prnPriview
            // 
            this.prnPriview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prnPriview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prnPriview.ClientSize = new System.Drawing.Size(400, 300);
            this.prnPriview.Enabled = true;
            this.prnPriview.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPriview.Icon")));
            this.prnPriview.Name = "prnPriview";
            this.prnPriview.Visible = false;
            // 
            // uc_3dot1
            // 
            this.uc_3dot1.Location = new System.Drawing.Point(-1, -2);
            this.uc_3dot1.Name = "uc_3dot1";
            this.uc_3dot1.Size = new System.Drawing.Size(108, 46);
            this.uc_3dot1.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1545, 906);
            this.Controls.Add(this.uc_3dot1);
            this.Controls.Add(this.flpOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private uc_3dot uc_3dot1;
        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.PrintPreviewDialog prnPriview;
        private System.Drawing.Printing.PrintDocument prnDocument;
        private System.Drawing.Printing.PrintDocument prnDoc;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}