using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_KhoaHoc : DBConnect
    {
        public DataTable getKhoaHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa_hoc", conn);
            DataTable dtKhoaHoc = new DataTable();
            da.Fill(dtKhoaHoc);
            return dtKhoaHoc;
        }

        public bool themKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Khoa_hoc VALUES (@Ten_KH, @Hoc_phi)", conn);
            cmd.Parameters.AddWithValue("@Ten_KH", kh.Ten_KH);
            cmd.Parameters.AddWithValue("@Hoc_phi", kh.Hoc_phi);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Khoa_hoc SET Ten_KH = @Ten_KH, Hoc_phi = @Hoc_phi WHERE Ma_KH = @Ma_KH", conn);
            cmd.Parameters.AddWithValue("@Ten_KH", kh.Ten_KH);
            cmd.Parameters.AddWithValue("@Hoc_phi", kh.Hoc_phi);
            cmd.Parameters.AddWithValue("@Ma_KH", kh.Ma_KH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Khoa_hoc WHERE Ma_KH = @Ma_KH", conn);
            cmd.Parameters.AddWithValue("@Ma_KH", kh.Ma_KH);
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
            string query = "SELECT * from Khoa_hoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewById(DataGridView dataGridView, int id)
        {
            conn.Open();
            string query = "SELECT * from Khoa_hoc where Ma_KH = @id";
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
            string query = "SELECT * from Khoa_hoc where Ma_KH LIKE '%' + @name + '%' or Ten_KH LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public int getIdByName(string name)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ma_KH FROM Khoa_hoc WHERE Ten_KH = @name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader reader = cmd.ExecuteReader();
            int id = -1;
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["Ma_KH"]);
            }
            conn.Close();
            return id;
        }

        public string getNameById(int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ten_KH FROM Khoa_hoc WHERE  Ma_KH = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            string name = "";
            if (reader.Read())
            {
                name = reader["Ten_KH"].ToString();
            }
            conn.Close();
            return name;
        }

        public int getFeeById(int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Hoc_phi FROM Khoa_hoc WHERE  Ma_KH = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            int fee = -1;
            if (reader.Read())
            {
                fee = Convert.ToInt32(reader["Hoc_phi"]);
            }
            conn.Close();
            return fee;
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
