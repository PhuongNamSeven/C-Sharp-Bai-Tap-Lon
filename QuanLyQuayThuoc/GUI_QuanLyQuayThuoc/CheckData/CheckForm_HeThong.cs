using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GUI_QuanLyQuayThuoc
{
    public class CheckForm_HeThong
    {
        #region Account
        public bool checkUsername( string username)
        {
            return Regex.Match(username, @"^[\w\d]{1,30}$").Success;
        }
        public bool checkPassword( string password)
        {
            return Regex.Match(password, @"^[\w\d]{6,30}$").Success;
        }
        #endregion
        #region NCC
        public  bool checkMaNCC( string mancc)
        {
            return Regex.Match(mancc, @"^[A-Z]+$").Success;
        }
        public bool checkTenNCC( string tenncc)
        {
            return Regex.Match(tenncc, @"^[A-Z][^.?!@#$`~%^&*+=_()1234567890/\,<>]+$").Success;
        }
        public bool checkSDTNCC( string sdtncc)
        {
            return Regex.Match(sdtncc, @"^([0][0-9]{2}[0-9]{7})$").Success;
        }
        public bool checkLoaiThuoc( string loaithuoc)
        {
            return Regex.Match(loaithuoc, @"^[A-Z][^.?!@#$`~%^&*+=_/\<>]*$").Success;
        }
        public bool checkDiaChi( string diachi)
        {
            return Regex.Match(diachi, @"^[^.?!@#$`~%^&*+=_\<>]*$").Success;
        }
        #endregion
    }
}
