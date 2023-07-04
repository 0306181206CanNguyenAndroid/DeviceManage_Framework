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
    public class Device_TypeDAOBase
    {
        public static List<Device_TypeModel> getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllDevice_Type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return CreateDevice_TypefromDataTable(dt);
        }
        public static void InsertDevice_Type(Device_TypeModel device_Type)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertDevice_type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Name"].Value = device_Type.Name;
            cmd.Parameters["@Description"].Value = device_Type.Description;
            cmd.Parameters["@CreatedDate"].Value = device_Type.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = device_Type.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = device_Type.IsDeleted;
            cmd.Parameters["@Status"].Value = device_Type.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //kiểm tra trùng tên loại thiết bị 
        public static bool CheckNameDevice_Type(string Name)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Device_Type where Name = @Name and IsDeleted=0";
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
        public static void UpDateDevice_Type(Device_TypeModel device_Type)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateDevice_Type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", device_Type.Id);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Name"].Value = device_Type.Name;
            cmd.Parameters["@Description"].Value = device_Type.Description;
            cmd.Parameters["@CreatedDate"].Value = device_Type.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = device_Type.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = device_Type.IsDeleted;
            cmd.Parameters["@Status"].Value = device_Type.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static bool IsDuplicateDecice_Type(Device_TypeModel device_Type, int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_Device_Type Where (Name=@Name and Id <>@Id) and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", device_Type.Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }

        //Lấy danh sách Sau khi xóa
        public static List<Device_TypeModel> GetDevice_TypeAfterDelete()
        {
            DataTable brand = new DataTable();
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetDevice_TypeAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
                return CreateDevice_TypefromDataTable(dt);
            }
        }
        public static void DeleteDevice_Type(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update D_Device_Type set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static Device_TypeModel SelectByPrimaryKey(int id)
        {
            Device_TypeModel objDeviceType = null;
            string storedProcName = "[dbo].[DeviceType_SelectByPrimaryKey]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // parameters
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceType = CreateDeviceTypeFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDeviceType;
        }

        /// <summary>
        /// Gets the total number of records in the DeviceType table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[DeviceType_GetRecordCount]", null, null, true, null);
        }

        public static int GetRecordCountShared(string storedProcName = null, string param = null, object paramValue = null, bool isUseStoredProc = true, string dynamicSqlScript = null)
        {
            int recordCount = 0;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                recordCount = (int)dt.Rows[0]["RecordCount"];
                            }
                        }
                    }
                }
            }

            return recordCount;
        }

        /// <summary>
        /// Gets the total number of records in the DeviceType table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[DeviceType_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                recordCount = (int)dt.Rows[0]["RecordCount"];
                            }
                        }
                    }
                }
            }

            return recordCount;
        }

        /// <summary>
        /// Selects DeviceType records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<Device_TypeModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[DeviceType_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects DeviceType records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<Device_TypeModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<Device_TypeModel> objDeviceTypeCol = null;
            string storedProcName = "[dbo].[DeviceType_SelectSkipAndTakeWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // select, skip, take, sort parameters
                    command.Parameters.AddWithValue("@start", startRowIndex);
                    command.Parameters.AddWithValue("@numberOfRows", rows);
                    command.Parameters.AddWithValue("@sort", sortByExpression);

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceTypeCol = new List<Device_TypeModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    Device_TypeModel objDeviceType = CreateDeviceTypeFromDataRowShared(dr);
                                    objDeviceTypeCol.Add(objDeviceType);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceTypeCol;
        }

        /// <summary>
        /// Selects all DeviceType
        /// </summary>
        public static List<Device_TypeModel> SelectAll()
        {
            return SelectShared("[dbo].[DeviceType_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceType.
        /// </summary>
        public static List<Device_TypeModel> SelectAllDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<Device_TypeModel> objDeviceTypeCol = null;
            string storedProcName = "[dbo].[DeviceType_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceTypeCol = new List<Device_TypeModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    Device_TypeModel objDeviceType = CreateDeviceTypeFromDataRowShared(dr);
                                    objDeviceTypeCol.Add(objDeviceType);
                                }
                            }
                        }
                    }
                }
            }
            if (objDeviceTypeCol != null)
                return objDeviceTypeCol;
            else return new List<Device_TypeModel>();
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<Device_TypeModel> SelectDeviceTypeDropDownListData()
        {
            List<Device_TypeModel> objDeviceTypeCol = null;
            string storedProcName = "[dbo].[DeviceType_SelectDropDownListData]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceTypeCol = new List<Device_TypeModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    Device_TypeModel objDeviceType = new Device_TypeModel();
                                    objDeviceType.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objDeviceType.Name = (string)(dr["Name"]);
                                    else
                                        objDeviceType.Name = null;

                                    objDeviceTypeCol.Add(objDeviceType);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceTypeCol;
        }

        public static List<Device_TypeModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<Device_TypeModel> objDeviceTypeCol = null;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // select, skip, take, sort parameters
                    if (!String.IsNullOrEmpty(sortByExpression) && startRowIndex != null && rows != null)
                    {
                        command.Parameters.AddWithValue("@start", startRowIndex.Value);
                        command.Parameters.AddWithValue("@numberOfRows", rows.Value);
                        command.Parameters.AddWithValue("@sort", sortByExpression);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceTypeCol = new List<Device_TypeModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    Device_TypeModel objDeviceType = CreateDeviceTypeFromDataRowShared(dr);
                                    objDeviceTypeCol.Add(objDeviceType);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceTypeCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        //public static int Insert(Device_TypeModel objDeviceType)
        //{
        //    string storedProcName = "[dbo].[DeviceType_Insert]";
        //    return InsertUpdate(objDeviceType, false, storedProcName);
        //}

        ///// <summary>
        ///// Updates a record
        ///// </summary>
        //public static void Update(Device_TypeModel objDeviceType)
        //{
        //    string storedProcName = "[dbo].[DeviceType_Update]";
        //    InsertUpdate(objDeviceType, true, storedProcName);
        //}

        //private static int InsertUpdate(Device_TypeModel objDeviceType, bool isUpdate, string storedProcName)
        //{
        //    int newlyCreatedId = objDeviceType.Id;

        //    object name = objDeviceType.Name;
        //    object createdDate = objDeviceType.CreatedDate;
        //    object createdUserId = objDeviceType.CreatedUserId;
        //    object status = objDeviceType.Status;

        //    if (String.IsNullOrEmpty(objDeviceType.Name))
        //        name = System.DBNull.Value;

        //    if (objDeviceType.CreatedDate == null)
        //        createdDate = System.DBNull.Value;

        //    if (objDeviceType.CreatedUserId == null)
        //        createdUserId = System.DBNull.Value;

        //    if (objDeviceType.Status == null)
        //        status = System.DBNull.Value;

        //    using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
        //    {
        //        connection.Open();

        //        using (SqlCommand command = new SqlCommand(storedProcName, connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            // parameters
        //            if (isUpdate)
        //            {
        //                // for update only
        //                command.Parameters.AddWithValue("@id", objDeviceType.Id);
        //            }

        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@createdDate", createdDate);
        //            command.Parameters.AddWithValue("@createdUserId", createdUserId);
        //            command.Parameters.AddWithValue("@isDeleted", objDeviceType.IsDeleted);
        //            command.Parameters.AddWithValue("@status", status);

        //            if (isUpdate)
        //                command.ExecuteNonQuery();
        //            else
        //                newlyCreatedId = (int)command.ExecuteScalar();
        //        }
        //    }

        //    return newlyCreatedId;
        //}

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        //public static void Delete(int id)
        //{
        //    string storedProcName = "[dbo].[DeviceType_Hide]";

        //    using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
        //    {
        //        connection.Open();

        //        using (SqlCommand command = new SqlCommand(storedProcName, connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            // parameters
        //            command.Parameters.AddWithValue("@id", id);

        //            // execute
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        /// <summary>
        /// Adds search parameters to the Command object
        /// </summary>
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (!String.IsNullOrEmpty(description))
                command.Parameters.AddWithValue("@description", description);
            else
                command.Parameters.AddWithValue("@description", System.DBNull.Value);

            //if (createdDate != null)
            //    command.Parameters.AddWithValue("@createdDate", createdDate);
            //else
            //    command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

            //if (createdUserId != null)
            //    command.Parameters.AddWithValue("@createdUserId", createdUserId);
            //else
            //    command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

            //if (isDeleted != null)
            //    command.Parameters.AddWithValue("@isDeleted", isDeleted);
            //else
            //    command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

            //if (status != null)
            //    command.Parameters.AddWithValue("@status", status);
            //else
            //    command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }

        /// <summary>
        /// Creates a DeviceType object from the passed data row
        /// </summary>
        protected static Device_TypeModel CreateDeviceTypeFromDataRowShared(DataRow dr)
        {
            Device_TypeModel objDeviceType = new Device_TypeModel();

            objDeviceType.Id = (int)dr["Id"];

            if (dr["Name"] != System.DBNull.Value)
                objDeviceType.Name = dr["Name"].ToString();
            else
                objDeviceType.Name = null;

            if (dr["Description"] != System.DBNull.Value)
                objDeviceType.Description = dr["Description"].ToString();
            else
                objDeviceType.Description = null;

            //if (dr["CreatedDate"] != System.DBNull.Value)
            //    objDeviceType.CreatedDate = (DateTime)dr["CreatedDate"];
            //else
            //    objDeviceType.CreatedDate = null;

            //if (dr["CreatedUserId"] != System.DBNull.Value)
            //    objDeviceType.CreatedUserId = (int)dr["CreatedUserId"];
            //else
            //    objDeviceType.CreatedUserId = null;

            //if (dr["IsDeleted"] != System.DBNull.Value)
            //    objDeviceType.IsDeleted = (bool)dr["IsDeleted"];
            //else
            //    objDeviceType.IsDeleted = false;

            //if (dr["Status"] != System.DBNull.Value)
            //    objDeviceType.Status = (int)dr["Status"];
            //else
            //    objDeviceType.Status = null;

            return objDeviceType;
        }

        ///tạo model từ datatable
        public static List<Device_TypeModel> CreateDevice_TypefromDataTable(DataTable dt)
        {
            List<Device_TypeModel> device_Types = new List<Device_TypeModel>();
            if(dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Device_TypeModel typeModel = new Device_TypeModel();
                        typeModel.Id = (int)dr["Id"];
                        if (dr["Name"] != System.DBNull.Value)
                            typeModel.Name = dr["Name"].ToString();
                        else
                            typeModel.Name = null;

                        if (dr["Description"] != System.DBNull.Value)
                            typeModel.Description = dr["Description"].ToString();
                        else
                            typeModel.Description = null;

                        if (dr["CreatedDate"] != System.DBNull.Value)
                            typeModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else
                            typeModel.CreatedDate = null;

                        if (dr["CreatedUserId"] != System.DBNull.Value)
                            typeModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else
                            typeModel.CreatedUserId = null;

                        if (dr["IsDeleted"] != System.DBNull.Value)
                            typeModel.IsDeleted = (bool)dr["IsDeleted"];
                        else
                            typeModel.IsDeleted = false;

                        if (dr["Status"] != System.DBNull.Value)
                            typeModel.Status = (int)dr["Status"];
                        else
                            typeModel.Status = null;

                        device_Types.Add(typeModel);
                    }
                }
                
            }
            return device_Types;
        }
    }
}
