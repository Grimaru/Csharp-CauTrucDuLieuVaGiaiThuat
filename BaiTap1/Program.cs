using System;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSinhVien();
            SinhVien b = new SinhVien("123", "nam", "cntt", 2004, 7);
        }

        static void TestSinhVien()
        {
            SinhVien a = new SinhVien();
            a.Nhap();
            Console.WriteLine("Thong tin sinh vien A: ");
            Console.WriteLine(a.Xuat());
        }
    }
}
