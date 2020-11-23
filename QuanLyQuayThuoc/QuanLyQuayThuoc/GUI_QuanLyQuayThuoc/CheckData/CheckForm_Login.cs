using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_QuanLyQuayThuoc.CheckData
{
    public class CheckForm_Login
    {
        public bool checkUserName(string username)
        {
            bool kt = Regex.Match(username ,@"^[\w\d]{6,30}$").Success;
            return kt;
        }
        public bool checkPassWord(string password)
        {
            bool kt = Regex.Match(password, @"^[\w\d]{6,30}$").Success;
            return kt;
        }
    }
}
