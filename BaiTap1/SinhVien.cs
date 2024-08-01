using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1
{
    class SinhVien
    {
        string maSo;
        string hoTen;
        string chuyenNganh;
        int namSinh;
        float diemTB;
        string loai;

        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Loai { get => loai; set => loai = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public float DiemTB 
        {
            get => diemTB;
            set
            {
                if (KTDiemTB(value))
                    return;
                diemTB = value;
            }
        }

        public bool KTDiemTB(float x)
        {
            return x >= 0 && x <= 10;
        }
        public bool KTNamSinh(int namSinh)
        {
            int tuoi = DateTime.Now.Year - namSinh;
            return tuoi >= 17 && tuoi <= 70;
        }

        public SinhVien()
        {
            this.maSo = "";
            this.hoTen = "";
            this.chuyenNganh = "";
            this.namSinh = 0;
            this.diemTB = 0;

        }

        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            XepLoai();
        }

        public void XepLoai()
        {
            if (this.diemTB >= 0 && this.diemTB < 5) this.Loai = "Kem";
            else if (this.diemTB < 7) this.Loai = "Trung binh";
            else if (this.diemTB < 8) this.Loai = "Kha";
            else if (this.diemTB <= 10) this.Loai = "Gioi";
        }

        float x;
        float y;
        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien: "); maSo = Console.ReadLine();
            Console.Write("Nhap ho va ten: "); hoTen = Console.ReadLine();
            Console.Write("Nhap chuyen nganh: "); chuyenNganh = Console.ReadLine();
            do
            {
                Console.Write("Nhap diem trung binh: "); x = int.Parse(Console.ReadLine());
                ///float.TryParse(Console.ReadLine(), out x);
                if (x < 0 || x > 10) Console.WriteLine("Gia tri x khong hop le, moi nhap lai: ");
            } while (!KTDiemTB(x));
            diemTB = x;

            Console.WriteLine("Nhap nam sinh: "); namSinh = int.Parse(Console.ReadLine());
            KTNamSinh(namSinh);
            //do
            //{
            //    Console.Write("Nhap nam sinh: "); y = int.Parse(Console.ReadLine());
            //    float.TryParse(Console.ReadLine(), out y);
            //    if (y < 1953 || y > 2006) Console.WriteLine("Nam sinh khong hop le, moi nhap lai: ");
            //} while (!KTNamSinh(y));
            //namSinh = y;

        }

        public string Xuat()
        {
            return $"Ma so sinh vien: {maSo} - Ho va ten sinh vien: {hoTen} + Chuyen nganh sinh vien: - {chuyenNganh} - Nam sinh sinh vien: {namSinh} - Diem trung binh tich luy: {diemTB} - Xep loai sinh vien: {loai}";
        }
    }
}
