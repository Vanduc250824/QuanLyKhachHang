using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class KhachHang
    {
        private static int autoid = 1;
        public int mKhachHang { get;  set; }
        public string tKhachHang { get; set; }
        public string SDT { get; set; }
        public string dcKhachHang { get; set; }

        public KhachHang() { }
        public KhachHang(int _mKhachHang, string _tKhachHang, string _SDT, string _dcKhachHang) {
            this.mKhachHang = autoid++;
            this.tKhachHang= _tKhachHang;
            this.dcKhachHang=_dcKhachHang;
            this.SDT= _SDT;
        }


    }
}
