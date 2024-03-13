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
    public class BUS_LopHoc
    {
        DAL_LopHoc dLH = new DAL_LopHoc();


        public void bindKHComboBox(ComboBox cbx)
        {
            dLH.bindKHComboBox(cbx);
        }

        public void bindCHComboBox(ComboBox cbx)
        {
            dLH.bindCHComboBox(cbx);
        }

        public void bindPHComboBox(ComboBox cbx)
        {
            dLH.bindPHComboBox(cbx);
        }

        public void bindGVComboBox(ComboBox cbx)
        {
            dLH.bindGVComboBox(cbx);
        }


        public bool themLopHoc(DTO_LopHoc lh)
        {
            return dLH.themLopHoc(lh);
        }


        public bool suaLopHoc(DTO_LopHoc lh)
        {
            return dLH.suaLopHoc(lh);
        }


        public bool xoaLopHoc(DTO_LopHoc lh)
        {
            return dLH.xoaLopHoc(lh);
        }

        public int getMaLHFromTenLH(string tenLH)
        {
            return dLH.getMaLHFromTenLH(tenLH);
        }

        public string getNameById(int id)
        {
            return dLH.getNameById(id);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dLH.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dLH.bindGridViewbySearch(gridView, name);
        }

        public void getLopHocGV(DataGridView dataGridView, string name)
        {
            dLH.getLopHocGV(dataGridView, name);
        }

        public void bindLHComboBoxByGV(ComboBox cbx, string maGV)
        {
            dLH.bindLHComboBoxByGV(cbx, maGV);
        }

        public Tuple<int, int> getMaPHMaCa(int maLH)
        {
            return dLH.getMaPHMaCa(maLH);
        }

        public void bindOpenLHComboBox(ComboBox cbx)
        {
            dLH.bindOpenLHComboBox(cbx);
        }

        public List<int> getMaLHbyMaGV(string maGV)
        {
            return dLH.getMaLHbyMaGV(maGV);
        }

        public DTO_LopHoc getLopHocFromTenLH(string tenLH)
        {
            return dLH.getLopHocFromTenLH(tenLH);
        }
        public List<int> getMaLHbyMaKH(int maKH)
        {
            return dLH.getMaLHbyMaKH(maKH);
        }
    }
}
