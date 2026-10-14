using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class FrmNhaCungCap : Form
    {
        Database db = new Database();

        public FrmNhaCungCap()
        {
            InitializeComponent();
            Panel topBar = KiotVietTheme.CreateKiotVietTopBar(this, "Đối tác");
            pnlTopNav.Controls.Add(topBar);
            KiotVietTheme.ApplyGridStyle(dgvNhaCungCap);
            KiotVietTheme.CreateSupportBadge(this);
            LoadNhaCungCap();
        }

        // Hiển thị danh sách nhà cung cấp
        private void LoadNhaCungCap()
        {
            string sql = @"SELECT 
                            MaNCC,
                            TenNCC,
                            SoDienThoai,
                            DiaChi
                           FROM NhaCungCap";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvNhaCungCap.DataSource = dt;
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

        // Chọn nhà cung cấp trên DataGridView
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        // Thêm nhà cung cấp
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (tenNCC == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhà cung cấp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string sql = @"INSERT INTO NhaCungCap
                           (TenNCC, SoDienThoai, DiaChi)
                           VALUES
                           (@TenNCC, @SoDienThoai, @DiaChi)";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Sửa nhà cung cấp
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà cung cấp cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string tenNCC = txtTenNCC.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (tenNCC == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhà cung cấp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maNCC = Convert.ToInt32(txtMaNCC.Text);

            string sql = @"UPDATE NhaCungCap
                           SET TenNCC = @TenNCC,
                               SoDienThoai = @SoDienThoai,
                               DiaChi = @DiaChi
                           WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cập nhật nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Xóa nhà cung cấp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà cung cấp cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maNCC = Convert.ToInt32(txtMaNCC.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhà cung cấp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Xóa nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();

            LoadNhaCungCap();
        }

        private void dgvNhaCungCap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (tenNCC == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhà cung cấp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string sql = @"INSERT INTO NhaCungCap
               (TenNCC, SoDienThoai, DiaChi)
               VALUES
               (@TenNCC, @SoDienThoai, @DiaChi)";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà cung cấp cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string tenNCC = txtTenNCC.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (tenNCC == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhà cung cấp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maNCC = Convert.ToInt32(txtMaNCC.Text);

            string sql = @"UPDATE NhaCungCap
               SET TenNCC = @TenNCC,
                   SoDienThoai = @SoDienThoai,
                   DiaChi = @DiaChi
               WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cập nhật nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà cung cấp cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int maNCC = Convert.ToInt32(txtMaNCC.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhà cung cấp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Xóa nhà cung cấp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadNhaCungCap();

                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa nhà cung cấp:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();

            LoadNhaCungCap();
        }
    }
}