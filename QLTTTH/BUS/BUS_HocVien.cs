using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HocVien
    {
        DAL_HocVien dHocVien = new DAL_HocVien();
        public bool themHocVien(DTO_HocVien hv)
        {
            return dHocVien.themHocVien(hv);
        }


        public bool suaHocVien(DTO_HocVien hv)
        {
            return dHocVien.suaHocVien(hv);
        }

        public bool xoaHocVien(DTO_HocVien hv)
        {
            return dHocVien.xoaHocVien(hv);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dHocVien.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dHocVien.bindGridViewbySearch(gridView, name);
        }


        public void bindLHComboBoxByKH(ComboBox cbx, string ten_kh)
        {
            dHocVien.bindLHComboBoxByKH(cbx, ten_kh);
        }

        public string getLatestMaHV()
        {
            return dHocVien.getLatestMaHV();
        }
        public bool checkSDTTonTai(string phone)
        {
            return dHocVien.checkSDTTonTai(phone);
        }

        public DTO_HocVien getHocVienById(string maHV)
        {
            return dHocVien.getHocVienById(maHV);
        }

        public string getSDTByID(string id)
        {
            return dHocVien.getSDTByID(id);
        }

        public void bindGridViewByMaHV(DataGridView dataGridView, string maHV)
        {
            dHocVien.bindGridViewByMaHV(dataGridView, maHV);
        }


        public DataTable getDataTableByMaHV(string maHV)
        {
            return dHocVien.getDataTableByMaHV(maHV);
        }

    }
}
