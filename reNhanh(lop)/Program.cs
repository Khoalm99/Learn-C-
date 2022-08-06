using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurenhanh
{
    class lyThuyet
    {
        static void main(string[] args)
        {
            Vidu2();
            Console.ReadKey();
        }
        static void Vidu1()
        {
            Console.WriteLine("nhap a: ");
            string soa = Console.ReadLine();

            Console.WriteLine("nhap b: ");
            string sob = Console.ReadLine();

            int a = int.Parse(soa);
            int b = int.Parse(sob);

            string kiemtra = (a < b) ? "a nho hon b" : "a lon hon b";

            bool ktra = (a < b); //kiem tra a va b, neu dung chuyen ve true  

            //lenh if
            if (a < b)
            {
                Console.WriteLine("a nho hon b");
            }
            if (a > b)
            {
                Console.WriteLine("a khong nho hon b");
            }

            Console.WriteLine(kiemtra);
            Console.WriteLine(ktra);
            Console.WriteLine(!ktra); // ! => lay phu dinh cua bien 

        }
        static void Vidu2()
        {
            // nhap 1 so + kiem tra chan hoac le
            Console.WriteLine("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            if ((a % 2 == 0) && (a > 0)) //điều kiện của if phải nằm trong giấu ngoặc đơn
            {
                Console.WriteLine("so a la so chan");
            }
            else
            {
                Console.WriteLine("so a la so le");


                //kiểm tra a có lớn hơn 10 không
                if (a > 10)
                {
                    Console.WriteLine("a lon hon 10");
                }
                else
                {
                    Console.WriteLine("a nho hon 10");
                }
            }

        }

        static void Vidu3() //giai phuong trinh ax+b=0
        {
            //nhap vao a va b
            Console.WriteLine("nhap a");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap b");
            float b = float.Parse(Console.ReadLine());

            //nghiem n
            float n;
            //neu a = 0 & b = 0 => pt vô số nghiệm
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else  //nếu a = 0 & b khac 0 => pt vô nghiệm
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            //nếu a khác 0 => x = -b/a
            else
            {
                n = (-b / a);
                Console.WriteLine("nghiem cua phuong trinh la: " + n);
            }
        }

        static void Vidu4()
        {
            //nhap a b c
            Console.WriteLine("nhap a");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap b");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap c");
            float c = float.Parse(Console.ReadLine());

            float x;
            double delta = Math.Pow(b, 2) - 4 * a * c;
            //a = 0 & b = 0 & c = 0 => vô số nghiệm
            //a = 0 & b = 0 & c != 0 => vô nghiệm
            //a = 0 & b != 0 => x = -c/b
            //a != 0 => tinh delta => b^2 -4*ac
            //delta = 0 => x=-b/2a
            //delta < 0 => vo nghiem
            //delta > 0 => (-b + can 2 delta) / 2a &&& (-b - can 2 delta) / 2a
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine("nghiem cua x la " + x);
                }
            }
            else
            {

                if (delta == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine("phuong trinh co nghiem kep:" + x);
                }
                else
                {
                    if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a); //(-b + can 2 delta) / 2a
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("nghiem 1 cua phuong trinh la {0}, nghiem 2 cua phuong trinh la {1} ", x1, x2);
                    }
                    else //(delta < 0)  
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
            }
        }


        static void Vidu5()//su dung switch case de in các thứ trong tuần
        {
            Console.WriteLine("nhap so thu (2-8)");
            int thu = int.Parse(Console.ReadLine());
            //ừng với từng case sẽ in ra chữ tương ứng
            switch (thu)
            {
                case 2:
                    Console.WriteLine("monday");  //trường hợp thu = 2 => monday
                    break; //báo kiểm tra xong
                case 3: Console.WriteLine("tuseday"); break;
                case 4: Console.WriteLine("wednesday"); break;
                case 5: Console.WriteLine("thursday"); break;
                case 6: Console.WriteLine("friday"); break;
                case 7: Console.WriteLine("saturday"); break;
                case 8: Console.WriteLine("sunday"); break;
                //nếu không rơi vào các trường hợp trên => chạy default
                default: Console.WriteLine("nhap sai"); break;
            }

            Console.WriteLine("Nhap thang: "); ;
            int thang = int.Parse(Console.ReadLine());

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("thang co 31 ngay");
                    break;
                case 2:
                    Console.WriteLine("thang co 28 hoac 29 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("thang co 31 ngay");
                    break;
            }

        }

    }
 
}






