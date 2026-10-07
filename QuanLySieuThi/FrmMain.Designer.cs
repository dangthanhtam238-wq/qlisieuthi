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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(418, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(337, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SIÊU THỊ";
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(237, 135);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(211, 46);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.Location = new System.Drawing.Point(237, 221);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Size = new System.Drawing.Size(211, 53);
            this.btnLoaiSanPham.TabIndex = 2;
            this.btnLoaiSanPham.Text = "Quản lý loại sản phẩm";
            this.btnLoaiSanPham.UseVisualStyleBackColor = true;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(237, 400);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(211, 52);
            this.btnNhaCungCap.TabIndex = 3;
            this.btnNhaCungCap.Text = "Quản lý nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(237, 316);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(211, 46);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(696, 135);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(204, 46);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(696, 221);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(204, 53);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Quản lý hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(696, 316);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(204, 46);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(696, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 52);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.btnLoaiSanPham);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SIÊU THỊ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
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