using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string taiKhoan;
        private string pass;
        private int loai;

        public DTO_TaiKhoan() { }

        public DTO_TaiKhoan(string taiKhoan, string pass, int loai)
        {
            this.taiKhoan = taiKhoan;
            this.pass = pass;
            this.loai = loai;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Loai { get => loai; set => loai = value; }
    }
}
