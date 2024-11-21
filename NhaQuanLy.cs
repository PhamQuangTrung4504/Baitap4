using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    public class NhaQuanLy : NhanVien
    {
        public String ChucVu {  get; set; }
        public int SoNgayCong { get; set; }
        public int BacLuong { get; set; }

        public override float TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }

        public override string ToString()
        {
            return $"[Nhà Quản Lý] {HoTen}, Năm Sinh: {NamSinh}, Bằng Cấp: {BangCap}, " +
                   $"Chức Vụ: {ChucVu}, Số Ngày Công: {SoNgayCong}, Bậc Lương: {BacLuong}, Lương: {TinhLuong()}";
        }
    }
}
