using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuayThuoc
{
    public class DTO_KhachHang
    {
        private int maKhachHang;
        private string tenKhachHang;
        private string diaChi;
        private string soDienThoai;
        private string benhAn;
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string BenhAn { get => benhAn; set => benhAn = value; }

        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(int makhachhang, string tenkhachhang, string diachi, string sodienthoai, string benhan)
        {
            this.MaKhachHang = makhachhang;
            this.TenKhachHang = tenkhachhang;
            this.DiaChi = diachi;
            this.SoDienThoai = sodienthoai;
            this.BenhAn = benhan;
        }
    }
}
