using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Hk2_CSharp_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //VTCA_Student student = new VTCA_Student();

            char input;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================================");
                Console.WriteLine("     CHUONG TRINH QUAN LY SINH VIEN SU DUNG COLLECTION        ");
                Console.WriteLine("==============================================================");
                Console.WriteLine("       CHON 1 COLLECTION DE LUU TRU DANH SACH SINH VIEN       ");
                Console.WriteLine("==============================================================");
                Console.WriteLine("1. Array List");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Hashtable");
                Console.WriteLine("4. Dictionary");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==============================================================");
                Console.Write("Moi chon: ");
                //Console.ReadKey();
                input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                   
                    case '1':
                        int input1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("       BAN DA CHON ARRAYLIST DE LUU TRU DANH SACH             ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Nhap danh sach sinh vien");
                            Console.WriteLine("2. Xuat danh sach sinh vien");
                            Console.WriteLine("3. Them 1 sinh vien vao danh sach");
                            Console.WriteLine("4. Tim thong tin sinh vien theo ma so");
                            Console.WriteLine("5. Liet ke danh sach nhung sinh vien co diem trung binh cao nhat");
                            Console.WriteLine("6. Thong ke so luong sinh vien theo xep loai");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input1 = Convert.ToChar(Console.ReadLine());
                            switch (input1)
                            {
                                case '1':
                                                                    
                                    break;
                                case '2':
                                   
                                    break;
                                case '3':
                                    
                                    break;
                                case '4':
                                    
                                    break;
                                case '5':
                                   
                                    break;
                                case '6':
                                    break;
                                case '0':
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (input1 != '0');
                        break;
                    case '2':                   
                        int input2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("          BAN DA CHON LIST DE LUU TRU DANH SACH               ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Nhap danh sach sinh vien");
                            Console.WriteLine("2. Xuat danh sach sinh vien");
                            Console.WriteLine("3. Them 1 sinh vien vao danh sach");
                            Console.WriteLine("4. Tim thong tin sinh vien theo ma so");
                            Console.WriteLine("5. Liet ke danh sach nhung sinh vien co diem trung binh cao nhat");
                            Console.WriteLine("6. Thong ke so luong sinh vien theo xep loai");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input2 = Convert.ToChar(Console.ReadLine());
                            switch (input2)
                            {
                                case '1':

                                    break;
                                case '2':

                                    break;
                                case '3':

                                    break;
                                case 4:

                                    break;
                                case '5':

                                    break;
                                case '6':
                                    break;
                                case '0':
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (input2 != '0');
                        break;
                    case '3':
                        int input3;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("       BAN DA CHON HASHTABLE DE LUU TRU DANH SACH             ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Nhap danh sach sinh vien");
                            Console.WriteLine("2. Xuat danh sach sinh vien");
                            Console.WriteLine("3. Them 1 sinh vien vao danh sach");
                            Console.WriteLine("4. Tim thong tin sinh vien theo ma so");
                            Console.WriteLine("5. Liet ke danh sach nhung sinh vien co diem trung binh cao nhat");
                            Console.WriteLine("6. Thong ke so luong sinh vien theo xep loai");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input3 = Convert.ToChar(Console.ReadLine());
                            switch (input3)
                            {
                                case '1':

                                    break;
                                case '2':

                                    break;
                                case '3':

                                    break;
                                case '4':

                                    break;
                                case '5':

                                    break;
                                case '6':
                                    break;
                                case '0':
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (input3 != '0');
                        break;
                    case '4':
                        int input4;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("       BAN DA CHON DICTIONARY DE LUU TRU DANH SACH             ");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("1. Nhap danh sach sinh vien");
                            Console.WriteLine("2. Xuat danh sach sinh vien");
                            Console.WriteLine("3. Them 1 sinh vien vao danh sach");
                            Console.WriteLine("4. Tim thong tin sinh vien theo ma so");
                            Console.WriteLine("5. Liet ke danh sach nhung sinh vien co diem trung binh cao nhat");
                            Console.WriteLine("6. Thong ke so luong sinh vien theo xep loai");
                            Console.WriteLine("0. Thoat");
                            Console.WriteLine("==============================================================");
                            Console.Write("Moi chon: ");
                            input4 = Convert.ToChar(Console.ReadLine());
                            switch (input4)
                            {
                                case '1':

                                    break;
                                case '2':

                                    break;
                                case '3':

                                    break;
                                case '4':

                                    break;
                                case '5':

                                    break;
                                case '6':
                                    break;
                                case '0':
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai! Vui long chon lai! ");
                                    Console.ReadKey();
                                    break;
                            }
                            

                        } while (input4 != '0');
                        break;
                    default:
                        Console.WriteLine("Nhap sai! Vui long chon lai! ");
                        Console.ReadKey();
                        break;

                }

            } while (input != '0');
            Console.WriteLine("Cam on ban da su dung chuong trinh. Hen gap lai !");
        }
    }
}
