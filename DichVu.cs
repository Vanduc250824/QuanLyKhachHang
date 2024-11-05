using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class DichVu
    {
        public int MaDichVu {  get; set; }
        public string tenDichVu { get; set; }
        public decimal Gia { get; set; }

        public DichVu(int _maDV, string _tenDV, decimal _Gia) { 
            this.MaDichVu = _maDV;
            this.tenDichVu = _tenDV;
            this.Gia = _Gia;
        }
    }
}
