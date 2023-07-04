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
    public class FacultyDAOBase
    {
        public static List<FacultyModel> getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllFaculty", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return CreateFacultyModelfromDataTable(dt);
        }
        public static void InsertFaculty(FacultyModel faculty)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertFaculty", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            //cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            //cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = faculty.Name;
            cmd.Parameters["@Description"].Value = faculty.Description;
            cmd.Parameters["@CreatedDate"].Value = faculty.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = faculty.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = faculty.IsDeleted;
            //cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //kiểm tra tên tên khao có tồn tại
        public static bool CheckNameFaculty(string Name)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Faculty where Name = @Name and IsDeleted=0";
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
        public static void UpdateFaculty(FacultyModel faculty)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateFaculty", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", faculty.Id);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            //cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            //cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = faculty.Name;
            cmd.Parameters["@Description"].Value = faculty.Description;
            cmd.Parameters["@CreatedDate"].Value = faculty.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = faculty.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = faculty.IsDeleted;
            //cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static bool IsDuplicateFaculty(FacultyModel facultyModel, int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_Faculty Where (Name=@Name and Id <>@Id) and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", facultyModel.Name);
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
        public static List<FacultyModel> GetFacultyAfterDelete()
        {
            DataTable faculty = new DataTable();
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetFacultyAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
                return CreateFacultyModelfromDataTable(dt);
            }
        }
        public static void DeleteFaculty(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update D_Faculty set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable SearchFacultyByName(string Name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchFacultyByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        //tạo model từ datatable

        public static List<FacultyModel> CreateFacultyModelfromDataTable(DataTable dt)
        {
            List<FacultyModel> faculty= new List<FacultyModel>();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        FacultyModel facultyModel = new FacultyModel();
                        facultyModel.Id = (int)dr["Id"];
                        if (dr["Name"] != System.DBNull.Value)
                            facultyModel.Name = dr["Name"].ToString();
                        else
                            facultyModel.Name = null;

                        if (dr["Description"] != System.DBNull.Value)
                            facultyModel.Description = dr["Description"].ToString();
                        else
                            facultyModel.Description = null;

                        if (dr["CreatedDate"] != System.DBNull.Value)
                            facultyModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else
                            facultyModel.CreatedDate = null;

                        if (dr["CreatedUserId"] != System.DBNull.Value)
                            facultyModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else
                            facultyModel.CreatedUserId = null;

                        if (dr["IsDeleted"] != System.DBNull.Value)
                            facultyModel.IsDeleted = (bool)dr["IsDeleted"];
                        else
                            facultyModel.IsDeleted = false;
                        faculty.Add(facultyModel);

                    }
                }
            }return faculty;
        }
    }
}
