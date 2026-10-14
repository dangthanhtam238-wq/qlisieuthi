using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class FrmLoaiSanPham : Form
    {
        Database db = new Database();

        public FrmLoaiSanPham()
        {
            InitializeComponent();
            Panel topBar = KiotVietTheme.CreateKiotVietTopBar(this, "Loại sản phẩm");
            pnlTopNav.Controls.Add(topBar);
            KiotVietTheme.ApplyGridStyle(dgvLoaiSanPham);
            KiotVietTheme.CreateSupportBadge(this);
            LoadLoaiSanPham();
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

                    dgvLoaiSanPham.DataSource = dt;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text.Trim();

            if (tenLoai == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên loại sản phẩm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string sql = "INSERT INTO LoaiSanPham (TenLoai) VALUES (@TenLoai)";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenLoai", tenLoai);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm loại sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadLoaiSanPham();

                txtTenLoai.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm loại sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];

                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn loại sản phẩm cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string tenLoai = txtTenLoai.Text.Trim();

            if (tenLoai == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên loại sản phẩm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maLoai = Convert.ToInt32(txtMaLoai.Text);

            string sql = @"UPDATE LoaiSanPham
               SET TenLoai = @TenLoai
               WHERE MaLoai = @MaLoai";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@TenLoai", tenLoai);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cập nhật loại sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadLoaiSanPham();

                txtMaLoai.Clear();
                txtTenLoai.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật loại sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn loại sản phẩm cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maLoai = Convert.ToInt32(txtMaLoai.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa loại sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM LoaiSanPham WHERE MaLoai = @MaLoai";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Xóa loại sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadLoaiSanPham();

                txtMaLoai.Clear();
                txtTenLoai.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa loại sản phẩm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();

            LoadLoaiSanPham();
        }
    }
}