using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SieuThiPhuongNam
{
    class SmartPhoneDB
    {
        public static List<SmartPhone> LayTatCaDienThoai()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
            connection.Open();

            //Construct sql command
            SqlCommand cmd = new SqlCommand("select * from DienThoai", connection);

            //add to list
            List<SmartPhone> list = new List<SmartPhone>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new SmartPhone()
                    {
                        MaSP = reader.GetString(0),
                        TenSP = reader.GetString(1),
                        DonGia = reader.GetInt32(2),
                        HangSX = reader.GetString(3).ToEnum<Branch>(),
                        XuatXu = reader.GetString(4).ToEnum<Country>(),
                        ThoiGianBH = reader.GetInt32(5),
                        length = reader.GetFloat(6),
                        width = reader.GetFloat(7),
                        height = reader.GetFloat(8),
                        weight = reader.GetFloat(9),
                        HDH = reader.GetString(10).ToEnum<OS>(),
                        Details = reader.GetString(11)
                    });

                }
            }

            connection.Close();
            return list;
        }

        public static List<SmartPhone> TimDTTheoTen(string ten)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
            connection.Open();

            //Construct sql command
            SqlCommand cmd = new SqlCommand("select * from DienThoai where TenSP like '%" + ten + "%'", connection);

            //add to list
            List<SmartPhone> list = new List<SmartPhone>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new SmartPhone()
                    {
                        MaSP = reader.GetString(0),
                        TenSP = reader.GetString(1),
                        DonGia = reader.GetInt32(2),
                        HangSX = reader.GetString(3).ToEnum<Branch>(),
                        XuatXu = reader.GetString(4).ToEnum<Country>(),
                        ThoiGianBH = reader.GetInt32(5),
                        length = reader.GetFloat(6),
                        width = reader.GetFloat(7),
                        height = reader.GetFloat(8),
                        weight = reader.GetFloat(9),
                        HDH = reader.GetString(10).ToEnum<OS>(),
                        Details = reader.GetString(11)
                    });

                }
            }
            connection.Close();
            return list;
        }
    }
}
