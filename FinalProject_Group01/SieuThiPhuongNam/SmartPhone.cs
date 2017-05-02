using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiPhuongNam
{
    enum OS { Android, iOS };
    class SmartPhone : Product
    {
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public OS HDH { get; set; }
        public string Details { get; set; }
        public SmartPhone()
        {
        }
        public string TaoDescription()
        {
            string description = "";
            string endl = "\r\n";

            description += this.TenSP.ToUpper() + endl;
            description += endl;
            description += "Dài: " + this.length.ToString() + " mm" + endl;
            description += "Rộng: " + this.width.ToString() + " mm" + endl;
            description += "Cao: " + this.height.ToString() + " mm" + endl;
            description += "Trọng lượng: " + this.weight.ToString() + " g" + endl;
            description += "Hệ điều hành: " + this.HDH.ToString() + endl;

            if (this.Details != "" && this.Details != null)
            {
                description += "Mô tả thêm: " + this.Details;
            }

            return description;
        }

        public static List<SmartPhone> LayDanhSachTatCaDienThoai()
        {
            List<SmartPhone> list = SmartPhoneDB.LayTatCaDienThoai();
            return list;
        }

        public static List<SmartPhone> LayDanhSachDTTheoTuKhoa(string tukhoa)
        {
            List<SmartPhone> list = SmartPhoneDB.TimDTTheoTen(tukhoa);
            return list;
        }
    }

}
