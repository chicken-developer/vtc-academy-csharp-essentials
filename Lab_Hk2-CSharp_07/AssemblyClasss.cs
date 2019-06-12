using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Lab_Hk2_CSharp_07
{
    public class VTCA_Student
    {
        private int student_code;
        private string student_name;
        private double C_mark, SQLite_mark, Csharp_mark;
        public int studentcode
        {
            get { return student_code; }
            set { if (value >= 0) student_code = value; }
        }
        public string studentname
        {
            get { return student_name; }
            set { if (value != null) student_name = value; }
        }
        public VTCA_Student()
        {
            student_code = 101010;
            student_name = "Temp Name ";
            C_mark = 0;
            SQLite_mark = 0;
            Csharp_mark = 0;

        }
    }
    //ket thuc phan dinh nghia class

    public class ArrayList_VTCA_Student
    {
        private ArrayList arr;
        public ArrayList_VTCA_Student()
        {
        }

        public void arraylist_input()
        {
        }
        public void arraylist_output()
        {
        }
        //trả về true nếu thêm được và ngược lại
        public bool arraylist_add_a_student(VTCA_Student S)
        {
        }
        //xuất ra thông tin sinh viên tìm thấy trả về true nếu tìm được, ngược lại trả về false
        public bool arraylist_find_student_by_code(int code)
        {
        }
        public void arraylist_students_max_avg()
        {
        }
        public void arraylist_students_classify()
        {
        }
        //Xuất ra số lượng sinh viên theo từng phân loại dựa trên điểm trung bình như sau: Xuất sắc(>=9), Giỏi(>=8), Khá(>=7), Trung bình-Khá(>=6), Trung bình(>=5), Không đạt(<5)
    }
    public class List_VTCA_Student
    {
        private IList arr;
        public List_VTCA_Student()
        {
        }

        public void input()
        {
        }
        public void output()
        {
        }
        //trả về true nếu thêm được và ngược lại
        public bool list_add_a_student(VTCA_Student S)
        {
        }
        //xuất ra thông tin sinh viên tìm thấy trả về true nếu tìm được, ngược lại trả về false
        public bool list_find_student_by_code(int code)
        {
        }
        public void list_students_max_avg()
        {
        }
        public void list_students_classify()
        {
        }



    }
}
