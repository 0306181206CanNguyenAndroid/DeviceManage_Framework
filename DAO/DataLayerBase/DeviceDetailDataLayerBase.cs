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
    /// <summary>
    /// Base class for SpecsDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the SpecsDataLayer class
    /// </summary>
    public class DeviceDetailDataLayerBase
    {
        // constructor
        public DeviceDetailDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceDetailModel SelectByPrimaryKey(int id)
        {
            DeviceDetailModel objDeviceDetail = null;
            string storedProcName = "[dbo].[DeviceDetail_SelectByPrimaryKey]";

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
                                objDeviceDetail = CreateDeviceDetailFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDeviceDetail;
        }

        /// <summary>
        /// Gets the total number of records in the Specs table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[DeviceDetail_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the Specs table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[DeviceDetail_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command,id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);

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
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[DeviceDetail_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<DeviceDetailModel> objDeviceDetailCol = null;
            string storedProcName = "[dbo].[DeviceDetail_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceDetailCol = new List<DeviceDetailModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceDetailModel objDeviceDetail = CreateDeviceDetailFromDataRowShared(dr);
                                    objDeviceDetailCol.Add(objDeviceDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceDetailCol;
        }

        /// <summary>
        /// Selects all Specs
        /// </summary>
        public static List<DeviceDetailModel> SelectAll()
        {
            return SelectShared("[dbo].[DeviceDetail_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs.
        /// </summary>
        public static List<DeviceDetailModel> SelectAllDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<DeviceDetailModel> objDeviceDetailCol = null;
            string storedProcName = "[dbo].[DeviceDetail_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command,id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceDetailCol = new List<DeviceDetailModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceDetailModel objDeviceDetail = CreateDeviceDetailFromDataRowShared(dr);
                                    objDeviceDetailCol.Add(objDeviceDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceDetailCol;
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<DeviceDetailModel> SelectSpecsDropDownListData()
        {
            List<DeviceDetailModel> objDeviceDetailCol = null;
            string storedProcName = "[dbo].[DeviceDetail_SelectDropDownListData]";

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
                                objDeviceDetailCol = new List<DeviceDetailModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceDetailModel objDeviceDetail = new DeviceDetailModel();
                                    objDeviceDetail.Id = (int)dr["Id"];

                                    if (dr["NameSpecs"] != System.DBNull.Value)
                                        objDeviceDetail.NameSpecs = (string)(dr["NameSpecs"]);
                                    else
                                        objDeviceDetail.NameSpecs = null;

                                    objDeviceDetailCol.Add(objDeviceDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceDetailCol;
        }

        public static List<DeviceDetailModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<DeviceDetailModel> objDeviceDetailCol = null;

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
                                objDeviceDetailCol = new List<DeviceDetailModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceDetailModel objDeviceDetail = CreateDeviceDetailFromDataRowShared(dr);
                                    objDeviceDetailCol.Add(objDeviceDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceDetailCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceDetailModel objDeviceDetail)
        {
            string storedProcName = "[dbo].[DeviceDetail_Insert]";
            return InsertUpdate(objDeviceDetail, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceDetailModel objDeviceDetail)
        {
            string storedProcName = "[dbo].[DeviceDetail_Update]";
            InsertUpdate(objDeviceDetail, true, storedProcName);
        }

        private static int InsertUpdate(DeviceDetailModel objDeviceDetail, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objDeviceDetail.Id;

            object nameSpecs = objDeviceDetail.NameSpecs;
            object deviceId = objDeviceDetail.DeviceId;
            object brandId = objDeviceDetail.BrandId;
            object deviceTypeSpecsId = objDeviceDetail.DeviceTypeSpecsId;
            object values = objDeviceDetail.Values;
            object description = objDeviceDetail.Description;
            object createdDate = objDeviceDetail.CreatedDate;
            object createdUserId = objDeviceDetail.CreatedUserId;
            object status = objDeviceDetail.Status;

            if (objDeviceDetail.Values == null)
                values = System.DBNull.Value;

            if (objDeviceDetail.Description == null)
                description = System.DBNull.Value;

            if (objDeviceDetail.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objDeviceDetail.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objDeviceDetail.Status == null)
                status = System.DBNull.Value;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // parameters
                    if (isUpdate)
                    {
                        // for update only
                        command.Parameters.AddWithValue("@id", objDeviceDetail.Id);
                    }

                    command.Parameters.AddWithValue("@nameSpecs", nameSpecs);
                    command.Parameters.AddWithValue("@deviceId", deviceId);
                    command.Parameters.AddWithValue("@brandId", brandId);
                    command.Parameters.AddWithValue("@deviceTypeSpecsId", deviceTypeSpecsId);
                    command.Parameters.AddWithValue("@values", values);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objDeviceDetail.IsDeleted);
                    command.Parameters.AddWithValue("@status", status);

                    if (isUpdate)
                        command.ExecuteNonQuery();
                    else
                        newlyCreatedId = (int)command.ExecuteScalar();
                    
                }
            }

            return newlyCreatedId;
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            string storedProcName = "[dbo].[DeviceDetail_Hide]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // parameters
                    command.Parameters.AddWithValue("@id", id);

                    // execute
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Adds search parameters to the Command object
        /// </summary>
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (deviceId != null)
                command.Parameters.AddWithValue("@deviceId", deviceId);
            else
                command.Parameters.AddWithValue("@deviceId", System.DBNull.Value);

            if (deviceTypeSpecsId != null)
                command.Parameters.AddWithValue("@deviceTypeSpecsId", deviceTypeSpecsId);
            else
                command.Parameters.AddWithValue("@deviceTypeSpecsId", System.DBNull.Value);

            if (brandId != null)
                command.Parameters.AddWithValue("@brandId", brandId);
            else
                command.Parameters.AddWithValue("@brandId", System.DBNull.Value);

            if (!String.IsNullOrEmpty(nameSpecs))
                command.Parameters.AddWithValue("@nameSpecs", nameSpecs);
            else
                command.Parameters.AddWithValue("@nameSpecs", System.DBNull.Value);

            if (values != null)
                command.Parameters.AddWithValue("@values", values);
            else
                command.Parameters.AddWithValue("@values", System.DBNull.Value);

            if (!String.IsNullOrEmpty(description))
                command.Parameters.AddWithValue("@description", description);
            else
                command.Parameters.AddWithValue("@description", System.DBNull.Value);

            if (createdDate != null)
                command.Parameters.AddWithValue("@createdDate", createdDate);
            else
                command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

            if (createdUserId != null)
                command.Parameters.AddWithValue("@createdUserId", createdUserId);
            else
                command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

            if (isDeleted != null)
                command.Parameters.AddWithValue("@isDeleted", isDeleted);
            else
                command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@status", status);
            else
                command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }

        /// <summary>
        /// Creates a Specs object from the passed data row
        /// </summary>
        private static DeviceDetailModel CreateDeviceDetailFromDataRowShared(DataRow dr)
        {
            DeviceDetailModel objDeviceDetail = new DeviceDetailModel();

            objDeviceDetail.Id = (int)dr["Id"];
            objDeviceDetail.DeviceId = (int)dr["DeviceId"];
            objDeviceDetail.DeviceTypeSpecsId = (int)dr["DeviceTypeSpecsId"];
            objDeviceDetail.BrandId = (int)dr["BrandId"];

            if (dr["NameSpecs"] != System.DBNull.Value)
                objDeviceDetail.NameSpecs = dr["NameSpecs"].ToString();
            else
                objDeviceDetail.NameSpecs = null;

            if (dr["Values"] != System.DBNull.Value)
                objDeviceDetail.Values = (decimal) dr["Values"];
            else
                objDeviceDetail.Values = null;

            if (dr["Description"] != System.DBNull.Value)
                objDeviceDetail.Description = dr["Description"].ToString();
            else
                objDeviceDetail.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objDeviceDetail.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDeviceDetail.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDeviceDetail.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDeviceDetail.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDeviceDetail.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDeviceDetail.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objDeviceDetail.Status = (int)dr["Status"];
            else
                objDeviceDetail.Status = null;

            return objDeviceDetail;
        }
    }
}
