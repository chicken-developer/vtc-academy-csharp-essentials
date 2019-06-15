using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            char input;
            List<HangHoa> hangHoas = new List<HangHoa>();
            hangHoas = XuLyFile.InputHangHoa("danhsachhanghoa.txt");
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================================");
                Console.WriteLine("             CHUONG TRINH QUAN LY HANG HOA                    ");
                Console.WriteLine("==============================================================");
                Console.WriteLine("1. Hien thi danh sach hang hoa");
                Console.WriteLine("2. Gia ban cua tung mat hang");
                Console.WriteLine("3. Them 1 hang hoa vao file du lieu");
                Console.WriteLine("4. Tim thong tin theo ma hang hoa");
                Console.WriteLine("5. Tim thong tin theo ten hang hoa");
                Console.WriteLine("6. Hien thi cac hang hoa co gia tu 3tr - 8tr, thue <= 10");
                Console.WriteLine("7. Tim nhung hang hoa co thue cao nhat");
                Console.WriteLine("8. Sap xep hang hoa");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==============================================================");
                Console.Write("Moi chon: ");
                input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                    case '1':
                        
                        hangHoas.InDanhSach();
                        Console.ReadKey();
                        break;
                    case '2':
                        hangHoas.InDanhSachGia();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.WriteLine("Chuc nang nay chua the su dung!");
                        Console.ReadKey();
                        break;
                    case '4':
                        hangHoas.Timtheoten();
                        Console.ReadKey();
                        break;
                    case '5':
                        hangHoas.Timtheoma();
                        Console.ReadKey();
                        break;
                    case '6':
                        hangHoas.InDanhSachHang3_8Tr();
                        Console.ReadKey();
                        break;
                    case '7':
                        hangHoas.Hanghoathuecao();
                        Console.ReadKey();
                        break;
                    case '8':
                        hangHoas.Sort();
                        Console.ReadKey();
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;



                }
            } while (input != '0');
            Console.WriteLine("Cam on ban da su dung chuong trinh. Hen gap lai !");
        }
    }
}


           

 