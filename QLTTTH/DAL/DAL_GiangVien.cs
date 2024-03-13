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
    public class DAL_GiangVien : DBConnect
    {
        public DataTable getHocVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc_vien", conn);
            DataTable dtHocVien = new DataTable();
            da.Fill(dtHocVien);
            return dtHocVien;
        }

        public bool themGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_GV", null);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Que_quan);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_GV", gv.Ma_GV);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Que_quan);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_GV", gv.Ma_GV);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Sdt);

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
            string query = "SELECT * from Giang_vien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Giang_vien where Ma_GV LIKE '%' + @name + '%' or Ten_GV LIKE '%' + @name + '%' or sdt LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public bool checkSDTTonTai(string phone)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Giang_vien where sdt = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            DTO_GiangVien gv = null;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                gv = new DTO_GiangVien();
                gv.Ma_GV = (string)reader["Ma_GV"];
                gv.Ten_GV = (string)reader["Ten_GV"];
                gv.Nam_sinh = (DateTime)reader["Nam_sinh"];
                gv.Sdt = (string)reader["sdt"];
                gv.Que_quan = (string)reader["Que_quan"];
            }
            reader.Close();
            conn.Close();
            if (gv == null)
            {
                return false;
            }
            return true;
        }

        public DTO_GiangVien getGiangVienById(string maGV)
        {
            DTO_GiangVien giangVien = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Giang_vien WHERE Ma_GV = @Ma_GV", conn);
            cmd.Parameters.AddWithValue("@Ma_GV", maGV);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                giangVien = new DTO_GiangVien();
                giangVien.Ma_GV = reader.GetString(0);
                giangVien.Ten_GV = reader.GetString(1);
                giangVien.Nam_sinh = reader.GetDateTime(2);
                giangVien.Sdt = reader.GetString(3);
                giangVien.Que_quan = reader.GetString(4);
            }
            conn.Close();
            return giangVien;
        }
    }

}
