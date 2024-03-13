using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocVien
    {
        private string ma_HV;
        private string ten_HV;
        private DateTime nam_sinh;
        private string dia_chi;
        private string sdt;

        public DTO_HocVien() { }

        public DTO_HocVien(string ma_HV, string ten_HV, DateTime nam_sinh, string dia_chi, string sdt)
        {
            this.Ma_HV = ma_HV;
            this.Ten_HV = ten_HV;
            this.Nam_sinh = nam_sinh;
            this.Dia_chi = dia_chi;
            this.Sdt = sdt;
        }

        public string Ma_HV { get => ma_HV; set => ma_HV = value; }
        public string Ten_HV { get => ten_HV; set => ten_HV = value; }
        public DateTime Nam_sinh { get => nam_sinh; set => nam_sinh = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
