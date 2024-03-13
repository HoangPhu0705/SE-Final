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
    public class DAL_HocVien : DBConnect
    {
        public DataTable getHocVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc_vien", conn);
            DataTable dtHocVien = new DataTable();
            da.Fill(dtHocVien);
            return dtHocVien;
        }

        public bool themHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_HV", null);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_HV", hv.Ma_HV);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_HV", hv.Ma_HV);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

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
            string query = "SELECT * from Hoc_vien";
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
            string query = "SELECT * from Hoc_vien where Ma_HV LIKE '%' + @name + '%' or Ten_HV LIKE '%' + @name + '%' or sdt LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }


        public void bindGridViewByMaHV(DataGridView dataGridView, string maHV)
        {
            conn.Open();
            string query = "SELECT * FROM Hoc_vien WHERE Ma_HV = @maHV";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maHV", maHV);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }



        public void bindLHComboBoxByKH(ComboBox cbx, string ten_kh)
        {
            conn.Open();
            SqlCommand command1 = new SqlCommand("SELECT Ma_KH FROM Khoa_hoc WHERE Ten_KH=@ten_kh", conn);
            command1.Parameters.AddWithValue("@ten_kh", ten_kh);
            int ma_kh = (int)command1.ExecuteScalar();

            
            SqlCommand command2 = new SqlCommand("SELECT Ma_LH, Ten_LH FROM Lop_hoc WHERE Ma_KH=@ma_kh", conn);
            command2.Parameters.AddWithValue("@ma_kh", ma_kh);
            SqlDataReader reader = command2.ExecuteReader();
            Dictionary<int, string> items = new Dictionary<int, string>();
            while (reader.Read())
            {
                items.Add(reader.GetInt32(0), reader.GetString(1));
            }
            cbx.DataSource = new BindingSource(items, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            conn.Close();
        }


        public string getLatestMaHV()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(CAST(SUBSTRING(Ma_HV, 3, LEN(Ma_HV) - 2) AS INT)) FROM Hoc_vien", conn);
            conn.Open();
            string latestMaHV = cmd.ExecuteScalar()?.ToString();
            conn.Close();

            if (latestMaHV == "")
            {
                latestMaHV = "HV000";
            }
            else
            {
                int latestMaHVNum = int.Parse(latestMaHV);
                latestMaHV = string.Format("HV{0:D3}", latestMaHVNum);
            }

            return latestMaHV;
        }



        public bool checkSDTTonTai(string phone)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Hoc_vien where sdt = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            DTO_HocVien hv = null;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                hv = new DTO_HocVien();
                hv.Ma_HV = (string)reader["Ma_hv"];
                hv.Ten_HV = (string)reader["Ten_HV"];
                hv.Nam_sinh = (DateTime)reader["Nam_sinh"];
                hv.Dia_chi = (string)reader["Dia_chi"];
                hv.Sdt = (string)reader["sdt"];
            }
            reader.Close();
            conn.Close();
            if (hv == null)
            {
                return false;
            }
            return true;
        }


        public DataTable getDataTableByMaHV(string maHV)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Hoc_vien WHERE Ma_HV = @MaHV";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@MaHV", maHV);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            conn.Close();
            return dt;
        }



        public DTO_HocVien getHocVienById(string maHV)
        {
            DTO_HocVien hocVien = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Hoc_vien WHERE Ma_HV = @Ma_HV", conn);
            cmd.Parameters.AddWithValue("@Ma_HV", maHV);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                hocVien = new DTO_HocVien();
                hocVien.Ma_HV = reader.GetString(0);
                hocVien.Ten_HV = reader.GetString(1);
                hocVien.Nam_sinh = reader.GetDateTime(2);
                hocVien.Dia_chi = reader.GetString(3);
                hocVien.Sdt = reader.GetString(4);
            }
            conn.Close();
            return hocVien;
        }

        public string getSDTByID(string id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT sdt FROM Hoc_vien WHERE Ma_HV=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            string sdt = cmd.ExecuteScalar()?.ToString();
            conn.Close();
            return sdt;
        }




    }
}
