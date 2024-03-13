using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongHoc
    {
        private int ma_PH;
        private string ten_PH;

        public DTO_PhongHoc(int ma_PH, string ten_PH)
        {
            this.ma_PH = ma_PH;
            this.ten_PH = ten_PH;
        }

        public int Ma_PH { get => ma_PH; set => ma_PH = value; }
        public string Ten_PH { get => ten_PH; set => ten_PH = value; }
    }
}
