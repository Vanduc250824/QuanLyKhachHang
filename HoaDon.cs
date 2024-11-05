using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class HoaDon
    {
        public int ID { get; set; }
        public KhachHang khachHang { get; set; }
        public List<DichVu> Danhsachdichvu { get; set; }
        public decimal Tongtien => Danhsachdichvu.Sum(dv => dv.Gia);
        public HoaDon(int _MaHD, KhachHang _khachHang, List<DichVu> _dichvu) { 
            this.ID = _MaHD;
            this.khachHang = _khachHang;
            this.Danhsachdichvu = _dichvu;
        }
    }
}
