using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassnameSpace4;

namespace Lab_Hk2_CSharp_05
{
    class Lab05_bai01
    {
        public static void Main(string[] agrs)
        {
            int year;
            Arr_Oto A = new Arr_Oto();
            A.input();
            Console.WriteLine("Danh sach cac xe da nhap:");
            A.output();
            Console.WriteLine("Chi phi dang kiem trong 1 nam la: {0}000 VND", A.registration_costs());
            Console.WriteLine("Thong tin nien han cua xe so voi nam hien tai:");
            A.out_of_date_now();
            Console.WriteLine("Thong tin nien han cua xe so voi nam nhap tu nguoi dung:");
            Console.WriteLine("Moi nhap vao 1 nam:"); year = Convert.ToInt32(Console.ReadLine());
            A.out_of_date_user_input(year);
            Console.WriteLine("Danh sach thong ke xe:");
            A.statistic();
        }
    }
}
