using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab8
{
    public class XuLyFile
    {

        public XuLyFile() { }

        public static List<HangHoa> InputHangHoa(string path)
        {
            List<HangHoa> DanhSachHangHoa = new List<HangHoa>();
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string lineMa;
                while ((lineMa = streamReader.ReadLine()) != null)
                {
                    string lineTen = streamReader.ReadLine();
                    int lineSoluong = Convert.ToInt32(streamReader.ReadLine());
                    int lineDonGia = Convert.ToInt32(streamReader.ReadLine());
                    int lineThue = Convert.ToInt32(streamReader.ReadLine());
                    DanhSachHangHoa.Add(new HangHoa(lineMa, lineTen, lineSoluong, lineDonGia, lineThue));
                }
            }
            return DanhSachHangHoa;
        }


    }
}
