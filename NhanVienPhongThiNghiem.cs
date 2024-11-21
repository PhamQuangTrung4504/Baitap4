using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    public class NhanVienPhongThiNghiem : NhanVien
    {
        public float LuongThang {  get; set; }
        public override float TinhLuong()
        {
            return LuongThang;
        }
        public override string ToString()
        {
            return $"[Nhân Viên PTN] {HoTen}, Năm Sinh: {NamSinh}, Bằng Cấp: {BangCap}, Lương Tháng: {LuongThang}"; ;
        }
    }
}
