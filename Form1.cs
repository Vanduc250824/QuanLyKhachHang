using System.Windows.Forms;

namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKH = new List<KhachHang>();
        private BindingSource bindingSourceKH = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = true;
            // Thiết lập BindingSource cho DataGridView
            bindingSourceKH.DataSource = danhSachKH;
            dataGridView1.DataSource = bindingSourceKH;

            gBDichVu.Controls.Add(rbThuePhong);
            gBDichVu.Controls.Add(rbDichVuKhac);

            danhSachKH.Add(new KhachHang
            {
                mKhachHang = 1,
                tKhachHang = "Nguyen Van A",
                SDT = "0123456789",
                dcKhachHang = "123 Đường ABC"
            });

            // Reset bindings để cập nhật DataGridView
            bindingSourceKH.ResetBindings(false);
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ các cột và hiển thị trong các TextBox
                txtMaKH.Text = selectedRow.Cells["columnMaKhachHang"].Value?.ToString();
                txtTenKH.Text = selectedRow.Cells["columnTenKhachHang"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["columnSoDienThoai"].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells["columnDiaChi"].Value?.ToString();
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của dòng đã chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Cập nhật các TextBox với giá trị của dòng
                txtMaKH.Text = selectedRow.Cells["columnMaKhachHang"].Value.ToString();
                txtTenKH.Text = selectedRow.Cells["columnTenKhachHang"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["columnSDT"].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells["columnDiaChi"].Value.ToString();
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var editedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị sửa đổi từ các cột
                int maKhachHang = Convert.ToInt32(editedRow.Cells["columnMaKhachHang"].Value);
                string tenKhachHang = editedRow.Cells["columnTenKhachHang"].Value?.ToString();
                string soDienThoai = editedRow.Cells["columnSoDienThoai"].Value?.ToString();
                string diaChi = editedRow.Cells["columnDiaChi"].Value?.ToString();

                // Cập nhật thông tin khách hàng trong danh sách
                var khachHang = danhSachKH.FirstOrDefault(kh => kh.mKhachHang == maKhachHang);
                if (khachHang != null)
                {
                    khachHang.tKhachHang = tenKhachHang;
                    khachHang.SDT = soDienThoai;
                    khachHang.dcKhachHang = diaChi;
                }
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Khi chỉnh sửa xong trong ô
            var editedRow = dataGridView1.Rows[e.RowIndex];
            // Lấy giá trị sửa đổi từ các cột
            int maKhachHang = Convert.ToInt32(editedRow.Cells["columnMaKhachHang"].Value);
            string tenKhachHang = editedRow.Cells["columnTenKhachHang"].Value?.ToString();
            string soDienThoai = editedRow.Cells["columnSoDienThoai"].Value?.ToString();
            string diaChi = editedRow.Cells["columnDiaChi"].Value?.ToString();

            // Cập nhật thông tin khách hàng trong danh sách
            var khachHang = danhSachKH.FirstOrDefault(kh => kh.mKhachHang == maKhachHang);
            if (khachHang != null)
            {
                khachHang.tKhachHang = tenKhachHang;
                khachHang.SDT = soDienThoai;
                khachHang.dcKhachHang = diaChi;
            }
        }

        private void ThemKH(int makh, string ten, string soDienThoai, string DiaChi)
        {
            KhachHang khachHang = new KhachHang
            {
                mKhachHang = makh, // Tự động tăng mã khách hàng
                tKhachHang = ten,
                SDT = soDienThoai,
                dcKhachHang = DiaChi
            };
            danhSachKH.Add(khachHang);
            dataGridView1.Refresh();
        }

        private void SuaKH(int maKH, string tenKH, string _SDT, string dcKH)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Cập nhật các ô trong dòng đã chọn với dữ liệu từ TextBox
                selectedRow.Cells["columnMaKhachHang"].Value = txtMaKH.Text;
                selectedRow.Cells["columnTenKhachHang"].Value = txtTenKH.Text;
                selectedRow.Cells["columnDiaChi"].Value = txtDiaChi.Text;
                selectedRow.Cells["columnSDT"].Value = txtSDT.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.");
            }
        }



        private void XoaKH(int _MaKhachhang)
        {
            var khachHang = danhSachKH.FirstOrDefault(kh => kh.mKhachHang == _MaKhachhang);
            if (khachHang != null)
            {
                danhSachKH.Remove(khachHang);
                MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi");
            }
        }
        private string LayDichVuDaChon(out double tongTien)
        {
            // Khởi tạo giá trị mặc định cho tổng tiền
            tongTien = 0;

            // Tạo Dictionary chứa dịch vụ và giá tương ứng
            var dichVuGia = new Dictionary<string, double>
            {
                { "Thuê Phòng", 500000 },
                { "Dịch Vụ Khác", 150000 },
            };

            // Lặp qua tất cả các RadioButton trong GroupBox
            foreach (RadioButton radio in gBDichVu.Controls.OfType<RadioButton>())
            {
                // Kiểm tra nếu RadioButton được chọn
                if (radio.Checked)
                {
                    // Kiểm tra xem Text của RadioButton có khớp với các khóa trong Dictionary không
                    if (dichVuGia.ContainsKey(radio.Text))
                    {
                        tongTien = dichVuGia[radio.Text]; // Cập nhật tổng tiền
                        return radio.Text; // Trả về tên dịch vụ đã chọn
                    }
                }
            }

            // Nếu không có dịch vụ nào được chọn, gán giá trị mặc định cho tongTien
            tongTien = 0; // Đảm bảo giá trị tongTien được gán
            return "Không có dịch vụ nào được chọn";
        }





        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = true;
            double tongTien;
            string dichVu = LayDichVuDaChon(out tongTien);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của dòng đã chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Cập nhật các TextBox với giá trị của dòng

                tenKhachHang.Text = selectedRow.Cells["columnTenKhachHang"].Value.ToString();
                SoDienThoai.Text = selectedRow.Cells["columnSDT"].Value?.ToString();
                DiaChi.Text = selectedRow.Cells["columnDiaChi"].Value.ToString();
                tongTienhd.Text = $"{tongTien} VND";
                if (rbDichVuKhac.Checked)
                    Dichvusudung.Text = rbDichVuKhac.Text;
                if (rbThuePhong.Checked)
                    Dichvusudung.Text = rbThuePhong.Text;
            }
        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.", "Thông báo");
                return;
            }

            // Tạo đối tượng KhachHang mới
            KhachHang khachHangMoi = new KhachHang
            {
                mKhachHang = Convert.ToInt32(txtMaKH.Text),
                tKhachHang = txtTenKH.Text,
                SDT = txtSDT.Text,
                dcKhachHang = txtDiaChi.Text
            };

            // Thêm vào danh sách khách hàng
            danhSachKH.Add(khachHangMoi);

            // Cập nhật lại BindingSource để DataGridView cập nhật
            bindingSourceKH.ResetBindings(false);

            // Xóa các trường TextBox
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }


        private void bntSuaKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã khách hàng có hợp lệ không
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.", "Thông báo");
                return;
            }

            // Lấy mã khách hàng từ TextBox
            int maKH = int.Parse(txtMaKH.Text); // Chuyển đổi từ string sang int
            string tenKH = txtTenKH.Text;
            string soDienThoai = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            // Tìm và cập nhật khách hàng trong danh sách
            SuaKH(maKH, tenKH, soDienThoai, diaChi);

            // Cập nhật lại BindingSource để DataGridView cập nhật
            bindingSourceKH.ResetBindings(false);

            // Hiển thị thông báo
            MessageBox.Show("Cập nhật thành công.", "Thông báo");
        }



        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            // Lấy mã khách hàng từ TextBox
            int maKH = int.Parse(txtMaKH.Text);

            // Xóa khách hàng
            XoaKH(maKH);

            // Cập nhật lại BindingSource
            bindingSourceKH.ResetBindings(false);
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo thanh toán thành công
            MessageBox.Show("Thanh toán thành công!", "Thông báo");

            // Xóa dữ liệu trong các Label
            tenKhachHang.Text =   "";  // Gán chuỗi rỗng
            SoDienThoai.Text = "";
            DiaChi.Text = "";
            // Xóa dữ liệu trong TextBox
            txtMaKH.Clear() ;
            txtTenKH.Clear() ;
            txtSDT.Clear() ;
            txtDiaChi.Clear() ;
            // Reset các dịch vụ đã chọn (uncheck các RadioButton)
            rbDichVuKhac.Checked = false;
            rbThuePhong.Checked = false;

            // Disable các RadioButton để không thể chọn lại sau khi thanh toán
            rbDichVuKhac.Enabled = false;
            rbThuePhong.Enabled = false;

            // Ẩn panel hóa đơn sau khi thanh toán
            panelHoaDon.Visible = false;

            // Gọi phương thức XoaKH nếu cần xóa các thông tin khách hàng
            

            // Xóa tất cả các dòng trong DataGridView (nếu cần)
            dataGridView1.Rows.Clear();  // Hoặc dataGridView.Rows.RemoveAt(index) để xóa dòng cụ thể

        }


    }
}
