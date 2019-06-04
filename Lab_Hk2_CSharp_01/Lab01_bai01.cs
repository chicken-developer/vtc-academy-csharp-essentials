using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Hk2_CSharp_01
{
    class Lab01_bai01
    {
        public static void printmenu()
        {
            Console.WriteLine("1.Nhap vao 2 so m va n, xuat ra nhung so chia het cho 7 tu m den n.");
            Console.WriteLine("2.Nhap vao so a, b va n.Xuat ra nhung so ma a, b deu chia het cho no trong khoang tu 1 toi n");
            Console.WriteLine("3.Nhap vao so n, xuat ra n so dau tien cua day fibonaci.");
            Console.WriteLine("4.Nhap vao so n, xuat ra n so nguyen to dau tien.");
            Console.WriteLine("0.Thoat ");
            Console.Write("#Lua chon cua ban:  ");

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
        public static void Chuc_nang_1(int m, int n)
        {
            int i, j;
            int[] temp = new int[n - m];
            Console.WriteLine("Cac so chia het cho 7 tu m den n la.");
            for (i = 0; i < n - m; i++)
            {
                temp[i] = m + i;
                if (temp[i] % 7 == 0) Console.Write(" {0} ", temp[i]);
            }
            Console.WriteLine("\nKet thuc chuc nang thu 1 !");
        }
        public static void Chuc_nang_2(int a, int b, int n)
        {
            int i, dem;
            int[] temp = new int[n];
            Console.WriteLine("Cac so ma ca a va b deu chia het trong khoang tu 1 den n la: ");
            dem = 0;
            for (i = 0; i < n; i++)
            {
                temp[i] = i + 1;
                if (a % temp[i] == 0 && b % temp[i] == 0) Console.Write(" {0} ", temp[i]);
                dem++;
            }
            if (dem == 0) Console.WriteLine("Khong co so nao thoa man");

            Console.WriteLine("\nKet thuc chuc nang thu 2 !");
        }
        public static void Chuc_nang_3(int n)
        {
            int i;
            int[] temp = new int[n];
            Console.WriteLine("{0} so dau tien cua day fibonaci la: ",n);
            temp[0] = 0;
            temp[1] = 1;
            for (i = 0; i < n - 2; i++) temp[i + 2] = temp[i] + temp[i + 1];
            for (i = 0; i < n; i++) Console.Write(" {0} ", temp[i]);
            Console.WriteLine("\nKet thuc chuc nang thu 3 !");
        }

        public static void Main(string[] args)
        {

            int input;
            do
            {
                printmenu();
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        int x, y;
                        Console.WriteLine("Ban da chon chuc nang 1");
                        Console.WriteLine("Vui long nhap 2 so m va n");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Chuc_nang_1(x, y);
                        break;
                    case 2:
                        int x2, y2, z2;
                        Console.WriteLine("Ban da chon chuc nang 2");
                        Console.WriteLine("Vui long nhap 3 so a, b va n");
                        x2 = Convert.ToInt32(Console.ReadLine());
                        y2 = Convert.ToInt32(Console.ReadLine());
                        z2 = Convert.ToInt32(Console.ReadLine());
                        Chuc_nang_2(x2, y2, z2);
                        break;
                    case 3:
                        int x3;
                        Console.WriteLine("Ban da chon chuc nang 3");
                        Console.WriteLine("Hay nhap vao 1 so ");
                        x3 = Convert.ToInt32(Console.ReadLine());
                        Chuc_nang_3(x3);
                        break;
                    case 4:
                        int x4, i = 2;
                        Console.WriteLine("Ban da cho chuc nang so 4");
                        int count = 0;
                        Console.WriteLine("Hay nhap vao 1 so ");
                        x4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} so nguyen to dau tien la ", x4);
                        while (count < x4)

                        {

                            if (Checksnt1(i) == true)

                            {
                                Console.Write(" {0} ", i);
                                count++;

                            }

                            i++;

                        }
                        Console.WriteLine("\nKet thuc chuc nang thu 4 !");
                        break;
                    case 0:
                        break;
                }
            } while (input != 0);






        }
    }
}
