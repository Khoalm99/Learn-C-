using System;
class Baitap_1
{
    static void Main(string[] args)
    {
        //Nhap vao ban kinh
        Console.WriteLine("Nhap ban kinh cua hinh tron: ");
        String bankinh = Console.ReadLine();
        float R = float.Parse(bankinh);

        //Tinh chu vi hinh tron
        float P = (float)(2 * R * Math.PI);

        //Tinh dien tich hinh tron
        float S = (float)(R * R * Math.PI);

        //Xuat ket qua
        Console.WriteLine("Dien tich cua hinh tron la: " + S);
        Console.WriteLine("Chu vi cua hinh tron la: " + P);
        Console.ReadKey();

    }
}
class Baitap_2
{
    static void Main(string[] args)
    {
        //so ngay cong
        Console.WriteLine("So ngay cong cua cong nhan la: ");
        String sngaycong = Console.ReadLine();

        //So con cua cong nhan
        Console.WriteLine("So nguoi con cua cong nhan la: ");
        String socon = Console.ReadLine();

        //tinh so tien luong ngay cong X
        int nc = int.Parse(sngaycong);
        int X = nc * 100000;

        //tinh so tien phu cap Y
        int sc = int.Parse(socon);
        int Y = sc * 150000;

        //So tien dong bhxh Z
        int Z = (15 / 100) * X;

        //tong so tien luong S = X+Y-Z
        int S = X + Y - Z;

        //Xuat ra ket qua
        Console.WriteLine("So tien luong ngay cong la: " + X);
        Console.WriteLine("So tien phu cap la: " + Y);
        Console.WriteLine("So tien bao hiem phai dong la: " + Z);
        Console.WriteLine("Tong so tien luong nhan duoc la: " + S);
    }
}
class Baitap_3
{
    static void Main(string[] args)
    {
        //Nhap diem thi 3 mon Toan, Ly, Hoa
        Console.WriteLine("So diem thi mon Toan la: ");
        String toan = Console.ReadLine();
        Console.WriteLine("So diem thi mon Ly la: ");
        String ly = Console.ReadLine();
        Console.WriteLine("So diem thi mon Hoa la: ");
        String hoa = Console.ReadLine();

        float x = float.Parse(toan);
        float y = float.Parse(ly);
        float z = float.Parse(hoa);

        //tong so diem
        float S = x + y + z;

        //Diem trung binh
        float P = S / 3;

        Console.WriteLine("Tong so diem 3 mon la: " + S);
        Console.WriteLine("Diem trung binh 3 mon la: " + P);

    }
}
class Baitap_4
{
    static void Main(string[] args)
    {
        //Nhap 2 canh vuong cua tam giac
        Console.WriteLine("Chieu dai canh vuong thu nhat la: ");
        String c1 = Console.ReadLine();
        Console.WriteLine("Chieu dai canh vuong thu nhat la: ");
        String c2 = Console.ReadLine();

        float a = float.Parse(c1);
        float b = float.Parse(c2);

        //Xac dinh canh huyen
        float c = (a * a) + (b * b);
        float ch = (float)Math.Sqrt(c);

        //Xác dinh chu vi
        float P = a + b + ch;

        //Xac dinh dien tich
        float S = (a * b) / 2;

        //Xuat ket qua
        Console.WriteLine("Chieu dai canh huyen la: " + ch);
        Console.WriteLine("Chu vi hinh tam giac la: " + P);
        Console.WriteLine("Dien tich hinh tam giac la: " + S);

    }

}
class Baitap_5
{
    static void Main(string[] args)
    {
        //Nhap vao canh hinh vuong
        Console.WriteLine("Nhap vao canh a hinh vuong: ");
        String canh = Console.ReadLine();

        //Tinh chu vi hinh vuong (cv hinh vuong = cv hinh tron)
        float a = float.Parse(canh);
        float P = 4 * a;

        //Xac dinh dc ban kinh R hinh tron
        float R = (float)(P / (2 * Math.PI));

        //Xuat ket qua R
        Console.WriteLine("Vay ban kinh R de co duoc chu vi hinh tron bang voi chu vi hinh vuong canh a la: " + R);
    }
}



