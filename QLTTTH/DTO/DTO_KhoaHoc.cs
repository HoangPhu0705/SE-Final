using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhoaHoc
    {
        private int ma_KH;
        private string ten_KH;
        private int hoc_phi;

        public DTO_KhoaHoc(int ma_KH, string ten_KH, int hoc_phi)
        {
            this.ma_KH = ma_KH;
            this.ten_KH = ten_KH;
            this.hoc_phi = hoc_phi;
        }

        public int Ma_KH { get => ma_KH; set => ma_KH = value; }
        public string Ten_KH { get => ten_KH; set => ten_KH = value; }
        public int Hoc_phi { get => hoc_phi; set => hoc_phi = value; }
    }
}
