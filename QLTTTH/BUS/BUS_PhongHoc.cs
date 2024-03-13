using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_PhongHoc
    {
        DAL_PhongHoc dPH = new DAL_PhongHoc();

        public string getTenPH(int maPH)
        {
            return dPH.getTenPH(maPH);
        }
    }
}
