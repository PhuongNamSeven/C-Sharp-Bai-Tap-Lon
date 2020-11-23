using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuayThuoc
{
    public class DTO_Account
    {
        private string userName;
        private string displayName;
        private string passWord;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public DTO_Account()
        {

        }
        public DTO_Account(string username, string displayname, string passsword)
        {
            this.UserName = username;
            this.DisplayName = displayname;
            this.PassWord = passsword;
        }
    }
}
