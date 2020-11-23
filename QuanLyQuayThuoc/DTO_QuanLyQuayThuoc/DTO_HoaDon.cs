using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuayThuoc
{
    public class DTO_HoaDon
    {
        private int maHoaDon;
        private int maKhach;
        private string maThuoc;
        private DateTime ngayLap;
        private int soLuong;
        private string loaiHoaDon;            
           

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaKhach { get => maKhach; set => maKhach = value; }
        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string LoaiHoaDon { get => loaiHoaDon; set => loaiHoaDon = value; }
        

        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(int mahoadon, int makhach, string mathuoc, DateTime ngaylap, int soluong, string loaihoadon)
        {
            this.MaHoaDon = mahoadon;
            this.MaKhach = makhach;
            this.MaThuoc = mathuoc;
            this.NgayLap = ngaylap;
            this.SoLuong = soluong;
            this.LoaiHoaDon = loaihoadon;       
        }
    }
}
