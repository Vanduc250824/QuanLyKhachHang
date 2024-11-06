namespace QuanLyKhachHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            columnMaKhachHang = new DataGridViewTextBoxColumn();
            columnTenKhachHang = new DataGridViewTextBoxColumn();
            columnSDT = new DataGridViewTextBoxColumn();
            columnDiaChi = new DataGridViewTextBoxColumn();
            lbNhan = new Label();
            btnThemKH = new Button();
            bntSuaKH = new Button();
            btnXoaKH = new Button();
            btnTaoHoaDon = new Button();
            panelHoaDon = new Panel();
            tongTienhd = new Label();
            Dichvusudung = new Label();
            label6 = new Label();
            btnThanhToan = new Button();
            lbTongTien = new Label();
            DiaChi = new Label();
            lbDiaChi = new Label();
            SoDienThoai = new Label();
            label1 = new Label();
            tenKhachHang = new Label();
            lbTenKhachHang = new Label();
            panelThemKH = new Panel();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            rbThuePhong = new RadioButton();
            rbDichVuKhac = new RadioButton();
            gBDichVu = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHoaDon.SuspendLayout();
            panelThemKH.SuspendLayout();
            gBDichVu.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnMaKhachHang, columnTenKhachHang, columnSDT, columnDiaChi });
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(580, 217);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // columnMaKhachHang
            // 
            columnMaKhachHang.DataPropertyName = "mKhachHang";
            columnMaKhachHang.HeaderText = "Mã Khách Hàng";
            columnMaKhachHang.MinimumWidth = 6;
            columnMaKhachHang.Name = "columnMaKhachHang";
            columnMaKhachHang.ReadOnly = true;
            columnMaKhachHang.Width = 125;
            // 
            // columnTenKhachHang
            // 
            columnTenKhachHang.DataPropertyName = "tKhachHang";
            columnTenKhachHang.HeaderText = "Tên Khách Hàng";
            columnTenKhachHang.MinimumWidth = 6;
            columnTenKhachHang.Name = "columnTenKhachHang";
            columnTenKhachHang.ReadOnly = true;
            columnTenKhachHang.Width = 150;
            // 
            // columnSDT
            // 
            columnSDT.DataPropertyName = "SDT";
            columnSDT.HeaderText = "Số Điện Thoại";
            columnSDT.MinimumWidth = 6;
            columnSDT.Name = "columnSDT";
            columnSDT.ReadOnly = true;
            columnSDT.Width = 125;
            // 
            // columnDiaChi
            // 
            columnDiaChi.DataPropertyName = "dcKhachHang";
            columnDiaChi.HeaderText = "Địa Chỉ";
            columnDiaChi.MinimumWidth = 6;
            columnDiaChi.Name = "columnDiaChi";
            columnDiaChi.ReadOnly = true;
            columnDiaChi.Width = 125;
            // 
            // lbNhan
            // 
            lbNhan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNhan.Location = new Point(126, 18);
            lbNhan.Name = "lbNhan";
            lbNhan.Size = new Size(363, 51);
            lbNhan.TabIndex = 1;
            lbNhan.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(764, 426);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(94, 29);
            btnThemKH.TabIndex = 2;
            btnThemKH.Text = "Thêm";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // bntSuaKH
            // 
            bntSuaKH.Location = new Point(764, 527);
            bntSuaKH.Name = "bntSuaKH";
            bntSuaKH.Size = new Size(94, 29);
            bntSuaKH.TabIndex = 3;
            bntSuaKH.Text = "Sửa";
            bntSuaKH.UseVisualStyleBackColor = true;
            bntSuaKH.Click += bntSuaKH_Click;
            // 
            // btnXoaKH
            // 
            btnXoaKH.Location = new Point(983, 527);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.Size = new Size(94, 29);
            btnXoaKH.TabIndex = 4;
            btnXoaKH.Text = "Xóa";
            btnXoaKH.UseVisualStyleBackColor = true;
            btnXoaKH.Click += btnXoaKH_Click;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(969, 426);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(108, 29);
            btnTaoHoaDon.TabIndex = 5;
            btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // panelHoaDon
            // 
            panelHoaDon.Controls.Add(tongTienhd);
            panelHoaDon.Controls.Add(Dichvusudung);
            panelHoaDon.Controls.Add(label6);
            panelHoaDon.Controls.Add(btnThanhToan);
            panelHoaDon.Controls.Add(lbTongTien);
            panelHoaDon.Controls.Add(DiaChi);
            panelHoaDon.Controls.Add(lbDiaChi);
            panelHoaDon.Controls.Add(SoDienThoai);
            panelHoaDon.Controls.Add(label1);
            panelHoaDon.Controls.Add(tenKhachHang);
            panelHoaDon.Controls.Add(lbTenKhachHang);
            panelHoaDon.Location = new Point(12, 374);
            panelHoaDon.Name = "panelHoaDon";
            panelHoaDon.Size = new Size(580, 301);
            panelHoaDon.TabIndex = 6;
            panelHoaDon.UseWaitCursor = true;
            panelHoaDon.Visible = false;
            // 
            // tongTienhd
            // 
            tongTienhd.Location = new Point(158, 167);
            tongTienhd.Name = "tongTienhd";
            tongTienhd.Size = new Size(235, 25);
            tongTienhd.TabIndex = 13;
            tongTienhd.UseWaitCursor = true;
            // 
            // Dichvusudung
            // 
            Dichvusudung.Location = new Point(158, 216);
            Dichvusudung.Name = "Dichvusudung";
            Dichvusudung.Size = new Size(235, 25);
            Dichvusudung.TabIndex = 12;
            Dichvusudung.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 216);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 11;
            label6.Text = "Dịch vụ sử dụng:";
            label6.UseWaitCursor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(464, 258);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.UseWaitCursor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(25, 172);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(78, 20);
            lbTongTien.TabIndex = 10;
            lbTongTien.Text = "Tổng Tiền:";
            lbTongTien.UseWaitCursor = true;
            // 
            // DiaChi
            // 
            DiaChi.Location = new Point(148, 129);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(207, 27);
            DiaChi.TabIndex = 5;
            DiaChi.UseWaitCursor = true;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(25, 129);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(60, 20);
            lbDiaChi.TabIndex = 4;
            lbDiaChi.Text = "Địa Chỉ:";
            lbDiaChi.UseWaitCursor = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.Location = new Point(148, 73);
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Size = new Size(207, 27);
            SoDienThoai.TabIndex = 3;
            SoDienThoai.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Số Điện Thoại: ";
            label1.UseWaitCursor = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.Location = new Point(148, 15);
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.Size = new Size(207, 27);
            tenKhachHang.TabIndex = 1;
            tenKhachHang.UseWaitCursor = true;
            // 
            // lbTenKhachHang
            // 
            lbTenKhachHang.AutoSize = true;
            lbTenKhachHang.Location = new Point(25, 15);
            lbTenKhachHang.Name = "lbTenKhachHang";
            lbTenKhachHang.Size = new Size(119, 20);
            lbTenKhachHang.TabIndex = 0;
            lbTenKhachHang.Text = "Tên Khách Hàng:";
            lbTenKhachHang.UseWaitCursor = true;
            // 
            // panelThemKH
            // 
            panelThemKH.Controls.Add(txtDiaChi);
            panelThemKH.Controls.Add(label5);
            panelThemKH.Controls.Add(txtSDT);
            panelThemKH.Controls.Add(label4);
            panelThemKH.Controls.Add(txtTenKH);
            panelThemKH.Controls.Add(txtMaKH);
            panelThemKH.Controls.Add(label3);
            panelThemKH.Controls.Add(label2);
            panelThemKH.Location = new Point(706, 74);
            panelThemKH.Name = "panelThemKH";
            panelThemKH.Size = new Size(396, 320);
            panelThemKH.TabIndex = 8;
            panelThemKH.TabStop = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(145, 215);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(208, 27);
            txtDiaChi.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 218);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 16;
            label5.Text = "Địa Chỉ:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(147, 152);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(208, 27);
            txtSDT.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 155);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 14;
            label4.Text = "Số Điện Thoại:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(147, 83);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(208, 27);
            txtTenKH.TabIndex = 13;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(147, 13);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(208, 27);
            txtMaKH.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 16);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã Khách Hàng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên Khách Hàng: ";
            // 
            // rbThuePhong
            // 
            rbThuePhong.AutoSize = true;
            rbThuePhong.Location = new Point(114, 39);
            rbThuePhong.Name = "rbThuePhong";
            rbThuePhong.Size = new Size(108, 24);
            rbThuePhong.TabIndex = 0;
            rbThuePhong.TabStop = true;
            rbThuePhong.Text = "Thuê Phòng";
            rbThuePhong.UseVisualStyleBackColor = true;
            rbThuePhong.UseWaitCursor = true;
            // 
            // rbDichVuKhac
            // 
            rbDichVuKhac.AutoSize = true;
            rbDichVuKhac.Location = new Point(348, 39);
            rbDichVuKhac.Name = "rbDichVuKhac";
            rbDichVuKhac.Size = new Size(117, 24);
            rbDichVuKhac.TabIndex = 1;
            rbDichVuKhac.TabStop = true;
            rbDichVuKhac.Text = "Dịch Vụ Khác";
            rbDichVuKhac.UseVisualStyleBackColor = true;
            rbDichVuKhac.UseWaitCursor = true;
            // 
            // gBDichVu
            // 
            gBDichVu.Controls.Add(rbDichVuKhac);
            gBDichVu.Controls.Add(rbThuePhong);
            gBDichVu.Location = new Point(649, 562);
            gBDichVu.Name = "gBDichVu";
            gBDichVu.Size = new Size(534, 77);
            gBDichVu.TabIndex = 12;
            gBDichVu.TabStop = false;
            gBDichVu.Text = "Dịch Vụ Đã Sử Dụng";
            gBDichVu.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 700);
            Controls.Add(gBDichVu);
            Controls.Add(panelThemKH);
            Controls.Add(panelHoaDon);
            Controls.Add(btnTaoHoaDon);
            Controls.Add(btnXoaKH);
            Controls.Add(bntSuaKH);
            Controls.Add(btnThemKH);
            Controls.Add(lbNhan);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHoaDon.ResumeLayout(false);
            panelHoaDon.PerformLayout();
            panelThemKH.ResumeLayout(false);
            panelThemKH.PerformLayout();
            gBDichVu.ResumeLayout(false);
            gBDichVu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbNhan;
        private Button btnThemKH;
        private Button bntSuaKH;
        private Button btnXoaKH;
        private Button btnTaoHoaDon;
        private Panel panelHoaDon;
        private Label SoDienThoai;
        private Label label1;
        private Label tenKhachHang;
        private Label lbTenKhachHang;
        private Label DiaChi;
        private Label lbDiaChi;
        private Label lbTongTien;
        private Button btnThanhToan;
        private Panel panelThemKH;
        private TextBox txtDiaChi;
        private Label label5;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn columnMaKhachHang;
        private DataGridViewTextBoxColumn columnTenKhachHang;
        private DataGridViewTextBoxColumn columnSDT;
        private DataGridViewTextBoxColumn columnDiaChi;
        private RadioButton rbThuePhong;
        private RadioButton rbDichVuKhac;
        private GroupBox gBDichVu;
        private Label Dichvusudung;
        private Label label6;
        private Label tongTienhd;
    }
}
