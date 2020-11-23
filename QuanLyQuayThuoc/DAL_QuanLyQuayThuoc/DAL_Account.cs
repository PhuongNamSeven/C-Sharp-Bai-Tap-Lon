using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
namespace DAL_QuanLyQuayThuoc
{
    public class DAL_Account
    {
        QuayThuocDataContext db;
        public DAL_Account()
        {
            db = new QuayThuocDataContext();
        }
        public List<DTO_Account> getDanhSachAccount()
        {
            var dsacc = db.Accounts.Select(p => p).OrderBy(x => x.UserName);
            List<DTO_Account> lstacc = new List<DTO_Account>();
            foreach (Account item in dsacc)
            {
                DTO_Account acc = new DTO_Account();
                acc.UserName = item.UserName;
                acc.DisplayName = item.DisplayName;
                acc.PassWord = item.PassWord;

                lstacc.Add(acc);
            }
            return lstacc;
        }
        public bool getAccountTheoUser(string username)
        {
            var acc = db.Accounts.Where(p => p.UserName.Equals(username)).FirstOrDefault();
            if(acc!= null)
            {
                return true;
            }
            return false;
        }
        private bool CheckIfExist(string makhach)
        {
            Account khtemp = db.Accounts.Where(x => x.UserName.Equals(makhach)).FirstOrDefault();
            if (khtemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themACC(DTO_Account acc)
        {
            if (CheckIfExist(acc.UserName))
            {
                return false;
            }

            Account acctemp = new Account();
            acctemp.PassWord = acc.PassWord;
            acctemp.UserName = acc.UserName;
            acctemp.DisplayName = acc.DisplayName;


            db.Accounts.InsertOnSubmit(acctemp);
            db.SubmitChanges();
            return true;
        }
        public bool xoaACC(string us)
        {
            Account tktemp = db.Accounts.Where(x => x.UserName.Equals(us)).FirstOrDefault();
            if (tktemp != null)
            {
                db.Accounts.DeleteOnSubmit(tktemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaTaiKhoan(DTO_Account tknew)
        {
            IQueryable<Account> tk = db.Accounts.Where(x => x.UserName.Equals(tknew.UserName));
            if (tk.Count() >= 0)
            {
                //tk.First().UserName = tknew.UserName;
                tk.First().DisplayName = tknew.DisplayName;
                tk.First().PassWord = tknew.PassWord;
                db.SubmitChanges();

                return true;
            }
            return false;
        }
    }
}
