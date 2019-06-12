using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace AssignmentAssemblyNamespace
{
    public class ATM
    {
        public ATM()
        {
            Sotaikhoan = "1qdfsdfe342365gddsf";
            Tenchuthe = " Nguyen Thi B";
            Ngaysinh = new DateTime(1998, 11, 8);
            Ngaymothe = new DateTime(2020, 1, 1);
            Cmnd = 167893781;
            Hansudung = 12;
            Sodu = 12550000;
            Mapin = 567453;

        }
        //variable
        protected string soTaiKhoan, tenChuThe;
        protected DateTime ngaySinh, ngayMoThe;
        protected int  hanSuDung, maPIN;
        protected decimal cMND, soDu;
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
                if ((now.Year - value.Year) >= 18) ngaySinh = value;
            }
        }
        public decimal Cmnd
        {
            get { return cMND; }
            set { if ((value.ToString().Length) >= 9) cMND = value; }
        }
        public DateTime Ngaymothe
        {
            get { return ngayMoThe; }
            set { if (value.Year >= ngaySinh.Year + 18) ngayMoThe = value; }
        }
        public int Hansudung
        {
            get { return hanSuDung; }
            set { hanSuDung = value; }
        }
        public decimal Sodu
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
   
   
   
    public class listATM : ATM
    {
        DataTable dt;
        decimal sessionatm = 0;
        SQLiteConnection _con = new SQLiteConnection();
        public void createConection()
        {
            string _strConnect = "Data Source=D:\\MyDatabase.sqlite;Version=3;";
            _con.ConnectionString = _strConnect;
            _con.Open();
        }
        public void closeConnection()
        {
            _con.Close();
        }
        public void createTable()
        {
           
            string sql = "CREATE TABLE IF NOT EXISTS tbl_lichsugd " +
                "([id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                " _soTaiKhoanGd TEXT(50),_NoidungGd TEXT, _ngayGd TEXT, _soTienGd decimal);";
            string sql2 = "CREATE TABLE IF NOT EXISTS tbl_atmlists " +
                "([id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                " _soTaiKhoan TEXT(50),  _tenChuThe TEXT(50),_ngaySinh TEXT, _ngayMoThe TEXT, _cMND decimal, _hanSuDung decimal, _soDu decimal, _maPIN decimal);";
           

            // SQLiteConnection.CreateFile("D:\\MyDatabase.sqlite");
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            SQLiteCommand command2 = new SQLiteCommand(sql2, _con);
            command2.ExecuteNonQuery();
             closeConnection();
            Console.WriteLine("Created table successfull !");
            Console.ReadKey();
        }
        public void insertData(ATM T)
        {

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            
            string sqliteconnect = " INSERT INTO tbl_atmlists (_soTaiKhoan, _tenChuThe, _ngaySinh, _ngayMoThe, _cMND, _hanSuDung, _soDu, _maPIN) VALUES" +
                "('" + T.Sotaikhoan + "', '" + T.Tenchuthe + "', '" + T.Ngaysinh.ToString("yyyy-MM-dd") + "', '" + T.Ngaymothe.ToString("yyyy-MM-dd") + "', " + T.Cmnd + ", " + T.Hansudung + ",  " + T.Sodu + ",  '" + T.Mapin + "'); ";
            SQLiteCommand command = new SQLiteCommand(sqliteconnect, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        public void loadData()
        {

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "select * from tbl_atmlists";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            Console.WriteLine("|==================================================================================================================|");
            Console.WriteLine("                                                         DANH SACH THE ATM                                         |");
            Console.WriteLine("|==================================================================================================================|");
            Console.WriteLine("| So tai khoan       |Ten chu the  |  Ngay sinh |  So CMND   |Ngay mo the   | Thoi han( Thang) | So du(VND) | ma PIN |");
            //
            while (reader.Read())
                Console.WriteLine(" " + reader["_Sotaikhoan"] + "       " + reader["_Tenchuthe"] + "   " + reader["_Ngaysinh"].ToString() + "   " + reader["_Cmnd"] + "    " + reader["_Ngaymothe"].ToString() + "           " + reader["_Hansudung"] + "         " + reader["_Sodu"] + "     " + reader["_Mapin"] + "  ");
        }
        public void lietkethehethan()
        {
            DateTime now = DateTime.Now;
            
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "select * from tbl_atmlists" +
                " where ( _Ngaymothe.Convert.ToDateTime().Year - now.Year )* 12 + " +
                "( | _Ngaymothe.Convert.ToDateTime().Month - now.Month )";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            Console.WriteLine("|==================================================================================================================|");
            Console.WriteLine("                                               DANH SACH THE ATM DA HET HAN                                        |");
            Console.WriteLine("|==================================================================================================================|");
            Console.WriteLine("| So tai khoan       |Ten chu the  |  Ngay sinh |  So CMND   |Ngay mo the   | Thoi han( Thang) | So du(VND) | ma PIN |");
            //
            while (reader.Read())
                Console.WriteLine(" " + reader["_Sotaikhoan"] + "       " + reader["_Tenchuthe"] + "   " + reader["_Ngaysinh"].ToString() + "   " + reader["_Cmnd"] + "    " + reader["_Ngaymothe"].ToString() + "           " + reader["_Hansudung"] + "         " + reader["_Sodu"] + "     " + reader["_Mapin"] + "  ");

        }
        public void xoaTheHetHan()
        {
            throw new NotImplementedException();
        }
        public void giahanthe()
        {

            string maatm;
            Console.WriteLine("Moi Nhap vao ma the ATM");
            maatm = Convert.ToString(Console.ReadLine());
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + maatm + "'";
            if (checkselect(sql))
            {
                Console.WriteLine("Login successful ! MOi nhap vao so thang muon gia han:");
                decimal giahan = Convert.ToDecimal(Console.ReadLine());
                Assignment.ThongTin.thoihan = Convert.ToDecimal(dt.Rows[0][6].ToString()) + giahan;
                Console.WriteLine("Completed! Cam on quy khach da su dung dich vu");

            }
            else
            {
                Console.WriteLine("Ma ATM khong hop le! ");
               
            }
            Console.ReadLine();


        }
        public void changename(string maatm)
        {
           
                string newname, confirmname;
                string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + maatm + "'";

                // checkselect(sotaikhoan);
                if (checkselect(sql))
                {
                    
                        Console.WriteLine("Moi nhap vao ten moi moi");
                        newname = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Xac nhan ten moi");
                        confirmname = Convert.ToString(Console.ReadLine());
                        if (newname == confirmname)
                        {
                            string sqlchangename = "UPDATE tbl_atmlists SET [_Tenchuthe] = '" + newname.Trim() + "' where _Sotaikhoan = '" +maatm + "';";

                            if (checkquery(sqlchangename) > 0)
                                Console.WriteLine("Doi ten thanh cong!");
                            else
                                Console.WriteLine("Doi ten khong thanh cong!");

                       
                    }
                    else Console.WriteLine("Ten cu khong chinh xac");



                }
                else
                {
                    Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                    Console.ReadLine();
                    Assignment.ThongTin.sotaikhoan = "";

                }
                Console.ReadKey();
            
        }
        public void changecmnd(string maatm)
        {
           
                string newcmnd, confirmcmnd;
                string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + maatm + "'";

                // checkselect(sotaikhoan);
                if (checkselect(sql))
                {
                   
                        Console.WriteLine("Moi nhap vao CMND moi");
                        newcmnd = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Xac nhan CMND moi");
                        confirmcmnd = Convert.ToString(Console.ReadLine());
                        if (newcmnd == confirmcmnd)
                        {
                            string sqlchangecmnd = "UPDATE tbl_atmlists SET [_cMND] = '" + newcmnd.Trim() + "' where _Sotaikhoan = '" + maatm + "';";

                            if (checkquery(sqlchangecmnd) > 0)
                                Console.WriteLine("Doi CMND thanh cong!");
                            else
                                Console.WriteLine("Doi CMND thanh cong!");

                        }
                        else Console.WriteLine("CMND khong khop");

                }
                else
                {
                    Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                    Console.ReadLine();
                    Assignment.ThongTin.sotaikhoan = "";

                }
                Console.ReadKey();

           
        }
        public void changebirthday(string maatm)
        {

            string newbirthday, confirmbirthday;
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + maatm + "'";

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {
                    Console.WriteLine("Moi nhap vao Ngay sinh moi");
                    newbirthday = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Xac nhan Ngay sinh moi");
                    confirmbirthday = Convert.ToString(Console.ReadLine());
                    if (newbirthday == confirmbirthday)
                    {
                        string sqlchangebirthday = "UPDATE tbl_atmlists SET [_ngaySinh] = '" + newbirthday.Trim() + "' where _Sotaikhoan = '" + maatm + "';";

                        if (checkquery(sqlchangebirthday) > 0)
                            Console.WriteLine("Doi Ngay sinh thanh cong!");
                        else
                            Console.WriteLine("Doi Ngay sinh thanh cong!");

                  
                    }
                else Console.WriteLine("Ngay sinh cu khong chinh xac");



            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();


        }
        public void input()
        {

            Console.WriteLine("Nhap vao thong tin the ATM: ");
            Console.Write("Nhap vao So tai khoan:");
            Sotaikhoan = Convert.ToString(Console.ReadLine());
            Console.Write("\nNhap vao Ten chu the:");
            Tenchuthe = Convert.ToString(Console.ReadLine());
            Console.Write("\nNhap vao Ngay sinh:");
            Ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nNhap vao CMND:");
            Cmnd = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nNhap vao Ngay mo the:");
            Ngaymothe = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nNhap vao Thoi han:");
            Hansudung = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap vao So du :");
            Sodu = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nNhap vao Ma PIN:");
            Mapin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ngaysinh.ToString("yyyy-MM-dd") + "----" + Ngaymothe.ToString("yyyy-MM-dd"));


        }
        public void changepassword(string sotaikhoan)
        {
            string newpass, oldpass, confirmpass;
            //if (sotaikhoan == null) Console.WriteLine("Vui long dang nhap truoc khi thuc hien thao tac");
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";
           
            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {
                Console.Write(" Moi nhap vao mat khau cu:");
                oldpass = Convert.ToString(Console.ReadLine());
                string checkpass = "select * from tbl_atmlists where _maPIN = '" + oldpass + "' AND _Sotaikhoan = '"+sotaikhoan+"';";
                if (checkselect(checkpass))
                {
                    Console.WriteLine("Moi nhap vao mat khau moi");
                    newpass = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Xac nhan mat khau moi");
                    confirmpass = Convert.ToString(Console.ReadLine());
                    if (newpass == confirmpass)
                    {
                        string sqlchangepass = "UPDATE tbl_atmlists SET [_Mapin] = '"+newpass.Trim()+"' where _Sotaikhoan = '"+sotaikhoan+"';";
                        
                        if (checkquery(sqlchangepass)>0)
                            Console.WriteLine("Doi mat khau thanh cong!");
                        else
                            Console.WriteLine("Doi mat khau khong thanh cong!");

                    }
                    else Console.WriteLine("Mat khau khong khop");
                   
                }
                else Console.WriteLine("Mat khau cu khong chinh xac");
               
                

            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();
        }
        public void vantin(string sotaikhoan)
        {
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {

                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
                string sql2 = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";

                SQLiteCommand command = new SQLiteCommand(sql2, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                Console.WriteLine("|==================================================================================================================|");
                Console.WriteLine("                                                    THONG TIN CUA THE ATM                                          |");
                Console.WriteLine("|==================================================================================================================|");
                Console.WriteLine("| So tai khoan       |Ten chu the  |  Ngay sinh |  So CMND   |Ngay mo the   | Thoi han( Nam) | So du(VND) | ma PIN |");
                //
                while (reader.Read())
                    Console.WriteLine(" " + reader["_Sotaikhoan"] + "       " + reader["_Tenchuthe"] + "   " + reader["_Ngaysinh"].ToString() + "   " + reader["_Cmnd"] + "    " + reader["_Ngaymothe"].ToString() + "           " + reader["_Hansudung"] + "         " + reader["_Sodu"] + "     " + reader["_Mapin"] + "  ");

            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();
        }             
        public void naptien(string sotaikhoan)
        {
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";
            int moneyin;
            
            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {

                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
                string stknhan = " None";
                string info = "Nap tien vao TK";
                DateTime now = DateTime.Now;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                Console.WriteLine("Moi nhap vao so tien muon nap vao tai khoan:");
                moneyin = Convert.ToInt32(Console.ReadLine());
                Assignment.ThongTin.sotiennap = moneyin;
                if (moneyin >0)
                {
                   
                    string sqlnguoinhan = " INSERT INTO tbl_lichsugd (_soTaiKhoanGd, _soTaiKhoanNhan, _NoidungGd , _ngayGd, _SotienGd) VALUES" +
                   "('" + sotaikhoan + "', '" + stknhan + "', '" + info + "', '" + now.ToString("yyyy-MM-dd") + "', " + moneyin + "); ";
                    SQLiteCommand command2 = new SQLiteCommand(sqlnguoinhan, m_dbConnection);
                    command.ExecuteNonQuery();
                    m_dbConnection.Close();

                    string sqlnaptien = "UPDATE tbl_atmlists SET [_Sodu] = [_sodu]+ "+moneyin+" where _Sotaikhoan = '" + sotaikhoan + "';";
                    
                    if (checkquery(sqlnaptien) > 0)
                        Console.WriteLine("Nap tien thanh cong!");
                    else
                        Console.WriteLine("Nap tien khong thanh cong!");

                }
                else Console.WriteLine("Mat khau khong khop");

            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();
        }
        public void ruttien(string sotaikhoan)
        {
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";
            int moneyout;

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {

                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
                string stknhan = " None";
                string info = "Rut tien mat";
                DateTime now = DateTime.Now;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                Console.WriteLine("Moi nhap vao so tien muon rut tu tai khoan:");
                moneyout = Convert.ToInt32(Console.ReadLine());
                Assignment.ThongTin.sotiennap = moneyout;
                if (moneyout > 0 && moneyout % 20000 == 0 && moneyout % 50000 ==0 && Assignment.ThongTin.Sodu - moneyout > 100000)
                {

                    string sqlnguoinhan = " INSERT INTO tbl_lichsugd (_soTaiKhoanGd, _soTaiKhoanNhan, _NoidungGd , _ngayGd, _SotienGd) VALUES" +
                   "('" + sotaikhoan + "', '" + stknhan + "', '" + info + "', '" + now.ToString("yyyy-MM-dd") + "', " + moneyout + "); ";
                    SQLiteCommand command2 = new SQLiteCommand(sqlnguoinhan, m_dbConnection);
                    command.ExecuteNonQuery();
                    m_dbConnection.Close();

                    string sqlnaptien = "UPDATE tbl_atmlists SET [_Sodu] = [_sodu]- " + moneyout + " where _Sotaikhoan = '" + sotaikhoan + "';";

                    if (checkquery(sqlnaptien) > 0)
                        Console.WriteLine("Rut tien thanh cong!");
                    else
                    Console.WriteLine("Rut tien khong thanh cong!");

                }
                else Console.WriteLine("So tien nhap vao khong phu hop! Xin nhap lai");

            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();
        }
        public void chuyentien(string sotaikhoan, ATM T)
        {
            string idnguoinhan,idnguoigui = sotaikhoan;
            decimal moneychange;
            //if (sotaikhoan == null) Console.WriteLine("Vui long dang nhap truoc khi thuc hien thao tac");
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {
                Console.Write(" Moi nhap vao ma ATM nguoi nhan:");
                idnguoinhan = Convert.ToString(Console.ReadLine());
                string checkuser = "select * from tbl_atmlists where _Sotaikhoan = '" + idnguoinhan + "';";
                if (checkselect(checkuser))
                {
                    Console.WriteLine("Moi nhap vao so tien muon chuyen");
                    moneychange = Convert.ToDecimal(Console.ReadLine());
                    
                    if (moneychange > 0 && moneychange + 100000 <= Assignment.ThongTin.Sodu)
                    {
                        DateTime now = DateTime.Now;
                        string noidunggd = "temp";
                        SQLiteConnection m_dbConnection;
                        m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
                        m_dbConnection.Open();
                        string sqlnguoichuyen = "UPDATE tbl_atmlists SET [_Sodu] = [_sodu]- " + moneychange + " where _Sotaikhoan = '" + sotaikhoan + "';";
                        // string sqlnguoinhan = "UPDATE tbl_atmlists SET [_Sodu] = [_sodu]- " + moneychange + " where _Sotaikhoan = '" + sotaikhoan + "';";
                        string sqlnguoinhan = " INSERT INTO tbl_lichsugd (_soTaiKhoanGd, _soTaiKhoanNhan, _NoidungGd , _ngayGd, _SotienGd) VALUES" +
                       "('" + sotaikhoan + "', '" + idnguoinhan + "', '" + noidunggd + "', '" + now.ToString("yyyy-MM-dd") + "', " + moneychange + "); ";
                                               
                        SQLiteCommand command = new SQLiteCommand(sqlnguoichuyen, m_dbConnection);
                        command.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(sqlnguoinhan, m_dbConnection);
                        command2.ExecuteNonQuery();
                        chuyentientemp(sotaikhoan, idnguoinhan, moneychange);
                        m_dbConnection.Close();


                        if (checkquery(sqlnguoichuyen) > 0 && checkquery(sqlnguoinhan) > 0)
                            Console.WriteLine("Chuyen tien thanh cong!");
                                                                    
                        else
                            Console.WriteLine("Chuyen tien khong thanh cong!");

                    }
                    else Console.WriteLine("So tien nhap vao khong hop le");

                }
                else Console.WriteLine("Khong tim thay nguoi dung nay !");



            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();
        }
        public void chuyentientemp(string nguoigui,string idnguoinhan, decimal moneychange)
        {
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + idnguoinhan + "'";

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {                   
                        DateTime now = DateTime.Now;
                        string noidunggd = "Nhan CK tu STK: ";
                        SQLiteConnection m_dbConnection;
                        m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
                        m_dbConnection.Open();
                        
                        string sqlnguoinhan = " INSERT INTO tbl_lichsugd (_soTaiKhoanGd, _NoidungGd , _ngayGd, _SotienGd) VALUES" +
                       "('" + nguoigui + "', '" + noidunggd + "', '" + now.ToString("yyyy-MM-dd") + "', " + moneychange + "); ";
                                       
                        SQLiteCommand command2 = new SQLiteCommand(sqlnguoinhan, m_dbConnection);
                        command2.ExecuteNonQuery();
                        m_dbConnection.Close();
            } else Console.WriteLine("Have Err");
        }
        public void lichsugd(string sotaikhoan)
        {

            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + sotaikhoan + "'";
            //int moneyout = 0;

            // checkselect(sotaikhoan);
            if (checkselect(sql))
            {

                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
                string sql2 = "select * from tbl_lichsugd where _soTaiKhoanGd = '" + sotaikhoan + "'";
                SQLiteCommand command = new SQLiteCommand(sql2, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                Console.WriteLine("|==================================================================================================================|");
                Console.WriteLine("                                                     LICH SU GIAO DICH                                             |");
                Console.WriteLine("|==================================================================================================================|");
                Console.WriteLine("| So tai khoan GD       |    Noi dung GD                           | Ngay GD     | So tien GD    |");
                //
                while (reader.Read())
                    Console.WriteLine(" " + reader["_soTaiKhoanGd"] + "    |    " + reader["_NoidungGd"] + "  |    " + reader["_ngayGd"] + "   |    " + reader["_SotienGd"] + " ");
                Console.WriteLine("| End =============================================================================================================|");
            }
            else
            {
                Console.WriteLine("Vui long dang nhap truoc khi su dung! ");
                Console.ReadLine();
                Assignment.ThongTin.sotaikhoan = "";

            }
            Console.ReadKey();

        }
        public bool checkselect(string sql)
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //S reader = command.ExecuteReader();
            //bool kq = reader.Read();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, m_dbConnection);
            dt = new DataTable();
            da.Fill(dt);
            bool kq = dt.Rows.Count > 0;
            m_dbConnection.Close();
            return kq;
            
            //dung cho cau lenh select
        }
        public int checkquery(string sql)
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=D:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            int kq = 0;
            try
            {
                SQLiteCommand command = new SQLiteCommand();// (sql, m_dbConnection);
                command.Connection = m_dbConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                kq= command.ExecuteNonQuery();
                m_dbConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi "+ex.ToString());

            }
            finally
            {
                m_dbConnection.Close();
            }
            return kq;
            //Nonquery: dung de thuc thi 1 cau lenh.insert update delete
            //neu tra ve != 0 thi thuc thi duoc, con == 0 thi ko thuc hien duoc;
        }
        public void dangNhap()
        {
            string maatm;
            Console.WriteLine("Moi Nhap vao ma the ATM");
            maatm = Convert.ToString(Console.ReadLine());
            //SQLiteConnection m_dbConnection;
            //m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            //m_dbConnection.Open();
            string sql = "select * from tbl_atmlists where _Sotaikhoan = '" + maatm + "'";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //ExecuteReader(): Con tro
            if (checkselect(sql))
            {
                Console.WriteLine("Login successful !");
                Assignment.ThongTin.sotaikhoan = maatm;
                Assignment.ThongTin.Sodu = Convert.ToDecimal(dt.Rows[0][7].ToString());
                Assignment.ThongTin.thoihan = Convert.ToDecimal(dt.Rows[0][6].ToString());
                Assignment.ThongTin.maPIN = dt.Rows[0][6].ToString();
                Assignment.ThongTin.ngaymothe = Convert.ToDateTime(dt.Rows[0][4]);
               
            }
            else {
                Console.WriteLine("Ma ATM khong hop le! ");
                Assignment.ThongTin.sotaikhoan = "";
                Assignment.ThongTin.maPIN = " ";
                Assignment.ThongTin.Sodu = 0;
                Assignment.ThongTin.thoihan = 0;

            }
            Console.ReadLine();


        }

    }
}






