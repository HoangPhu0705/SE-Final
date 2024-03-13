using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tai_Khoan", conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }


        public bool checkLogin(string username, string pass, int type) 
        {

            conn.Open();
            string query = "SELECT COUNT(*) FROM Tai_Khoan WHERE TaiKhoan=@username AND pass=@pass AND loai=@loai";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@loai", type);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                return true;
            }

            return false;
        }

        public string getMKByTaiKhoan(string username)
        {
            conn.Open();
            string query = "SELECT pass FROM Tai_Khoan WHERE TaiKhoan=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            string password = cmd.ExecuteScalar().ToString();
            conn.Close();
            return password;
        }

        public bool updateMatKhau(string username, string newPass)
        {
            conn.Open();
            string query = "UPDATE Tai_Khoan SET pass=@newPass WHERE TaiKhoan=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newPass", newPass);
            cmd.Parameters.AddWithValue("@username", username);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return (result > 0);
        }



    }
}
