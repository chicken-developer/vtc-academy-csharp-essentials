using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyClassnameSpace4
{
    public class Oto
    {
        private string company, model;
        private int year;
        public string Company
        {
            get { return company; }
            set { if (value != null) company = value; }//kiểm tra không được phép rỗng
        }
        public string Model
        {
            get { return model; }
            set { if (value != null) model = value; }//kiểm tra không được phép rỗng
        }
        public int Year
        {
            get { return year; }
            set { if (value >= 1986) year = value; }//kiểm tra phải >= 1986
        }
        public virtual void input()
        {
            Console.WriteLine("Nhap vao hang san xuat cua xe:");
            Company = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap vao nhan hieu cua xe:");
            Model = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap vao nam san xuat:");
            Year = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.Write("Hang san xuat: {0} | Nhan hieu: {1} | Nam san xuat {2} |", company,model,year);
        }
       
    }
    public class Car : Oto
    {
        private int seat;//số chỗ ngồi
        public int Seat
        {
            get { return seat; }
            set { if (value >= 4) seat = value; }//kiểm tra phải >=4
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap vao so luong cho ngoi: ");
            Seat = Convert.ToInt32(Console.ReadLine());
            //gọi lại hàm input từ lớp Oto và nhập thêm thuộc tính Seat
        }
        public override void output()
        {
            base.output();
            Console.Write("So luong cho ngoi: {0} | \n", seat);
            //gọi lại hàm output từ lớp Oto và xuất thêm thuộc tính Seat
        }
    }
    public class Truck : Oto
    {
        private double capacity;//tinh theo don vi tan
        public double Capacity
        {
            get { return capacity; }
            set { if (value > 0.5) capacity = value; }//kiểm tra phải >= 0.5 (tan)
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap vao trong tai cua xe: ");
            Capacity = Convert.ToInt32(Console.ReadLine());
            // gọi lại hàm input từ lớp Oto và nhập thêm thuộc tính Capacity
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Trong tai : {0} | \n", capacity);
            // gọi lại hàm output từ lớp Oto và xuất thêm thuộc tính Capacity
        }
    }
   
    public class Arr_Oto
    {
        private int n;
        private Oto[] arr;
       
        public void input()
        {
            //foreach(var item in arr)
            //{
            //    if(item is Car)
            //    {

            //       // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });
            //       (item as Car).input();

            //    }
            //    if(item is Truck)
            //    {
            //       // Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });
            //        (item as Truck).input();
            //    }
            //}
            Console.WriteLine("Nhap vao so luong xe: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int chon = 0 ;
            arr = new Oto[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ban muon nhap xe nao? 1-Car, 2-Truck? ");
                chon = Convert.ToInt32(Console.ReadLine());
                if (chon == 1)
                    arr[i] = new Car();
                else
                    arr[i] = new Truck();
                arr[i].input();
            }

        }
        public void output()
        {

            foreach (var item in arr) item.output();
            //{
            //    if (item is Car)
            //    {

            //       // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });
            //        (item as Car).output();

            //    }
            //    if (item is Truck)
            //    {
            //       // Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });
            //        (item as Truck).output();
            //    }
            //}
        }
        public decimal registration_costs()//tính chi phí đăng kiểm
        {
            int cost = 0;
            foreach (var item in arr)
            {
                if (item is Car)
                {

                   // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });

                    if ((item as Car).Seat > 40) cost = cost + 350;
                    else if ((item as Car).Seat > 25 && (item as Car).Seat < 40  ) cost = cost + 320;
                    else if ((item as Car).Seat > 10 && (item as Car).Seat < 25) cost = cost + 280;
                    else cost = cost + 240;

                }
                if (item is Truck)
                {
                    //Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });

                    if ((item as Truck).Capacity > 20) cost = cost + 560;
                   else if ((item as Truck).Capacity > 7 && (item as Truck).Capacity < 20) cost = cost + 350;
                   else if ((item as Truck).Capacity > 2 && (item as Truck).Capacity < 7) cost = cost + 320;
                   else if ((item as Truck).Capacity < 2) cost = cost + 280;
                    else cost = cost + 180;

                }
            }
            return cost;
        }
        //liệt kê danh sách xe hết niên hạn, dùng lệnh DateTime.Now.Year để lấy năm hiện tại
       
        public void out_of_date_now()
        {
           int year = DateTime.Now.Year;
            Console.WriteLine("Danh sach xe het nien han :");
            int dem = 0;
            foreach (var item in arr)
            {
                if (item is Car)
                {

                    // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });
                    if (year - (item as Car).Year > 20)
                    {
                        item.output(); dem++;
                    }

                }
                if (item is Truck)
                {

                    // Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });
                    if (year - (item as Truck).Year > 25)
                    {
                        item.output();
                        dem++;
                    }

                }
                
            }
            if (dem == 0) Console.WriteLine("Khong co xe nao het han dang kiem");

        }
        //liệt kê danh sách xe hết niên hạn trong năm (tham số year) được truyền vào
      
        public void out_of_date_user_input(int year)
        {
            Console.WriteLine("Danh sach xe het nien han trong nam {0}: ",year);
            int dem = 0;
            foreach (var item in arr)
            {
                if (item is Car)
                {

                    // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });
                    if (year - (item as Car).Year > 20)
                    {
                        item.output(); dem++;
                    }

                }
                if (item is Truck)
                {

                    // Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });
                    if (year - (item as Truck).Year > 25)
                    {
                        item.output();
                        dem++;
                    }

                }

            }
            if (dem == 0) Console.WriteLine("Khong co xe nao het han dang kiem");

        }
        //thống kê số lượng từng loại xe theo phân khúc (có thể tách riêng thành  từng hàm theo mỗi loại phân khúc tùy ý)

        public void statistic()
        {
            int cs4 =0, cs25= 0, cs10 = 0, cs =0, tc20 = 0, tc7 =0, tc2=0, tc = 0;
            foreach (var item in arr)
            {
                if (item is Car)
                {

                    // Oto[] arr = Array.FindAll(arrcar, delegate (Oto i) { return i is Car; });

                    if ((item as Car).Seat > 40) cs4++;
                    else if ((item as Car).Seat > 25 && (item as Car).Seat < 40) cs25++;
                    else if ((item as Car).Seat > 10 && (item as Car).Seat < 25) cs10++;
                    else cs++;

                }
                if (item is Truck)
                {
                    //Oto[] arr = Array.FindAll(arrtruck, delegate (Oto i) { return i is Truck; });

                    if ((item as Truck).Capacity > 20)tc20++ ;
                    else if ((item as Truck).Capacity > 7 && (item as Car).Seat < 20) tc7++;
                    else if ((item as Truck).Capacity > 2 && (item as Car).Seat < 7) tc2++;
                    else tc++;
                  
                }
            }
            Console.WriteLine("So luong xe hoi tren 40 cho la: {0}", cs4);
            Console.WriteLine("So luong xe hoi tu 25 den 40 cho la: {0}", cs25);
            Console.WriteLine("So luong xe hoi tu 10 den 20 cho la: {0}", cs10);
            Console.WriteLine("So luong xe hoi duoi 10 cho la: {0}", cs);
            Console.WriteLine("So luong xe tai tren 20 tan: {0}", tc20);
            Console.WriteLine("So luong xe tai tu 7 den 20 tan la: {0}", tc7);
            Console.WriteLine("So luong xe tai tu 2 den 7 tan la: {0}", tc2);
            Console.WriteLine("So luong xe tai duoi 2 tan la: {0}", tc);
           
        }
    }
}
