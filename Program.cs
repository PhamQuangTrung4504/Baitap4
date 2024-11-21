using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    using System;
    using System.Collections.Generic;

    namespace Demo
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                List<NhanVien> danhSachNhanVien = new List<NhanVien>();

                while (true)
                {
                    Console.WriteLine("\nChọn loại nhân viên để nhập thông tin:");
                    Console.WriteLine("1. Nhà Khoa Học");
                    Console.WriteLine("2. Nhà Quản Lý");
                    Console.WriteLine("3. Nhân Viên Phòng Thí Nghiệm");
                    Console.WriteLine("4. Hiển thị danh sách và tổng lương");
                    Console.WriteLine("5. Thoát");
                    Console.Write("Lựa chọn của bạn: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            danhSachNhanVien.Add(NhapNhaKhoaHoc());
                            break;
                        case 2:
                            danhSachNhanVien.Add(NhapNhaQuanLy());
                            break;
                        case 3:
                            danhSachNhanVien.Add(NhapNhanVienPTN());
                            break;
                        case 4:
                            HienThiDanhSachVaTongLuong(danhSachNhanVien);
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                            break;
                    }
                }
            }

            static NhaKhoaHoc NhapNhaKhoaHoc()
            {
                Console.WriteLine("\nNhập thông tin Nhà Khoa Học:");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.Write("Bằng cấp: ");
                string bangCap = Console.ReadLine();
                Console.Write("Chức vụ: ");
                string chucVu = Console.ReadLine();
                Console.Write("Số bài báo: ");
                int soBaiBao = int.Parse(Console.ReadLine());
                Console.Write("Số ngày công: ");
                int soNgayCong = int.Parse(Console.ReadLine());
                Console.Write("Bậc lương: ");
                int bacLuong = int.Parse(Console.ReadLine());

                return new NhaKhoaHoc
                {
                    HoTen = hoTen,
                    NamSinh = namSinh,
                    BangCap = bangCap,
                    ChucVu = chucVu,
                    SoBaiBao = soBaiBao,
                    SoNgayCong = soNgayCong,
                    BacLuong = bacLuong
                };
            }

            static NhaQuanLy NhapNhaQuanLy()
            {
                Console.WriteLine("\nNhập thông tin Nhà Quản Lý:");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.Write("Bằng cấp: ");
                string bangCap = Console.ReadLine();
                Console.Write("Chức vụ: ");
                string chucVu = Console.ReadLine();
                Console.Write("Số ngày công: ");
                int soNgayCong = int.Parse(Console.ReadLine());
                Console.Write("Bậc lương: ");
                int bacLuong = int.Parse(Console.ReadLine());

                return new NhaQuanLy
                {
                    HoTen = hoTen,
                    NamSinh = namSinh,
                    BangCap = bangCap,
                    ChucVu = chucVu,
                    SoNgayCong = soNgayCong,
                    BacLuong = bacLuong
                };
            }

            static NhanVienPhongThiNghiem NhapNhanVienPTN()
            {
                Console.WriteLine("\nNhập thông tin Nhân Viên Phòng Thí Nghiệm:");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.Write("Bằng cấp: ");
                string bangCap = Console.ReadLine();
                Console.Write("Lương tháng: ");
                float luongThang = float.Parse(Console.ReadLine());

                return new NhanVienPhongThiNghiem
                {
                    HoTen = hoTen,
                    NamSinh = namSinh,
                    BangCap = bangCap,
                    LuongThang = luongThang
                };
            }

            static void HienThiDanhSachVaTongLuong(List<NhanVien> danhSach)
            {
                double tongLuongNhaKhoaHoc = 0, tongLuongNhaQuanLy = 0, tongLuongNhanVienPTN = 0;

                Console.WriteLine("\nDanh sách nhân viên:");
                foreach (var nhanVien in danhSach)
                {
                    Console.WriteLine(nhanVien);
                    if (nhanVien is NhaKhoaHoc)
                        tongLuongNhaKhoaHoc += nhanVien.TinhLuong();
                    else if (nhanVien is NhaQuanLy)
                        tongLuongNhaQuanLy += nhanVien.TinhLuong();
                    else if (nhanVien is NhanVienPhongThiNghiem)
                        tongLuongNhanVienPTN += nhanVien.TinhLuong();
                }

                Console.WriteLine("\nTổng lương đã chi trả:");
                Console.WriteLine($"Nhà Khoa Học: {tongLuongNhaKhoaHoc}");
                Console.WriteLine($"Nhà Quản Lý: {tongLuongNhaQuanLy}");
                Console.WriteLine($"Nhân Viên Phòng Thí Nghiệm: {tongLuongNhanVienPTN}");
            }
        }
    }

}
