using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO.ModelBase;
using System.Data.SqlClient;
using DAO;
using DAO.DataLayer;

namespace DAO.DataLayerBase
{
    public class PositionDAOBase
    {
        public static DataTable getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllPosition", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertPosition(PositionModel position)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertPosition", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            //cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            //cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = position.Name;
            cmd.Parameters["@CreatedDate"].Value = position.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = position.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = position.IsDeleted;
            //cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //kiểm tra tên tên chức có tồn tại
        public static bool CheckNamePosition(string Name)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Position where Name = @Name and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                //kiểm tra
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void UpdatePosition(PositionModel position)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdatePosition", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", position.Id);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            //cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            //cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = position.Name;
            cmd.Parameters["@CreatedDate"].Value = position.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = position.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = position.IsDeleted;
            //cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static bool IsDuplicatePosition(PositionModel positionModel, int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_Position Where (Name=@Name and Id <>@Id) and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", positionModel.Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
        //lấy danh sách sau khi xóa
        public static DataTable GetPositionAfterDelete()
        {
            DataTable faculty = new DataTable();
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetPositonAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
                return dt;
            }
        }
        public static void DeletePosition(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update D_Position set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static DataTable SearchPositionByName(string Name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchPositionByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
    }
}
