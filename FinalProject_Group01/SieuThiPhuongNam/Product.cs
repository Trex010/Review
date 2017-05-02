using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiPhuongNam
{
    enum Country { My, TrungQuoc, HanQuoc, Canada };
    enum Branch { Apple, Samsung, Sony, HTC, Asus };
    class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Branch HangSX { get; set; }
        public int ThoiGianBH { get; set; }
        public Country XuatXu { get; set; }
        public int DonGia { get; set; }
    }
}
