using System;
//using System.DateTime;
using System.Collections.Generic;
using System.Text;


namespace AssemblyClassNameSpace3
{
    //----------------------------------------------------------------------------------------------------
    // Lab04_bai02::
    //----------------------------------------------------------------------------------------------------
    public class Fraction:IComparable
    {
        int tuso, mauso;
        public Fraction()// khoi tao mac dinh
        {
            tuso = 0;
            mauso = 1;
        }
        public Fraction(Fraction Temp)// Khoi tao co tham so truyen vao
        {
            tuso = Temp.tu;
            mauso = Temp.mau;
        }
        public int tu // property
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int mau //property
        {
            get { return mauso; }
            set{mauso = value;}
        }
        // Dinh nghia toan tu...................................................
        public static Fraction operator + (Fraction temp1, Fraction temp2) 
        {
            Fraction ketqua = new Fraction();
            ketqua.tu = temp1.tu * temp2.mau+ temp2.tu*temp1.mau;
            ketqua.mau = temp1.mau * temp2.mau;
            return ketqua;
        }
        public static Fraction operator -(Fraction temp1, Fraction temp2)
        {
            Fraction ketqua = new Fraction();
            ketqua.tu = temp1.tu * temp2.mau - temp2.tu * temp1.mau;
            ketqua.mau = temp1.mau * temp2.mau;
            return ketqua;
        }
        public static Fraction operator *(Fraction temp1, Fraction temp2)
        {
            Fraction ketqua = new Fraction();
            ketqua.tu = temp1.tu * temp2.tu;
            ketqua.mau = temp1.mau * temp2.mau;
            return ketqua;
        }
       
        public static Fraction operator /(Fraction temp1, Fraction temp2)
        {
            Fraction ketqua = new Fraction();
            ketqua.tu = temp1.tu * temp2.mau;
            ketqua.mau = temp1.mau * temp2.tu;
            return ketqua;
        }
       // Ket thuc dinh nghia toan tu...........................................
      
        //---------------------------------------
        // Ham so sanh
       
        public static bool operator >(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau)> (temp2.tu*temp1.mau)) return true;
            return false;
        }
        public static bool operator <(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau) < (temp2.tu * temp1.mau)) return true;
            return false;
        }
        public static bool operator >=(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau) >= (temp2.tu * temp1.mau)) return true;
            return false;
        }
        public static bool operator <=(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau) <= (temp2.tu * temp1.mau)) return true;
            return false;
        }
        public static bool operator !=(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau) != (temp2.tu * temp1.mau)) return true;
            return false;
        }
        public static bool operator ==(Fraction temp1, Fraction temp2)
        {
            if ((temp1.tu * temp2.mau) == (temp2.tu * temp1.mau)) return true;
            return false;
        }
        //---------------------------------------------
        public Fraction rutgon()
        {
            int t = Math.Abs(tu);
            int m = Math.Abs(mau);
            int us = 1;
            while (t > 0 && m > 0)
            {
                if (t > m) t -= m;
                else m -= t;
            }
            us = t + m;

            tu /= us;
            mau /= us;
            return this;
        }
        public void input()
        {
            do
            {
                Console.WriteLine("Nhap vao tu so: ");
                tu = Convert.ToInt32(Console.ReadLine());
            } while (tu == 0);
            do
            {
                Console.WriteLine("Nhap vao mau so: ");
                mau= Convert.ToInt32(Console.ReadLine());
            } while (mau == 0);
            if( (tu < 0 && mau < 0) | mau < 0)
            {
                tu = 0 - tu;
                mau = 0 - mau;
            }
            
        }
        public void output()
        {
            Console.WriteLine("{0} / {1}", tuso, mauso);
        }


        public int CompareTo(object obj) // Dinh nghia ham sap xep cho lop PhanSo
        {
            if (this < (obj as Fraction)) return -1;
            if (this == (obj as Fraction)) return 0;
            return 1;
        }
        

    }

    //----------------------------------------------------------------------------------------------------
    // Lab04_bai03::
    //----------------------------------------------------------------------------------------------------
    public class ThoiGian
    {
        int ngay, thang, nam, gio, phut, giay;
        DateTimeKind kind;
        //DateTime day;
        DayOfWeek day;
        //public enum WeekDay
        //{
        //    MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY
        //}
        //Khoi tao mac dinh
        public ThoiGian()
        {
            //day = WeekDay.SATURDAY;
            ngay = 1; thang = 1; nam = 2000; gio = 0; phut = 0; giay = 0;

        }
        public DayOfWeek Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }
        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }
        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        public int Giay
        {
            get { return giay; }
            set { giay = value; }
        }
        public ThoiGian(ThoiGian time)
        {
            Day = time.day;
            Ngay = time.ngay;
            Thang = time.thang;
            Nam = time.nam;
            Gio = time.gio;
            Phut = time.phut;
            Giay = time.giay;

        }
  
        public void inputtime()
        {

            do
            {
                Console.WriteLine("Nhap vao ngay: ");
                Ngay = Convert.ToInt32(Console.ReadLine());
            } while (Ngay <= 0 || Ngay > 31);



            do
            {
                Console.WriteLine("Nhap vao thang: ");
                Thang = Convert.ToInt32(Console.ReadLine());
            } while (Thang <= 0 || Thang > 12);

            do
            {
                Console.WriteLine("Nhap vao nam: ");
                Nam = Convert.ToInt32(Console.ReadLine());
            } while (Nam <= 0);

            do
            {
                Console.WriteLine("Nhap vao gio: ");
                Gio = Convert.ToInt32(Console.ReadLine());
            } while (Gio < 0 || Gio > 24);


            do
            {
                Console.WriteLine("Nhap vao phut: ");
                Phut = Convert.ToInt32(Console.ReadLine());
            } while (Phut < 0 || Phut > 60);

            do
            {
                Console.WriteLine("Nhap vao giay: ");
                Giay = Convert.ToInt32(Console.ReadLine());
            } while (Giay < 0 || Giay > 60);

            DateTime ngay = new DateTime(Nam, Thang, Ngay);
            day = ngay.DayOfWeek;
        }
        public void Formattime(ThoiGian temptg)
        {
            if(temptg.giay >= 60)
            {
                temptg.giay = 0;
                temptg.phut++;
            }
            if (temptg.phut >= 60)
            {
                temptg.phut = 0;
                temptg.gio++;
            }
            if (temptg.gio >= 24)
            {
                temptg.gio = 0;
                temptg.ngay++;
            }
            int[] thangchan = { 4, 6, 9, 11 };
            int[] thangle = { 1,3,5,7,8,10,12};
            if ((Array.IndexOf(thangchan,temptg.thang )>=0 && temptg.ngay>30) || (Array.IndexOf(thangle, temptg.thang) >= 0 && temptg.ngay > 31)
                ||( temptg.thang == 2 && temptg.ngay > 28))
            {
                temptg.ngay = 0;
                temptg.thang++;
            }
            if(temptg.thang > 12)
            {
                temptg.thang = 1;
                temptg.nam++;
            }
            
        }
        public void outputtime()
        {
           
            Console.WriteLine("{0}, {1}/{2}/{3}  {4}:{5}:{6}", day, ngay, thang, nam, gio, phut, giay);
        }
        public void ganthoigian()
        {
            DateTime now = DateTime.Now;
            Ngay = now.Day;
            Thang = now.Month;
            Nam = now.Year;
            gio = now.Hour;
            phut = now.Minute;
            giay = now.Second;
           

        }
      
        public void AddDay( int day)
        {
            
            DateTime ngay = new DateTime(Nam , Thang, Ngay);
            ngay = ngay.AddDays(day);
            Ngay = ngay.Day; Thang = ngay.Month; Nam = ngay.Year;
            
        }
        public void SubDay(int day)
        {
            DateTime ngay = new DateTime(Nam, Thang, Ngay);
            ngay = ngay.AddDays(-day);
            Ngay = ngay.Day; Thang = ngay.Month; Nam = ngay.Year;
        }
        public void AddMonth(int thang)
        {
            DateTime ngay = new DateTime(Nam, Thang, Ngay);
            ngay = ngay.AddMonths(thang);
            Ngay = ngay.Day; Thang = ngay.Month; Nam = ngay.Year;
        }
        public void SubMonth(int thang)
        {
            DateTime ngay = new DateTime(Nam, Thang, Ngay);
            ngay = ngay.AddMonths(-thang);
            Ngay = ngay.Day; Thang = ngay.Month; Nam = ngay.Year;
        }
        public void Distance(ThoiGian tempthoigian1, ThoiGian templatethoigian2)
        {

        }

    }
}
