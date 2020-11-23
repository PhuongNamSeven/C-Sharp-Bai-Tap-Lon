using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;

namespace DAL_QuanLyQuayThuoc
{
    public class DAL_KhachHang
    {
        QuayThuocDataContext db;
        public DAL_KhachHang()
        {
            db = new QuayThuocDataContext();
        }

        public List<DTO_KhachHang> layDanhSachKhachHang()
        {
            var dskh = db.KhachHangs.Select(p => p).OrderBy(p => p.Ma_KhachHang);

            List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

            foreach (KhachHang item in dskh)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.MaKhachHang = item.Ma_KhachHang;
                kh.TenKhachHang = item.Ten_KhachHang;
                kh.DiaChi = item.DiaChi_KhachHang;
                kh.SoDienThoai = item.Sdt_KhachHang;
                kh.BenhAn = item.BenhAn_KhachHang;

                lskh.Add(kh);
            }
            return lskh;
        }

        private bool CheckIfExist(int makhach)
        {
            KhachHang khtemp = db.KhachHangs.Where(x => x.Ma_KhachHang == makhach).FirstOrDefault();
            if (khtemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themKhachHang(DTO_KhachHang khnew)
        {
            if (CheckIfExist(khnew.MaKhachHang))
            {
                return false;
            }

            KhachHang khtemp = new KhachHang();
            khtemp.Ten_KhachHang = khnew.TenKhachHang;
            khtemp.DiaChi_KhachHang = khnew.DiaChi;
            khtemp.Sdt_KhachHang = khnew.SoDienThoai;
            khtemp.BenhAn_KhachHang = khnew.BenhAn;

            db.KhachHangs.InsertOnSubmit(khtemp);
            db.SubmitChanges();
            return true;
        }

        public bool xoaKhachHang(int makhachhang)
        {
            KhachHang khtemp = db.KhachHangs.Where(x => x.Ma_KhachHang == makhachhang).FirstOrDefault();
            if (khtemp != null)
            {
                db.KhachHangs.DeleteOnSubmit(khtemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaKhachHang(DTO_KhachHang khnew)
        {
            IQueryable<KhachHang> kh = db.KhachHangs.Where(x => x.Ma_KhachHang == khnew.MaKhachHang);
            if (kh.Count() >= 0)
            {
                kh.First().Ten_KhachHang = khnew.TenKhachHang;
                kh.First().DiaChi_KhachHang = khnew.DiaChi;
                kh.First().Sdt_KhachHang = khnew.SoDienThoai;
                kh.First().BenhAn_KhachHang = khnew.BenhAn;
                db.SubmitChanges();

                return true;
            }
            return false;
        }

        public DTO_KhachHang layKhachHangTheoTen(string tenkh)
        {
            KhachHang khtemp = db.KhachHangs.Where(p => p.Ten_KhachHang.Equals(tenkh)).FirstOrDefault();

            DTO_KhachHang kh = new DTO_KhachHang();
            kh.MaKhachHang = khtemp.Ma_KhachHang;
            kh.TenKhachHang = khtemp.Ten_KhachHang;
            kh.DiaChi = khtemp.DiaChi_KhachHang;
            kh.SoDienThoai = khtemp.Sdt_KhachHang;
            kh.BenhAn = khtemp.BenhAn_KhachHang;

            return kh;
        }
        public List<DTO_KhachHang> layKhachHangTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            if (theoTen)
            {
                var dskh = from kh in db.KhachHangs
                            where kh.Ten_KhachHang.StartsWith(giaTriTim)
                            orderby kh.Ma_KhachHang
                            select kh;
                List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

                foreach (KhachHang item in dskh)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.MaKhachHang = item.Ma_KhachHang;
                    kh.TenKhachHang = item.Ten_KhachHang;
                    kh.DiaChi = item.DiaChi_KhachHang;
                    kh.SoDienThoai = item.Sdt_KhachHang;
                    kh.BenhAn = item.BenhAn_KhachHang;

                    lskh.Add(kh);
                }
                return lskh;
            }
            else
            {
                var dskh = from kh in db.KhachHangs
                           where kh.Sdt_KhachHang.Equals(giaTriTim)
                           orderby kh.Ma_KhachHang
                           select kh;
                List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

                foreach (KhachHang item in dskh)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.MaKhachHang = item.Ma_KhachHang;
                    kh.TenKhachHang = item.Ten_KhachHang;
                    kh.DiaChi = item.DiaChi_KhachHang;
                    kh.SoDienThoai = item.Sdt_KhachHang;
                    kh.BenhAn = item.BenhAn_KhachHang;

                    lskh.Add(kh);
                }
                return lskh;
            }


            return null;
        }

    }
}
