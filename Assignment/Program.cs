using System;
using System.Collections.Generic;
using System.Text;
using AssignmentAssemblyNamespace;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            listATM atmlist = new listATM();
            
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================================");
                Console.WriteLine("             CHUONG TRINH QUAN LY THE ATM                     ");
                Console.WriteLine("==============================================================");
                Console.WriteLine("A. Quan ly danh sach the ATM");
                Console.WriteLine("B. Thao tac voi the ATM");
                Console.WriteLine("E. Thoat");
                Console.WriteLine("==============================================================");
                Console.Write("Moi chon: ");
                input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                    case 'A':
                    case 'a':
                        int input2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("                QUAN LY DANH SACH THE ATM                     ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Nhap danh sach the");
                            Console.WriteLine("2. Hien thi danh sach the");
                            Console.WriteLine("3. Lap 1 the moi");
                            Console.WriteLine("4. Liet ke danh sach nhung the het han");
                            Console.WriteLine("5. Gia han the het han");
                            Console.WriteLine("6. Sua thong tin the");
                            Console.WriteLine("7. Xoa nhung the het han");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input2 = Convert.ToInt32(Console.ReadLine());
                            switch (input2)
                            {
                                case 1:
                                    // atmlist.createTable();
                                    //ATM atm = new ATM();

                                    //atmlist.createTable(); 
                                    Console.WriteLine("Da nhap danh sach the, vui long chon 3 de them the moi !");
                                    
                                    //Console.WriteLine("Nhap danh sach thanh cong!");                                    
                                    break;
                                case 2:
                                    atmlist.loadData();
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    int inputzz;
                                    do
                                    {
                                        atmlist.input();
                                        atmlist.insertData(atmlist);
                                        Console.WriteLine("Ban co muon nhap tiep hay khong? - 1: Tiep tuc  -2 Thoat!");
                                        inputzz = Convert.ToInt32(Console.ReadLine());
                                    } while (inputzz != 2);
                                    break;
                                case 4:
                                    atmlist.lietkethehethan();
                                    Console.ReadLine();
                                    break;
                                case 5:
                                    atmlist.giahanthe();
                                    Console.ReadLine();
                                    break;
                                case 6:
                                    int inputtemp;
                                    do
                                    {
                                        
                                        Console.WriteLine("Ban muon sua thong tin nao ?");
                                        Console.WriteLine("Chon 1 de sua Ten nguoi dung");
                                        Console.WriteLine("Chon 2 de sua  CMND");
                                        Console.WriteLine("Chon 3 de sua Ngay sinh");
                                        Console.WriteLine("Chon 0 de thoat");
                                        inputtemp = Convert.ToInt32(Console.ReadLine());
                                        switch (inputtemp)
                                        {
                                            case 1:
                                                Console.WriteLine("MOi nhap vao ma ATM ");
                                                string maatm = Convert.ToString(Console.ReadLine());
                                                atmlist.changename(maatm);
                                                break;
                                            case 2:
                                                Console.WriteLine("MOi nhap vao ma ATM ");
                                                string maatm2 = Convert.ToString(Console.ReadLine());
                                                atmlist.changecmnd(maatm2);
                                                break;
                                            case 3:
                                                Console.WriteLine("MOi nhap vao ma ATM ");
                                                string maatm3 = Convert.ToString(Console.ReadLine());
                                                atmlist.changebirthday(maatm3);
                                                break;
                                            case 0:
                                                break;
                                            default:
                                                Console.WriteLine("Nhap sai  !!! ");
                                                break;
                                        }
                                    } while (inputtemp != 0);
                                    Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Danh sach the het han:");
                                    atmlist.lietkethehethan();
                                    Console.ReadLine();
                                    Console.WriteLine("Ban co chac muon xoa nhung the het han khong?( Y: Yes - N - No)");
                                    char checkinput;
                                    checkinput = Convert.ToChar(Console.ReadLine());
                                    if (checkinput == 'y' || checkinput == 'Y')
                                    {
                                        atmlist.xoaTheHetHan();
                                        Console.WriteLine("Danh sach the sau khi xoa:");
                                        atmlist.loadData();
                                        Console.ReadLine();
                                    }
                                    else if (checkinput == 'N' || checkinput == 'n') Console.WriteLine("Nhan phim bat ky de quay lai");
                                    else Console.WriteLine("Ban da nhap sai");
                                    //Console.ReadLine();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    break;
                            }

                        } while (input2 != 0);
                        break;
                    case 'B':
                    case 'b':
                        int input3;
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("                   THAO TAC VOI THE ATM                       ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Dang nhap");
                            Console.WriteLine("2. Doi mat khau");
                            Console.WriteLine("3. Van tin");
                            Console.WriteLine("4. Nap tien vao the");
                            Console.WriteLine("5. Rut tien");
                            Console.WriteLine("6. Chuyen tien");
                            Console.WriteLine("7. Nhat ky giao dich( Sao ke)");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input3 = Convert.ToInt32(Console.ReadLine());
                            switch (input3)
                            {
                                case 1:
                                    atmlist.dangNhap();
                                    break;
                                case 2:
                                    atmlist.changepassword(Assignment.ThongTin.sotaikhoan);
                                    break;
                                case 3:
                                    atmlist.vantin(Assignment.ThongTin.sotaikhoan);
                                    break;
                                case 4:
                                    atmlist.naptien(Assignment.ThongTin.sotaikhoan);
                                    break;
                                case 5:
                                    atmlist.ruttien(Assignment.ThongTin.sotaikhoan);
                                    break;
                                case 6:
                                    atmlist.chuyentien(Assignment.ThongTin.sotaikhoan, atmlist);
                                    break;
                                case 7:
                                    atmlist.lichsugd(Assignment.ThongTin.sotaikhoan);
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    break;
                            }
                        } while (input3 != 0);
                        break;
                    case 'E':
                    case 'e':
                        break;
                    default:
                        Console.WriteLine("Nhap sai! Vui long chon lai! ");
                        break;
                }

            } while (input != 'E' && input != 'e');
         Console.WriteLine("Cam on ban da su dung chuong trinh. Hen gap lai !");
        }
    }
}
