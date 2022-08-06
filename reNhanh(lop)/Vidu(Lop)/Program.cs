using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Lop_
{
    class BTtailop
    {
        static void Main(string[] args)
        {
            BT_4();
            Console.ReadKey();
        }
        static void BT_1()
        {
            Console.WriteLine("Nhap so X1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so X2: ");
            int x2 = int.Parse(Console.ReadLine());

            if (x1 > x2)
            {
                //Đảo giá trị x1 và x2
                int tmp = x1;
                x1 = x2;
                x2 = tmp;
            }
            Console.WriteLine("X1 = {0}, X2 = {1}", x1, x2);
        }
        static void BT_2()
        {
            Console.WriteLine("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            float c = float.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Duong");
                    }
                    else
                    {
                        Console.WriteLine("Am");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Am");
                    }
                    else
                    {
                        Console.WriteLine("Duong");
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Am");
                    }
                    else
                    {
                        Console.WriteLine("Duong");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Duong");
                    }
                    else
                    {
                        Console.WriteLine("Am");
                    }
                }
            }

        }
        static void BT_3()
        {
            Console.WriteLine("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            float c = float.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    if (a < c)
                    {
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                }
            }
            else // a < b
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }

        static void BT_4()
        {
            Console.WriteLine("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            float c = float.Parse(Console.ReadLine());

            float max = a;

            if (a < b)
            {
                max = b;
                if (b < c)
                {
                    max = c;
                }
                else
                {
                    max = b;

                }

            }

        }
        static void BT_5()
        {

        }
        static void BT_6()
        {

        }
    }
}
