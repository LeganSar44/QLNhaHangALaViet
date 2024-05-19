namespace QLNhaHangALaViet
{
    partial class frmDsNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsNhanVien));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridviewDSnv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnThemNhanVien = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.snackbardDsnv = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDSnv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(122, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(88, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 1);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(123, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản và vai trò nhân viên";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(134, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thêm mới tài khoản nhân viên để vận hành nhà hàng thuận tiện hơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridviewDSnv);
            this.panel2.Location = new System.Drawing.Point(112, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 332);
            this.panel2.TabIndex = 5;
            // 
            // datagridviewDSnv
            // 
            this.datagridviewDSnv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridviewDSnv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewDSnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewDSnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewDSnv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewDSnv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewDSnv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewDSnv.ColumnHeadersHeight = 40;
            this.datagridviewDSnv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            this.datagridviewDSnv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridviewDSnv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridviewDSnv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.datagridviewDSnv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridviewDSnv.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.datagridviewDSnv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.datagridviewDSnv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.datagridviewDSnv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridviewDSnv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridviewDSnv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.datagridviewDSnv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridviewDSnv.CurrentTheme.Name = null;
            this.datagridviewDSnv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.datagridviewDSnv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridviewDSnv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridviewDSnv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.datagridviewDSnv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewDSnv.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewDSnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewDSnv.EnableHeadersVisualStyles = false;
            this.datagridviewDSnv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.datagridviewDSnv.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.datagridviewDSnv.HeaderBackColor = System.Drawing.Color.Empty;
            this.datagridviewDSnv.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewDSnv.Location = new System.Drawing.Point(0, 0);
            this.datagridviewDSnv.Name = "datagridviewDSnv";
            this.datagridviewDSnv.RowHeadersVisible = false;
            this.datagridviewDSnv.RowHeadersWidth = 51;
            this.datagridviewDSnv.RowTemplate.Height = 40;
            this.datagridviewDSnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewDSnv.Size = new System.Drawing.Size(844, 332);
            this.datagridviewDSnv.TabIndex = 0;
            this.datagridviewDSnv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.datagridviewDSnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewDSnv_CellContentClick);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.AllowAnimations = true;
            this.btnThemNhanVien.AllowMouseEffects = true;
            this.btnThemNhanVien.AllowToggling = false;
            this.btnThemNhanVien.AnimationSpeed = 200;
            this.btnThemNhanVien.AutoGenerateColors = false;
            this.btnThemNhanVien.AutoRoundBorders = false;
            this.btnThemNhanVien.AutoSizeLeftIcon = true;
            this.btnThemNhanVien.AutoSizeRightIcon = true;
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanVien.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.BackgroundImage")));
            this.btnThemNhanVien.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemNhanVien.ButtonText = "Thêm nhân viên";
            this.btnThemNhanVien.ButtonTextMarginLeft = 0;
            this.btnThemNhanVien.ColorContrastOnClick = 45;
            this.btnThemNhanVien.ColorContrastOnHover = 45;
            this.btnThemNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnThemNhanVien.CustomizableEdges = borderEdges1;
            this.btnThemNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemNhanVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemNhanVien.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemNhanVien.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemNhanVien.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhanVien.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemNhanVien.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThemNhanVien.IconMarginLeft = 11;
            this.btnThemNhanVien.IconPadding = 10;
            this.btnThemNhanVien.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNhanVien.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemNhanVien.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThemNhanVien.IconSize = 25;
            this.btnThemNhanVien.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.IdleBorderRadius = 1;
            this.btnThemNhanVien.IdleBorderThickness = 1;
            this.btnThemNhanVien.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.IdleIconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_add_50;
            this.btnThemNhanVien.IdleIconRightImage = null;
            this.btnThemNhanVien.IndicateFocus = false;
            this.btnThemNhanVien.Location = new System.Drawing.Point(783, 158);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemNhanVien.OnDisabledState.BorderRadius = 1;
            this.btnThemNhanVien.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemNhanVien.OnDisabledState.BorderThickness = 1;
            this.btnThemNhanVien.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemNhanVien.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemNhanVien.OnDisabledState.IconLeftImage = null;
            this.btnThemNhanVien.OnDisabledState.IconRightImage = null;
            this.btnThemNhanVien.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemNhanVien.onHoverState.BorderRadius = 1;
            this.btnThemNhanVien.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemNhanVien.onHoverState.BorderThickness = 1;
            this.btnThemNhanVien.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemNhanVien.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.onHoverState.IconLeftImage = null;
            this.btnThemNhanVien.onHoverState.IconRightImage = null;
            this.btnThemNhanVien.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.OnIdleState.BorderRadius = 1;
            this.btnThemNhanVien.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemNhanVien.OnIdleState.BorderThickness = 1;
            this.btnThemNhanVien.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.OnIdleState.IconLeftImage = global::QLNhaHangALaViet.Properties.Resources.icons8_add_50;
            this.btnThemNhanVien.OnIdleState.IconRightImage = null;
            this.btnThemNhanVien.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemNhanVien.OnPressedState.BorderRadius = 1;
            this.btnThemNhanVien.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemNhanVien.OnPressedState.BorderThickness = 1;
            this.btnThemNhanVien.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemNhanVien.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.OnPressedState.IconLeftImage = null;
            this.btnThemNhanVien.OnPressedState.IconRightImage = null;
            this.btnThemNhanVien.Size = new System.Drawing.Size(158, 39);
            this.btnThemNhanVien.TabIndex = 2;
            this.btnThemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemNhanVien.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemNhanVien.TextMarginLeft = 0;
            this.btnThemNhanVien.TextPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThemNhanVien.UseDefaultRadiusAndThickness = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnXoa.CustomizableEdges = borderEdges2;
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
            this.btnXoa.IdleBorderRadius = 1;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(96)))), ((int)(((byte)(67)))));
            this.btnXoa.IdleIconLeftImage = null;
            this.btnXoa.IdleIconRightImage = null;
            this.btnXoa.IndicateFocus = false;
            this.btnXoa.Location = new System.Drawing.Point(99, 752);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.OnDisabledState.BorderRadius = 1;
            this.btnXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnDisabledState.BorderThickness = 1;
            this.btnXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.OnDisabledState.IconLeftImage = null;
            this.btnXoa.OnDisabledState.IconRightImage = null;
            this.btnXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.BorderRadius = 1;
            this.btnXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.onHoverState.BorderThickness = 1;
            this.btnXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.onHoverState.IconLeftImage = null;
            this.btnXoa.onHoverState.IconRightImage = null;
            this.btnXoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.BorderRadius = 1;
            this.btnXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnIdleState.BorderThickness = 1;
            this.btnXoa.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(96)))), ((int)(((byte)(67)))));
            this.btnXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnIdleState.IconLeftImage = null;
            this.btnXoa.OnIdleState.IconRightImage = null;
            this.btnXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.BorderRadius = 1;
            this.btnXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnPressedState.BorderThickness = 1;
            this.btnXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnPressedState.IconLeftImage = null;
            this.btnXoa.OnPressedState.IconRightImage = null;
            this.btnXoa.Size = new System.Drawing.Size(82, 39);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.TextMarginLeft = 0;
            this.btnXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoa.UseDefaultRadiusAndThickness = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // snackbardDsnv
            // 
            this.snackbardDsnv.AllowDragging = false;
            this.snackbardDsnv.AllowMultipleViews = true;
            this.snackbardDsnv.ClickToClose = true;
            this.snackbardDsnv.DoubleClickToClose = true;
            this.snackbardDsnv.DurationAfterIdle = 3000;
            this.snackbardDsnv.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.ErrorOptions.ActionBorderRadius = 1;
            this.snackbardDsnv.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbardDsnv.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snackbardDsnv.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snackbardDsnv.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snackbardDsnv.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbardDsnv.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snackbardDsnv.ErrorOptions.IconLeftMargin = 12;
            this.snackbardDsnv.FadeCloseIcon = false;
            this.snackbardDsnv.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snackbardDsnv.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.InformationOptions.ActionBorderRadius = 1;
            this.snackbardDsnv.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbardDsnv.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snackbardDsnv.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snackbardDsnv.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbardDsnv.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snackbardDsnv.InformationOptions.IconLeftMargin = 12;
            this.snackbardDsnv.Margin = 10;
            this.snackbardDsnv.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackbardDsnv.MaximumViews = 7;
            this.snackbardDsnv.MessageRightMargin = 15;
            this.snackbardDsnv.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackbardDsnv.ShowBorders = false;
            this.snackbardDsnv.ShowCloseIcon = false;
            this.snackbardDsnv.ShowIcon = true;
            this.snackbardDsnv.ShowShadows = true;
            this.snackbardDsnv.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.SuccessOptions.ActionBorderRadius = 1;
            this.snackbardDsnv.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbardDsnv.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snackbardDsnv.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snackbardDsnv.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snackbardDsnv.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbardDsnv.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snackbardDsnv.SuccessOptions.IconLeftMargin = 12;
            this.snackbardDsnv.ViewsMargin = 7;
            this.snackbardDsnv.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbardDsnv.WarningOptions.ActionBorderRadius = 1;
            this.snackbardDsnv.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbardDsnv.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snackbardDsnv.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snackbardDsnv.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snackbardDsnv.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbardDsnv.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbardDsnv.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snackbardDsnv.WarningOptions.IconLeftMargin = 12;
            this.snackbardDsnv.ZoomCloseIcon = true;
            // 
            // frmDsNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 820);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDsNhanVien";
            this.Text = "DanhSachNhanVien";
            this.Load += new System.EventHandler(this.frmDsNhanVien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDSnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridviewDSnv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoa;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbardDsnv;
    }
}