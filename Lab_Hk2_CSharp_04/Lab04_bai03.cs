using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNameSpace3;

namespace Lab_Hk2_CSharp_04
{
    class Lab04_bai03
    {
        static void Main(string[] args)
        {
            ThoiGian time = new ThoiGian();
            time.inputtime();
            time.Formattime(time);

            Console.WriteLine("Thoi gian hien tai la: ");
            time.outputtime();

            Console.WriteLine("Nhap vao so ngay muon them vao thoi gian hien tai: ");
            int day = Convert.ToInt32(Console.ReadLine());
            time.AddDay(day);
            time.outputtime();

            Console.WriteLine("Nhap vao so ngay muon bo di khoi thoi gian hien tai: ");
            int day2 = Convert.ToInt32(Console.ReadLine());
            time.SubDay(day);
            time.outputtime();

            Console.WriteLine("Nhap vao so thang muon them vao thoi gian hien tai: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            time.AddMonth(thang);
            time.outputtime();

            Console.WriteLine("Nhap vao so thang muon bo di khoi thoi gian hien tai: ");
            int thang2 = Convert.ToInt32(Console.ReadLine());
            time.AddMonth(thang2);
            time.outputtime();



        }
    }
}
