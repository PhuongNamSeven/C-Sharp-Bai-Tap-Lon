using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
using DAL_QuanLyQuayThuoc;
namespace BUS_QuanLyQuayThuoc
{
    public class BUS_HoaDon
    {
        DAL_HoaDon hdDAL;
        public BUS_HoaDon()
        {
            hdDAL = new DAL_HoaDon();
        }
        public List<DTO_HoaDon> getAllHoaDon()
        {
            return hdDAL.getDanhSachHoaDon();
        }
        public List<object> getHoaDonInfo()
        {
            return hdDAL.getChiTietHoaDon();
        }        
        public bool addHoaDon(DTO_HoaDon hdnew, DTO_KhachHang khnew, DTO_Thuoc tnew)
        {
            return hdDAL.themHoaDon(hdnew, khnew, tnew);
        }
        public bool deleteHoaDon(int mahd)
        {
            return hdDAL.xoaHoaDon(mahd);
        }
        public bool editHoaDon(DTO_HoaDon hdnew)
        {
            return hdDAL.suaHoaDon(hdnew);
        }
        public List<object> getHoaDonTheoNgay(DateTime date)
        {
            return hdDAL.layHoaDonTheoNgay(date);
        }
        public List<object> getHoaDonTheoNgayTheoLoai(DateTime date, string loaihd)
        {
            return hdDAL.layHoaDonTheoNgayTheoLoai(date, loaihd);
        }
        public List<object> getHoaDonFromTree_QLDT(string l1)
        {
            return hdDAL.layHoaDonFromTree_QLDT(l1);
        }
        public bool deleteHDTheoMaThuoc(string maThuoc)
        {
            return hdDAL.xoaHoaDonTheoMaThuoc(maThuoc);
        }
        public List<object> getHoaDonFromTree(string l1)
        {
            return hdDAL.layHoaDon(l1);
        }
    }
}
