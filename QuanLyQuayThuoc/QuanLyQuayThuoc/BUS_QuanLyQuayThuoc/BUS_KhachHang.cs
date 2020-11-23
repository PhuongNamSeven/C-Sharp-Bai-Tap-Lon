using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyQuayThuoc;
using DTO_QuanLyQuayThuoc;

namespace BUS_QuanLyQuayThuoc
{
    public class BUS_KhachHang
    {
        DAL_KhachHang khDAL;
        public BUS_KhachHang()
        {
            khDAL = new DAL_KhachHang();
        }
        public List<DTO_KhachHang> getAllKhachHang()
        {
            return khDAL.layDanhSachKhachHang();
        }
        public bool addKhachHang(DTO_KhachHang khnew)
        {
            return khDAL.themKhachHang(khnew);
        }
        public bool deleteKhachHang(int maKhachHang)
        {
            return khDAL.xoaKhachHang(maKhachHang);
        }
        public bool editKhachHang(DTO_KhachHang khnew)
        {
            return khDAL.suaKhachHang(khnew);
        }
        public DTO_KhachHang getKhachHangTheoTen(string tenkh)
        {
            return khDAL.layKhachHangTheoTen(tenkh);
        }
        public List<DTO_KhachHang> getKhachHangTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            return khDAL.layKhachHangTheoAutocompalet(giaTriTim, theoTen);
        }
    }
}
