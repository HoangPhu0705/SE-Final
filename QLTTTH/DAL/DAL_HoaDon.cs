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
    public class DAL_HoaDon : DBConnect
    {

        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoa_don", conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        public bool themHoaDon(DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_hd", null);
            cmd.Parameters.AddWithValue("@Nguoi_dong_tien", hd.Nguoi_dong_tien);
            cmd.Parameters.AddWithValue("@Ngay_lap", hd.Ngay_lap);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.Tong_tien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaHoaDon(DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_hd", hd.Ma_hd);
            cmd.Parameters.AddWithValue("@Nguoi_dong_tien", hd.Nguoi_dong_tien);
            cmd.Parameters.AddWithValue("@Ngay_lap", hd.Ngay_lap);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.Tong_tien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaHoaDon(DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_hd", hd.Ma_hd);
            cmd.Parameters.AddWithValue("@Nguoi_dong_tien", hd.Nguoi_dong_tien);
            cmd.Parameters.AddWithValue("@Ngay_lap", hd.Ngay_lap);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.Tong_tien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * FROM Hoa_don";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public int getCurrentMaHoaDon()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAX(Ma_hd) FROM Hoa_don", conn);
            int currentMaHoaDon = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return currentMaHoaDon;
        }

        public void bindGridViewById(DataGridView dataGridView, int id)
        {
            conn.Open();
            string query = "SELECT * from Hoa_don where Ma_hd = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Hoa_don where Ma_hd LIKE '%' + @name + '%' or Nguoi_dong_tien LIKE '%' + @name + '%' or Ngay_lap LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public DataTable getDoanhThu(DateTime dateStart, DateTime dateEnd)
        {
            conn.Open();
            string sql = "SELECT CAST(Ngay_lap AS DATE) AS ngaylap, SUM(Tong_tien) AS doanhthu" +
                " FROM Hoa_don WHERE Ngay_lap BETWEEN @startDate AND @endDate GROUP BY CAST(Ngay_lap AS DATE)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@startDate", dateStart);
            cmd.Parameters.AddWithValue("@endDate", dateEnd);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            return dt;
        }
    }
}
