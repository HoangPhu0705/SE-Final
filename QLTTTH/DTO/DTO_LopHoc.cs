using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LopHoc
    {
        private int ma_LH;
        private string ten_LH;
        private int ma_KH;
        private int ma_PH;
        private int ma_ca;
        private string ma_GV;
        private DateTime ngay_bat_dau;
        private DateTime ngay_ket_thuc;
        private bool dang_Mo;
        private int so_buoi;
        private int soluong;
        public DTO_LopHoc()
        {

        }

        public DTO_LopHoc(int ma_LH, string ten_LH, int ma_KH, int ma_PH, int ma_ca, string ma_GV, DateTime ngay_bat_dau, DateTime ngay_ket_thuc, bool dang_Mo, int so_buoi, int soluong)
        {
            this.ma_LH = ma_LH;
            this.ten_LH = ten_LH;
            this.ma_KH = ma_KH;
            this.ma_PH = ma_PH;
            this.ma_ca = ma_ca;
            this.ma_GV = ma_GV;
            this.ngay_bat_dau = ngay_bat_dau;
            this.ngay_ket_thuc = ngay_ket_thuc;
            this.dang_Mo = dang_Mo;
            this.so_buoi = so_buoi;
            this.soluong = soluong;
        }

        public int Ma_LH { get => ma_LH; set => ma_LH = value; }
        public string Ten_LH { get => ten_LH; set => ten_LH = value; }
        public int Ma_KH { get => ma_KH; set => ma_KH = value; }
        public int Ma_PH { get => ma_PH; set => ma_PH = value; }
        public int Ma_ca { get => ma_ca; set => ma_ca = value; }
        public string Ma_GV { get => ma_GV; set => ma_GV = value; }
        public DateTime Ngay_bat_dau { get => ngay_bat_dau; set => ngay_bat_dau = value; }
        public DateTime Ngay_ket_thuc { get => ngay_ket_thuc; set => ngay_ket_thuc = value; }
        public bool Dang_Mo { get => dang_Mo; set => dang_Mo = value; }
        public int So_buoi { get => so_buoi; set => so_buoi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
