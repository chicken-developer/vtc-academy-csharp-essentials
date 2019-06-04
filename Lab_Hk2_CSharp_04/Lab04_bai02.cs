using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNameSpace3;

namespace Lab_Hk2_CSharp_04
{
    class Lab04_bai02
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so luong phan tu");
            n = Convert.ToInt32(Console.ReadLine());
            Fraction[] Temp = new Fraction[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0}", i + 1);
                Temp[i] = new Fraction();
                Temp[i].input();

            }
            Console.WriteLine("Mang phan so sau khi rut gon la: ");
            for (int i = 0; i < n; i++)
            {

                Temp[i].rutgon().output();// RUt gon va xuat mang phan so
            }
            

           
           
            Array.Sort(Temp);
            Console.WriteLine("Mang sau khi sap xep theo thu tu tang dan la: ");
            for (int i = 0; i < n; i++)
            {

                Temp[i].output();// RUt gon va xuat mang phan so
            }
            Console.WriteLine("Phan so nho nhat trong mang la: "); Temp[0].output();
            Console.WriteLine("Phan so lon nhat trong mang la: " ); Temp[n - 1].output();
            for (int i = 0; i < n - 1; i++)
            {
                Temp[n - 1] += Temp[i];
            }
            Console.WriteLine("Tong cac phan so trong mang la:"); Temp[n - 1].rutgon().output();
        }

    }
}
