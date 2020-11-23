using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
namespace DAL_QuanLyQuayThuoc
{
    public class DAL_Thuoc
    {
        QuayThuocDataContext db;
        public DAL_Thuoc()
        {
            db = new QuayThuocDataContext();
        }
        public List<DTO_Thuoc> layDanhSachThuoc()
        {
            var dst = db.Thuocs.Select(p => p).OrderBy(p => p.Ma_Thuoc);
            List<DTO_Thuoc> lst = new List<DTO_Thuoc>();
            foreach (Thuoc item in dst)
            {
                DTO_Thuoc t = new DTO_Thuoc();
                t.MaThuoc = item.Ma_Thuoc;
                t.MaNhaCC = item.Ma_NCC;
                t.TenThuoc = item.Ten_Thuoc;
                t.CongDung = item.CongDung_Thuoc;
                t.DonViTinh = item.DonViTinh_Thuoc;
                t.DonGia = item.DonGia_Thuoc;
                t.SoLuongThuoc = item.SoLuongThuoc;
                t.NgaySX = item.NSX_Thuoc;
                t.HanSD = item.HSD_Thuoc;

                lst.Add(t);
            }
            return lst;
        }
        public bool xoaMaHoaDon(string maNCC)
        {
            var lit = db.Thuocs.Where(x => x.Ma_NCC.Equals(maNCC));
            List<DTO_Thuoc> li = new List<DTO_Thuoc>();
            if (lit != null)
            {
                foreach (Thuoc th in lit)
                {
                    DTO_Thuoc t = new DTO_Thuoc();
                    t.MaThuoc = th.Ma_Thuoc;
                    li.Add(t);
                }
                foreach (DTO_Thuoc th in li)
                {
                    var hdtemp = db.HoaDons.Where(x => x.Ma_Thuoc == th.MaThuoc);
                    if (hdtemp != null)
                    {
                        foreach (HoaDon item in hdtemp)
                        {
                            db.HoaDons.DeleteOnSubmit(item);
                            db.SubmitChanges();
                        }
                    }
                }
                foreach (Thuoc item in lit)
                {
                    db.Thuocs.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
                return true;

            }
            return false;
        }
        public List<object> layChiTietThuoc()
        {
            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }

        public DTO_Thuoc layThuocTheoMa(string mathuoc)
        {
            Thuoc ttemp = db.Thuocs.Where(x => x.Ma_Thuoc.Equals(mathuoc)).FirstOrDefault();

            DTO_Thuoc tt = new DTO_Thuoc();
            tt.MaThuoc = ttemp.Ma_Thuoc;
            tt.TenThuoc = ttemp.Ten_Thuoc;
            tt.CongDung = ttemp.CongDung_Thuoc;
            tt.DonViTinh = ttemp.DonViTinh_Thuoc;
            tt.DonGia = ttemp.DonGia_Thuoc;
            tt.NgaySX = ttemp.NSX_Thuoc;
            tt.HanSD = ttemp.HSD_Thuoc;
            tt.SoLuongThuoc = ttemp.SoLuongThuoc;

            return tt;
        }
        private bool CheckIfExist(string mathuoc)
        {
            Thuoc ttemp = db.Thuocs.Where(x => x.Ma_Thuoc.Equals(mathuoc)).FirstOrDefault();
            if (ttemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themThuoc(DTO_Thuoc tnew, DTO_NhaCungCap nccnew)
        {
            if (CheckIfExist(tnew.MaThuoc))
            {
                return false;
            }

            Thuoc ttemp = new Thuoc();
            ttemp.Ma_Thuoc = tnew.MaThuoc;
            ttemp.Ma_NCC = tnew.MaNhaCC;
            ttemp.Ten_Thuoc = tnew.TenThuoc;
            ttemp.CongDung_Thuoc = tnew.CongDung;
            ttemp.DonGia_Thuoc = tnew.DonGia;
            ttemp.DonViTinh_Thuoc = tnew.DonViTinh;
            ttemp.SoLuongThuoc = tnew.SoLuongThuoc;
            ttemp.NSX_Thuoc = tnew.NgaySX;
            ttemp.HSD_Thuoc = tnew.HanSD;

            db.Thuocs.InsertOnSubmit(ttemp);
            db.SubmitChanges();
            return true;
        }

        public bool xoaThuoc(string mathuoc)
        {
            Thuoc ttemp = db.Thuocs.Where(x => x.Ma_Thuoc.Equals(mathuoc)).FirstOrDefault();
            if (ttemp != null)
            {
                db.Thuocs.DeleteOnSubmit(ttemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaThuoc(DTO_Thuoc tnew)
        {
            IQueryable<Thuoc> t = db.Thuocs.Where(x => x.Ma_Thuoc.Equals(tnew.MaThuoc));
            if (t.Count() >= 0)
            {
                t.First().Ma_Thuoc = tnew.MaThuoc;
                t.First().Ma_NCC = tnew.MaNhaCC;
                t.First().Ten_Thuoc = tnew.TenThuoc;
                t.First().CongDung_Thuoc = tnew.CongDung;
                t.First().DonViTinh_Thuoc = tnew.DonViTinh;
                t.First().DonGia_Thuoc = tnew.DonGia;
                t.First().SoLuongThuoc = tnew.SoLuongThuoc;
                t.First().NSX_Thuoc = tnew.NgaySX;
                t.First().HSD_Thuoc = tnew.HanSD;

                db.SubmitChanges();

                return true;
            }
            return false;
        }
        public List<object> layThuocTheoLoai(string loaithuoc)
        {
            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       where ncc.LoaiThuoc_NCC.Equals(loaithuoc)
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> layThuocTheoTinhTrang_ConHan()
        {

            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       where t.HSD_Thuoc >= DateTime.Now
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> layThuocTheoTinhTrang_HetHan()
        {

            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       where t.HSD_Thuoc < DateTime.Now
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }

        public List<object> layThuocTheoLoaiVaTinhTrang_ConHan(string loaithuoc)
        {

            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       where t.HSD_Thuoc >= DateTime.Now && ncc.LoaiThuoc_NCC.Equals(loaithuoc)
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> layThuocTheoLoaiVaTinhTrang_HetHan(string loaithuoc)
        {

            var dst = (from t in db.Thuocs
                       join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                       where t.HSD_Thuoc < DateTime.Now && ncc.LoaiThuoc_NCC.Equals(loaithuoc)
                       select new
                       {
                           MaThuoc = t.Ma_Thuoc,
                           TenNhaCungCap = ncc.Ten_NCC,
                           TenThuoc = t.Ten_Thuoc,
                           CongDung = t.CongDung_Thuoc,
                           DonViTinh = t.DonViTinh_Thuoc,
                           DonGia = t.DonGia_Thuoc,
                           NgaySX = t.NSX_Thuoc,
                           HanSD = t.HSD_Thuoc,
                           SoLuong = t.SoLuongThuoc
                       }).OrderBy(x => x.MaThuoc);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        public DTO_Thuoc timTheoMa(string ma) // chỉ lấy một cột trong database
        {
            Thuoc dst = db.Thuocs.Where(x => x.Ma_Thuoc.Equals(ma)).FirstOrDefault();
            DTO_Thuoc t = new DTO_Thuoc();
            t.MaNhaCC = dst.Ma_NCC;
            return t;
        }
        public bool themThuoc(DTO_Thuoc tnew)
        {
            if (CheckIfExist(tnew.MaThuoc))
            {
                return false;
            }

            Thuoc ttemp = new Thuoc();
            ttemp.Ma_Thuoc = tnew.MaThuoc;
            ttemp.Ma_NCC = tnew.MaNhaCC;
            ttemp.Ten_Thuoc = tnew.TenThuoc;
            ttemp.CongDung_Thuoc = tnew.CongDung;
            ttemp.DonGia_Thuoc = tnew.DonGia;
            ttemp.DonViTinh_Thuoc = tnew.DonViTinh;
            ttemp.SoLuongThuoc = tnew.SoLuongThuoc;
            ttemp.NSX_Thuoc = tnew.NgaySX;
            ttemp.HSD_Thuoc = tnew.HanSD;

            db.Thuocs.InsertOnSubmit(ttemp);
            db.SubmitChanges();
            return true;
        }
        public List<object> TimMoiDieuKien(string ten, string loai, string hsd)
        {
            if (ten.Equals(""))
            {
                if (loai.Equals("(None)"))
                {
                    if (hsd.Equals("Hết hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc <= DateTime.Now)
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else if (hsd.Equals("Còn hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc > DateTime.Now)
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else
                    {
                        var dst = (from t in db.Thuocs
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                }
                else
                {
                    if (hsd.Equals("Hết hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc <= DateTime.Now)
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else if (hsd.Equals("Còn hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc > DateTime.Now)
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else
                    {
                        var dst = (from t in db.Thuocs
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                }
            }
            else
            {
                if (loai.Equals("(None)"))
                {
                    if (hsd.Equals("Hết hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc <= DateTime.Now && x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else if (hsd.Equals("Còn hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc > DateTime.Now && x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                }
                else
                {
                    if (hsd.Equals("Hết hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc <= DateTime.Now && x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else if (hsd.Equals("Còn hạn"))
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.HSD_Thuoc > DateTime.Now && x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                    else
                    {
                        var dst = (from t in db.Thuocs.Where(x => x.Ten_Thuoc.Equals(ten))
                                   join ncc in db.NhaCungCaps.Where(p => p.LoaiThuoc_NCC.Equals(loai)) on t.Ma_NCC equals ncc.Ma_NCC
                                   select new
                                   {
                                       MaThuoc = t.Ma_Thuoc,
                                       TenNhaCungCap = ncc.Ten_NCC,
                                       TenThuoc = t.Ten_Thuoc,
                                       CongDung = t.CongDung_Thuoc,
                                       DonViTinh = t.DonViTinh_Thuoc,
                                       DonGia = t.DonGia_Thuoc,
                                       NgaySX = t.NSX_Thuoc,
                                       HanSD = t.HSD_Thuoc,
                                       SoLuong = t.SoLuongThuoc,
                                       LoaiThuoc = ncc.LoaiThuoc_NCC
                                   }).OrderBy(x => x.MaThuoc);
                        List<object> lst = new List<object>();
                        foreach (var item in dst)
                        {
                            lst.Add(item);
                        }
                        return lst;
                    }
                }
            }


        }
    }
}