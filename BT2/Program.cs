using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai14();
            void Bai9()
            {
                //Nhap vao ho va ten nguoi nhan
                Console.WriteLine("Ten nguoi nhan - Ho:  ");
                string hoNguoiNhan = Console.ReadLine();


                Console.WriteLine("Ten nguoi nhan - Ten va chu lot:  ");
                string tenNguoiNhan = Console.ReadLine();

                //Nhap vo ho va ten nguoi gui 
                Console.WriteLine("Ten nguoi gui - Ho:  ");
                string hoNguoiGui = Console.ReadLine();

                Console.WriteLine("Ten nguoi gui - Ten va chu lot:  ");
                string tenNguoiGui = Console.ReadLine();


                //Viet la thu 
                Console.WriteLine("Than goi {0} {2}, " +
                    "\n Nhan dip sinh nhat cua {2}, cho phep {3} gui den {2} nhung loi chuc tot dep nhat ve suc khoe, hanh phuc va thanh cong trong moi linh vuc" +
                    "\n Gui loi hoi tham suc khoe hai bac cua {2}" +
                    "\n Ban cua {2}" +
                    "\n {1} {3}" +
                    "\n Ba ma {3} thuong nhac den {2} luon", hoNguoiNhan, hoNguoiGui, tenNguoiNhan, tenNguoiGui);

            }
            void Bai10()
            {
                //Nhap so tien gui 
                Console.WriteLine("Số tiền ban muon gui la (VND): ");
                string tienGui = Console.ReadLine();
                int tien = int.Parse(tienGui);


                //Nhap lai suat hang nam
                Console.WriteLine("Lai suat hien tai cua ngan hang tren 1 nam (%): ");
                string laiSuat = Console.ReadLine();
                float ls = float.Parse(laiSuat);

                //Nhap thoi gian muon gui 
                Console.WriteLine("Thoi gian muon gui (nam): ");
                string thoiGian = Console.ReadLine();
                float tg = float.Parse(thoiGian);


                ////Nếu thời han lon hon 9 thang thi lai suat +0.2%
                //ls = (float)((tg > 0.75) ? (ls + 0.2) : ls);


                //Neu thoi han lon hon 9 va <12 thi lai suat +0.2%, >=12 thì +0.3%
                ls = (float)((tg > 0.75 && tg < 12) ? (ls + 0.2): ((tg >=12) ? (ls+0.3) :ls));

                //Tinh tong lai~      
                float lai = (float)((ls / 100) * tien * tg);
                double tong = lai + tien;

                
                //Xuat so tien lai nguoi gui nhan duoc
                Console.WriteLine("So tien nguoi gui nhan duoc (gom ca goc + lai~) la: " + tong + " VND");
                Console.WriteLine("Trong do so tien lai~ la: " + lai + " VND");
                Console.WriteLine("Lãi suất là: "+ ls);                  
            }
            void Bai11()
            {
                //Ten khach hang
                Console.WriteLine("Ten khach hang: ");
                String name = Console.ReadLine();

                //So ngay o
                Console.WriteLine("So ngay o: ");
                String soNgayO = Console.ReadLine();
                int day = int.Parse(soNgayO);

                //So bua an
                Console.WriteLine("So bua an: ");
                String soBuaAn = Console.ReadLine();
                int meal = int.Parse(soBuaAn);

                //Chi phi phong trong 1 ngay 
                Console.WriteLine("Chi phi 1 dem tai khach san la: ");
                String gia1Dem = Console.ReadLine();
                float priceRoom = float.Parse(gia1Dem);

                //Chi phi 1 bua an 
                Console.WriteLine("Chi phi 1 bua an tai khach san la: ");
                String gia1An = Console.ReadLine();
                float priceMeal = float.Parse(gia1An);

                //Tong tien phong
                float room = priceRoom * day;

                //Tong tien an
                float eat = priceMeal * day;

                //Phi phuc vu
                Console.WriteLine("Chi phi phuc vu: ");
                String phucVu = Console.ReadLine();
                float service = float.Parse(phucVu);

                //Tong chi phi
                float total = room + eat + service;

                //Xuat ket qua
                Console.WriteLine(String.Format("{0,-20}", "Khach san Five Stars"));
                Console.WriteLine(String.Format("{0,-20}|{1,-20}", "So ngay o: " + soNgayO, "So bua an: " + soBuaAn));
                Console.WriteLine(String.Format("{0,-20}|{1,-20}|{2,-20}", "Tien o: " + room, "Tien an: " + eat, "Phi phuc vu: " + service));
                Console.WriteLine(String.Format("{0,-20}", "Tong cong: " + total));

                

            }
            void Bai12()
            {
                //Nhap so nguyen X
                Console.WriteLine("Nhap so nguyen X: ");
                String soX = Console.ReadLine();
                int X = int.Parse(soX); 

                
                //Dong 1
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10} {3,-10} {4,-15}", "N", "N*N", "1/N", "Can bac 2", "Can bac 4"));

                //Chay (X) toi (X + 20)
                for (float i = X; i <= X + 20; i++)
                {
                    //Cot 
                    float mu2 = (float)Math.Pow(i,2);
                    float chia = 1/i;
                    float can2 = (float)Math.Sqrt(i);
                    float can4 = (float)Math.Pow(i, (float)1/4);

                    Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10} {3,-10} {4:0.##,-15}", i , mu2, chia, can2, can4));
                    //làm tròn 2 chữ số thập phân math.round , {4:0.##}               
                }
                    
            }

            void Bai13()
            {
                //Nhap so lon nhớt
                Console.WriteLine("So Lon Nhot can mua: ");
                string soLon = Console.ReadLine();
                int X = int.Parse(soLon);

                //Số nón
                float non;


                //Số viết
                float viet;

                //Số lon nhớt dư
                float phanDu = (float)(X % 3);
                

                //3 lon nhớt => 1 cái nón
                if (phanDu == 0)
                {
                    non = X / 3;
                }
                else  viet = 0;
                //Dư 1 => 2 cây viết
                if (phanDu == 1)
                {
                    non = X / 3;
                    viet = (X % 3) * 2;
                }
                //Dư 2 => 4 cây viết
                else
                {
                    non = X / 3;
                    viet = (X % 3) * 2;
                }
                 
                
                //Giá 1 lon nhớt 
                Console.WriteLine("Gia 1 lon nhot: ");
                string gia1Lon = Console.ReadLine();
                int A = int.Parse(gia1Lon);

                //Số tiền khách trả
                int price = X * A;


                //Số quà được thưởng
                Console.WriteLine("So non duoc thuong la: " + non);
                Console.WriteLine("So viet duoc thuong la: " + viet);

                //Xuat ket qua
                Console.WriteLine("So tien khach phai tra la: " + price);
             
            }
            void Bai14()
            {
                NhapLieu:///dán nhãn
                Console.WriteLine("Nhập số nguyên X: ");
                int X;

                
                //báo lỗi khi nhập sai dạng biến
                try ///các việc cần kiểm tra
                {
                    X = int.Parse(Console.ReadLine());
                }
                catch (Exception e)/// Nếu phát hiện lỗi thì làm các lệnh này
                {
                    Console.WriteLine("Vui lòng nhập số nguyên");
                    goto NhapLieu; ///khi gặp lỗi quay trở lại vị trí NhapLieu 

                }

                Console.WriteLine("Số nguyên là : "+ X);
                Console.WriteLine("\t lafjeijfoaweivn" +  "\t sdlfjhuef");
                Console.WriteLine(String.Format("{0,-5} , {1,-10} , {2,5}", "Bill", "Gates", 51));
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
            }
        }
    }
}
