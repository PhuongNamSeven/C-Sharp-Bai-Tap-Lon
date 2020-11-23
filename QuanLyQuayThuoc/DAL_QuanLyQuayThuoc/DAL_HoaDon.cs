using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;

namespace DAL_QuanLyQuayThuoc
{
    public class DAL_HoaDon
    {
        QuayThuocDataContext db;
        public DAL_HoaDon()
        {
            db = new QuayThuocDataContext();
        }

        public List<DTO_HoaDon> getDanhSachHoaDon()
        {
            var dshd = db.HoaDons.Select(p => p).OrderBy(x => x.Ma_HD);
            List<DTO_HoaDon> lsthd = new List<DTO_HoaDon>();
            foreach (HoaDon item in dshd)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.MaHoaDon = item.Ma_HD;
                hd.MaKhach = item.Ma_KhachHang;
                hd.MaThuoc = item.Ma_Thuoc;
                hd.NgayLap = item.NgayLap_HD;
                hd.SoLuong = item.SoLuong_HD;
                hd.LoaiHoaDon = item.Loai_HD;

                lsthd.Add(hd);
            }
            return lsthd;
        }
        public List<DTO_HoaDon> layHoaDonTheoLoai(string loaihd)
        {
            var dshd = db.HoaDons.Where(p => p.Loai_HD.Equals(loaihd));
            List<DTO_HoaDon> lsthd = new List<DTO_HoaDon>();
            foreach (HoaDon item in dshd)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.MaHoaDon = item.Ma_HD;
                hd.MaKhach = item.Ma_KhachHang;
                hd.MaThuoc = item.Ma_Thuoc;
                hd.NgayLap = item.NgayLap_HD;
                hd.SoLuong = item.SoLuong_HD;
                hd.LoaiHoaDon = item.Loai_HD;

                lsthd.Add(hd);
            }
            return lsthd;
        }
        public List<object> getChiTietHoaDon()
        {
            var dshd = (from hd in db.HoaDons
                       join kh in db.KhachHangs on hd.Ma_KhachHang equals kh.Ma_KhachHang
                       join t in db.Thuocs on hd.Ma_Thuoc equals t.Ma_Thuoc
                       select new { MaHoaDon = hd.Ma_HD, NgayLapHD = hd.NgayLap_HD, LoaiHD = hd.Loai_HD, TenKhachHang = kh.Ten_KhachHang,
                                    MaThuoc = t.Ma_Thuoc, TenThuoc = t.Ten_Thuoc, CongDung = t.CongDung_Thuoc, DonGia = t.DonGia_Thuoc,
                                    SoLuong = hd.SoLuong_HD, DonViTinh = t.DonViTinh_Thuoc, ThanhTien = (hd.SoLuong_HD * t.DonGia_Thuoc)}).OrderBy(x=>x.MaHoaDon);
            List<object> lshd = new List<object>();
            foreach (var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }

        public List<object> layHoaDonTheoNgay(DateTime date)
        {
            var dshd = (from hd in db.HoaDons
                        join kh in db.KhachHangs on hd.Ma_KhachHang equals kh.Ma_KhachHang
                        join t in db.Thuocs on hd.Ma_Thuoc equals t.Ma_Thuoc
                        where (hd.NgayLap_HD.Day == date.Day && hd.NgayLap_HD.Month == date.Month && hd.NgayLap_HD.Year == date.Year)
                        select new
                        {
                            MaHoaDon = hd.Ma_HD,
                            NgayLapHD = hd.NgayLap_HD,
                            LoaiHD = hd.Loai_HD,
                            TenKhachHang = kh.Ten_KhachHang,
                            MaThuoc = t.Ma_Thuoc,
                            TenThuoc = t.Ten_Thuoc,
                            CongDung = t.CongDung_Thuoc,
                            DonGia = t.DonGia_Thuoc,
                            SoLuong = hd.SoLuong_HD,
                            DonViTinh = t.DonViTinh_Thuoc,
                            ThanhTien = (hd.SoLuong_HD * t.DonGia_Thuoc)
                        }).OrderBy(x => x.MaHoaDon);
            List<object> lshd = new List<object>();
            foreach (var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }
        public List<object> layHoaDonTheoNgayTheoLoai(DateTime date, string loaihd)
        {
            var dshd = (from hd in db.HoaDons
                        join kh in db.KhachHangs on hd.Ma_KhachHang equals kh.Ma_KhachHang
                        join t in db.Thuocs on hd.Ma_Thuoc equals t.Ma_Thuoc
                        where((hd.NgayLap_HD.Day == date.Day && hd.NgayLap_HD.Month == date.Month && hd.NgayLap_HD.Year == date.Year) && (hd.Loai_HD.Equals(loaihd)))
                        select new
                        {
                            MaHoaDon = hd.Ma_HD,
                            NgayLapHD = hd.NgayLap_HD,
                            LoaiHD = hd.Loai_HD,
                            TenKhachHang = kh.Ten_KhachHang,
                            MaThuoc = t.Ma_Thuoc,
                            TenThuoc = t.Ten_Thuoc,
                            CongDung = t.CongDung_Thuoc,
                            DonGia = t.DonGia_Thuoc,
                            SoLuong = hd.SoLuong_HD,
                            DonViTinh = t.DonViTinh_Thuoc,
                            ThanhTien = (hd.SoLuong_HD * t.DonGia_Thuoc)
                        }).OrderBy(x => x.MaHoaDon);
            List<object> lshd = new List<object>();
            foreach (var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }
        private bool CheckIfExist(int mahoadon)
        {
            HoaDon hdtemp = db.HoaDons.Where(x => x.Ma_HD == mahoadon).FirstOrDefault();
            if (hdtemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themHoaDon(DTO_HoaDon hdnew, DTO_KhachHang khnew, DTO_Thuoc tnew)
        {
            if (CheckIfExist(hdnew.MaHoaDon))
            {
                return false;
            }

            
            HoaDon hdtemp = new HoaDon();
            hdtemp.Ma_Thuoc = hdnew.MaThuoc;
            hdtemp.Ma_KhachHang = hdnew.MaKhach;
            DateTime date = Convert.ToDateTime(hdnew.NgayLap);
            hdtemp.NgayLap_HD = date;
            hdtemp.SoLuong_HD = hdnew.SoLuong;
            hdtemp.Loai_HD = hdnew.LoaiHoaDon;         
            

            db.HoaDons.InsertOnSubmit(hdtemp);
            db.SubmitChanges();
            return true;
        }

        public bool xoaHoaDon(int mahd)
        {
            HoaDon hdtemp = db.HoaDons.Where(x => x.Ma_HD == mahd).FirstOrDefault();
            if (hdtemp != null)
            {
                db.HoaDons.DeleteOnSubmit(hdtemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaHoaDon(DTO_HoaDon hdnew)
        {
            IQueryable<HoaDon> hd = db.HoaDons.Where(x => x.Ma_HD == hdnew.MaHoaDon);
            if (hd.Count() >= 0)
            {
                hd.First().Ma_HD = hdnew.MaHoaDon;
                hd.First().Ma_KhachHang = hdnew.MaKhach;
                hd.First().Ma_Thuoc = hdnew.MaThuoc;
                hd.First().NgayLap_HD = hdnew.NgayLap;
                hd.First().SoLuong_HD = hdnew.SoLuong;
                hd.First().Loai_HD = hdnew.LoaiHoaDon;

                db.SubmitChanges();

                return true;
            }
            return false;
        }
        public List<object> layHoaDonFromTree_QLDT(string l1)
        {
            var dshd = (from hd in db.HoaDons
                        join kh in db.KhachHangs on hd.Ma_KhachHang equals kh.Ma_KhachHang
                        join t in db.Thuocs on hd.Ma_Thuoc equals t.Ma_Thuoc
                        where hd.Ma_HD == (Convert.ToInt32(l1))
                        select new
                        {
                            MaHoaDon = hd.Ma_HD,
                            NgayLapHD = hd.NgayLap_HD,
                            LoaiHD = hd.Loai_HD,
                            TenKhachHang = kh.Ten_KhachHang,
                            MaThuoc = t.Ma_Thuoc,
                            TenThuoc = t.Ten_Thuoc,
                            CongDung = t.CongDung_Thuoc,
                            DonGia = t.DonGia_Thuoc,
                            SoLuong = hd.SoLuong_HD,
                            DonViTinh = t.DonViTinh_Thuoc,
                            ThanhTien = (hd.SoLuong_HD * t.DonGia_Thuoc)
                        }).OrderBy(x => x.MaHoaDon);
            List<object> lshd = new List<object>();
            foreach (var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }
        public bool xoaHoaDonTheoMaThuoc(string maThuoc)
        {
            var hdtemp = db.HoaDons.Where(x => x.Ma_Thuoc == maThuoc);
            if (hdtemp != null)
            {
                foreach (HoaDon item in hdtemp)
                {
                    db.HoaDons.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }
        public List<object> layHoaDon(string l1)
        {

            var dshd = (from hd in db.HoaDons
                        join kh in db.KhachHangs on hd.Ma_KhachHang equals kh.Ma_KhachHang
                        join t in db.Thuocs on hd.Ma_Thuoc equals t.Ma_Thuoc
                        where hd.Ma_HD == (Convert.ToInt32(l1))
                        select new
                        {
                            MaHoaDon = hd.Ma_HD,
                            NgayLapHD = hd.NgayLap_HD,
                            LoaiHD = hd.Loai_HD,
                            TenKhachHang = kh.Ten_KhachHang,
                            MaThuoc = t.Ma_Thuoc,
                            TenThuoc = t.Ten_Thuoc,
                            CongDung = t.CongDung_Thuoc,
                            DonGia = t.DonGia_Thuoc,
                            SoLuong = hd.SoLuong_HD,
                            DonViTinh = t.DonViTinh_Thuoc,
                            ThanhTien = (hd.SoLuong_HD * t.DonGia_Thuoc)
                        }).OrderBy(x => x.MaHoaDon);
            List<object> lshd = new List<object>();
            foreach (var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }
    }
}
