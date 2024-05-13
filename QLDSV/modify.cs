using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace QLDSV
{
    class modify
    {
        public static DataTable getAllSinhVien()
        {
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAllSinhVien", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static void insertSinhVien(SinhVien sv)
        {
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_insertSinhVien", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSV", sv.TenSV);
                command.Parameters.AddWithValue("@MSSV", sv.MSSV);
                command.Parameters.AddWithValue("@diemSo", sv.Diem);
                command.Parameters.AddWithValue("@ngaySinh", sv.NgaySinh);
                command.Parameters.AddWithValue("@xepLoai", sv.XepLoai);
                command.ExecuteNonQuery();
            }
        }

        public static void deleteSinhVien(string mssv)
        {
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_deleteSinhVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MSSV", mssv);
                command.ExecuteNonQuery();
            }
        }

        public static void updateSinhVien(SinhVien sv)
        {
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_updateSinhVien", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSV", sv.TenSV);
                command.Parameters.AddWithValue("@MSSV", sv.MSSV);
                command.Parameters.AddWithValue("@diemSo", sv.Diem);
                command.Parameters.AddWithValue("@ngaySinh", sv.NgaySinh);
                command.Parameters.AddWithValue("@xepLoai", sv.XepLoai);
                command.ExecuteNonQuery();
            }
        }

        

    }
}
