        using System;
        using System.Collections.Generic;
        using System.Text;

namespace AssemblyClassNamespace2

{
    public class VTCA_Student
    {
        private int student_code;
        private string student_name;
        private double C_mark, SQLite_mark, Csharp_mark;
        
        public VTCA_Student()
        {
            student_code = 101010;
            student_name = "Temp Name ";
            C_mark = 0;
            SQLite_mark = 0;
            Csharp_mark = 0;
            
        }
        public VTCA_Student(VTCA_Student Student)
        {
            Student_code = Student.student_code;
            Student_name = Student.student_name;
            C_Mark = Student.C_mark;
            SQLite_Mark = Student.SQLite_mark;
            Csharp_Mark = Student.Csharp_mark;
          
        }
        public int Student_code
        {
            get { return student_code; }
            set { student_code = value; }
        }
        public int soluonghs
        {
            get { return soluonghs; }
            set { soluonghs = value; }
        }
        public string Student_name
        {
            get { return student_name; }
            set { student_name = value; }
        }

        public double C_Mark
        {
            get { return C_mark; }
            set { if (value > 0 && value < 10) C_mark = value; }//yêu cầu kiểm tra không được phép <0 và >10
        }

        public double SQLite_Mark
        {
            get { return SQLite_mark; }
            set { if (value > 0 && value < 10) SQLite_mark = value; }//yêu cầu kiểm tra không được phép <0 và >10
        }
        public double Csharp_Mark
        {
            get { return Csharp_mark; }
            set { if (value > 0 && value < 10) Csharp_mark = value; }//yêu cầu kiểm tra không được phép <0 và >10
        }
        public void input()
        {
            Console.WriteLine("Enter Student ID: ");
            Student_code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student name: ");
            Student_name =Console.ReadLine();
            Console.WriteLine("Enter C Mark: ");
            C_Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SQLite Mark: ");
            SQLite_Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CSharp Mark: ");
            Csharp_Mark = Convert.ToInt32(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("Student ID: {0} | Student name: {1}  | Avg_Mark: {2} ", student_code,student_name,avg_mark());
            //avg_mark();
        }
        public double avg_mark()//(C_mark+SQLite_mark+Csharp_mark)/3
        {
          double avg_Mark = (C_Mark + SQLite_Mark + Csharp_Mark) / 3;
          return avg_Mark;
        }
        
    }
}
    

