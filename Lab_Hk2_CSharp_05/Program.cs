using System;

namespace Lab_Hk2_CSharp_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //SLide 06: Ke thua va da hinh
            //Có 2 loại kế thừa: đơn kế thừa và đa kế thừa c++(1 lớp kế thừa từ nhiều lớp khác)
            //đa hình
            //toán tử is kiểm tra 1 thành phần ko thuộc lớp cha nằm tại lớp con nào ?
            //vd lớp cha là PET.......có 2 lớp con là DOG và CAT, tại lớp cha có biến name, lớp con DOG có 1 biến riêng là cân nặng, lớp con CAT có 1 biến riêng là tuổi
            // Khi khởi tạo dùng lớp cha nên phải kiểm tra lớp đó là thuộc lớp con DOG hay CAT, dùng toán tử is
            // toán tử as
            // ví dụ khi cần tìm DOG nặng nhất. ta phải kiểm tra xem PET đó là DOG hay CAT bằng is
            // sau khi kiểm tra ta cần chuyển kiểu PET về DOG để lấy được biến cân nặng.

            //trước khi chuyển kiểu phải kiểm tra trước để tránh bị lỗi

        }
    }
}
