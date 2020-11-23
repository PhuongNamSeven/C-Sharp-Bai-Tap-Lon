using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuayThuoc;
namespace DAL_QuanLyQuayThuoc
{
    public class DAL_NhaCungCap
    {
        QuayThuocDataContext db;
        public DAL_NhaCungCap()
        {
            db = new QuayThuocDataContext();
        }
        public List<DTO_NhaCungCap> layDanhSachNhaCungCap()
        {
            var dsncc = db.NhaCungCaps.Select(p => p).OrderBy(p => p.Ma_NCC);

            List<DTO_NhaCungCap> lsncc = new List<DTO_NhaCungCap>();

            foreach (NhaCungCap item in dsncc)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                ncc.MaNhaCC = item.Ma_NCC;
                ncc.TenNhaCC = item.Ten_NCC;
                ncc.DiaChi = item.DiaChi_NCC;
                ncc.SoDT = item.Sdt_NCC;
                ncc.LoaiThuoc = item.LoaiThuoc_NCC;

                lsncc.Add(ncc);
            }
            return lsncc;
        }
        public DTO_NhaCungCap layNhaCungCapTheoTen(string tenkhach)
        {
            NhaCungCap ncctemp = db.NhaCungCaps.Where(p => p.Ten_NCC.Equals(tenkhach)).FirstOrDefault();

            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            ncc.MaNhaCC = ncctemp.Ma_NCC;
            ncc.TenNhaCC = ncctemp.Ten_NCC;
            ncc.DiaChi = ncctemp.DiaChi_NCC;
            ncc.SoDT = ncctemp.Sdt_NCC;
            ncc.LoaiThuoc = ncctemp.LoaiThuoc_NCC;

            return ncc;
        }
        public List<object> layChiTietNCC()
        {
            var dst = (from ncc in db.NhaCungCaps
                       select new
                       {
                           MaNCC = ncc.Ma_NCC,
                           TenNCC = ncc.Ten_NCC,
                           DiaChi = ncc.DiaChi_NCC,
                           SdtNCC = ncc.Sdt_NCC,
                           LoaiThuoc = ncc.LoaiThuoc_NCC
                       }).OrderBy(x => x.MaNCC);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        private bool CheckIfExist(string maNhaCC)
        {
            NhaCungCap ttemp = db.NhaCungCaps.Where(x => x.Ma_NCC.Equals(maNhaCC)).FirstOrDefault();
            if (ttemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themNhaCC(DTO_NhaCungCap nccnew)
        {
            if (CheckIfExist(nccnew.MaNhaCC))
            {
                return false;
            }

            NhaCungCap ncc = new NhaCungCap();
            ncc.Ma_NCC = nccnew.MaNhaCC;
            ncc.Ten_NCC = nccnew.TenNhaCC;
            ncc.DiaChi_NCC = nccnew.DiaChi;
            ncc.Sdt_NCC = nccnew.SoDT;
            ncc.LoaiThuoc_NCC = nccnew.LoaiThuoc;
            db.NhaCungCaps.InsertOnSubmit(ncc);
            db.SubmitChanges();
            return true;
        }
        public bool xoaNhaCC(string maNhaCC)
        {
            NhaCungCap ttemp = db.NhaCungCaps.Where(x => x.Ma_NCC.Equals(maNhaCC)).FirstOrDefault();
            if (ttemp != null)
            {
                db.NhaCungCaps.DeleteOnSubmit(ttemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaNhaCC(DTO_NhaCungCap tnew)
        {
            IQueryable<NhaCungCap> t = db.NhaCungCaps.Where(x => x.Ma_NCC.Equals(tnew.MaNhaCC));
            if (t.Count() >= 0)
            {
                t.First().Ma_NCC = tnew.MaNhaCC;
                t.First().Ten_NCC = tnew.TenNhaCC;
                t.First().DiaChi_NCC = tnew.DiaChi;
                t.First().Sdt_NCC = tnew.SoDT;
                t.First().LoaiThuoc_NCC = tnew.LoaiThuoc;

                db.SubmitChanges();

                return true;
            }
            return false;
        }
    }
}
