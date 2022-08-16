using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VD8();
        }


        static void VD1()
        {
            Console.WriteLine("Nhập N");
            int n = int.Parse(Console.ReadLine());
            double k = 1;
            for (int i = 1; i <= n; i++)
            {
                k = k * i;
            }
            Console.WriteLine("Giá trị {0}! = {1}", n, k);
        }
        static void VD2()
        {
            //vòng lặp for phức tạp 
            for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
            //chèn được biểu thức trong for()
            {
                Console.WriteLine("i={0}, sum={1}", i, sum);
            }

        }
        static void VD3()
        {
            // nhập n và m. Tính n mũ m
            Console.WriteLine("Nhập n");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập m");
            double kq = 1;
            float m = float.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                kq = kq * n;
                Console.WriteLine("i = " + i);
                Console.WriteLine("Kết quả {0}", kq);
            }
        }
        static void VD4()
        {
            //tạo 1 bảng cửu chương 
            Console.WriteLine("Bảng cửu chương n, Nhập n : ");
            int n = int.Parse(Console.ReadLine());
            double kq = 1;
            for (int i = 0; i <= 10; i++)
            {
                kq = i * n;
                Console.WriteLine("{0} x {1} = {2}", n, i, kq);
            }


        }
        static void VD5()
        {
            //cho chữ rơi từ đỉnh xuống đáy màn hình 
            Console.WriteLine("Nhập chữ ");
            string chu = Console.ReadLine();
            for (int i = 0; i <= Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, i);//vị trí con trỏ chuột, chính giữa, dòng thứ i
                Console.WriteLine(chu);
                System.Threading.Thread.Sleep(200);//thiết lập thời gian xuất hiện
                Console.Clear();
            }

        }
        static void VD6()
        {
            //In tam giác pascal 
            Console.WriteLine("Nhập n ");
            float n = float.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" " + j);
                }

                Console.WriteLine();
                System.Threading.Thread.Sleep(200);//thiết lập thời gian xuất hiện

            }
        }
        static void VD7()
        {
            Console.WriteLine("Nhập số con: ");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số chân: ");
            float m = float.Parse(Console.ReadLine());
            //x - số con gà ; x max = m/2; 
            //y - số con bò; y max = m/4 ;
            //x+y= n

            for (int x = 1; x < m; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    if ((x + y == n) && ((2 * x) + (4 * y) == m))
                    {
                        Console.WriteLine("Số gà " + x);
                        Console.WriteLine("Số bò " + y);
                    }
                }
            }

        }
        static void VD8()
        {
            //Đàn trâu
            Console.WriteLine("Tổng số trâu: ");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Số bó cỏ: ");
            float m = float.Parse(Console.ReadLine());
            //x - số trâu đứng; ăn 5 bó
            //y - số trâu nằm; ăn 3 bó
            //z - trâu già = 3 con 1 bó 


        }
    }
}
