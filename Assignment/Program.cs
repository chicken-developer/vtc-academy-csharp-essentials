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
            char input;
            do
            {
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
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    break;
                                case 7:
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
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    break;
                                case 7:
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
