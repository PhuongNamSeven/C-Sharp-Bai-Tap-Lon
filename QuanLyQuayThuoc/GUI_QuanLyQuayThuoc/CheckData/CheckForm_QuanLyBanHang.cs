using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_QuanLyQuayThuoc.CheckData
{
    public class CheckForm_QuanLyBanHang
    {
        public bool checkRegex(string soluong)
        {
            return Regex.Match(soluong, @"^([0-9]{1,2})$").Success;
        }
    }
}
