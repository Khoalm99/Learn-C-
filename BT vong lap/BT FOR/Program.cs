using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_8();
        }
        static void Bai_1()
        {
            Console.WriteLine("Nhập số N nguyên dương: ");
            int n = int.Parse(Console.ReadLine());

            float S1 = 0;
            float S2 = 0;
            float S3 = 0;
            float S4 = 1;
            float S5 = 0;
            float S6 = 0;
            //tính tổng n
            for (int i = 0; i <= n; i++)
            {
                S1 = S1 + i;
            }
            Console.WriteLine("Kết quả S1: " + S1);

            //tính tổng 1/n
            for (float i = 1; i <= n; i++)
            {
                S2 = S2 + 1 / i;
            }
            Console.WriteLine("Kết quả S2: " + S2);
            //tính tổng (n*10 + n) 
            for (float i = 1; i <= n; i++)
            {
                S3 = S3 + (11 * i);
            }
            Console.WriteLine("Kết quả S3: " + S3);
            //tính n!
            for (int i = 1; i <= n; i++)
            {
                S4 = S4 * i;
            }
            Console.WriteLine("Kết quả S4: " + S4);

            //tính 1/(n!)
            float x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
                S5 = S5 + (1 / x);
            }
            Console.WriteLine("Kết quả S5: " + S5);

            //tính 1/(n*(n+1))
            for (float i = 1; i <= n; i++)
            {
                S6 = S6 + (1 / (i * (i + 1)));
            }
            Console.WriteLine("Kết quả S6: " + S6);

        }
        static void Bai_3()
        {
            //Nhập 1 số n
            Console.WriteLine("Nhập số n: ");
            float n = float.Parse(Console.ReadLine());

            //Kiểm tra số nguyên tố nếu N > 0
            bool KQ = true;
            if (n < 2)
            {
                KQ = false;
            }
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    KQ = false;
                    break;
                }
            }
            if (KQ==true)
            {
                Console.WriteLine("{0} là số nguyên tố.", n);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố.", n);
            }

        }
        static void Bai_4()
        {
            
            int n, i, j, thapPhan = 0, dn;
            Console.Write("Nhập 1 số nguyên dương: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                thapPhan = thapPhan + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.WriteLine("So trong he nhi phan tuong duong cua so {0} la {1}.", dn, thapPhan);
        }

        static void Bai_5()
        {
            Console.WriteLine("Nhập số nguyên dương M,N (M>N>0): ");
            Console.WriteLine("Nhập M: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập N: ");
            int n = int.Parse(Console.ReadLine());
            if (m<=n|| n<=0)
            {
                Console.WriteLine("Nhập lại M,N");
            }
            else
            {
                double s1 = 1, s2 = 1, s3 = 1;
                //s1 là giai thừa của m, s2 là giai thừa của n, s3 là giai thừa của m-n
                for (int i = 1; i <= m; i++)
                {
                    s1 = s1 * i;
                }
                for (int j = 1; j <= (m-n); j++)
                {
                    s2 = s2 * j;
                }
                for (int t = 1; t <= n; t++)
                {
                    s3 = s3 * t;
                }
                Console.WriteLine("Tổ hợp chập {0} của {1} là : {2}",m,n,(s1/(s2*s3)));
                Console.WriteLine("Chỉnh hợp là: {0}", s1/s2);

            }
            
        }
        static void Bai_8()
        {
            // Nhap chuoi can chay ngang
            Console.WriteLine("Nhap chuoi: ");
            string ChuoiNgang = Console.ReadLine();

            // Vong lap tang vi tri dong cua con tro chuot
            for (int i = 0; i <= Console.WindowWidth; i++)
            {
                // Xac dinh vi tri ban dau
                Console.SetCursorPosition(i, 0);

                // In chuoi
                Console.WriteLine(ChuoiNgang);

                // Thiet lap thoi gian xuat hien
                System.Threading.Thread.Sleep(5);

                // Xoa man hinh
                Console.Clear();
            }

        }
        static void  bai_9()
        {
            // Nhap chuoi can rot
            Console.Write("Nhap chuoi: ");
            string ChuoiRoi = Console.ReadLine();

            // Vong lap tang vi tri dong cua con tro chuot
            for (int i = 0; i <= Console.WindowHeight; i++)
            {
                // Xac dinh vi tri ban dau
                Console.SetCursorPosition(i, i);

                // In chuoi
                Console.Write(ChuoiRoi);

                // Thiet lap thoi gian xuat hien
                System.Threading.Thread.Sleep(1000);

                // Xoa man hinh
                Console.Clear();
            }

        }
        static void Bai_10()
        {

        }
    }
}
