using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public static class ExtensionMethods
    {
        //extension for danh sach hang hoa
        public static void InDanhSach(this List<HangHoa> hangHoas)
        {

            Console.WriteLine("======================================================================");
            Console.WriteLine("|                          DANH SÁCH HÀNG HÓA                        |");
            Console.WriteLine("======================================================================");

            Console.WriteLine(string.Format("{0,-8}{1,-10}{2,-2}{3,5}{4,5}", "Ma hang", "Ten hang", "|So luong|", "Gia nhap|", "Thue|"));
            Console.WriteLine("======================================================================");
            foreach (HangHoa item in hangHoas)
            {
                item.InHangHoa();
            }

        }
        public static void InDanhSachGia(this List<HangHoa> hangHoas)
        {

            Console.WriteLine("==========================  GIA BAN  =========================================");
            foreach (HangHoa item in hangHoas)
            {
                item.InGiaBan();
            }
        }
        public static void InDanhSachHang3_8Tr(this List<HangHoa> hangHoas)
        {

            Console.WriteLine("======================================================================");
            Console.WriteLine("|        DANH SACH HANG HOA CO GIA TU 3TR - 8TR                       |");
            Console.WriteLine("======================================================================");

            Console.WriteLine(string.Format("{0,-8}{1,-10}{2,-2}{3,5}{4,5}", "Ma hang", "Ten hang", "|So luong|", "Gia nhap|", "Thue|"));
            Console.WriteLine("======================================================================");
            foreach (HangHoa item in hangHoas)
            {
                if(item.GiaBan > 3000000 && item.GiaBan < 8000000 && item.Thue < 10)    item.InHangHoa();
            }
        }
        public static void Timtheoten(this List<HangHoa> hangHoas)
        {
            Console.WriteLine("Nhap vao ten mat hang muon tim");
            string search = Convert.ToString(Console.ReadLine());
            int check = 0;
            Console.WriteLine("======================================================================");
            Console.WriteLine("|          DANH SACH CAC MAT HANG DUOC TIM THAY                      |");
            Console.WriteLine("======================================================================");

            Console.WriteLine(string.Format("{0,-8}{1,-10}{2,-2}{3,5}{4,5}", "Ma hang", "Ten hang", "|So luong|", "Gia nhap|", "Thue|"));
            Console.WriteLine("======================================================================");
            foreach (HangHoa item in hangHoas)
            {
                if (item.TenHang == search)
                {
                    item.InHangHoa();
                    check++;
                }
            }
            if (check == 0) Console.WriteLine("Khong tim thay mat hang nay");
        }
        public static void Timtheoma(this List<HangHoa> hangHoas)
        {
            Console.WriteLine("Nhap vao ma mat hang muon tim");
            string search = Convert.ToString(Console.ReadLine());
            int check = 0;
            Console.WriteLine("======================================================================");
            Console.WriteLine("|          DANH SACH CAC MAT HANG DUOC TIM THAY                      |");
            Console.WriteLine("======================================================================");

            Console.WriteLine(string.Format("{0,-8}{1,-10}{2,-2}{3,5}{4,5}", "Ma hang", "Ten hang", "|So luong|", "Gia nhap|", "Thue|"));
            Console.WriteLine("======================================================================");
            foreach (HangHoa item in hangHoas)
            {
                if (item.MaHang == search)
                {
                    item.InHangHoa();
                    check++;
                }
            }
            if (check == 0) Console.WriteLine("Khong tim thay mat hang voi ma so nay");
        }
        public static void Hanghoathuecao(this List<HangHoa> hangHoas)
        {
           
            Console.WriteLine("======================================================================");
            Console.WriteLine("|          DANH SACH CAC MAT HANG THUE CAO NHAT                      |");
            Console.WriteLine("======================================================================");

            Console.WriteLine(string.Format("{0,-8}{1,-10}{2,-2}{3,5}{4,5}", "Ma hang", "Ten hang", "|So luong|", "Gia nhap|", "Thue|"));
            Console.WriteLine("======================================================================");
            int thuemax =0;
            int count = hangHoas.Count;
            for (int i = 0; i < count; i++){
                if (hangHoas[i].Thue > thuemax) thuemax = hangHoas[i].Thue;
            }
            foreach (HangHoa item in hangHoas)
            {
                if (item.Thue == thuemax)
                {
                    item.InHangHoa();
                }
            }

        }


    }
}
