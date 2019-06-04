using System;

namespace Lab_Hk2_CSharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //predicate: truyền 1 hàm có trả về kết quả true or false
            //action: truyền 1 hàm có trả về kiểu void
            //static: sử dụng từ khóa này trước các hàm muốn sài mà không cần khởi tạo trước.

            //constructer: hàm khởi tạo giá trị ban đầu cho hàm
            // để khởi tạo constructer: _access(public/ private)+ Tên hàm trùng với tên class( Không có kiểu trả về)
            // có 3 loại hàm khởi tạo: không tham số, có tham số truyền vào , hàm khởi tạo sao chép.
            // khởi tạo hàm có tham số truyền vào phải khởi tạo kèm 1 hàm không có tham số truyền vào

            // hàm hủy( destructer) tên hàm bắt đầu bằng dấu ~ và cùng với tên lớp: vd: ~Destructer()
            // hàm hủy được gọi lên tự động trong Java, c#( trong c/ C++ phải gọi hàm hủy để hủy con trỏ)

            //định nghĩa toán lại tử
            /*
             * từ khóa bắt buộc: public static + tên class + operator + ký hiệu toán tử(+, -, *, /, ....)+(số ngôi của toán tử)
             * vd định nghĩa lại toán tử +: public static Point operator+(Point p1, Point p2)
             * với các toán tử so sánh thì phải định nghĩa cả trường hợp phủ định
             * vd: định nghĩa toán tử lớn hơn phải định nghĩa toán tử nhỏ hơn( viết 2 hàm định nghĩa).
             * 
             */

        }
    }
}
