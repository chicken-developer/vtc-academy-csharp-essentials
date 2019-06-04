        using System;
        using System.Collections.Generic;
        using System.Text;

        namespace Lab_Hk2_CSharp_01
        {
            class Lab01_bai01
            {
                public static void printmenu()
                {
                    Console.WriteLine("1.Nhap mang gom n so, xuat ra man hinh");
                    Console.WriteLine("2.Tim so lon nhat/ nho nhat trong mang");
                    Console.WriteLine("3.Tim vi tri dau tien/ cuoi cung cua 1 so trong mang. neu khong co tra ve -1");
                    Console.WriteLine("4.Xuat ra nhung so nguyen to trong mang.");
                    Console.WriteLine("5. Tim nhung so chia het cho 3 tai vi tri chan trong mang");
                    Console.WriteLine("6.Tinh tong nhung so nguyen to trong mang");
                    Console.WriteLine("7. Sap xep mang tang dan ");
                    Console.WriteLine("0.Thoat ");
                    Console.Write("#Lua chon cua ban:  ");

                }
                public static int Checksnt(int n)
                {
                    int i, count;
                    count = 0;
                    for (i = 1; i < n; i++)
                    {
                        if (n % i == 0) count++;
                    }
                    if (count == 1) return 1;
                    else return 0;
                }
                public static bool Checksnt1(int n)
                {
                    int i, count;
                    count = 0;
                    for (i = 1; i < n; i++)
                    {
                        if (n % i == 0) count++;
                    }
                    if (count == 1) return true;
                    else return false;
                }
                public static void Main(string[] args)
                {

                    int input;
                    int n, i;
                    Console.WriteLine("Vui long nhap vao so luong phan tu");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] mainarray = new int[n];
                    for (i = 0; i < n; i++)
                    {
                        Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                        mainarray[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    do
                    {
                        printmenu();
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:

                            Console.WriteLine("Cac thanh phan cua mang:");
                            for (i = 0; i < n; i++)
                                {
                              
                                    Console.Write(" {0} ", mainarray[i]);
                                }

                                break;
                            case 2:
                                Array.Sort(mainarray);
                                Console.WriteLine("So nho nhat trong mang la: {0} ", mainarray[0]);
                                Console.WriteLine("So lon nhat trong mang la: {0} ", mainarray[n - 1]);
                                break;
                            case 3:
                                int vt, firstvt, lastvt;
                                Console.WriteLine("Vui long nhap so can tim vi tri: ");
                                vt = Convert.ToInt32(Console.ReadLine());
                                firstvt = Array.IndexOf(mainarray, vt);
                                lastvt = Array.LastIndexOf(mainarray, vt);
                                Console.WriteLine("Vi tri dau tien la {0} , Vi tri cuoi cung la {1} ", firstvt + 1, lastvt + 1);
                                break;
                            case 4:
                                Console.WriteLine("Cac so nguyen to trong mang mang:");
                                for (i = 0; i < n; i++)
                                {
                                    if (Checksnt(mainarray[i]) == 1) Console.Write(" {0} ", mainarray[i]);
                                }
                                break;
                            case 5:
                                Console.WriteLine("Cac so chia het cho 3 tai vi tri chan la:");
                                for (i = 0; i < n; i++)
                                {
                            
                                    if (mainarray[i]%3 == 0 && i%2 == 0) Console.Write(" {0} ", mainarray[i]);
                                }

                                break;
                            case 6:
                                int total;
                                total = 0;

                                /*for (i = 0; i < n; i++)
                                {

                                    if (Checksnt(mainarray[i]) == 1) total = total + mainarray[i];
                                }*/
                                foreach (var item in Array.FindAll(mainarray,Checksnt1))
                                {
                                    total += item;
                                }
                                Console.WriteLine("Tong cac SNT trong mang la: {0}", total);
                                break;
                            case 7:
                                Array.Sort(mainarray);
                                foreach (var item in mainarray)
                                {
                                    Console.Write(" {0} ",item);
                                }
                                break;
                            case 0:
                                break;
                        }
                    } while (input != 0);






                }
            }
        }
