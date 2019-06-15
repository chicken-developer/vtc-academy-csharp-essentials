using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab8
{
    public class HangHoa
    {
        private string _maHang;
        private string _tenHang;
        private int _soLuong;
        private int _donGiaNhap;
        private int _thue;
        private double _giaBan;
        public string MaHang { get => _maHang; set => _maHang = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGiaNhap { get => _donGiaNhap; set => _donGiaNhap = value; }
        public int Thue { get => _thue; set => _thue = value; }
        public double GiaBan { get => _giaBan; }

        //constructor
        public HangHoa()
        {
            //nothing
        }

        public HangHoa(string ma, string ten, int sluong, int donGia, int thue)
        {
            this.MaHang = ma;
            this.TenHang = ten;
            this.SoLuong = sluong;
            this.DonGiaNhap = donGia;
            this.Thue = thue;
        }

        public void InHangHoa()
        {
            Console.WriteLine(string.Format("{0,-8}{1,-13}{2,-7}{3,5}{4,5}", this.MaHang, this.TenHang, this.SoLuong, this.DonGiaNhap, this.Thue));
        }
        public void InGiaBan()
        {
            double thueNew = ((double)_thue / 100) * (double)_donGiaNhap;

            _giaBan = _donGiaNhap + thueNew;
            Console.WriteLine("Tên hàng: " + this.TenHang);
            Console.WriteLine("Giá bán: " + this.GiaBan * 1.3);
        }


    }
}
