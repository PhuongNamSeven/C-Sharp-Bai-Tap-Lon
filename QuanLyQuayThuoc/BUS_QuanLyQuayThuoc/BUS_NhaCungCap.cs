using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyQuayThuoc;
using DTO_QuanLyQuayThuoc;

namespace BUS_QuanLyQuayThuoc
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap nccDAL;
        public BUS_NhaCungCap()
        {
            nccDAL = new DAL_NhaCungCap();
        }
        public List<DTO_NhaCungCap> getAllNhaCungCap()
        {
            return nccDAL.layDanhSachNhaCungCap();
        }
        public DTO_NhaCungCap getNhaCungCapTheoTen(string tenkhach)
        {
            return nccDAL.layNhaCungCapTheoTen(tenkhach);
        }
        public List<object> getNCCInfo()
        {
            return nccDAL.layChiTietNCC();
        }
        public bool addNhaCC(DTO_NhaCungCap nccnew)
        {
            return nccDAL.themNhaCC(nccnew);
        }
        public bool deleteNhaCC(string maNhaCC)
        {
            return nccDAL.xoaNhaCC(maNhaCC);
        }
        public bool editNhaCC(DTO_NhaCungCap tnew)
        {
            return nccDAL.suaNhaCC(tnew);
        }
    }
}
