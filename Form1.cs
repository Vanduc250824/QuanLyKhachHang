using System.Windows.Forms;

namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKH = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView_SelectionChanged;
            dataGridView1.CellClick += dataGridView_CellClick;
            btnOK.Click += btnOK_Click;

            
            gBDichVu.Controls.Add(rbThuePhong);
            gBDichVu.Controls.Add(rbDichVuKhac);
        }
        

        private void ThemKH(string ten, string soDienThoai, string DiaChi)
        {
           int ten = txtMaKH.Text;
           
        }
        
        private void SuaKH(int maKH, string tenKH, string _SDT, string dcKH)
        {
            var khachHang = danhSachKH.FirstOrDefault(kh => kh.mKhachHang == maKH);
            if (khachHang != null) {
                khachHang.tKhachHang = tenKH;
                khachHang.dcKhachHang = dcKH;
                khachHang.SDT = _SDT;
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo");
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
        private string LayDichVuDaChon()
        {
            foreach (RadioButton radio in gBDichVu.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    return radio.Text;  
                }
            }
            return "Không có dịch vụ nào được chọn";
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từng cột trong hàng được chọn
                var maKhachHang = selectedRow.Cells["Mã Khách Hàng"].Value?.ToString();  
                var tenKhachhang = selectedRow.Cells["Tên Khách Hàng"].Value?.ToString(); 
                var soDienThoai = selectedRow.Cells["Số Điện Thoại"].Value?.ToString();   
                var diaChi = selectedRow.Cells["Địa Chỉ"].Value?.ToString();

                // Hiển thị hoặc sử dụng dữ liệu (ví dụ hiển thị trong các TextBox)
                tenKhachHang.Text = tenKhachhang;
                SoDienThoai.Text = soDienThoai;
                DiaChi.Text = diaChi;

            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từng cột trong hàng được chọn
                var maKhachHang = selectedRow.Cells["Mã Khách Hàng"].Value?.ToString();  
                var tenKhachHang = selectedRow.Cells["Tên Khách Hàng"].Value?.ToString(); 
                var soDienThoai = selectedRow.Cells["Số Điện Thoại"].Value?.ToString();   
                var diaChi = selectedRow.Cells["Địa Chỉ"].Value?.ToString();      

                // Hiển thị hoặc sử dụng dữ liệu (ví dụ hiển thị trong các TextBox)
                txtMaKH.Text = maKhachHang;
                txtTenKH.Text += tenKhachHang;
                txtSDT.Text += soDienThoai;
                txtDiaChi.Text += diaChi;
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = true;

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            panelThemKH.Visible = true;
            panelThemKH.Enabled = true;

            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
             KhachHang khachHang = new KhachHang();
            danhSachKH.Add(khachHang);
            KhachHang khachHang1 = new KhachHang { tKhachHang = "Nguyen Van A", SDT = "0123456789", dcKhachHang = "Ha Noi" };
            KhachHang khachHang2 = new KhachHang { tKhachHang = "Tran Thi B", SDT = "0987654321", dcKhachHang = "Ho Chi Minh" };

            // Thêm khách hàng vào danh sách
            danhSachKH.Add(khachHang1);
            danhSachKH.Add(khachHang2);
            dataGridView1.DataSource = null; // Reset DataSource
            dataGridView1.DataSource = danhSachKH;
        }

        private void bntSuaKH_Click(object sender, EventArgs e)
        {
            // Lấy mã khách hàng từ TextBox
            int maKH = int.Parse(txtMaKH.Text);
            string tenKH = txtTenKH.Text;
            string soDienThoai = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            // Cập nhật thông tin khách hàng
            SuaKH(maKH, tenKH, soDienThoai, diaChi);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachKH;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            // Lấy mã khách hàng từ TextBox
            int maKH = int.Parse(txtMaKH.Text);

            // Xóa khách hàng
            XoaKH(maKH);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachKH;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string tenKh = txtTenKH.Text;
            string maKh = txtMaKH.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string dichvu = LayDichVuDaChon();

            decimal tong = dichvu == "Thuê Phòng" ? 250000 : 150000; 

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các TextBox có rỗng không
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return; // Dừng lại nếu có thông tin chưa điền
            }

            // Lấy dữ liệu từ TextBox
            string tenKH = txtTenKH.Text;
            string soDienThoai = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            // Thêm khách hàng vào danh sách
            ThemKH(tenKH, soDienThoai, diaChi);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null; // Reset DataSource
            dataGridView1.DataSource = danhSachKH; // Gán lại danh sách

            // Đóng panel sau khi thêm khách hàng
            panelThemKH.Visible = false; // Ẩn panel
        }
    }
}
