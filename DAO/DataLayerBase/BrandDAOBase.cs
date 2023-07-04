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
using DTO.Model;

namespace DAO.DataLayerBase
{
    public class BrandDAOBase
    {
        public static List<BrandModel> getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return CreateBrandModelfromDataTable(dt);
        }

        public static void InsertBrand(BrandModel brand)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            //cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = brand.Name;
            cmd.Parameters["@Address"].Value = brand.Address;
            cmd.Parameters["@CreatedDate"].Value = brand.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = brand.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = brand.IsDeleted;
            cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static bool CheckNameBrand(string Name)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Brand where Name = @Name and IsDeleted=0";
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
        public static void UpdateBrand(BrandModel brand)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", brand.Id);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Name"].Value = brand.Name;
            cmd.Parameters["@Address"].Value = brand.Address;
            cmd.Parameters["@CreatedDate"].Value = brand.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = brand.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = brand.IsDeleted;
            cmd.Parameters["@Status"].Value = brand.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //check Name có trùng với bảng
        public static bool IsDuplicateBrand(BrandModel brandModel, int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_Brand Where (Name=@Name and Id <>@Id) and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", brandModel.Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
        //lấy danh sách thương hiệu sau khi xóa
        public static List<BrandModel> GetBrandAfterDelete()
        {
            DataTable brand = new DataTable();
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBrandAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
                return CreateBrandModelfromDataTable(dt);
            }
        }
        public static void DeleteBrand(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update D_Brand set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static DataTable SearchBrandByName(string Name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchBrandByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        //Tạo model từ datatable
        public static List<BrandModel> CreateBrandModelfromDataTable(DataTable dt) {
            List<BrandModel> brands = new List<BrandModel>();
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        BrandModel brandModel = new BrandModel();
                        brandModel.Id = (int)dr["Id"];
                        if (dr["Name"] != System.DBNull.Value)
                            brandModel.Name = dr["Name"].ToString();
                        else brandModel.Name = null;
                        if (dr["Address"] != System.DBNull.Value)
                            brandModel.Address = dr["Address"].ToString();
                        else brandModel.Address = null;
                        if (dr["CreatedDate"] != System.DBNull.Value)
                            brandModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else brandModel.CreatedDate = null;
                        if (dr["CreatedUserId"] != System.DBNull.Value)
                            brandModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else brandModel.CreatedUserId = null;
                        if (dr["IsDeleted"] != System.DBNull.Value)
                            brandModel.IsDeleted = (bool)dr["IsDeleted"];
                        else brandModel.IsDeleted = false;
                        if (dr["Status"] != System.DBNull.Value)
                            brandModel.Status = (int)dr["Status"];
                        else brandModel.Status = null;

                        brands.Add(brandModel);
                    }
                }
            }return brands;
        }
        protected static BrandModel CreateBrandfromDataRow(DataRow dr)
        {
            BrandModel objBrand = new BrandModel();

            objBrand.Id = (int)dr["Id"];
            if (dr["Name"] != System.DBNull.Value)
                objBrand.Name = dr["Name"].ToString();
            else objBrand.Name = null;
            if (dr["Address"] != System.DBNull.Value)
                objBrand.Address = dr["Address"].ToString();
            else objBrand.Address = null;
            if (dr["CreatedDate"] != System.DBNull.Value)
                objBrand.CreatedDate = (DateTime)dr["CreatedDate"];
            else objBrand.CreatedDate = null;
            if (dr["CreatedUserId"] != System.DBNull.Value)
                objBrand.CreatedUserId = (int)dr["CreatedUserId"];
            else objBrand.CreatedUserId = null;
            if (dr["IsDeleted"] != System.DBNull.Value)
                objBrand.IsDeleted = (bool)dr["IsDeleted"];
            else objBrand.IsDeleted = false;
            if (dr["Status"] != System.DBNull.Value)
                objBrand.Status = (int)dr["Status"];
            else objBrand.Status = null;
            return objBrand;
        }
        //lấy theo id
        public static BrandModel SelectById(int Id)
        {
            BrandModel ojbBrand = null;
            using(SqlConnection conn=new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd=new SqlCommand("Brand_SelectById", conn))
                {
                    cmd.CommandType= CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", Id);
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt!=null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                ojbBrand = CreateBrandfromDataRow(dt.Rows[0]);
                            }
                        }
                    }
                }
            }return ojbBrand;
        }
    }
}
