using System;

namespace BaiTap2
{
    class Program
    {
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Gia tri mang phat sinh: ");
            obj.Xuat();
        }

        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Mang duoc tao tu danh sach cho truoc:");
            obj.Xuat();
        }

        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Mang vua nhap tu ban phim:");
            obj1.Xuat();
            IntArray obj2 = new IntArray(obj1);
            Console.WriteLine("\nMang copy tu mang vua nhap: ");
            obj2.Xuat();
        }

        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();

            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.TimTuanTu(x);
            if (kq == -1) 
                Console.WriteLine($"-> Khong ton tai {x}!");
            else 
                Console.WriteLine($"-> Co {x} tai vi tri {kq}");
        }

        static void TestTimNhiPhan()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();

            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.binarySearch(x);
            if (kq == -1)
                Console.WriteLine($"-> Khong ton tai {x}!");
            else
                Console.WriteLine($"-> Co {x} tai vi tri {kq}");
        }

        static void TestInterchangeSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.Xuat();
        }

        static void TestBubbleSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.BubbleSort();
            Console.WriteLine("\n>>Bubble Sort:");
            objTam.Xuat();
        }

        static void TestSelectionSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Xuat();
        }

        static void TestQuickSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            //right bằng a.Length - 1 => khi thay độ dài của mảng obj thì cũng phải thay lại số trong hàm QuickSort với độ dài của obj - 1
            objTam.QuickSort(0, 9);
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Xuat();
        }

        static void TestShellSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.ShellSort();
            Console.WriteLine("\n>>Shell Sort:");
            objTam.Xuat();
        }

        static void TestShakerSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            //right bằng a.Length - 1 => khi thay độ dài của mảng obj thì cũng phải thay lại số trong hàm ShakerSort với độ dài của obj - 1
            objTam.ShakerSort(0, 9);
            Console.WriteLine("\n>>Shaker Sort:");
            objTam.Xuat();
        }
        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();
            //TestTimTuanTu();
            //TestTimNhiPhan();
            IntArray obj = new IntArray(10);
            //TestInterchangeSort(obj);
            //TestBubbleSort(obj);
            //TestSelectionSort(obj);
            //TestQuickSort(obj);
            //TestShellSort(obj);
            TestShakerSort(obj);
            Console.ReadKey();
        }
    }
}
