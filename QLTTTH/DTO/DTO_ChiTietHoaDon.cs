using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        private int ma_hd;
        private int ma_KH;

        public DTO_ChiTietHoaDon()
        {
        }

        public DTO_ChiTietHoaDon(int ma_hd, int ma_KH)
        {
            this.Ma_hd = ma_hd;
            this.Ma_KH = ma_KH;
        }

        public int Ma_hd { get => ma_hd; set => ma_hd = value; }
        public int Ma_KH { get => ma_KH; set => ma_KH = value; }
    }
}
