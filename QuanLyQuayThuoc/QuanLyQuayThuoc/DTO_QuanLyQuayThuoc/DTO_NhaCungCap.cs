using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuayThuoc
{
    public class DTO_NhaCungCap
    {
        private string maNhaCC;
        private string tenNhaCC;
        private string diaChi;
        private string soDT;
        private string loaiThuoc;

        public string MaNhaCC { get => maNhaCC; set => maNhaCC = value; }
        public string TenNhaCC { get => tenNhaCC; set => tenNhaCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string LoaiThuoc { get => loaiThuoc; set => loaiThuoc = value; }

        public DTO_NhaCungCap()
        {

        }

        public DTO_NhaCungCap(string manhacc, string tennhacc, string diachi, string sodt, string loaithuoc)
        {
            this.MaNhaCC = manhacc;
            this.TenNhaCC = tennhacc;
            this.DiaChi = diachi;
            this.SoDT = sodt;
            this.LoaiThuoc = loaithuoc;
        }
    
    }
}
