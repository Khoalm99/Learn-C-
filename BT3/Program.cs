using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class BTVN_3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_5();
            
        }
        static void Bai_1()
        {
            //Viết Phương trình bậc 2 
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
        static void Bai_2()
        {
            //Viết vào họ tên bất kỳ 
            Console.WriteLine("Nhập vào HỌ của bạn (Không dấu): ");
            string ho = Console.ReadLine();
            string h = ho.ToUpper();
            Console.WriteLine("Nhập vào TÊN LÓT của bạn (Không dấu): ");
            string lot = Console.ReadLine();
            string l = lot.ToUpper();
            Console.WriteLine("Nhập vào TÊN của bạn (Không dấu): ");
            string ten = Console.ReadLine();
            string t = ten.ToUpper();


            if (l.Contains(" THI ")|| l.Contains(" THI")||l.Contains("THI "))
            {
                Console.WriteLine("Tên của bạn là {0} {1} {2}. Dựa theo tên, bạn là nữ",h,l,t);
            }
            else
            {
                Console.WriteLine("Tên của bạn là {0} {1} {2}. Dựa theo tên, bạn có thể là nam hoặc nữ", h,l,t);
            }
        }
        static void Bai_3()
        {
            //Nhập phép toán bạn muốn sử dụng
            Console.WriteLine("Giả lập máy tính");
            Console.WriteLine("Nhập (cong) nếu bạn muốn sử dụng phép cộng" +
                "\nNhập (tru) nếu bạn muốn sử dụng phép trừ" +
                "\nNhập (nhan) nếu bạn muốn sử dụng phép nhân" +
                "\nNhập (chia) nếu bạn muốn sử dụng phép chia" +
                "\nNhập (can) nếu bạn muốn sử dụng phép tính căn bậc 2" +
                "\n****Lưu ý, nhập không dấu****" );
            string toanTu = Console.ReadLine();
            
            
            //Phép cộng, trừ, nhân, chia
            if (toanTu == "cong"|| toanTu == "tru"||toanTu == "nhan"||toanTu == "chia"||toanTu == "chia")
            {
                Console.WriteLine("Nhập số thứ I: ");
                float so1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Nhập số thứ II: ");
                float so2 = float.Parse(Console.ReadLine());

                
                if (toanTu == "cong")
                {
                    float so3 = so1 + so2;
                    Console.WriteLine("Kết quả: " + so3);
                }
                if (toanTu == "tru")
                {
                    float so3 = so1 - so2;
                    Console.WriteLine("Kết quả: " + so3);
                }
                if (toanTu == "nhan")
                {
                    float so3 = so1 * so2;
                    Console.WriteLine("Kết quả: " + so3);
                }
                if (toanTu == "chia")
                {
                    float so3 = so1 / so2;
                    Console.WriteLine("Kết quả: " + so3);
                }

            }
            else 
            {
                if (toanTu == "can")
                {
                    Console.WriteLine("Nhập số cần lấy căn bậc 2: ");
                    double soX = double.Parse(Console.ReadLine());
                    double soY = Math.Sqrt(soX);
                    Console.WriteLine("Kết quả căn bậc 2 của {0} là: {1}", soX, soY);
                }
                else
                {
                    Console.WriteLine("Nhập sai");
                }
                
            }
            
        }
        static void Bai_4()
        {
            //giải hệ phương trình
            //Giải bằng định thức

            //d = a1 * b2 - a2 * b1;
            //dx = c1 * b2 - c2 * b1;
            //dy = a1 * c2 - a2 * c1;
            //+) d # 0 - có nghiệm duy nhất
            //x = dx / d;
            //y = dy / d;
            //+) dx = 0 và d = 0 - vô số nghiệm
            //+) d = 0 và dx # 0 - vô nghiệm

            //Nhập hệ số a1*x +b1*y =c1
            Console.WriteLine("Nhập hệ số a1: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b1: ");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c1: ");
            float c1 = float.Parse(Console.ReadLine());


            //Nhập hệ số a2*x +b2*y =c2
            Console.WriteLine("Nhập hệ số a2: ");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b2: ");
            float b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c2: ");
            float c2 = float.Parse(Console.ReadLine());

            float d = a1 * b2 - a2 * b1;
            float dx = c1 * b2 - c2 * b1;
            float dy = a1 * c2 - a2 * c1;


            if (d==0)
            {
                if (dx==0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            else
            {
                float x = dx / d;
                float y = dy / d;
                Console.WriteLine("Phương trình có nghiệm duy nhất ({0},{1})",x,y);
            }

        }
        static void Bai_5()
        {
            //Nhập lựa chọn người chơi 
            Console.WriteLine("Oẳn tù xì ra cái gì ra cái này: ");
            Console.WriteLine("***Nhập lựa chọn của bạn (keo), (bua) hoặc (bao)");
            string nguoiChoi = Console.ReadLine();
            string player = nguoiChoi.ToUpper();
           

            var random = new Random();
            var list = new List<string> {"BUA", "KEO", "BAO"}; //Tạo list lựa chọn
            int com = random.Next(list.Count); //chọn random trong list

            int result;
            //người chơi thắng => result = 2 
            //người chơi hòa => result = 1 
            //người chơi thua => result = 0

            Console.WriteLine("Bạn ra: " + player);
            Console.WriteLine("Máy tính ra: " + list[com]);

            if (list[com] == "BUA")
            {
                if (player == "KEO")
                {
                    result = 0;
                    Console.WriteLine("Bạn THUA máy tính");
                }
                else
                {
                    if (player == "BAO")
                    {
                        result = 2;
                        Console.WriteLine("Bạn THẮNG máy tính");
                    }
                    else
                    {
                        result = 1;
                        Console.WriteLine("Bạn HÒA máy tính");
                    }
                }
            }
            if (list[com] == "KEO")
            {
                if (player == "BAO")
                {
                    result = 0;
                    Console.WriteLine("Bạn THUA máy tính");
                }
                else
                {
                    if (player == "BUA")
                    {
                        result = 2;
                        Console.WriteLine("Bạn THẮNG máy tính");

                    }
                    else
                    {
                        result = 1;
                        Console.WriteLine("Bạn HÒA máy tính");
                    }
                }
            }
            if (list[com] == "BAO")
            {
                if (player == "BUA")
                {
                    result = 0;
                    Console.WriteLine("Bạn THUA máy tính");
                }
                else
                {
                    if (player == "KEO")
                    {
                        result = 2;
                        Console.WriteLine("Bạn THẮNG máy tính");
                    }
                    else
                    {
                        result = 1;
                        Console.WriteLine("Bạn HÒA máy tính");
                    }
                }
            }

        }
        static void Bai_6()
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so d: ");
            int d = int.Parse(Console.ReadLine());

            int max1, min1, tmp1;
            int max2, min2, tmp2;

            if (a > b)
            {
                tmp1 = a; 
                a = b;
                b = tmp1;
            }

            max1 = b;
            min1 = a;
            
            if (c > d)
            {
                tmp2 = c; 
                c = d;
                d = tmp2;
            }
            
            max2 = d;
            min2 = c;

            if (max1 > max2)
            {
                Console.WriteLine("Số lớn nhất là: "+max1);
            }
            else
            {
                Console.WriteLine("Số lớn nhất là: "+max2);
            }
            
            if (min1 < min2)
            {
                Console.WriteLine("Số bé nhất là: "+min1);
            }
            else
            {
                Console.WriteLine("Số bé nhất là: "+min2);
            }

        }
        static  void Bai_7()
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so d: ");
            int d = int.Parse(Console.ReadLine());

            int max1, min1, tmp1;
            int max2, min2, tmp2;

            if (a > b)
            {
                tmp1 = a;
                a = b;
                b = tmp1;
            }
            //string cap1 = a.ToString() + b.ToString(); //in chuỗi
            max1 = b;
            min1 = a;
            

            if (c > d)
            {
                tmp2 = c;
                c = d;
                d = tmp2;
            }
            //string cap2 = c.ToString() + d.ToString(); //in chuỗi
            max2 = d;
            min2 = c;

            if (max1> max2)
            {
                if (min2>min1)
                {
                    string chuoi = max1.ToString() +" "+ max2.ToString()+ " " + min2.ToString() +" "+ min1.ToString();
                    Console.WriteLine("Chuỗi số theo thứ tự giảm dần là: " + chuoi);
                }
                else
                {
                    string chuoi = max1.ToString() + " " + max2.ToString() + " " + min1.ToString() + " " + min2.ToString();
                    Console.WriteLine("Chuỗi số theo thứ tự giảm dần là: " + chuoi);
                }
            }
            else
            {
                if (min2 > min1)
                {
                    string chuoi = max2.ToString() + " " + max1.ToString() + " " + min2.ToString() + " " + min1.ToString();
                    Console.WriteLine("Chuỗi số theo thứ tự giảm dần là: " + chuoi);
                }
                else
                {
                    string chuoi = max2.ToString() + " " + max1.ToString() + " " + min1.ToString() + " " + min2.ToString();
                    Console.WriteLine("Chuỗi số theo thứ tự giảm dần là: " + chuoi);
                }
            }

        }
        static void Bai_8()
        {
            Console.WriteLine("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            if ((a % 2 == 0) && (a > 0))
            {
                Console.WriteLine("so a la so chan");
            }
            else
            {
                Console.WriteLine("so a la so le");
            }
        }
        static void Bai_9()
        {//N có là bội số của 3 và 5 không 
            Console.WriteLine("Nhap N: ");
            float n = float.Parse(Console.ReadLine());

            if (n%5==0)
            {
                if (n%3==0)
                {
                    Console.WriteLine("N là bội số của 3 và 5");
                }
                else
                {
                    Console.WriteLine("N là bội số của 5");
                }
            }
            else
            {
                if (n%3==0)
                {
                    Console.WriteLine("N là bội số của 3");
                }
                else
                {
                    Console.WriteLine("N không là bội số của 3 và 5");
                }
            }

        }
        static void Bai_10()
        {
            //Giải Phương trình bậc 2  => lấy thêm 2 giá trị căn
            //nhap a b c
            Console.WriteLine("Giải phương trình trùng phương");
            Console.WriteLine("nhap a");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap b");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap c");
            float c = float.Parse(Console.ReadLine());

            double x;
            double x0;
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
                    if (x >= 0)
                    {
                        x0 = Math.Sqrt(x);
                        double x1 = x0;
                        double x2 = -x0;
                        Console.WriteLine("nghiem 1 cua phuong trinh la {0}, nghiem 2 cua phuong trinh la {1} ", x1, x2);
                    }
                    else
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
            }
            else
            {

                if (delta == 0)
                {
                    x = -b / (2 * a);
                    if (x>=0)
                    {
                        x0 = Math.Sqrt(x);
                        double x1 = x0;
                        double x2 = -x0;
                        Console.WriteLine("nghiem 1 cua phuong trinh la x1 = {0}, nghiem 2 cua phuong trinh la x2 = {1} ", x1, x2);
                    }
                    else
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
                else
                {
                    if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a); //(-b + can 2 delta) / 2a
                        
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        double x01 = Math.Sqrt(x1);
                        double x02 = Math.Sqrt(x2);

                        if (x01>0)
                        {
                            if (x02>0)
                            {
                                double x011 = x01;
                                double x012 = -x01;
                                double x021 = x02;
                                double x022 = -x02;
                                Console.WriteLine("Phương trình có 4 nghiệm x1 = {0}, x2 = {1}, x3 = {2}, x4 = {3}",x011,x012,x021,x022);
                            }
                            else
                            {
                                double x011 = x01;
                                double x012 = -x01;
                                Console.WriteLine("Phương trình có 2 nghiệm x1 = {0}, x2 = {1}", x011, x012);
                            }
                        }
                        else
                        {
                            if (x02 > 0)
                            {
                                double x021 = x02;
                                double x022 = -x02;
                                Console.WriteLine("Phương trình có 2 nghiệm x1 = {0}, x2 = {1}", x021, x022);
                            }
                            else
                            {
                                Console.WriteLine("Phương trình vô nghiệm");
                            }
                        }

                    }
                    else //(delta < 0)  
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                }
            }

        }
    }
}

