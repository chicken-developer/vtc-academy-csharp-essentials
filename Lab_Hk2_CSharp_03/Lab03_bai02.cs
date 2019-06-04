using System;
using System.Collections.Generic;
using System.Text;
using AssemblyClassNamespace2;

namespace Lab_Hk5_CSharp_03
{
    class Lab03_bai05
    {
        static void Main(string[] args)
        {
            VTCA_Student[] i = new VTCA_Student[5];
            int count = 0;
            double max;

            for (count = 0; count < 5; count++)
            {
                i[count] = new VTCA_Student();
                Console.WriteLine(" Nhap thong tin hoc sinh thu {0}", count + 1);
                i[count].input();
               // i.output();

            }
            for( count = 0; count < 5; count++)
            {
                i[count].output();
            }
            max = i[0].avg_mark();
            int temp = 0;
            for (count = 0; count < 5; count++)
            {
                if (i[count].avg_mark() > max)
                {
                    max = i[count].avg_mark();
                    temp = count;
                }
            }
            Console.WriteLine("Hoc sinh co  diem trung binh cao nhat la: ");
            i[temp].output();

            //Console.ReadKey();

        }
    }
}
