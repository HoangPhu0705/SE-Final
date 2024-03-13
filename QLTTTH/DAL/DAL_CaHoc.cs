using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
        public class DAL_CaHoc : DBConnect
        {
            public Tuple<string, string> getBuoiAndGioHoc(int ma_ca)
            {
                Tuple<string, string> result = null;

                SqlCommand command = new SqlCommand("SELECT Buoi, GioHoc FROM Ca_hoc WHERE Ma_ca=@Ma_ca", conn);
                command.Parameters.AddWithValue("@Ma_ca", ma_ca);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string buoi = reader.GetString(0);
                    string gioHoc = reader.GetString(1);

                    result = new Tuple<string, string>(buoi, gioHoc);
                }

                conn.Close();
                return result;
            }
        }
}
