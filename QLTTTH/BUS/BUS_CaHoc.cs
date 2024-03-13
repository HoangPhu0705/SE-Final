using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_CaHoc
    {
        DAL_CaHoc dCH = new DAL_CaHoc();
        public Tuple<string, string> getBuoiAndGioHoc(int ma_ca)
        {
            return dCH.getBuoiAndGioHoc(ma_ca);
        }

    }
}
