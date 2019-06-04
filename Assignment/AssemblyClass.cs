using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAssemblyNamespace
{
    public class ATM
    {
        //variable
        protected string soTaiKhoan, tenChuThe;
        protected DateTime ngaySinh, ngayMoThe;
        protected int cMND, hanSuDung, soDu, maPIN;
        //end variable

        //property
        public string Sotaikhoan
        {
            get { return soTaiKhoan; }
            set { if (value != null && value.Length >= 10) soTaiKhoan = value; }
        }
        public string Tenchuthe
        {
            get { return tenChuThe; }
            set
            {
                if (value != null && Array.TrueForAll(value.ToCharArray(), c => char.IsDigit(c) == false)) tenChuThe = value;
            }
        }
        public DateTime Ngaysinh
        {
            get { return ngaySinh; }
            set
            {
                DateTime now = DateTime.Now;
                if ((value.Year - now.Year) >= 18) ngaySinh = value;
            }
        }
        public int Cmnd
        {
            get { return cMND; }
            set { if ((value.ToString().Length) > 9) cMND = value; }
        }
        public DateTime Ngaymothe
        {
            get { return ngayMoThe; }
            set { if (value.Year >= ngayMoThe.Year + 18) ngayMoThe = value; }
        }
        public int Sodu
        {
            get { return soDu; }
            set { if (value >= 100000) soDu = value; }
        }
        public int Mapin
        {
            get { return maPIN; }
            set
            {
                if ((value.ToString().Length == 6) && Array.TrueForAll(value.ToString().ToCharArray(), c => char.IsDigit(c) == true)) maPIN = value;
            }
        }
        // end property
    }
                            
    
    public interface IQuanLy
    {
        void layDanhSachThe();
        void xuatDanhSachThe();
        void themTheMoi();
        void lietKeDSTheHetHan();
        void giaHanTheHetHan();
        void suaThongTinThe();
        void xoaTheHetHan();
    }
    public interface IThaoTac
    {
        void dangNhap();
        void dangXuat();
        void vanTin();
        void napTien();
        void rutTien();
        void chuyenTien();
        void nhatKyGiaoDich();
    }
    public class listATM: ATM, IQuanLy, IThaoTac
    {
        //Hien thuc cac interfaces
       
        void IQuanLy.layDanhSachThe()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.xuatDanhSachThe()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.themTheMoi()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.lietKeDSTheHetHan()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.giaHanTheHetHan()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.suaThongTinThe()
        {
            throw new NotImplementedException();
        }

        void IQuanLy.xoaTheHetHan()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.dangNhap()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.dangXuat()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.vanTin()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.napTien()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.rutTien()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.chuyenTien()
        {
            throw new NotImplementedException();
        }

        void IThaoTac.nhatKyGiaoDich()
        {
            throw new NotImplementedException();
        }
        //Ket thuc hien thuc interfaces
    }
}






//Copy Paste List

//-------------------------------
//void layDanhSachThe()
//{
//}
//void xuatDanhSachThe()
//{
//}
//void themTheMoi()
//{

//}
//void lietKeDSTheHetHan()
//{
//}
//void giaHanTheHetHan()
//{

//}
//void suaThongTinThe()
//{

//}
//void xoaTheHetHan()
//{

//}
//void dangNhap()
//{

//}
//void dangXuat()
//{

//}
//void vanTin()
//{

//}

//void napTien()
//{

//}
//void rutTien()
//{

//}
//void chuyenTien()
//{

//}
//void nhatKyGiaoDich()
//{

//}

