using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    public abstract class NhanVien
    {
        public String HoTen { get; set;}
        public int NamSinh { get; set;}
        public String BangCap { get; set;}

        public abstract float TinhLuong();

    }
}
