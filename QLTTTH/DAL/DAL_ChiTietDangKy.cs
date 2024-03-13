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

    public class DAL_ChiTietDangKy:DBConnect
    {
        public bool themChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public List<int> getMaLHByMaHV(string Ma_HV)
        {
            List<int> Ma_LHs = new List<int>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ma_LH FROM chi_tiet WHERE Ma_HV = @Ma_HV", conn);
            cmd.Parameters.AddWithValue("@Ma_HV", Ma_HV);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Ma_LH = reader.GetInt32(0);
                Ma_LHs.Add(Ma_LH);
            }
            conn.Close();
            return Ma_LHs;
        }


        public List<string> getMaHVByMaLH(int Ma_LH)
        {
            List<string> maHVList = new List<string>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ma_HV FROM chi_tiet WHERE Ma_LH = @Ma_LH", conn);
            cmd.Parameters.AddWithValue("@Ma_LH", Ma_LH);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Ma_HV = reader.GetString(0);
                maHVList.Add(Ma_HV);
            }
            conn.Close();
            return maHVList;
        }

        public bool checkIfChiTietExists(string maHV, int maLH)
        {

            conn.Open();
            bool exists = false;
            string query = "SELECT COUNT(*) FROM chi_tiet WHERE Ma_HV=@maHV AND Ma_LH=@maLH";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maHV", maHV);
            command.Parameters.AddWithValue("@maLH", maLH);

            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                exists = true;
            }
            conn.Close();
            return exists;

        }

        public bool checkIfMaLHExists(int maLH)
        {
            conn.Open();
            bool exists = false;
            string query = "SELECT COUNT(*) FROM chi_tiet WHERE Ma_LH=@maLH";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maLH", maLH);

            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                exists = true;
            }
            conn.Close();
            return exists;
        }
    }
}
