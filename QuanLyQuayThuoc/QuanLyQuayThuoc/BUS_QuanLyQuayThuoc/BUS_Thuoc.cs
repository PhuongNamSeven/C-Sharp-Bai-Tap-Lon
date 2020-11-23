using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
using DAL_QuanLyQuayThuoc;

namespace BUS_QuanLyQuayThuoc
{
    public class BUS_Thuoc
    {
        DAL_Thuoc tDAL;
        public BUS_Thuoc()
        {
            tDAL = new DAL_Thuoc();
        }
        public List<DTO_Thuoc> getAllThuoc()
        {
            return tDAL.layDanhSachThuoc();
        }
        public List<object> getThuocInfo()
        {
            return tDAL.layChiTietThuoc();
        }
        public DTO_Thuoc getThuocTheoMa(string mathuoc)
        {
            return tDAL.layThuocTheoMa(mathuoc);
        }
        public bool addThuoc(DTO_Thuoc tnew, DTO_NhaCungCap nccnew)
        {
            return tDAL.themThuoc(tnew, nccnew);
        }
        public bool deleteThuoc(string mathuoc)
        {
            return tDAL.xoaThuoc(mathuoc);
        }
        public bool editThuoc(DTO_Thuoc tnew)
        {
            return tDAL.suaThuoc(tnew);
        }
        public List<object> getThuocTheoLoai(string loaithuoc)
        {
            return tDAL.layThuocTheoLoai(loaithuoc);
        }
        public List<object> getThuocTheoTinhTrang_ConHan()
        {
            return tDAL.layThuocTheoTinhTrang_ConHan();
        }
        public List<object> getThuocTheoTinhTrang_HetHan()
        {
            return tDAL.layThuocTheoTinhTrang_HetHan();
        }
        public List<object> getThuocTheoLoaiVaTinhTrang_ConHan(string loaithuoc)
        {
            return tDAL.layThuocTheoLoaiVaTinhTrang_ConHan(loaithuoc);
        }
        public List<object> getThuocTheoLoaiVaTinhTrang_HetHan(string loaithuoc)
        {
            return tDAL.layThuocTheoLoaiVaTinhTrang_HetHan(loaithuoc);
        }
        public DTO_Thuoc getTimTheoMa(string ma)
        {
            return tDAL.timTheoMa(ma);
        }

        public bool addThuoc(DTO_Thuoc tnew)
        {
            return tDAL.themThuoc(tnew);
        }
        public List<object> getDieuKien(string ten, string loai, string hsd)
        {
            return tDAL.TimMoiDieuKien(ten, loai, hsd);
        }
        public bool deleMaHoaDon(string maNCC)
        {
            return tDAL.xoaMaHoaDon(maNCC);
        }
    }
}
