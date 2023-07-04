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
    /// Base class for DeviceErrorDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the DeviceErrorDataLayer class
    /// </summary>
    public class DeviceErrorDataLayerBase
    {
        // constructor
        public DeviceErrorDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceErrorModel SelectByPrimaryKey(int id)
        {
            DeviceErrorModel objDeviceError = null;
            string storedProcName = "[dbo].[DeviceError_SelectByPrimaryKey]";

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
                                objDeviceError = CreateDeviceErrorFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDeviceError;
        }

        /// <summary>
        /// Gets the total number of records in the DeviceError table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[DeviceError_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the DeviceError table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[DeviceError_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);

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
        /// Selects DeviceError records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[DeviceError_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects DeviceError records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<DeviceErrorModel> objDeviceErrorCol = null;
            string storedProcName = "[dbo].[DeviceError_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceErrorCol = new List<DeviceErrorModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceErrorModel objDeviceError = CreateDeviceErrorFromDataRowShared(dr);
                                    objDeviceErrorCol.Add(objDeviceError);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceErrorCol;
        }

        /// <summary>
        /// Selects all DeviceError
        /// </summary>
        public static List<DeviceErrorModel> SelectAll()
        {
            return SelectShared("[dbo].[DeviceError_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceError.
        /// </summary>
        public static List<DeviceErrorModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<DeviceErrorModel> objDeviceErrorCol = null;
            string storedProcName = "[dbo].[DeviceError_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceErrorCol = new List<DeviceErrorModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceErrorModel objDeviceError = CreateDeviceErrorFromDataRowShared(dr);
                                    objDeviceErrorCol.Add(objDeviceError);
                                }
                            }
                        }
                    }
                }
            }
            if (objDeviceErrorCol != null)
                return objDeviceErrorCol;
            else return new List<DeviceErrorModel>();
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<DeviceErrorModel> SelectDeviceErrorDropDownListData()
        {
            List<DeviceErrorModel> objDeviceErrorCol = null;
            string storedProcName = "[dbo].[DeviceError_SelectDropDownListData]";

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
                                objDeviceErrorCol = new List<DeviceErrorModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceErrorModel objDeviceError = new DeviceErrorModel();
                                    objDeviceError.Id = (int)dr["Id"];


                                    objDeviceErrorCol.Add(objDeviceError);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceErrorCol;
        }

        public static List<DeviceErrorModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<DeviceErrorModel> objDeviceErrorCol = null;

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
                                objDeviceErrorCol = new List<DeviceErrorModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceErrorModel objDeviceError = CreateDeviceErrorFromDataRowShared(dr);
                                    objDeviceErrorCol.Add(objDeviceError);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceErrorCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceErrorModel objDeviceError)
        {
            string storedProcName = "[dbo].[DeviceError_Insert]";
            return InsertUpdate(objDeviceError, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceErrorModel objDeviceError)
        {
            string storedProcName = "[dbo].[DeviceError_Update]";
            InsertUpdate(objDeviceError, true, storedProcName);
        }

        private static int InsertUpdate(DeviceErrorModel objDeviceError, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objDeviceError.Id;

           
            object createdDate = objDeviceError.CreatedDate;
            object createdUserId = objDeviceError.CreatedUserId;
            //object image = objDeviceError.Image;

           

            if (objDeviceError.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objDeviceError.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            //if (objDeviceError.Image == null)
            // image = System.DBNull.Value;

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
                        command.Parameters.AddWithValue("@id", objDeviceError.Id);
                    }

                   
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objDeviceError.IsDeleted);
                    //command.Parameters.AddWithValue("@image",objDeviceError.Image);

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
            string storedProcName = "[dbo].[DeviceError_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (deviceTypeId != null)
                command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
            else
                command.Parameters.AddWithValue("@deviceTypeId", System.DBNull.Value);

            if (errorCode != null)
                command.Parameters.AddWithValue("@errorCode", errorCode);
            else
                command.Parameters.AddWithValue("@errorCode", System.DBNull.Value);

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

            if (solution != null)
                command.Parameters.AddWithValue("@solution", solution);
            else
                command.Parameters.AddWithValue("@solution", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@status", id);
            else
                command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }

        /// <summary>
        /// Creates a DeviceError object from the passed data row
        /// </summary>
        protected static DeviceErrorModel CreateDeviceErrorFromDataRowShared(DataRow dr)
        {
            DeviceErrorModel objDeviceError = new DeviceErrorModel();

            objDeviceError.Id = (int)dr["Id"];
            objDeviceError.DeviceTypeId = (int)dr["deviceTypeId"];


            if (dr["Description"] != System.DBNull.Value)
                objDeviceError.Description = dr["Description"].ToString();
            else
                objDeviceError.Description = null;

            if (dr["Solution"] != System.DBNull.Value)
                objDeviceError.Solution = dr["Solution"].ToString();
            else
                objDeviceError.Solution = null;

            if (dr["ErrorCode"] != System.DBNull.Value)
                objDeviceError.ErrorCode = dr["ErrorCode"].ToString();
            else
                objDeviceError.ErrorCode = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objDeviceError.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDeviceError.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDeviceError.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDeviceError.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDeviceError.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDeviceError.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objDeviceError.Status = (int)dr["Status"];
            else
                objDeviceError.Status = null;

            return objDeviceError;
        }
    }
}
