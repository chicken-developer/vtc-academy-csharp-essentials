using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNameSpace3;

namespace Lab_Hk2_CSharp_04
{
    class Lab04_bai01
    {
        static void Main(string[] agrs)
        {
            Fraction Temp1 = new Fraction();
            Fraction Temp2 = new Fraction();
            Console.WriteLine("Nhap phan so thu 1");
            Temp1.input();
            Temp1.rutgon();
            Console.WriteLine("Nhap phan so thu 2");
            Temp2.input();
            Temp2.rutgon();
            
            Console.Write("Tong 2 phan so  = "); (Temp1 + Temp2).rutgon().output();
            Console.Write("\nHieu 2 phan so  = "); (Temp1 - Temp2).rutgon().output();
            Console.Write("\nTich 2 phan so  = ");(Temp1* Temp2).rutgon() .output();
            Console.Write("\nThuong 2 phan so  = "); (Temp1 / Temp2).rutgon().output();
        }
    }
}
