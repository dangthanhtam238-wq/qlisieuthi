using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public static class KiotVietTheme
    {
        // KiotViet Color Palette
        public static readonly Color PrimaryBlue = Color.FromArgb(0, 119, 197);       // #0077C5
        public static readonly Color DarkNavBlue = Color.FromArgb(0, 88, 143);        // #00588F
        public static readonly Color NavHoverBlue = Color.FromArgb(0, 102, 170);
        public static readonly Color KiotGreen = Color.FromArgb(75, 172, 77);         // #4BAC4D
        public static readonly Color KiotGreenHover = Color.FromArgb(64, 155, 66);
        public static readonly Color KiotRed = Color.FromArgb(217, 83, 79);           // #D9534F
        public static readonly Color KiotRedHover = Color.FromArgb(195, 65, 61);
        public static readonly Color KiotGray = Color.FromArgb(108, 117, 125);
        public static readonly Color KiotGrayHover = Color.FromArgb(90, 98, 104);

        public static readonly Color BgLight = Color.FromArgb(240, 244, 248);         // #F0F4F8
        public static readonly Color SidebarBg = Color.FromArgb(235, 241, 245);       // #EBF1F5
        public static readonly Color CardBg = Color.White;
        public static readonly Color BorderColor = Color.FromArgb(218, 225, 233);     // #DAE1E9
        public static readonly Color InputBorder = Color.FromArgb(204, 214, 224);
        
        public static readonly Color TableHeaderBg = Color.FromArgb(232, 244, 250);   // #E8F4FA
        public static readonly Color TableHeaderBorder = Color.FromArgb(204, 226, 238);
        public static readonly Color TableAlternateRow = Color.FromArgb(248, 250, 252);
        public static readonly Color TableSelectionBg = Color.FromArgb(227, 242, 253);

        public static readonly Color TextDark = Color.FromArgb(33, 37, 41);
        public static readonly Color TextMuted = Color.FromArgb(108, 117, 125);
        public static readonly Color TextNavy = Color.FromArgb(24, 43, 73);

        // Fonts
        public static readonly Font FontLogo = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontTitle = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontSection = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font FontBold = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font FontRegular = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static readonly Font FontSmall = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        public static readonly Font FontSmallBold = new Font("Segoe UI", 8.5F, FontStyle.Bold);

        /// <summary>
        /// Applies modern KiotViet styling to a DataGridView
        /// </summary>
        public static void ApplyGridStyle(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(228, 233, 239);
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowTemplate.Height = 34;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = TableHeaderBg;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(27, 68, 105);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Row Style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = TextDark;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = TableSelectionBg;
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(12, 74, 110);
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            // Alternate Row
            dgv.AlternatingRowsDefaultCellStyle.BackColor = TableAlternateRow;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextDark;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = TableSelectionBg;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(12, 74, 110);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
        }

        /// <summary>
        /// Styles a flat modern button
        /// </summary>
        public static void ApplyButton(Button btn, Color bg, Color hoverBg, Color text, Font font = null)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bg;
            btn.ForeColor = text;
            btn.Font = font ?? FontBold;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter -= Button_MouseEnter;
            btn.MouseLeave -= Button_MouseLeave;

            btn.Tag = new Color[] { bg, hoverBg };
            btn.MouseEnter += Button_MouseEnter;
            btn.MouseLeave += Button_MouseLeave;
        }

        private static void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Color[] colors)
            {
                btn.BackColor = colors[1];
            }
        }

        private static void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Color[] colors)
            {
                btn.BackColor = colors[0];
            }
        }

        /// <summary>
        /// Builds the top 2-tier KiotViet navigation bar (White utility bar + Blue menu bar)
        /// </summary>
        public static Panel CreateKiotVietTopBar(Form currentForm, string activeModule = "Hàng hóa")
        {
            Panel container = new Panel
            {
                Dock = DockStyle.Top,
                Height = 84,
                BackColor = Color.White
            };

            // Tier 1: White bar (height 44)
            Panel whiteBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = Color.White,
                Padding = new Padding(15, 0, 15, 0)
            };

            // Logo
            Label lblLogo = new Label
            {
                Text = "Titmit Mart",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = KiotGreen,
                AutoSize = true,
                Location = new Point(14, 5),
                Cursor = Cursors.Hand
            };
            lblLogo.Click += (s, e) =>
            {
                if (!(currentForm is FrmMain))
                {
                    currentForm.Close();
                }
            };

            Label lblSlogan = new Label
            {
                Text = "Hệ Thống Siêu Thị Tiện Lợi",
                Font = new Font("Segoe UI", 7.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(120, 140, 160),
                AutoSize = true,
                Location = new Point(18, 28)
            };

            // Right utility links
            FlowLayoutPanel rightLinks = new FlowLayoutPanel
            {
                Dock = DockStyle.Right,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0, 10, 0, 0)
            };

            string[] utilities = new string[] {
                "🎨 Chủ đề",
                "❓ Hỗ trợ",
                "☁ Tải TeamViewer",
                "🏪 Chi nhánh trung tâm ▾",
                "⚙ Thiết lập ▾",
                "👤 admin ▾"
            };

            foreach (var util in utilities)
            {
                Label lblUtil = new Label
                {
                    Text = util,
                    Font = FontSmall,
                    ForeColor = Color.FromArgb(70, 80, 95),
                    AutoSize = true,
                    Margin = new Padding(10, 3, 10, 0),
                    Cursor = Cursors.Hand
                };
                lblUtil.MouseEnter += (s, e) => lblUtil.ForeColor = PrimaryBlue;
                lblUtil.MouseLeave += (s, e) => lblUtil.ForeColor = Color.FromArgb(70, 80, 95);
                rightLinks.Controls.Add(lblUtil);
            }

            whiteBar.Controls.Add(lblLogo);
            whiteBar.Controls.Add(lblSlogan);
            whiteBar.Controls.Add(rightLinks);

            // Tier 2: Blue Navigation Bar (height 40)
            Panel blueNav = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = PrimaryBlue
            };

            FlowLayoutPanel navItems = new FlowLayoutPanel
            {
                Dock = DockStyle.Left,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(10, 0, 0, 0)
            };

            Tuple<string, string>[] menuItems = new Tuple<string, string>[]
            {
                Tuple.Create("Tổng quan", "👁 Tổng quan"),
                Tuple.Create("Hàng hóa", "📦 Hàng hóa"),
                Tuple.Create("Loại sản phẩm", "🏷 Loại sản phẩm"),
                Tuple.Create("Đối tác", "👥 Đối tác NCC"),
                Tuple.Create("Giao dịch", "🔄 Giao dịch"),
                Tuple.Create("Sổ quỹ", "💲 Sổ quỹ"),
                Tuple.Create("Báo cáo", "📊 Báo cáo")
            };

            foreach (var item in menuItems)
            {
                bool isActive = item.Item1.Equals(activeModule, StringComparison.OrdinalIgnoreCase);
                Button btnMenu = new Button
                {
                    Text = item.Item2,
                    Height = 40,
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = isActive ? DarkNavBlue : PrimaryBlue,
                    ForeColor = Color.White,
                    Font = isActive ? FontBold : FontRegular,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(0),
                    Padding = new Padding(12, 0, 12, 0),
                    UseVisualStyleBackColor = false
                };
                btnMenu.FlatAppearance.BorderSize = 0;

                btnMenu.MouseEnter += (s, e) =>
                {
                    if (!isActive) btnMenu.BackColor = NavHoverBlue;
                };
                btnMenu.MouseLeave += (s, e) =>
                {
                    if (!isActive) btnMenu.BackColor = PrimaryBlue;
                };

                // Navigation click handling
                btnMenu.Click += (s, e) =>
                {
                    HandleNavClick(currentForm, item.Item1);
                };

                navItems.Controls.Add(btnMenu);
            }

            // Right "Bán hàng" button
            Button btnBanHang = new Button
            {
                Text = "🛒 Bán hàng",
                Dock = DockStyle.Right,
                Width = 120,
                FlatStyle = FlatStyle.Flat,
                BackColor = DarkNavBlue,
                ForeColor = Color.White,
                Font = FontBold,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.MouseEnter += (s, e) => btnBanHang.BackColor = Color.FromArgb(0, 68, 115);
            btnBanHang.MouseLeave += (s, e) => btnBanHang.BackColor = DarkNavBlue;
            btnBanHang.Click += (s, e) =>
            {
                MessageBox.Show("Màn hình Bán hàng (POS) siêu thị đang sẵn sàng phục vụ!", "Titmit Mart Bán Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            blueNav.Controls.Add(navItems);
            blueNav.Controls.Add(btnBanHang);

            container.Controls.Add(blueNav);
            container.Controls.Add(whiteBar);

            return container;
        }

        private static void HandleNavClick(Form currentForm, string module)
        {
            switch (module)
            {
                case "Tổng quan":
                    if (!(currentForm is FrmMain))
                    {
                        currentForm.Close();
                    }
                    break;
                case "Hàng hóa":
                    if (!(currentForm is FrmSanPham))
                    {
                        if (!(currentForm is FrmMain)) currentForm.Close();
                        FrmSanPham frm = new FrmSanPham();
                        frm.ShowDialog();
                    }
                    break;
                case "Loại sản phẩm":
                    if (!(currentForm is FrmLoaiSanPham))
                    {
                        if (!(currentForm is FrmMain)) currentForm.Close();
                        FrmLoaiSanPham frm = new FrmLoaiSanPham();
                        frm.ShowDialog();
                    }
                    break;
                case "Đối tác":
                    if (!(currentForm is FrmNhaCungCap))
                    {
                        if (!(currentForm is FrmMain)) currentForm.Close();
                        FrmNhaCungCap frm = new FrmNhaCungCap();
                        frm.ShowDialog();
                    }
                    break;
                case "Giao dịch":
                case "Sổ quỹ":
                case "Báo cáo":
                    MessageBox.Show("Chức năng '" + module + "' đang hoạt động trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        /// <summary>
        /// Creates a floating green support pill button like KiotViet ("💬 Hỗ trợ KiotViet")
        /// </summary>
        public static Button CreateSupportBadge(Form parent)
        {
            Button btnSupport = new Button
            {
                Text = "💬 Hỗ trợ Titmit Mart",
                Size = new Size(165, 36),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                BackColor = KiotGreen,
                ForeColor = Color.White,
                Font = FontBold,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnSupport.FlatAppearance.BorderSize = 0;
            btnSupport.Location = new Point(parent.ClientSize.Width - btnSupport.Width - 18, parent.ClientSize.Height - btnSupport.Height - 12);
            btnSupport.MouseEnter += (s, e) => btnSupport.BackColor = KiotGreenHover;
            btnSupport.MouseLeave += (s, e) => btnSupport.BackColor = KiotGreen;
            btnSupport.Click += (s, e) =>
            {
                MessageBox.Show("Tổng đài hỗ trợ Titmit Mart: 1900 6522\nWebsite: titmitmart.vn\nPhiên bản Quản lý Siêu thị Titmit Mart v2.5", "Hỗ trợ khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            parent.Controls.Add(btnSupport);
            btnSupport.BringToFront();
            return btnSupport;
        }

        /// <summary>
        /// Creates an accordion header card commonly seen in KiotViet sidebar filters
        /// </summary>
        public static Panel CreateAccordionHeader(string title, int width = 240)
        {
            Panel pnlHeader = new Panel
            {
                Width = width,
                Height = 32,
                BackColor = PrimaryBlue,
                Padding = new Padding(10, 0, 8, 0)
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = FontBold,
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(8, 7)
            };

            Label lblArrow = new Label
            {
                Text = "▾",
                Font = FontBold,
                ForeColor = Color.White,
                AutoSize = true,
                Dock = DockStyle.Right
            };

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblArrow);
            return pnlHeader;
        }
    }
}
