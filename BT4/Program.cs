using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            BaiTapTaiNha();
            //vidu();
            
        }
        static void BaiTapTaiNha()
        {
        Start:

            Console.WriteLine("\n");
            Console.WriteLine("****************");
            //Nhập năm sinh người Nam, Nữ

            int x, y;

            try //Kiểm tra định dạng
            {
                Console.WriteLine("Nhập năm sinh của Nam: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập năm sinh của Nữ: ");
                y = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("NHẬP SAI, NHẬP LẠI");
                goto Start;
            }

            //Số năm phải >0
            if (x <= 0 || y <= 0)
            {
                Console.WriteLine("Số năm phải lớn hơn 0, NHẬP SAI, NHẬP LẠI");
                goto Start;
            }

            // a Tính "Can"
            float a1 = x % 10;
            float a2 = y % 10;

            
            // b Tính "Chi"     ///2 chữ số cuối
            int b1 = x%12;
            int b2 = y%12;

            //xác định CAN của NAM 
            string canNAM = "", chiNAM = "", canNU = "", chiNU = "";
            
            
            switch (a1)
            {
                case 0: canNAM = ("Canh"); break;
                case 1: canNAM = ("Tân"); break;
                case 2: canNAM = ("Nhâm"); break;
                case 3: canNAM = ("Quý"); break;
                case 4: canNAM = ("Giáp"); break;
                case 5: canNAM = ("Ất"); break;
                case 6: canNAM = ("Bính"); break;
                case 7: canNAM = ("Đinh"); break;
                case 8: canNAM = ("Mậu"); break;
                case 9: canNAM = ("Kỷ");  break; 
            }       
                    //xác định CHI của NAM 
                    switch (b1)
                    {
                        case 4: chiNAM = ("Tý"); break;
                        case 5: chiNAM = ("Sửu"); break;
                        case 6: chiNAM = ("Dần"); break;
                        case 7: chiNAM = ("Mão"); break;
                        case 8: chiNAM = ("Thìn"); break;
                        case 9: chiNAM = ("Tỵ"); break;
                        case 10: chiNAM = ("Ngọ"); break;
                        case 11: chiNAM = ("Mùi"); break;
                        case 0: chiNAM = ("Thân"); break;
                        case 1: chiNAM = ("Dậu"); break;
                        case 2: chiNAM = ("Tuất"); break;
                        case 3: chiNAM = ("Hợi"); break;
                           
                    }

            //xác định CAN của NỮ 
            switch (a2)
            {
                case 0: canNU = ("Canh"); break;
                case 1: canNU = ("Tân"); break;
                case 2: canNU = ("Nhâm"); break;
                case 3: canNU = ("Quý"); break;
                case 4: canNU = ("Giáp"); break;
                case 5: canNU = ("Ất"); break;
                case 6: canNU = ("Bính"); break;
                case 7: canNU = ("Đinh"); break;
                case 8: canNU = ("Mậu"); break;
                case 9: canNU = ("Kỷ");  break; 
            }       
                    //xác định CHI của NỮ 
                    switch (b2)
                    {
                        case 4: chiNU = ("Tý"); break;
                        case 5: chiNU = ("Sửu"); break;
                        case 6: chiNU = ("Dần"); break;
                        case 7: chiNU = ("Mão"); break;
                        case 8: chiNU = ("Thìn"); break;
                        case 9: chiNU = ("Tỵ"); break;
                        case 10: chiNU = ("Ngọ"); break;
                        case 11: chiNU = ("Mùi"); break;
                        case 0: chiNU = ("Thân"); break;
                        case 1: chiNU = ("Dậu"); break;
                        case 2: chiNU = ("Tuất"); break;
                        case 3: chiNU = ("Hợi"); break;
                           
                    }
            Console.WriteLine("Tuổi của Nam là: {0} {1} ",canNAM,chiNAM);
            Console.WriteLine("Tuổi của Nữ là: {0} {1} ",canNU,chiNU);



            switch (chiNAM)
            {
                case ("Tý"):
                    switch (chiNU)
                    {
                        case ("Thân"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Thân - Tý - Thìn");break; 
                        case ("Thìn"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Thân - Tý - Thìn");break;
                        case ("Ngọ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Mão"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Dậu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                    }

                    break;

                case ("Sửu"):
                    switch (chiNU)
                    {
                        case ("Tỵ"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Tỵ - Sửu - Dậu");break; 
                        case ("Dậu"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Tỵ - Sửu - Dậu");break;
                        case ("Thìn"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Tuất"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Mùi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                    }

                    break;

                case ("Dần"):
                    switch (chiNU)
                    {
                        case ("Ngọ"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Dần - Ngọ - Tuất");break; 
                        case ("Tuất"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Dần - Ngọ - Tuất");break;
                        case ("Thân"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Tỵ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Hợi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                    }

                    break;
                
                case ("Mão"):
                    switch (chiNU)
                    {
                        case ("Hợi"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Hợi - Mão - Mùi");break; 
                        case ("Mùi"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Hợi - Mão - Mùi");break;
                        case ("Tý"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Ngọ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Dậu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                    }

                    break;
                
                case ("Thìn"):
                    switch (chiNU)
                    {
                        case ("Thân"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Thân - Tý - Thìn");break; 
                        case ("Tý"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Thân - Tý - Thìn");break;
                        case ("Tuất"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Sửu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Mùi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                    }

                    break;
                
                case ("Tỵ"):
                    switch (chiNU)
                    {
                        case ("Sửu"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Tỵ - Sửu - Dậu");break; 
                        case ("Dậu"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Tỵ - Sửu - Dậu");break;
                        case ("Dần"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Thân"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Hợi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                    }

                    break;
                
                case ("Ngọ"):
                    switch (chiNU)
                    {
                        case ("Dần"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Dần - Ngọ - Tuất");break; 
                        case ("Tuất"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Dần - Ngọ - Tuất");break;
                        case ("Tý"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Mão"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Dậu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                    }

                    break;
                
                case ("Mùi"):
                    switch (chiNU)
                    {
                        case ("Hợi"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Hợi - Mão - Mùi");break; 
                        case ("Mão"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Hợi - Mão - Mùi");break;
                        case ("Thìn"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Tuất"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Sửu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                    }

                    break;
                
                case ("Thân"):
                    switch (chiNU)
                    {
                        case ("Tý"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Thân - Tý - Thìn");break; 
                        case ("Thìn"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Thân - Tý - Thìn");break;
                        case ("Dần"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Tỵ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Hợi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                    }

                    break;
                
                case ("Dậu"):
                    switch (chiNU)
                    {
                        case ("Tỵ"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Tỵ - Sửu - Dậu");break; 
                        case ("Sửu"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Tỵ - Sửu - Dậu");break;
                        case ("Tý"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Ngọ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                        case ("Mão"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Tý - Ngọ - Mão - Dậu");break;
                    }

                    break;
                
                case ("Tuất"):
                    switch (chiNU)
                    {
                        case ("Dần"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Dần - Ngọ - Tuất");break; 
                        case ("Ngọ"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Dần - Ngọ - Tuất");break;
                        case ("Thìn"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Sửu"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                        case ("Mùi"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Thìn - Tuất - Sửu - Mùi");break;
                    }

                    break;
                
                case ("Hợi"):
                    switch (chiNU)
                    {
                        case ("Mão"): Console.WriteLine("Cả 2 người HỢP tuổi 'Tam hợp' Hợi - Mão - Mùi");break; 
                        case ("Mùi"): Console.WriteLine("Cả 2 người HỢP tuổi, 'Tam hợp' Hợi - Mão - Mùi");break;
                        case ("Dần"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Thân"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                        case ("Tỵ"): Console.WriteLine("Cả 2 người KHÔNG HỢP tuổi, 'Tứ hành xung' Dần - Thân - Tỵ - Hợi");break;
                    }

                    break;

            }

            //var conGiap = new List<string> { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            //var tamHop1 = new List<string> { "Thân", "Tý", "Thìn" }; Thân - Tý - Thìn 
            //var tamHop2 = new List<string> { "Dần", "Ngọ", "Tuất" }; Dần - Ngọ - Tuất
            //var tamHop3 = new List<string> { "Tỵ", "Sửu", "Dậu" };  Tỵ - Sửu - Dậu
            //var tamHop4 = new List<string> { "Hợi", "Mão", "Mùi" }; Hợi - Mão - Mùi 

            
            //var tuHanh1 = new List<string> { "Tý", "Ngọ", "Mão", "Dậu"}; Tý - Ngọ - Mão - Dậu
            //var tuHanh2 = new List<string> { "Dần", "Thân", "Tỵ","Hợi" }; Dần - Thân - Tỵ - Hợi
            //var tuHanh3 = new List<string> { "Thìn", "Tuất", "Sửu", "Mùi" }; Thìn - Tuất - Sửu - Mùi

        }
        
    }


}


