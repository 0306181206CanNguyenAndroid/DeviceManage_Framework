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
    /// Base class for DeviceRegistrationDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the DeviceRegistrationDataLayer class
    /// </summary>
    public class DeviceRegistrationDataLayerBase
    {
        // constructor
        public DeviceRegistrationDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceRegistrationModel SelectByPrimaryKey(int id)
        {
            DeviceRegistrationModel objDeviceRegistration = null;
            string storedProcName = "[dbo].[DeviceRegistration_SelectByPrimaryKey]";

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
                                objDeviceRegistration = CreateDeviceRegistrationFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDeviceRegistration;
        }

        /// <summary>
        /// Gets the total number of records in the DeviceRegistration table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[DeviceRegistration_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the DeviceRegistration table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[DeviceRegistration_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);

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
        /// Selects DeviceRegistration records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[DeviceRegistration_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects DeviceRegistration records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = null;
            string storedProcName = "[dbo].[DeviceRegistration_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceRegistrationCol = new List<DeviceRegistrationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceRegistrationModel objDeviceRegistration = CreateDeviceRegistrationFromDataRowShared(dr);
                                    objDeviceRegistrationCol.Add(objDeviceRegistration);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceRegistrationCol;
        }

        /// <summary>
        /// Selects all DeviceRegistration
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAll()
        {
            return SelectShared("[dbo].[DeviceRegistration_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceRegistration.
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAllDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = null;
            string storedProcName = "[dbo].[DeviceRegistration_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceRegistrationCol = new List<DeviceRegistrationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceRegistrationModel objDeviceRegistration = CreateDeviceRegistrationFromDataRowShared(dr);
                                    objDeviceRegistrationCol.Add(objDeviceRegistration);
                                }
                            }
                        }
                    }
                }
            }
            if (objDeviceRegistrationCol != null)
                return objDeviceRegistrationCol;
            else return new List<DeviceRegistrationModel>();
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<DeviceRegistrationModel> SelectDeviceRegistrationDropDownListData()
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = null;
            string storedProcName = "[dbo].[DeviceRegistration_SelectDropDownListData]";

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
                                objDeviceRegistrationCol = new List<DeviceRegistrationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceRegistrationModel objDeviceRegistration = new DeviceRegistrationModel();
                                    objDeviceRegistration.Id = (int)dr["Id"];

                                    objDeviceRegistrationCol.Add(objDeviceRegistration);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceRegistrationCol;
        }

        public static List<DeviceRegistrationModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = null;

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
                                objDeviceRegistrationCol = new List<DeviceRegistrationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceRegistrationModel objDeviceRegistration = CreateDeviceRegistrationFromDataRowShared(dr);
                                    objDeviceRegistrationCol.Add(objDeviceRegistration);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceRegistrationCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceRegistrationModel objDeviceRegistration)
        {
            string storedProcName = "[dbo].[DeviceRegistration_Insert]";
            return InsertUpdate(objDeviceRegistration, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceRegistrationModel objDeviceRegistration)
        {
            string storedProcName = "[dbo].[DeviceRegistration_Update]";
            InsertUpdate(objDeviceRegistration, true, storedProcName);
        }

        private static int InsertUpdate(DeviceRegistrationModel objDeviceRegistration, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objDeviceRegistration.Id;

            object createdDate = objDeviceRegistration.CreatedDate;
            object createdUserId = objDeviceRegistration.CreatedUserId;
            object status = objDeviceRegistration.Status;


            if (objDeviceRegistration.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objDeviceRegistration.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objDeviceRegistration.Status == null)
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
                        command.Parameters.AddWithValue("@id", objDeviceRegistration.Id);
                    }

                    command.Parameters.AddWithValue("@locationId", objDeviceRegistration.LocationId);
                    command.Parameters.AddWithValue("@roomId", objDeviceRegistration.RoomId);
                    command.Parameters.AddWithValue("@deviceId", objDeviceRegistration.DeviceId);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objDeviceRegistration.IsDeleted);
                    command.Parameters.AddWithValue("@status",objDeviceRegistration.Status);

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
            string storedProcName = "[dbo].[DeviceRegistration_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (deviceId != null)
                command.Parameters.AddWithValue("@deviceId", deviceId);
            else
                command.Parameters.AddWithValue("@deviceId", System.DBNull.Value);

            if (roomId != null)
                command.Parameters.AddWithValue("@roomId", roomId);
            else
                command.Parameters.AddWithValue("@roomId", System.DBNull.Value);

            if (locationId != null)
                command.Parameters.AddWithValue("@locationId", locationId);
            else
                command.Parameters.AddWithValue("@locationId", System.DBNull.Value);

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
        /// Creates a DeviceRegistration object from the passed data row
        /// </summary>
        protected static DeviceRegistrationModel CreateDeviceRegistrationFromDataRowShared(DataRow dr)
        {
            DeviceRegistrationModel objDeviceRegistration = new DeviceRegistrationModel();

            objDeviceRegistration.Id = (int)dr["Id"];
            objDeviceRegistration.DeviceId = (int)dr["DeviceId"];
            objDeviceRegistration.RoomId = (int)dr["RoomId"];
            objDeviceRegistration.LocationId = (int)dr["LocationId"];


            if (dr["CreatedDate"] != System.DBNull.Value)
                objDeviceRegistration.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDeviceRegistration.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDeviceRegistration.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDeviceRegistration.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDeviceRegistration.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDeviceRegistration.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objDeviceRegistration.Status = (int)dr["Status"];
            else
                objDeviceRegistration.Status = null;

            return objDeviceRegistration;
        }
    }
}
