using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
using DAL_QuanLyQuayThuoc;

namespace BUS_QuanLyQuayThuoc
{
    public class BUS_Account
    {
        DAL_Account accDAL;
        public BUS_Account()
        {
            accDAL = new DAL_Account();
        }
        public List<DTO_Account> getAllAccount()
        {
            return accDAL.getDanhSachAccount();
        }
        public bool getAccountTheoUser(string username)
        {
            return accDAL.getAccountTheoUser(username);
        }
        public bool addACC(DTO_Account ACC)
        {
            return accDAL.themACC(ACC);
        }
        public bool delACC(string ACC)
        {
            return accDAL.xoaACC(ACC);
        }
        public bool editACC(DTO_Account khnew)
        {
            return accDAL.suaTaiKhoan(khnew);
        }
    }
}
