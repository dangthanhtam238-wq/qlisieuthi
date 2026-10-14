using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class FrmSanPham : Form
    {
        Database db = new Database();
        public FrmSanPham()
        {
            InitializeComponent();
            
            Panel topBar = KiotVietTheme.CreateKiotVietTopBar(this, "Hàng hóa");
            pnlTopNav.Controls.Add(topBar);
            KiotVietTheme.ApplyGridStyle(dgvSanPham);
            KiotVietTheme.CreateSupportBadge(this);
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;

            LoadSanPham();
            LoadLoaiSanPham();
            LoadNhaCungCap();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.DataSource is DataTable dt)
            {
                string kw = txtTimKiem.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(kw))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format("TenSP LIKE '%{0}%' OR DonViTinh LIKE '%{0}%'", kw);
                }
            }
        }
        private void LoadSanPham()
        {
            string sql = @"SELECT 
                    sp.MaSP,
                    sp.TenSP,
                    lsp.TenLoai,
                    ncc.TenNCC,
                    sp.DonViTinh,
                    sp.DonGia,
                    sp.SoLuong,
                    sp.HanSuDung
                   FROM SanPham sp
                   INNER JOIN LoaiSanPham lsp
                       ON sp.MaLoai = lsp.MaLoai
                   INNER JOIN NhaCungCap ncc
                       ON sp.MaNCC = ncc.MaNCC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSanPham.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải dữ liệu sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadLoaiSanPham()
        {
            string sql = "SELECT MaLoai, TenLoai FROM LoaiSanPham";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboLoaiSP.DataSource = dt;
                    cboLoaiSP.DisplayMember = "TenLoai";
                    cboLoaiSP.ValueMember = "MaLoai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải loại sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadNhaCungCap()
        {
            string sql = "SELECT MaNCC, TenNCC FROM NhaCungCap";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboNCC.DataSource = dt;
                    cboNCC.DisplayMember = "TenNCC";
                    cboNCC.ValueMember = "MaNCC";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNCC_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                if (row.Cells["HanSuDung"].Value != DBNull.Value)
                {
                    dtpHanSuDung.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
                }

                cboLoaiSP.Text = row.Cells["TenLoai"].Value.ToString();
                cboNCC.Text = row.Cells["TenNCC"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();

            if (tenSP == "" || donViTinh == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên sản phẩm và đơn vị tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show(
                    "Đơn giá phải là số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maLoai = Convert.ToInt32(cboLoaiSP.SelectedValue);
            int maNCC = Convert.ToInt32(cboNCC.SelectedValue);

            string sql = @"INSERT INTO SanPham
               (TenSP, MaLoai, MaNCC, DonViTinh, DonGia, SoLuong, HanSuDung)
               VALUES
               (@TenSP, @MaLoai, @MaNCC, @DonViTinh, @DonGia, @SoLuong, @HanSuDung)";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@HanSuDung", dtpHanSuDung.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string tenSP = txtTenSP.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();

            if (tenSP == "" || donViTinh == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên sản phẩm và đơn vị tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show(
                    "Đơn giá phải là số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maSP = Convert.ToInt32(txtMaSP.Text);
            int maLoai = Convert.ToInt32(cboLoaiSP.SelectedValue);
            int maNCC = Convert.ToInt32(cboNCC.SelectedValue);

            string sql = @"UPDATE SanPham
               SET TenSP = @TenSP,
                   MaLoai = @MaLoai,
                   MaNCC = @MaNCC,
                   DonViTinh = @DonViTinh,
                   DonGia = @DonGia,
                   SoLuong = @SoLuong,
                   HanSuDung = @HanSuDung
               WHERE MaSP = @MaSP";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@HanSuDung", dtpHanSuDung.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cập nhật sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maSP = Convert.ToInt32(txtMaSP.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Xóa sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonViTinh.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();

            if (cboLoaiSP.Items.Count > 0)
            {
                cboLoaiSP.SelectedIndex = 0;
            }

            if (cboNCC.Items.Count > 0)
            {
                cboNCC.SelectedIndex = 0;
            }

            dtpHanSuDung.Value = DateTime.Now;

            LoadSanPham();
        }
    }
}

