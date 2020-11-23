using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuayThuoc
{
    public class DTO_Thuoc
    {
        private string maThuoc;
        private string maNhaCC;
        private string tenThuoc;
        private string congDung;
        private string donViTinh;
        private int donGia;
        private DateTime ngaySX;
        private DateTime hanSD;
        private int soLuongThuoc;

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string MaNhaCC { get => maNhaCC; set => maNhaCC = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string CongDung { get => congDung; set => congDung = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuongThuoc { get => soLuongThuoc; set => soLuongThuoc = value; }
        public DateTime NgaySX { get => ngaySX; set => ngaySX = value; }
        public DateTime HanSD { get => hanSD; set => hanSD = value; }

        public DTO_Thuoc()
        {

        }
        public DTO_Thuoc(string mathuoc, string manhaccc, string tenthuoc, string congdung, string donvitinh, int dongia, int soluongthuoc, DateTime nsx, DateTime hsd)
        {
            this.MaThuoc = mathuoc;
            this.MaNhaCC = manhaccc;
            this.TenThuoc = tenthuoc;
            this.CongDung = congdung;
            this.DonViTinh = donvitinh;
            this.DonGia = dongia;
            this.NgaySX = nsx;
            this.HanSD = hsd;
            this.SoLuongThuoc = soluongthuoc;
        }
    }
}
