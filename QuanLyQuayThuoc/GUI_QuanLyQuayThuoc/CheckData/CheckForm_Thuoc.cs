using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_QuanLyQuayThuoc
{
    public class CheckForm_Thuoc
    {
        public bool checkMaThuoc(string maThuoc)
        {
            return Regex.Match(maThuoc, @"^[A-Z]+$").Success;
        }
        public bool checkTenThuoc(string tenThuoc)
        {
            return Regex.Match(tenThuoc, @"^[A-Z][^.?!@#$`~%^&*+=_()/\,<>]*$").Success;
        }
        public bool checkSoLuong(string soLuong)
        {
            return Regex.Match(soLuong, @"^[0-9]+$").Success;
        }
        public bool checkCongDung(string congDung)
        {
            return Regex.Match(congDung, @"^[A-Z][^.?!@#$`~%^&*+=_/\<>]*$").Success;

        }
        public bool checkDonGia(string donGia)
        {
            return Regex.Match(donGia, @"^[0-9][0-9\.]{0,10}$").Success;
        }
        public bool checkDonViTinh(string donViTinh)
        {
            return Regex.Match(donViTinh, @"^[A-Z]+[^.?!@#$`~%^&*+=_/\<>]*$").Success;
        }
        public bool checkNhaCC(string NCC)
        {
            return Regex.Match(NCC, @"^[A-Z]+$").Success;
        }

    }

}