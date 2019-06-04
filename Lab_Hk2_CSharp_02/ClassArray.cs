    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CS_Buoi1
    {
        class Program
        {

       
            static void Main(string[] args)
            {
                Console.WriteLine("DEMO ARRAY (CO SU DUNG MOT SO HAM CUA LOP ARRAY): ");
                Console.WriteLine("-------------------------------------------------");
                int[] a;
                int n;
                Console.Write("Nhap so luong phan tu cua mang: ");
                n = Convert.ToInt32(Console.ReadLine());
                a = new int[n];
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Moi nhap cac phan tu cua mang");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\t+phan tu {0} = ", i + 1);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("-----------------------------");
                Console.Write("Mang ban vua nhap gom cac phan tu: ");
                foreach (var item in a)
                    Console.Write("{0} ", item);
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("tim vi tri/dau cuoi su dung ham IndexOf, LastIndexOf");
                int x;
                Console.Write("Nhap phan tu can tim: ");
                x = Convert.ToInt32(Console.ReadLine());
                int vt = Array.IndexOf(a, x);
                if (vt == -1)
                    Console.WriteLine("{0} khong co trong mang", x);
                else
                    Console.WriteLine("vi tri dau tien cua {0} trong mang la {1}", x, vt);
                vt = Array.LastIndexOf(a, x);
                if (vt == -1)
                    Console.WriteLine("{0} khong co trong mang", x);
                else
                    Console.WriteLine("vi tri cuoi cua {0} trong mang la {1}", x, vt);
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Sap sep mang su dung ham Sort va xuat dung ham ForEach");
                Array.Sort(a);
                //xuất mảng sử dụng hàm ForEach
                //hàm foreach có 2 tham số, tham số đầu là mảng, 
                //tham số 2 là 1 thao tác gì đó liên quan đến giá trị của phân tử trong mảng
                //trong demo này ta chỉ xuất phần tử đó ra thôi => xem code hàm output
                //lưu ý hàm thao tác này phải là kiểu void và tham số của hàm phải có kiểu giống với mảng
                Array.ForEach(a, output);
                Console.WriteLine("\n-----------------------------");
                Console.Write("Cac so nguyen to trong mang (dung ham FindAll): ");
                //sử dụng hàm FindAll
                //hàm findall có 2 tham số, tham số 1 là mảng, 
                //tham số 2 là 1 thao tác điều kiện gì đó liên quan đến giá trị của phân tử trong mảng
                //trong demo này ta kiểm tra số nguyên tố => xem code hàm songuyento
                //lưu ý hàm điều kiện này phải là kiểu bool và tham số của hàm phải có kiểu giống với mảng
                foreach (var item in Array.FindAll(a, songuyento))
                {
                    Console.Write("{0}\t", item);
                }
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Kiem tra xem mang co phai la toan bo so nguyen to khong? (dung ham TrueForALL)");
                if (Array.TrueForAll(a, songuyento))
                    Console.WriteLine("Ket qua: mang toan so nguyen to");
                else
                    Console.WriteLine("Ket qua: mang khong phai la mang toan so nguyen to");
                Console.ReadKey();
            }
            static void output(int x)
            {
                Console.Write(x + "\t");
            }
            static bool songuyento(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }
    }