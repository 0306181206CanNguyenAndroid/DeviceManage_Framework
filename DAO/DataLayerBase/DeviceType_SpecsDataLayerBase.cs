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
    public class DeviceType_SpecsDataLayerBase
    {
        // constructor
        public DeviceType_SpecsDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceType_SpecsModel SelectByPrimaryKey(int id)
        {
            DeviceType_SpecsModel objDeviceType_Specs = null;
            string storedProcName = "[dbo].[DeviceType_Specs_SelectByPrimaryKey]";

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
                                objDeviceType_Specs = CreateDeviceType_SpecsFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDeviceType_Specs;
        }

        /// <summary>
        /// Gets the total number of records in the Specs table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[DeviceType_Specs_GetRecordCount]", null, null, true, null);
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
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[DeviceType_Specs_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted/*, status*/);

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
        public static List<DeviceType_SpecsModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[DeviceType_Specs_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/, string sortByExpression, int startRowIndex, int rows)
        {
            List<DeviceType_SpecsModel> objDeviceType_SpecsCol = null;
            string storedProcName = "[dbo].[DeviceType_Specs_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted/*, status*/);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceType_SpecsCol = new List<DeviceType_SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceType_SpecsModel objDeviceType_Specs = CreateDeviceType_SpecsFromDataRowShared(dr);
                                    objDeviceType_SpecsCol.Add(objDeviceType_Specs);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceType_SpecsCol;
        }

        /// <summary>
        /// Selects all Specs
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAll()
        {
            return SelectShared("[dbo].[DeviceType_Specs_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// 
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/)
        {
            List<DeviceType_SpecsModel> objDeviceType_SpecsCol = null;
            string storedProcName = "[dbo].[DeviceType_Specs_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted/*, status*/);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceType_SpecsCol = new List<DeviceType_SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceType_SpecsModel objDeviceType_Specs = CreateDeviceType_SpecsFromDataRowShared(dr);
                                    objDeviceType_SpecsCol.Add(objDeviceType_Specs);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceType_SpecsCol;
        }

        public static List<DeviceType_SpecsModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<DeviceType_SpecsModel> objDeviceType_SpecsCol = null;

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
                                objDeviceType_SpecsCol = new List<DeviceType_SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceType_SpecsModel objDeviceType_Specs = CreateDeviceType_SpecsFromDataRowShared(dr);
                                    objDeviceType_SpecsCol.Add(objDeviceType_Specs);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceType_SpecsCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceType_SpecsModel objDeviceType_Specs)
        {
            string storedProcName = "[dbo].[DeviceType_Specs_Insert]";
            return InsertUpdate(objDeviceType_Specs, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceType_SpecsModel objDeviceType_Specs)
        {
            string storedProcName = "[dbo].[DeviceType_Specs_Update]";
            InsertUpdate(objDeviceType_Specs, true, storedProcName);
        }

        private static int InsertUpdate(DeviceType_SpecsModel objDeviceType_Specs, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objDeviceType_Specs.Id;

            object deviceTypeId = objDeviceType_Specs.DeviceTypeId;
            object deviceSpecsId = objDeviceType_Specs.SpecsId;
            object createdDate = objDeviceType_Specs.CreatedDate;
            object createdUserId = objDeviceType_Specs.CreatedUserId;
            //object status = objDeviceType_Specs.Status;

            if (objDeviceType_Specs.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objDeviceType_Specs.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            //if (objDeviceType_Specs.Status == null)
            //    status = System.DBNull.Value;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // parameters
                    if (isUpdate)
                    {
                        // for update only
                        command.Parameters.AddWithValue("@id", objDeviceType_Specs.Id);
                    }

                    command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                    command.Parameters.AddWithValue("@deviceSpecsId", deviceSpecsId);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objDeviceType_Specs.IsDeleted);
                    //command.Parameters.AddWithValue("@status", status);

                    connection.Open();

                    if (isUpdate)
                        command.ExecuteNonQuery();
                    else
                    {
                        newlyCreatedId = (int) command.ExecuteScalar();
                    }
                }
            }

            return newlyCreatedId;
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            string storedProcName = "[dbo].[DeviceType_Specs_Hide]";

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
        /// Selects records based on the passed filters as a collection (List) .
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAllSpecsOfDevice(int deviceTypeId, bool isDeleted)
        {
            List<DeviceType_SpecsModel> objDeviceType_SpecsCol = null;
            string storedProcName = "[dbo].[DeviceType_Specs_SelectAllSpecsOfDevice]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                    command.Parameters.AddWithValue("@isDeleted", isDeleted);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceType_SpecsCol = new List<DeviceType_SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceType_SpecsModel objDeviceType_Specs = CreateDeviceType_SpecsFromDataRowShared(dr);
                                    if (dr["Name"] != System.DBNull.Value)
                                        objDeviceType_Specs.SpecsName = dr["Name"].ToString();
                                    else
                                        objDeviceType_Specs.SpecsName = "";

                                    if (dr["DataType"] != System.DBNull.Value)
                                        objDeviceType_Specs.DataType = dr["DataType"].ToString();
                                    else
                                        objDeviceType_Specs.DataType = "";
                                    if (dr["Ordinal"] != System.DBNull.Value)
                                        objDeviceType_Specs.Ordinal = (int)dr["Ordinal"];
                                    else
                                        objDeviceType_Specs.Ordinal = 99;

                                    objDeviceType_SpecsCol.Add(objDeviceType_Specs);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceType_SpecsCol;
        }

        /// <summary>
        /// Adds search parameters to the Command object
        /// </summary>
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (deviceTypeId != null)
                command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
            else
                command.Parameters.AddWithValue("@deviceTypeId", System.DBNull.Value);

            if (deviceSpecsId != null)
                command.Parameters.AddWithValue("@deviceSpecsId", deviceSpecsId);
            else
                command.Parameters.AddWithValue("@deviceSpecsId", System.DBNull.Value);

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

            //if (status != null)
            //    command.Parameters.AddWithValue("@status", status);
            //else
            //    command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }

        /// <summary>
        /// Creates a Specs object from the passed data row
        /// </summary>
        protected static DeviceType_SpecsModel CreateDeviceType_SpecsFromDataRowShared(DataRow dr)
        {
            DeviceType_SpecsModel objDeviceType_Specs = new DeviceType_SpecsModel();

            objDeviceType_Specs.Id = (int)dr["Id"];

            if (dr["DeviceTypeId"] != System.DBNull.Value)
                objDeviceType_Specs.DeviceTypeId = (int)dr["DeviceTypeId"];
            else
                objDeviceType_Specs.DeviceTypeId = 1;

            if (dr["DeviceSpecsId"] != System.DBNull.Value)
                objDeviceType_Specs.SpecsId = (int)dr["DeviceSpecsId"];
            else
                objDeviceType_Specs.SpecsId = 1;

            if (dr["Description"] != System.DBNull.Value)
                objDeviceType_Specs.Description = dr["Description"].ToString();
            else
                objDeviceType_Specs.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objDeviceType_Specs.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDeviceType_Specs.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDeviceType_Specs.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDeviceType_Specs.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDeviceType_Specs.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDeviceType_Specs.IsDeleted = false;

            //if (dr["Status"] != System.DBNull.Value)
            //    objDeviceType_Specs.Status = (int)dr["Status"];
            //else
            //    objDeviceType_Specs.Status = null;

            return objDeviceType_Specs;
        }
    }
}
