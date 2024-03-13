using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietDangKy
    {
        private DateTime ngay_Dang_Ky;
        private string ma_HV;
        private int ma_LH;

        public DTO_ChiTietDangKy() { }

        public DTO_ChiTietDangKy(DateTime ngay_Dang_Ky, string ma_HV, int ma_LH)
        {
            this.ngay_Dang_Ky = ngay_Dang_Ky;
            this.ma_HV = ma_HV;
            this.ma_LH = ma_LH;
        }

        public DateTime Ngay_Dang_Ky { get => ngay_Dang_Ky; set => ngay_Dang_Ky = value; }
        public string Ma_HV { get => ma_HV; set => ma_HV = value; }
        public int Ma_LH { get => ma_LH; set => ma_LH = value; }
    }
}
