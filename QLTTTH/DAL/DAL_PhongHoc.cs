using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_PhongHoc : DBConnect
    {
        public string getTenPH(int maPH)
        {
            string tenPH = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Ten_PH FROM Phong_hoc WHERE Ma_PH = @maPH", conn);
                cmd.Parameters.AddWithValue("@maPH", maPH);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tenPH = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tenPH;
        }
    }
}
