using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public enum LoaiCo
    {
        Vip,
        Thuong
    }
    public class Class1
    {
        private const int GiaCoVip = 50000;
        private const int GiaCoThuong = 30000;
        private const int GiaThemCo = 10000;

        public static double TinhTongTien(LoaiCo co, double Gio, bool ThemCo)
        {
            double giaTien = co == LoaiCo.Vip ? GiaCoVip : GiaCoThuong;
            if (ThemCo)
            {
                giaTien += GiaThemCo;
            }
            return giaTien * Gio;
        }
    }
}
