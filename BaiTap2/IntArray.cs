using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class IntArray
    {
        private int[] a;
        public int[] A { get => a; set => a = value; }
        public int this[int i] { get => a[i]; set => a[i] = value; }
        public int Size { get => a.Length; }


        public IntArray()
        {
            a = new int[1];
            a[0] = 0;
        }

        public IntArray(int k)
        {
            a = new int[k];
            Random rd = new Random();
            for (int i = 0; i < k; i++)
            {
                a[i] = rd.Next(1, 200);
            }
        }
        public IntArray(int[] b)
        {
            int n = b.Length;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = b[i];
            }
        }
        public IntArray(IntArray obj)
        {
            int n = obj.a.Length;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = obj.a[i];
            }
        }

        public bool TestKichThuoc(int k)
        {
            return k > 0 && k < 1000000;
        }

        public void Nhap()
        {
            int n;
            do
            {
                Console.Write("So luong phan tu thuoc khoang [1..1000000] = ");
                int.TryParse(Console.ReadLine(), out n);
                if (!TestKichThuoc(n)) Console.WriteLine("Kiem tra khong hop le, moi nhap lai");
            } while (!TestKichThuoc(n));
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu tai vi tri {0} = ", i);
                int.TryParse(Console.ReadLine(), out a[i]);
            }
        }

        public void TangDan()
        {
            Random rd = new Random();
            int n;
            Console.Write("So luong phan tu = ");
            int.TryParse(Console.ReadLine(), out n);
            a = new int[n];
            a[0] = rd.Next(1, 5);
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + rd.Next(1, 5);
            }
        }

        public int TimTuanTu(int x)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }


        public void Xuat()
        {
            Console.WriteLine(">> So luong phan tu = " + a.Length);
            Console.Write(">> Gia tri cac phan tu trong mang: ");
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
        }

        public int binarySearch(int x)
        {
            int l = 0;
            int r = a.Length - 1;
            while (l >= r)
            {
                int m = 1 + (r - 1) / 2;
                if (a[m] == x) return m;
                if (a[m] < x) l = m + 1;
                else r = m - 1;
            }
            return -1;
        }

        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }

        public void InterchangeSort()
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        HoanVi(ref a[i], ref a[j]);
                    }
                }
            }
        }

        public void BubbleSort()
        {
            int n = a.Length;
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = 0; j <= n - 2; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        HoanVi(ref a[j], ref a[j + 1]);
                    }
                }
            }
        }

        public void SelectionSort()
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                HoanVi(ref a[min], ref a[i]);
            }
        }

        public int Partitioning(int left, int right)
        {
            int chot = a[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;
            while (true)
            {
                do i++; while (a[i] < chot);
                do j--; while (a[j] > chot);
                if (i >= j)
                {
                    return j;
                }
                HoanVi(ref a[i], ref a[j]);
            }
        }

        public void QuickSort(int left, int right)
        {
            if (left < right)
            {
                int partition = Partitioning(left, right);
                QuickSort(left, partition);
                QuickSort(partition + 1, right);
            }
        }

        public void ShellSort()
        {
            int n = a.Length;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i++)
                {
                    int currentValue = a[i];
                    int k = i;

                    while (k >= interval && a[k - interval] > currentValue)
                    {
                        a[k] = a[k - interval];
                        k -= interval;
                    }
                    a[k] = currentValue;
                }
            }
        }

        public void ShakerSort(int left, int right)
        {
            int n = a.Length;
            int k = 0;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        HoanVi(ref a[i], ref a[i + 1]);
                        k = i;
                    }
                }
                right = k;

                for(int i = right; i > left; i--)
                {
                    if(a[i] < a[i-1])
                    {
                        HoanVi(ref a[i], ref a[i - 1]);
                        k = i;
                    }
                }
                left = k;
            }
        }
    }
}
