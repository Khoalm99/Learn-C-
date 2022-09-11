using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BT_1();

        }
        static void BT_1()
        {
            Console.Write("Nhập vào số phần tử n của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int max, min;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            max = a[0];
            min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min > a[i])
                {
                    min = a[i];
                }

            }
            Console.WriteLine("So lon nhat: " + a.Max());
            Console.WriteLine("So nho nhat: " + a.Min());
        }
        static void BT_2()
        {
            Console.Write("Nhập vào số phần tử n của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int kq = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhập số nguyên X: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                kq = 2;
                if (x == a[i])
                {
                    kq = 1;
                    break;
                }

            }
            if (kq == 1)
            {
                Console.WriteLine("X thuộc mảng");
            }
            else
            {
                Console.WriteLine("X không thuộc mảng");

            }

        }
        static void BT_3()
        {
            Console.Write("Nhập vào số phần tử n của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhập số nguyên X: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {

                if (x == a[i])
                {

                    Console.WriteLine("Phần tử {0} trong mảng có giá trị bằng X: ", i);
                }
            }

        }
       
        static void BT_5()
        {
            Console.WriteLine("Nhập vào số phần tử n của mảng");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //Mảng trước sắp xếp
            Console.WriteLine();
            Console.WriteLine("Mảng được nhập");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            //Mảng sau sắp xếp tăng dần
            Console.WriteLine();
            Array.Sort(a);
            Console.WriteLine("Mảng tăng dần:");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            //Mảng sau sắp xếp giảm dần
            Console.WriteLine();
            Array.Reverse(a);
            Console.WriteLine("Mảng giảm dần:");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
        static void BT_6()
        {
            Console.WriteLine("Nhập vào số phần tử n của mảng");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write("Nhap phan tu {0}: ", k);
                a[k] = int.Parse(Console.ReadLine());
            }

            int soAM = 0, soDUONG = 0, tongAM = 0, tongDUONG = 0;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] < 0)
                {
                    soAM++;
                    tongAM = tongAM + a[i];
                }
                else
                {
                    continue;
                }
                
            }

            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] > 0)
                {
                    soDUONG++;
                    tongDUONG = tongDUONG + a[j];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Số số ÂM: {0} số",soAM);
            Console.WriteLine("Tổng các số ÂM: {0}",tongAM);
            Console.WriteLine("Số số DƯƠNG: {0} số", soDUONG);
            Console.WriteLine("Tổng các số DƯƠNG: {0}", tongDUONG);


        }


        static void BT_7()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Nhập vào số phần tử dãy Fibonacci: ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Cần nhập số phần tử lớn hơn 2: ");
            }
            else
            {
                Console.Write("Day Fibonacci: " + firstNumber + " " + SecondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }
        static void BT_8()
        {
            Console.Write("Nhập Tháng: ");
            int n = int.Parse(Console.ReadLine());

            string[] DoM = { "31", "28 hoặc 29", "31", "30", "31", "30", "31", "31", "30", "31","30","31" };
            Console.WriteLine(DoM[DoM.Length - 1]);

        }

    }
}

