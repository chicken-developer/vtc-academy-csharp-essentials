using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNamespace1;
namespace Lab_Hk2_CSharp_03
{


    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            Point B = new Point();
            Console.WriteLine("Nhap diem A");
            A.input();
            Console.WriteLine("Nhap diem B");
            B.input();

            Console.WriteLine("D(A, B) = {0}", A.distance(B));

            Console.ReadKey();
        }
    }
}


