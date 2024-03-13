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
    public class BUS_KhoaHoc
    {
        DAL_KhoaHoc dKhoaHoc = new DAL_KhoaHoc();

        public bool themKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.themKhoaHoc(kh);
        }

        public bool suaKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.suaKhoaHoc(kh);
        }

        public bool xoaKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.xoaKhoaHoc(kh);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dKhoaHoc.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dKhoaHoc.bindGridViewbySearch(gridView, name);
        }

        public int getIdByName(string name)
        {
            return dKhoaHoc.getIdByName(name);
        }

        public string getNameById(int id)
        {
            return dKhoaHoc.getNameById(id);
        }

        public void bindGridViewById(DataGridView dataGridView, int id)
        {
            dKhoaHoc.bindGridViewById(dataGridView, id);
        }

        public int getFeeById(int id)
        {
            return dKhoaHoc.getFeeById(id);
        }

        public void bindComboBox(ComboBox cbx)
        {
            dKhoaHoc.bindComboBox(cbx);
        }
        public bool checkIfMaLHExists(int maLH)
        {
            return dKhoaHoc.checkIfMaLHExists(maLH);
        }
    }
}
