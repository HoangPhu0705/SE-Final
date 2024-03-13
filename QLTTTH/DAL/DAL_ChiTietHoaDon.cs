using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_ChiTietHoaDon : DBConnect
    {
        public bool themChiTietHoaDon(DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Chitiet_hd_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_hd", cthd.Ma_hd);
            cmd.Parameters.AddWithValue("@Ma_KH", cthd.Ma_KH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaChiTietHoaDon(DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Chitiet_hd_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_hd", cthd.Ma_hd);
            cmd.Parameters.AddWithValue("@Ma_KH", cthd.Ma_KH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaChiTietHoaDon(DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Chitiet_hd_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_hd", cthd.Ma_hd);
            cmd.Parameters.AddWithValue("@Ma_KH", cthd.Ma_KH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public void bindComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ten_KH FROM Khoa_Hoc", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(reader.GetString(0));
            }
            conn.Close();
        }



        
    }
}
