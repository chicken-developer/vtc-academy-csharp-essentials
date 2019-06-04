using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNamespace2;

namespace Lab_Hk2_CSharp_03
{
    class Lab03_bai02_Nangcao
    {
       
       
        public static void Main(string[] agrs)
        {
              int n;

             Console.WriteLine("Nhap vao so luong hoc sinh");
             n = Convert.ToInt32(Console.ReadLine());
            VTCA_Student[] Temp = new VTCA_Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao tohng tin hoc sinh thu {0}", i + 1);
                Temp[i] = new VTCA_Student();
                Temp[i].input();

            }


           
        }
        public void editpoit()
        {
            int tempcode;
            Console.WriteLine("Moi nhap vao ma hoc sinh can sua dem mon C:");
            tempcode = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (tempcode == student_code)
                {

                }
                else Console.WriteLine("Ma hoc sinh khong hop le");
        }
    }
}
