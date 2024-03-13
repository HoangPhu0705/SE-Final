using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dChiTietHoaDon = new DAL_ChiTietHoaDon();
        public bool themChiTietHoaDon(DTO_ChiTietHoaDon hd)
        {
            return dChiTietHoaDon.themChiTietHoaDon(hd);
        }

        public bool xoaChiTietHoaDon(DTO_ChiTietHoaDon hd)
        {
            return dChiTietHoaDon.xoaChiTietHoaDon(hd);
        }

        public bool suaChiTietHoaDon(DTO_ChiTietHoaDon hd)
        {
            return dChiTietHoaDon.suaChiTietHoaDon(hd);
        }

        public void bindComboBox(ComboBox cbx)
        {
            dChiTietHoaDon.bindComboBox(cbx);
        }
    }
}
