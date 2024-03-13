using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiangVien
    {
        private string ma_GV;
        private string ten_GV;
        private DateTime nam_sinh;
        private string sdt;
        private string que_quan;

        public DTO_GiangVien() { }

        public DTO_GiangVien(string ma_GV, string ten_GV, DateTime nam_sinh, string sdt, string que_quan)
        {
            this.Ma_GV = ma_GV;
            this.Ten_GV = ten_GV;
            this.Nam_sinh = nam_sinh;
            this.Sdt = sdt;
            this.Que_quan = que_quan;
        }

        public string Ma_GV { get => ma_GV; set => ma_GV = value; }
        public string Ten_GV { get => ten_GV; set => ten_GV = value; }
        public DateTime Nam_sinh { get => nam_sinh; set => nam_sinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Que_quan { get => que_quan; set => que_quan = value; }
    }
}
