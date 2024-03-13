using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CaHoc
    {
        private int ma_ca;
        private string buoi;
        private string gio_Hoc;


        public DTO_CaHoc() { }

        public DTO_CaHoc(int ma_ca, string buoi, string gio_Hoc)
        {
            this.ma_ca = ma_ca;
            this.buoi = buoi;
            this.gio_Hoc = gio_Hoc;
        }

        public int Ma_ca { get => ma_ca; set => ma_ca = value; }
        public string Buoi { get => buoi; set => buoi = value; }
        public string Gio_Hoc { get => gio_Hoc; set => gio_Hoc = value; }
    }
}
