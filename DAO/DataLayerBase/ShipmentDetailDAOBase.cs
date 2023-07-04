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
    /// Base class for ShipmentDetailDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the ShipmentDetailDataLayer class
    /// </summary>
    public class ShipmentDetailDataLayerBase
    {
        // constructor
        public ShipmentDetailDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static ShipmentDetailModel SelectByPrimaryKey(int id)
        {
            ShipmentDetailModel objShipmentDetail = null;
            string storedProcName = "[dbo].[ShipmentDetail_SelectByPrimaryKey]";

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
                                objShipmentDetail = CreateShipmentDetailFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objShipmentDetail;
        }

        /// <summary>
        /// Gets the total number of records in the ShipmentDetail table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[ShipmentDetail_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the ShipmentDetail table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[ShipmentDetail_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);

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
        /// Selects ShipmentDetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[ShipmentDetail_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects ShipmentDetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = new List<ShipmentDetailModel>();
            string storedProcName = "[dbo].[ShipmentDetail_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ShipmentDetailModel objShipmentDetail = CreateShipmentDetailFromDataRowShared(dr);
                                    objShipmentDetailCol.Add(objShipmentDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentDetailCol;
        }

        /// <summary>
        /// Selects all ShipmentDetail
        /// </summary>
        public static List<ShipmentDetailModel> SelectAll()
        {
            return SelectShared("[dbo].[ShipmentDetail_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of ShipmentDetail.
        /// </summary>
        public static List<ShipmentDetailModel> SelectAllDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = new List<ShipmentDetailModel>();
            string storedProcName = "[dbo].[ShipmentDetail_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ShipmentDetailModel objShipmentDetail = CreateShipmentDetailFromDataRowShared(dr);
                                    objShipmentDetailCol.Add(objShipmentDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentDetailCol;
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<ShipmentDetailModel> SelectShipmentDetailDropDownListData()
        {
            List<ShipmentDetailModel> objShipmentDetailCol = new List<ShipmentDetailModel>();
            string storedProcName = "[dbo].[ShipmentDetail_SelectDropDownListData]";

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
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ShipmentDetailModel objShipmentDetail = new ShipmentDetailModel();
                                    objShipmentDetail.Id = (int)dr["Id"];

                                    objShipmentDetailCol.Add(objShipmentDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentDetailCol;
        }

        public static List<ShipmentDetailModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = new List<ShipmentDetailModel>();

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
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ShipmentDetailModel objShipmentDetail = CreateShipmentDetailFromDataRowShared(dr);
                                    objShipmentDetailCol.Add(objShipmentDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentDetailCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(ShipmentDetailModel objShipmentDetail)
        {
            string storedProcName = "[dbo].[ShipmentDetail_Insert]";
            return InsertUpdate(objShipmentDetail, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(ShipmentDetailModel objShipmentDetail)
        {
            string storedProcName = "[dbo].[ShipmentDetail_Update]";
            InsertUpdate(objShipmentDetail, true, storedProcName);
        }

        private static int InsertUpdate(ShipmentDetailModel objShipmentDetail, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objShipmentDetail.Id;
            
            object status = objShipmentDetail.Status;
            object code = objShipmentDetail.Code;
            object createdUserId = objShipmentDetail.CreatedUserId;

            if (objShipmentDetail.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objShipmentDetail.Status == null)
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
                        command.Parameters.AddWithValue("@id", objShipmentDetail.Id);
                    }

                    command.Parameters.AddWithValue("@deviceId", objShipmentDetail.DeviceId);
                    command.Parameters.AddWithValue("@shipmentId", objShipmentDetail.ShipmentId);
                    command.Parameters.AddWithValue("@createdDate", objShipmentDetail.CreatedDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objShipmentDetail.IsDeleted);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@code", code);

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
            string storedProcName = "[dbo].[ShipmentDetail_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (shipmentId != null)
                command.Parameters.AddWithValue("@shipmentId", shipmentId);
            else
                command.Parameters.AddWithValue("@shipmentId", System.DBNull.Value);

            if (deviceId != null)
                command.Parameters.AddWithValue("@deviceId", deviceId);
            else
                command.Parameters.AddWithValue("@deviceId", System.DBNull.Value);

            if (code != null)
                command.Parameters.AddWithValue("@code", code);
            else
                command.Parameters.AddWithValue("@code", System.DBNull.Value);

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
        /// Creates a ShipmentDetail object from the passed data row
        /// </summary>
        protected static ShipmentDetailModel CreateShipmentDetailFromDataRowShared(DataRow dr)
        {
            ShipmentDetailModel objShipmentDetail = new ShipmentDetailModel();

            objShipmentDetail.Id = (int)dr["Id"];
            objShipmentDetail.DeviceId = (int)dr["DeviceId"];
            objShipmentDetail.ShipmentId = (int)dr["ShipmentId"];

            if (dr["Description"] != System.DBNull.Value)
                objShipmentDetail.Description = dr["Description"].ToString();
            else
                objShipmentDetail.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objShipmentDetail.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objShipmentDetail.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objShipmentDetail.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objShipmentDetail.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objShipmentDetail.IsDeleted = (bool)dr["IsDeleted"];
            else
                objShipmentDetail.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objShipmentDetail.Status = (int) dr["Status"];
            else
                objShipmentDetail.Status = null;

            return objShipmentDetail;
        }
    }
}
