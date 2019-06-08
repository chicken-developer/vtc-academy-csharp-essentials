using System;

namespace Lab_Hk2_CSharp_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nNhap vao Ngay mo the:");
            DateTime Ngaymothe = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine( Ngaymothe.ToString("yyyy-MM-dd"));
            //Abstract class: khi có 1 hàm buộc người dùng làm theo khuôn mẫu mà coder viết ra
            // Có thể khai báo field, property,funct trong hàm abstract - chỉ định nghĩa 
            //abstruct là hàm định nghĩa, muốn sử dụng phải kế thừa và dùng hàm kế thừa.
            // trong funct buộc phải thêm từ khóa abstruct
            // những hàm kế thừa nó buộc phải định nghĩa lại( hiện thực/ khởi tạo) các funtc 
            //
            //
            //interfaces
            //Khai báo interfaces Teninterfaces{}
            //ĐỊnh nghĩa interfaces thường thêm chữ I phía trước để dễ nhận dạng
            //CHỉ dùng định nghĩa hàm, không có property hay field
            // mặc định access là public, không cần khai báo thêm
            // những hàm kế thừa nó buộc phải có override và định nghĩa lại( hiện thực/ khởi tạo) các funtc và property
            // Không thể khởi tạo 1 interfaces mà phải tạo 1 đối tượng đã định nghĩa interfaces sau đó tạo thông qua đối tượng đó.
            // Hàm con có thể kế thừa nhiều interfaces,1 class.
        }
    }
}
