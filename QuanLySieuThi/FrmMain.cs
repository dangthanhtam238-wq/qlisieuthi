using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            Panel topBar = KiotVietTheme.CreateKiotVietTopBar(this, "Tổng quan");
            pnlTopNav.Controls.Add(topBar);
            KiotVietTheme.CreateSupportBadge(this);

            btnThoat.Click += BtnThoat_Click;
            btnBanHang.Click += BtnBanHang_Click;
            btnNhanVien.Click += BtnNhanVien_Click;
            btnThongKe.Click += BtnThongKe_Click;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Màn hình Bán hàng (POS) siêu thị đang sẵn sàng phục vụ!", "Titmit Mart Bán Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý nhân viên ca trực đang được tích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng báo cáo thống kê doanh số đang được cập nhật dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tra cứu hóa đơn bán lẻ siêu thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.ShowDialog();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            FrmLoaiSanPham frmLoaiSanPham = new FrmLoaiSanPham();
            frmLoaiSanPham.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }
    }
}
