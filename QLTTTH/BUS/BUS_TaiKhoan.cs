using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        private DAL_TaiKhoan dTK = new DAL_TaiKhoan();
        public bool checkLogin(string username, string pass, int type)
        {
            return dTK.checkLogin(username, pass, type);
        }

        public string getMKByTaiKhoan(string username)
        {
            return dTK.getMKByTaiKhoan(username);
        }

        public bool updateMatKhau(string username, string newPass)
        {
            return dTK.updateMatKhau(username, newPass);
        }

        

    }
}
