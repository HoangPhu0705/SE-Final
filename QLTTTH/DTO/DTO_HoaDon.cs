using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private int ma_hd;
        private string nguoi_dong_tien;
	    private DateTime ngay_lap;
        private int tong_tien;

        public DTO_HoaDon() { }

        public DTO_HoaDon(int ma_hd, string nguoi_dong_tien, DateTime ngay_lap, int tong_tien)
        {
            this.Ma_hd = ma_hd;
            this.Nguoi_dong_tien = nguoi_dong_tien;
            this.Ngay_lap = ngay_lap;
            this.Tong_tien = tong_tien;
        }

        public int Ma_hd { get => ma_hd; set => ma_hd = value; }
        public string Nguoi_dong_tien { get => nguoi_dong_tien; set => nguoi_dong_tien = value; }
        public DateTime Ngay_lap { get => ngay_lap; set => ngay_lap = value; }
        public int Tong_tien { get => tong_tien; set => tong_tien = value; }
    }
}
