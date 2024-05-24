namespace QLNhaHangALaViet
{
    partial class frmDsmathang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsmathang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.DataGridViewDanhSachMatHang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemMHang_DSmathang = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnImport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.snkDsmh = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel2.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDanhSachMatHang)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách mặt hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panel1.Location = new System.Drawing.Point(80, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.bunifuShadowPanel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 947);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 15;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.DataGridViewDanhSachMatHang);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuPanel1);
            this.bunifuShadowPanel1.Controls.Add(this.label5);
            this.bunifuShadowPanel1.Controls.Add(this.panel4);
            this.bunifuShadowPanel1.Controls.Add(this.panel3);
            this.bunifuShadowPanel1.Controls.Add(this.label4);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(80, 251);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1212, 630);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // DataGridViewDanhSachMatHang
            // 
            this.DataGridViewDanhSachMatHang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewDanhSachMatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDanhSachMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDanhSachMatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDanhSachMatHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDanhSachMatHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDanhSachMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDanhSachMatHang.ColumnHeadersHeight = 40;
            this.DataGridViewDanhSachMatHang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewDanhSachMatHang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewDanhSachMatHang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewDanhSachMatHang.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.DataGridViewDanhSachMatHang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.DataGridViewDanhSachMatHang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewDanhSachMatHang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewDanhSachMatHang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewDanhSachMatHang.CurrentTheme.Name = null;
            this.DataGridViewDanhSachMatHang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewDanhSachMatHang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewDanhSachMatHang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DataGridViewDanhSachMatHang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDanhSachMatHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDanhSachMatHang.EnableHeadersVisualStyles = false;
            this.DataGridViewDanhSachMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DataGridViewDanhSachMatHang.HeaderBackColor = System.Drawing.Color.Crimson;
            this.DataGridViewDanhSachMatHang.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewDanhSachMatHang.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewDanhSachMatHang.Location = new System.Drawing.Point(74, 200);
            this.DataGridViewDanhSachMatHang.Name = "DataGridViewDanhSachMatHang";
            this.DataGridViewDanhSachMatHang.RowHeadersVisible = false;
            this.DataGridViewDanhSachMatHang.RowHeadersWidth = 51;
            this.DataGridViewDanhSachMatHang.RowTemplate.Height = 40;
            this.DataGridViewDanhSachMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDanhSachMatHang.Size = new System.Drawing.Size(1042, 403);
            this.DataGridViewDanhSachMatHang.TabIndex = 9;
            this.DataGridViewDanhSachMatHang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(707, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tùy chỉnh hiển thị";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(4, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.panel3.Location = new System.Drawing.Point(24, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 3);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(20, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tất cả mặt hàng";
            // 
            // btnThemMHang_DSmathang
            // 
            this.btnThemMHang_DSmathang.AllowAnimations = true;
            this.btnThemMHang_DSmathang.AllowMouseEffects = true;
            this.btnThemMHang_DSmathang.AllowToggling = false;
            this.btnThemMHang_DSmathang.AnimationSpeed = 200;
            this.btnThemMHang_DSmathang.AutoGenerateColors = false;
            this.btnThemMHang_DSmathang.AutoRoundBorders = false;
            this.btnThemMHang_DSmathang.AutoSizeLeftIcon = true;
            this.btnThemMHang_DSmathang.AutoSizeRightIcon = true;
            this.btnThemMHang_DSmathang.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMHang_DSmathang.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.btnThemMHang_DSmathang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMHang_DSmathang.BackgroundImage")));
            this.btnThemMHang_DSmathang.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMHang_DSmathang.ButtonText = "Thêm mặt hàng";
            this.btnThemMHang_DSmathang.ButtonTextMarginLeft = 0;
            this.btnThemMHang_DSmathang.ColorContrastOnClick = 45;
            this.btnThemMHang_DSmathang.ColorContrastOnHover = 45;
            this.btnThemMHang_DSmathang.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnThemMHang_DSmathang.CustomizableEdges = borderEdges4;
            this.btnThemMHang_DSmathang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemMHang_DSmathang.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemMHang_DSmathang.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemMHang_DSmathang.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemMHang_DSmathang.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThemMHang_DSmathang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemMHang_DSmathang.ForeColor = System.Drawing.Color.White;
            this.btnThemMHang_DSmathang.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMHang_DSmathang.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemMHang_DSmathang.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThemMHang_DSmathang.IconMarginLeft = 11;
            this.btnThemMHang_DSmathang.IconPadding = 10;
            this.btnThemMHang_DSmathang.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMHang_DSmathang.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemMHang_DSmathang.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThemMHang_DSmathang.IconSize = 25;
            this.btnThemMHang_DSmathang.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemMHang_DSmathang.IdleBorderRadius = 15;
            this.btnThemMHang_DSmathang.IdleBorderThickness = 1;
            this.btnThemMHang_DSmathang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.btnThemMHang_DSmathang.IdleIconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_plus_30;
            this.btnThemMHang_DSmathang.IdleIconRightImage = null;
            this.btnThemMHang_DSmathang.IndicateFocus = false;
            this.btnThemMHang_DSmathang.Location = new System.Drawing.Point(730, 147);
            this.btnThemMHang_DSmathang.Name = "btnThemMHang_DSmathang";
            this.btnThemMHang_DSmathang.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemMHang_DSmathang.OnDisabledState.BorderRadius = 15;
            this.btnThemMHang_DSmathang.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMHang_DSmathang.OnDisabledState.BorderThickness = 1;
            this.btnThemMHang_DSmathang.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemMHang_DSmathang.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemMHang_DSmathang.OnDisabledState.IconLeftImage = null;
            this.btnThemMHang_DSmathang.OnDisabledState.IconRightImage = null;
            this.btnThemMHang_DSmathang.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemMHang_DSmathang.onHoverState.BorderRadius = 15;
            this.btnThemMHang_DSmathang.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMHang_DSmathang.onHoverState.BorderThickness = 1;
            this.btnThemMHang_DSmathang.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemMHang_DSmathang.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemMHang_DSmathang.onHoverState.IconLeftImage = null;
            this.btnThemMHang_DSmathang.onHoverState.IconRightImage = null;
            this.btnThemMHang_DSmathang.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemMHang_DSmathang.OnIdleState.BorderRadius = 15;
            this.btnThemMHang_DSmathang.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMHang_DSmathang.OnIdleState.BorderThickness = 1;
            this.btnThemMHang_DSmathang.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(254)))));
            this.btnThemMHang_DSmathang.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThemMHang_DSmathang.OnIdleState.IconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_plus_30;
            this.btnThemMHang_DSmathang.OnIdleState.IconRightImage = null;
            this.btnThemMHang_DSmathang.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemMHang_DSmathang.OnPressedState.BorderRadius = 15;
            this.btnThemMHang_DSmathang.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMHang_DSmathang.OnPressedState.BorderThickness = 1;
            this.btnThemMHang_DSmathang.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemMHang_DSmathang.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThemMHang_DSmathang.OnPressedState.IconLeftImage = null;
            this.btnThemMHang_DSmathang.OnPressedState.IconRightImage = null;
            this.btnThemMHang_DSmathang.Size = new System.Drawing.Size(150, 39);
            this.btnThemMHang_DSmathang.TabIndex = 3;
            this.btnThemMHang_DSmathang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMHang_DSmathang.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemMHang_DSmathang.TextMarginLeft = 0;
            this.btnThemMHang_DSmathang.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnThemMHang_DSmathang.UseDefaultRadiusAndThickness = true;
            this.btnThemMHang_DSmathang.Click += new System.EventHandler(this.btnThemMHang_DSmathang_Click);
            // 
            // btnExport
            // 
            this.btnExport.AllowAnimations = true;
            this.btnExport.AllowMouseEffects = true;
            this.btnExport.AllowToggling = false;
            this.btnExport.AnimationSpeed = 200;
            this.btnExport.AutoGenerateColors = false;
            this.btnExport.AutoRoundBorders = false;
            this.btnExport.AutoSizeLeftIcon = true;
            this.btnExport.AutoSizeRightIcon = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackColor1 = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.ButtonText = "Xuất danh sách";
            this.btnExport.ButtonTextMarginLeft = 0;
            this.btnExport.ColorContrastOnClick = 45;
            this.btnExport.ColorContrastOnHover = 45;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExport.CustomizableEdges = borderEdges2;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExport.IconMarginLeft = 11;
            this.btnExport.IconPadding = 8;
            this.btnExport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExport.IconSize = 25;
            this.btnExport.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.IdleBorderRadius = 15;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExport.IdleIconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_export_64;
            this.btnExport.IdleIconRightImage = null;
            this.btnExport.IndicateFocus = false;
            this.btnExport.Location = new System.Drawing.Point(391, 147);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.OnDisabledState.BorderRadius = 15;
            this.btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnDisabledState.BorderThickness = 1;
            this.btnExport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExport.OnDisabledState.IconLeftImage = null;
            this.btnExport.OnDisabledState.IconRightImage = null;
            this.btnExport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExport.onHoverState.BorderRadius = 15;
            this.btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.onHoverState.BorderThickness = 1;
            this.btnExport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExport.onHoverState.IconLeftImage = null;
            this.btnExport.onHoverState.IconRightImage = null;
            this.btnExport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.OnIdleState.BorderRadius = 15;
            this.btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnIdleState.BorderThickness = 1;
            this.btnExport.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnExport.OnIdleState.IconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_export_64;
            this.btnExport.OnIdleState.IconRightImage = null;
            this.btnExport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.BorderRadius = 15;
            this.btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnPressedState.BorderThickness = 1;
            this.btnExport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnPressedState.IconLeftImage = null;
            this.btnExport.OnPressedState.IconRightImage = null;
            this.btnExport.Size = new System.Drawing.Size(213, 55);
            this.btnExport.TabIndex = 2;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.TextMarginLeft = 0;
            this.btnExport.TextPadding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnExport.UseDefaultRadiusAndThickness = true;
            // 
            // btnImport
            // 
            this.btnImport.AllowAnimations = true;
            this.btnImport.AllowMouseEffects = true;
            this.btnImport.AllowToggling = false;
            this.btnImport.AnimationSpeed = 200;
            this.btnImport.AutoGenerateColors = false;
            this.btnImport.AutoRoundBorders = false;
            this.btnImport.AutoSizeLeftIcon = true;
            this.btnImport.AutoSizeRightIcon = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackColor1 = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.ButtonText = "Nhập danh sách";
            this.btnImport.ButtonTextMarginLeft = 0;
            this.btnImport.ColorContrastOnClick = 45;
            this.btnImport.ColorContrastOnHover = 45;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnImport.CustomizableEdges = borderEdges3;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnImport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnImport.IconMarginLeft = 11;
            this.btnImport.IconPadding = 8;
            this.btnImport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnImport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnImport.IconSize = 25;
            this.btnImport.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnImport.IdleBorderRadius = 15;
            this.btnImport.IdleBorderThickness = 1;
            this.btnImport.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnImport.IdleIconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_import_64;
            this.btnImport.IdleIconRightImage = null;
            this.btnImport.IndicateFocus = false;
            this.btnImport.Location = new System.Drawing.Point(154, 147);
            this.btnImport.Name = "btnImport";
            this.btnImport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImport.OnDisabledState.BorderRadius = 15;
            this.btnImport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnDisabledState.BorderThickness = 1;
            this.btnImport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImport.OnDisabledState.IconLeftImage = null;
            this.btnImport.OnDisabledState.IconRightImage = null;
            this.btnImport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImport.onHoverState.BorderRadius = 15;
            this.btnImport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.onHoverState.BorderThickness = 1;
            this.btnImport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnImport.onHoverState.IconLeftImage = null;
            this.btnImport.onHoverState.IconRightImage = null;
            this.btnImport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnImport.OnIdleState.BorderRadius = 15;
            this.btnImport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnIdleState.BorderThickness = 1;
            this.btnImport.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnImport.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnImport.OnIdleState.IconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_import_64;
            this.btnImport.OnIdleState.IconRightImage = null;
            this.btnImport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImport.OnPressedState.BorderRadius = 15;
            this.btnImport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnPressedState.BorderThickness = 1;
            this.btnImport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnImport.OnPressedState.IconLeftImage = null;
            this.btnImport.OnPressedState.IconRightImage = null;
            this.btnImport.Size = new System.Drawing.Size(213, 55);
            this.btnImport.TabIndex = 1;
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImport.TextMarginLeft = 0;
            this.btnImport.TextPadding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnImport.UseDefaultRadiusAndThickness = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.txtTimKiem);
            this.bunifuPanel1.Location = new System.Drawing.Point(141, 112);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(628, 52);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNhaHangALaViet.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AcceptsReturn = false;
            this.txtTimKiem.AcceptsTab = false;
            this.txtTimKiem.AnimationSpeed = 200;
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.BackgroundImage")));
            this.txtTimKiem.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimKiem.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimKiem.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimKiem.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderRadius = 1;
            this.txtTimKiem.BorderThickness = 1;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.FillColor = System.Drawing.Color.White;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.IconLeft = null;
            this.txtTimKiem.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.IconPadding = 10;
            this.txtTimKiem.IconRight = null;
            this.txtTimKiem.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(69, 8);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimKiem.Modified = false;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnIdleState = stateProperties4;
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm mặt hàng";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(437, 41);
            this.txtTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TextMarginBottom = 0;
            this.txtTimKiem.TextMarginLeft = 3;
            this.txtTimKiem.TextMarginTop = 0;
            this.txtTimKiem.TextPlaceholder = "Tìm kiếm mặt hàng";
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.WordWrap = true;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.AllowAnimations = true;
            this.btnXoa.AllowMouseEffects = true;
            this.btnXoa.AllowToggling = false;
            this.btnXoa.AnimationSpeed = 200;
            this.btnXoa.AutoGenerateColors = false;
            this.btnXoa.AutoRoundBorders = false;
            this.btnXoa.AutoSizeLeftIcon = true;
            this.btnXoa.AutoSizeRightIcon = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(96)))), ((int)(((byte)(67)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.ButtonTextMarginLeft = 0;
            this.btnXoa.ColorContrastOnClick = 45;
            this.btnXoa.ColorContrastOnHover = 45;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXoa.CustomizableEdges = borderEdges1;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXoa.IconMarginLeft = 11;
            this.btnXoa.IconPadding = 10;
            this.btnXoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoa.IconSize = 25;
            this.btnXoa.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IdleBorderRadius = 15;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(96)))), ((int)(((byte)(67)))));
            this.btnXoa.IdleIconLeftImage = null;
            this.btnXoa.IdleIconRightImage = null;
            this.btnXoa.IndicateFocus = false;
            this.btnXoa.Location = new System.Drawing.Point(162, 887);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.OnDisabledState.BorderRadius = 15;
            this.btnXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnDisabledState.BorderThickness = 1;
            this.btnXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.OnDisabledState.IconLeftImage = null;
            this.btnXoa.OnDisabledState.IconRightImage = null;
            this.btnXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.BorderRadius = 15;
            this.btnXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.onHoverState.BorderThickness = 1;
            this.btnXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.onHoverState.IconLeftImage = null;
            this.btnXoa.onHoverState.IconRightImage = null;
            this.btnXoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.BorderRadius = 15;
            this.btnXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnIdleState.BorderThickness = 1;
            this.btnXoa.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(96)))), ((int)(((byte)(67)))));
            this.btnXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnIdleState.IconLeftImage = null;
            this.btnXoa.OnIdleState.IconRightImage = null;
            this.btnXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.BorderRadius = 15;
            this.btnXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnPressedState.BorderThickness = 1;
            this.btnXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnPressedState.IconLeftImage = null;
            this.btnXoa.OnPressedState.IconRightImage = null;
            this.btnXoa.Size = new System.Drawing.Size(82, 39);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.TextMarginLeft = 0;
            this.btnXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoa.UseDefaultRadiusAndThickness = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // snkDsmh
            // 
            this.snkDsmh.AllowDragging = false;
            this.snkDsmh.AllowMultipleViews = true;
            this.snkDsmh.ClickToClose = true;
            this.snkDsmh.DoubleClickToClose = true;
            this.snkDsmh.DurationAfterIdle = 3000;
            this.snkDsmh.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.ErrorOptions.ActionBorderRadius = 1;
            this.snkDsmh.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snkDsmh.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snkDsmh.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snkDsmh.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snkDsmh.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snkDsmh.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snkDsmh.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snkDsmh.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snkDsmh.ErrorOptions.IconLeftMargin = 12;
            this.snkDsmh.FadeCloseIcon = false;
            this.snkDsmh.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snkDsmh.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.InformationOptions.ActionBorderRadius = 1;
            this.snkDsmh.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snkDsmh.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snkDsmh.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snkDsmh.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snkDsmh.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snkDsmh.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snkDsmh.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snkDsmh.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snkDsmh.InformationOptions.IconLeftMargin = 12;
            this.snkDsmh.Margin = 10;
            this.snkDsmh.MaximumSize = new System.Drawing.Size(0, 0);
            this.snkDsmh.MaximumViews = 7;
            this.snkDsmh.MessageRightMargin = 15;
            this.snkDsmh.MinimumSize = new System.Drawing.Size(0, 0);
            this.snkDsmh.ShowBorders = false;
            this.snkDsmh.ShowCloseIcon = false;
            this.snkDsmh.ShowIcon = true;
            this.snkDsmh.ShowShadows = true;
            this.snkDsmh.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.SuccessOptions.ActionBorderRadius = 1;
            this.snkDsmh.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snkDsmh.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snkDsmh.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snkDsmh.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snkDsmh.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snkDsmh.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snkDsmh.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snkDsmh.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snkDsmh.SuccessOptions.IconLeftMargin = 12;
            this.snkDsmh.ViewsMargin = 7;
            this.snkDsmh.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snkDsmh.WarningOptions.ActionBorderRadius = 1;
            this.snkDsmh.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snkDsmh.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snkDsmh.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snkDsmh.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snkDsmh.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snkDsmh.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snkDsmh.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snkDsmh.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snkDsmh.WarningOptions.IconLeftMargin = 12;
            this.snkDsmh.ZoomCloseIcon = true;
            // 
            // frmDsmathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 984);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemMHang_DSmathang);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDsmathang";
            this.Text = "frmDsmathang";
            this.Load += new System.EventHandler(this.frmDsmathang_Load_1);
            this.panel2.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDanhSachMatHang)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemMHang_DSmathang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewDanhSachMatHang;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoa;
        private Bunifu.UI.WinForms.BunifuSnackbar snkDsmh;
    }
}