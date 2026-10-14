namespace QuanLySieuThi
{
    partial class FrmMain
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
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.pnlSubHeader = new System.Windows.Forms.Panel();
            this.lblBranchInfo = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlKpiContainer = new System.Windows.Forms.Panel();
            this.pnlKpi1 = new System.Windows.Forms.Panel();
            this.lblKpi1Sub = new System.Windows.Forms.Label();
            this.lblKpi1Val = new System.Windows.Forms.Label();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.pnlKpi2 = new System.Windows.Forms.Panel();
            this.lblKpi2Sub = new System.Windows.Forms.Label();
            this.lblKpi2Val = new System.Windows.Forms.Label();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.pnlKpi3 = new System.Windows.Forms.Panel();
            this.lblKpi3Sub = new System.Windows.Forms.Label();
            this.lblKpi3Val = new System.Windows.Forms.Label();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.pnlKpi4 = new System.Windows.Forms.Panel();
            this.lblKpi4Sub = new System.Windows.Forms.Label();
            this.lblKpi4Val = new System.Windows.Forms.Label();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.flpModules = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlSubHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlKpiContainer.SuspendLayout();
            this.pnlKpi1.SuspendLayout();
            this.pnlKpi2.SuspendLayout();
            this.pnlKpi3.SuspendLayout();
            this.pnlKpi4.SuspendLayout();
            this.flpModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1260, 84);
            this.pnlTopNav.TabIndex = 0;
            // 
            // pnlSubHeader
            // 
            this.pnlSubHeader.BackColor = System.Drawing.Color.White;
            this.pnlSubHeader.Controls.Add(this.lblBranchInfo);
            this.pnlSubHeader.Controls.Add(this.lblTieuDe);
            this.pnlSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubHeader.Location = new System.Drawing.Point(0, 84);
            this.pnlSubHeader.Name = "pnlSubHeader";
            this.pnlSubHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlSubHeader.Size = new System.Drawing.Size(1260, 52);
            this.pnlSubHeader.TabIndex = 1;
            // 
            // lblBranchInfo
            // 
            this.lblBranchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranchInfo.AutoSize = true;
            this.lblBranchInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBranchInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBranchInfo.Location = new System.Drawing.Point(920, 16);
            this.lblBranchInfo.Name = "lblBranchInfo";
            this.lblBranchInfo.Size = new System.Drawing.Size(320, 20);
            this.lblBranchInfo.TabIndex = 1;
            this.lblBranchInfo.Text = "🏪 Chi nhánh: Trung Tâm  |  👤 Người dùng: admin";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTieuDe.Location = new System.Drawing.Point(14, 8);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(262, 37);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SIÊU THỊ";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlBody.Controls.Add(this.flpModules);
            this.pnlBody.Controls.Add(this.lblSectionTitle);
            this.pnlBody.Controls.Add(this.pnlKpiContainer);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 136);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBody.Size = new System.Drawing.Size(1260, 614);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlKpiContainer
            // 
            this.pnlKpiContainer.Controls.Add(this.pnlKpi4);
            this.pnlKpiContainer.Controls.Add(this.pnlKpi3);
            this.pnlKpiContainer.Controls.Add(this.pnlKpi2);
            this.pnlKpiContainer.Controls.Add(this.pnlKpi1);
            this.pnlKpiContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlKpiContainer.Name = "pnlKpiContainer";
            this.pnlKpiContainer.Size = new System.Drawing.Size(1220, 105);
            this.pnlKpiContainer.TabIndex = 0;
            // 
            // pnlKpi1
            // 
            this.pnlKpi1.BackColor = System.Drawing.Color.White;
            this.pnlKpi1.Controls.Add(this.lblKpi1Sub);
            this.pnlKpi1.Controls.Add(this.lblKpi1Val);
            this.pnlKpi1.Controls.Add(this.lblKpi1Title);
            this.pnlKpi1.Location = new System.Drawing.Point(0, 0);
            this.pnlKpi1.Name = "pnlKpi1";
            this.pnlKpi1.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlKpi1.Size = new System.Drawing.Size(285, 95);
            this.pnlKpi1.TabIndex = 0;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi1Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(176, 20);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "💰 DOANH THU HÔM NAY";
            // 
            // lblKpi1Val
            // 
            this.lblKpi1Val.AutoSize = true;
            this.lblKpi1Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.lblKpi1Val.Location = new System.Drawing.Point(10, 32);
            this.lblKpi1Val.Name = "lblKpi1Val";
            this.lblKpi1Val.Size = new System.Drawing.Size(61, 37);
            this.lblKpi1Val.TabIndex = 1;
            this.lblKpi1Val.Text = "0 đ";
            // 
            // lblKpi1Sub
            // 
            this.lblKpi1Sub.AutoSize = true;
            this.lblKpi1Sub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKpi1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.lblKpi1Sub.Location = new System.Drawing.Point(13, 69);
            this.lblKpi1Sub.Name = "lblKpi1Sub";
            this.lblKpi1Sub.Size = new System.Drawing.Size(147, 19);
            this.lblKpi1Sub.TabIndex = 2;
            this.lblKpi1Sub.Text = "✔ Hệ thống vận hành tốt";
            // 
            // pnlKpi2
            // 
            this.pnlKpi2.BackColor = System.Drawing.Color.White;
            this.pnlKpi2.Controls.Add(this.lblKpi2Sub);
            this.pnlKpi2.Controls.Add(this.lblKpi2Val);
            this.pnlKpi2.Controls.Add(this.lblKpi2Title);
            this.pnlKpi2.Location = new System.Drawing.Point(300, 0);
            this.pnlKpi2.Name = "pnlKpi2";
            this.pnlKpi2.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlKpi2.Size = new System.Drawing.Size(285, 95);
            this.pnlKpi2.TabIndex = 1;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi2Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(171, 20);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "📦 SẢN PHẨM KINH DOANH";
            // 
            // lblKpi2Val
            // 
            this.lblKpi2Val.AutoSize = true;
            this.lblKpi2Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.lblKpi2Val.Location = new System.Drawing.Point(10, 32);
            this.lblKpi2Val.Name = "lblKpi2Val";
            this.lblKpi2Val.Size = new System.Drawing.Size(154, 37);
            this.lblKpi2Val.TabIndex = 1;
            this.lblKpi2Val.Text = "Đang quản";
            // 
            // lblKpi2Sub
            // 
            this.lblKpi2Sub.AutoSize = true;
            this.lblKpi2Sub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKpi2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi2Sub.Location = new System.Drawing.Point(13, 69);
            this.lblKpi2Sub.Name = "lblKpi2Sub";
            this.lblKpi2Sub.Size = new System.Drawing.Size(127, 19);
            this.lblKpi2Sub.TabIndex = 2;
            this.lblKpi2Sub.Text = "Kho hàng siêu thị đầy đủ";
            // 
            // pnlKpi3
            // 
            this.pnlKpi3.BackColor = System.Drawing.Color.White;
            this.pnlKpi3.Controls.Add(this.lblKpi3Sub);
            this.pnlKpi3.Controls.Add(this.lblKpi3Val);
            this.pnlKpi3.Controls.Add(this.lblKpi3Title);
            this.pnlKpi3.Location = new System.Drawing.Point(600, 0);
            this.pnlKpi3.Name = "pnlKpi3";
            this.pnlKpi3.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlKpi3.Size = new System.Drawing.Size(285, 95);
            this.pnlKpi3.TabIndex = 2;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi3Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(133, 20);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "👥 NHÀ CUNG CẤP";
            // 
            // lblKpi3Val
            // 
            this.lblKpi3Val.AutoSize = true;
            this.lblKpi3Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblKpi3Val.Location = new System.Drawing.Point(10, 32);
            this.lblKpi3Val.Name = "lblKpi3Val";
            this.lblKpi3Val.Size = new System.Drawing.Size(107, 37);
            this.lblKpi3Val.TabIndex = 1;
            this.lblKpi3Val.Text = "Đối tác";
            // 
            // lblKpi3Sub
            // 
            this.lblKpi3Sub.AutoSize = true;
            this.lblKpi3Sub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKpi3Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi3Sub.Location = new System.Drawing.Point(13, 69);
            this.lblKpi3Sub.Name = "lblKpi3Sub";
            this.lblKpi3Sub.Size = new System.Drawing.Size(133, 19);
            this.lblKpi3Sub.TabIndex = 2;
            this.lblKpi3Sub.Text = "Liên kết nhà phân phối";
            // 
            // pnlKpi4
            // 
            this.pnlKpi4.BackColor = System.Drawing.Color.White;
            this.pnlKpi4.Controls.Add(this.lblKpi4Sub);
            this.pnlKpi4.Controls.Add(this.lblKpi4Val);
            this.pnlKpi4.Controls.Add(this.lblKpi4Title);
            this.pnlKpi4.Location = new System.Drawing.Point(900, 0);
            this.pnlKpi4.Name = "pnlKpi4";
            this.pnlKpi4.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlKpi4.Size = new System.Drawing.Size(285, 95);
            this.pnlKpi4.TabIndex = 3;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.AutoSize = true;
            this.lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi4Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(126, 20);
            this.lblKpi4Title.TabIndex = 0;
            this.lblKpi4Title.Text = "🛒 BÁN HÀNG POS";
            // 
            // lblKpi4Val
            // 
            this.lblKpi4Val.AutoSize = true;
            this.lblKpi4Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.lblKpi4Val.Location = new System.Drawing.Point(10, 32);
            this.lblKpi4Val.Name = "lblKpi4Val";
            this.lblKpi4Val.Size = new System.Drawing.Size(129, 37);
            this.lblKpi4Val.TabIndex = 1;
            this.lblKpi4Val.Text = "Sẵn sàng";
            // 
            // lblKpi4Sub
            // 
            this.lblKpi4Sub.AutoSize = true;
            this.lblKpi4Sub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKpi4Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpi4Sub.Location = new System.Drawing.Point(13, 69);
            this.lblKpi4Sub.Name = "lblKpi4Sub";
            this.lblKpi4Sub.Size = new System.Drawing.Size(121, 19);
            this.lblKpi4Sub.TabIndex = 2;
            this.lblKpi4Sub.Text = "Màn hình thu ngân";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(20, 140);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(262, 25);
            this.lblSectionTitle.TabIndex = 1;
            this.lblSectionTitle.Text = "CHỨC NĂNG QUẢN LÝ CHÍNH";
            // 
            // flpModules
            // 
            this.flpModules.Controls.Add(this.btnSanPham);
            this.flpModules.Controls.Add(this.btnLoaiSanPham);
            this.flpModules.Controls.Add(this.btnNhaCungCap);
            this.flpModules.Controls.Add(this.btnBanHang);
            this.flpModules.Controls.Add(this.btnHoaDon);
            this.flpModules.Controls.Add(this.btnNhanVien);
            this.flpModules.Controls.Add(this.btnThongKe);
            this.flpModules.Controls.Add(this.btnThoat);
            this.flpModules.Location = new System.Drawing.Point(20, 175);
            this.flpModules.Name = "flpModules";
            this.flpModules.Size = new System.Drawing.Size(1220, 380);
            this.flpModules.TabIndex = 2;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.White;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.btnSanPham.Location = new System.Drawing.Point(6, 6);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(16);
            this.btnSanPham.Size = new System.Drawing.Size(275, 110);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "📦  Quản lý sản phẩm\r\n\r\nXem, thêm, sửa, tồn kho";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.BackColor = System.Drawing.Color.White;
            this.btnLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSanPham.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.btnLoaiSanPham.Location = new System.Drawing.Point(299, 6);
            this.btnLoaiSanPham.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Padding = new System.Windows.Forms.Padding(16);
            this.btnLoaiSanPham.Size = new System.Drawing.Size(275, 110);
            this.btnLoaiSanPham.TabIndex = 1;
            this.btnLoaiSanPham.Text = "🏷  Loại sản phẩm\r\n\r\nPhân nhóm ngành hàng";
            this.btnLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoaiSanPham.UseVisualStyleBackColor = false;
            this.btnLoaiSanPham.Click += new System.EventHandler(this.btnLoaiSanPham_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhaCungCap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnNhaCungCap.Location = new System.Drawing.Point(592, 6);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Padding = new System.Windows.Forms.Padding(16);
            this.btnNhaCungCap.Size = new System.Drawing.Size(275, 110);
            this.btnNhaCungCap.TabIndex = 2;
            this.btnNhaCungCap.Text = "🏢  Nhà cung cấp\r\n\r\nDanh sách đối tác cung ứng";
            this.btnNhaCungCap.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.White;
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnBanHang.Location = new System.Drawing.Point(885, 6);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(16);
            this.btnBanHang.Size = new System.Drawing.Size(275, 110);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "🛒  Bán Hàng (POS)\r\n\r\nMàn hình bán lẻ siêu thị";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.White;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnHoaDon.Location = new System.Drawing.Point(6, 138);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(16);
            this.btnHoaDon.Size = new System.Drawing.Size(275, 110);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "📄  Quản lý hóa đơn\r\n\r\nLịch sử hóa đơn bán lẻ";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnNhanVien.Location = new System.Drawing.Point(299, 138);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(16);
            this.btnNhanVien.Size = new System.Drawing.Size(275, 110);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "👥  Quản lý nhân viên\r\n\r\nDanh sách nhân sự ca trực";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnThongKe.Location = new System.Drawing.Point(592, 138);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(16);
            this.btnThongKe.Size = new System.Drawing.Size(275, 110);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "📊  Báo cáo & Thống kê\r\n\r\nDoanh số và lợi nhuận";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnThoat.Location = new System.Drawing.Point(885, 138);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 12, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(16);
            this.btnThoat.Size = new System.Drawing.Size(275, 110);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "🚪  Thoát hệ thống\r\n\r\nĐăng xuất tài khoản";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1260, 750);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSubHeader);
            this.Controls.Add(this.pnlTopNav);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titmit Mart - Tổng Quan Quản Lý Siêu Thị";
            this.pnlSubHeader.ResumeLayout(false);
            this.pnlSubHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlKpiContainer.ResumeLayout(false);
            this.pnlKpi1.ResumeLayout(false);
            this.pnlKpi1.PerformLayout();
            this.pnlKpi2.ResumeLayout(false);
            this.pnlKpi2.PerformLayout();
            this.pnlKpi3.ResumeLayout(false);
            this.pnlKpi3.PerformLayout();
            this.pnlKpi4.ResumeLayout(false);
            this.pnlKpi4.PerformLayout();
            this.flpModules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Panel pnlSubHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblBranchInfo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlKpiContainer;
        private System.Windows.Forms.Panel pnlKpi1;
        private System.Windows.Forms.Label lblKpi1Title;
        private System.Windows.Forms.Label lblKpi1Val;
        private System.Windows.Forms.Label lblKpi1Sub;
        private System.Windows.Forms.Panel pnlKpi2;
        private System.Windows.Forms.Label lblKpi2Title;
        private System.Windows.Forms.Label lblKpi2Val;
        private System.Windows.Forms.Label lblKpi2Sub;
        private System.Windows.Forms.Panel pnlKpi3;
        private System.Windows.Forms.Label lblKpi3Title;
        private System.Windows.Forms.Label lblKpi3Val;
        private System.Windows.Forms.Label lblKpi3Sub;
        private System.Windows.Forms.Panel pnlKpi4;
        private System.Windows.Forms.Label lblKpi4Title;
        private System.Windows.Forms.Label lblKpi4Val;
        private System.Windows.Forms.Label lblKpi4Sub;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.FlowLayoutPanel flpModules;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnLoaiSanPham;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}