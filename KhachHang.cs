using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class KhachHang
    {
        public int mKhachHang { get; set; }    // Mã khách hàng
        public string tKhachHang { get; set; }  // Tên khách hàng
        public string SDT { get; set; }         // Số điện thoại
        public string dcKhachHang { get; set; } // Địa chỉ khách hàng

        public KhachHang() { }
        public KhachHang(int _mKhachHang, string _tKhachHang, string _SDT, string _dcKhachHang) {
            this.mKhachHang = _mKhachHang;
            this.tKhachHang= _tKhachHang;
            this.dcKhachHang=_dcKhachHang;
            this.SDT= _SDT;
        }


    }
}
