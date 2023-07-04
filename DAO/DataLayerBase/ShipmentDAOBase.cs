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
    /// Base class for ShipmentDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the ShipmentDataLayer class
    /// </summary>
    public class ShipmentDataLayerBase
    {
        // constructor
        public ShipmentDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static ShipmentModel SelectByPrimaryKey(int id)
        {
            ShipmentModel objShipment = null;
            string storedProcName = "[dbo].[Shipment_SelectByPrimaryKey]";

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
                                objShipment = CreateShipmentFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objShipment;
        }

        /// <summary>
        /// Gets the total number of records in the Shipment table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[Shipment_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the Shipment table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[Shipment_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);

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
        /// Selects Shipment records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[Shipment_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Shipment records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTakeDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<ShipmentModel> objShipmentCol = new List<ShipmentModel>();
            string storedProcName = "[dbo].[Shipment_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id,brandId,approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);

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
                                    ShipmentModel objShipment = CreateShipmentFromDataRowShared(dr);
                                    objShipmentCol.Add(objShipment);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentCol;
        }

        /// <summary>
        /// Selects all Shipment
        /// </summary>
        public static List<ShipmentModel> SelectAll()
        {
            return SelectShared("[dbo].[Shipment_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Shipment.
        /// </summary>
        public static List<ShipmentModel> SelectAllDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<ShipmentModel> objShipmentCol = new List<ShipmentModel>();
            string storedProcName = "[dbo].[Shipment_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id,brandId,approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);

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
                                    ShipmentModel objShipment = CreateShipmentFromDataRowShared(dr);
                                    objShipmentCol.Add(objShipment);
                                }
                            }
                        }
                    }
                }
            }
               
            return objShipmentCol;
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<ShipmentModel> SelectShipmentDropDownListData()
        {
            List<ShipmentModel> objShipmentCol = new List<ShipmentModel>();
            string storedProcName = "[dbo].[Shipment_SelectDropDownListData]";

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
                                    ShipmentModel objShipment = new ShipmentModel();
                                    objShipment.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objShipment.Name = (string)(dr["Name"]);
                                    else
                                        objShipment.Name = null;

                                    objShipmentCol.Add(objShipment);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentCol;
        }

        public static List<ShipmentModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<ShipmentModel> objShipmentCol = new List<ShipmentModel>();

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
                                    ShipmentModel objShipment = CreateShipmentFromDataRowShared(dr);
                                    objShipmentCol.Add(objShipment);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(ShipmentModel objShipment)
        {
            string storedProcName = "[dbo].[Shipment_Insert]";
            return InsertUpdate(objShipment, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(ShipmentModel objShipment)
        {
            string storedProcName = "[dbo].[Shipment_Update]";
            InsertUpdate(objShipment, true, storedProcName);
        }

        private static int InsertUpdate(ShipmentModel objShipment, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objShipment.Id;

            object name = objShipment.Name;
            object createdDate = objShipment.CreatedDate;
            object createdUserId = objShipment.CreatedUserId;
            object invoice = objShipment.Invoice;
            object description = objShipment.Description;

            if (String.IsNullOrEmpty(objShipment.Name))
                name = System.DBNull.Value;

            if (String.IsNullOrEmpty(objShipment.Description))
                description = System.DBNull.Value;

            if (objShipment.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objShipment.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objShipment.Invoice == null)
             invoice = System.DBNull.Value;

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
                        command.Parameters.AddWithValue("@id", objShipment.Id);
                    }

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@brandId", objShipment.BrandId);
                    command.Parameters.AddWithValue("@invoice", invoice);
                    command.Parameters.AddWithValue("@approverId", objShipment.ApproverId);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@importDate", objShipment.ImportDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objShipment.IsDeleted);
                    command.Parameters.AddWithValue("@status", objShipment.Status);

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
            string storedProcName = "[dbo].[Shipment_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (brandId != null)
                command.Parameters.AddWithValue("@brandId", brandId);
            else
                command.Parameters.AddWithValue("@brandId", System.DBNull.Value);

            if (approverId != null)
                command.Parameters.AddWithValue("@approverId", approverId);
            else
                command.Parameters.AddWithValue("@approverId", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (invoice != null)
                command.Parameters.AddWithValue("@invoice", invoice);
            else
                command.Parameters.AddWithValue("@invoice", System.DBNull.Value);

            if (!String.IsNullOrEmpty(description))
                command.Parameters.AddWithValue("@description", description);
            else
                command.Parameters.AddWithValue("@description", System.DBNull.Value);

            if (importDate != null)
                command.Parameters.AddWithValue("@importDate", importDate);
            else
                command.Parameters.AddWithValue("@importDate", System.DBNull.Value);

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
        /// Creates a Shipment object from the passed data row
        /// </summary>
        protected static ShipmentModel CreateShipmentFromDataRowShared(DataRow dr)
        {
            ShipmentModel objShipment = new ShipmentModel();

            objShipment.Id = (int)dr["Id"];
            objShipment.BrandId = (int)dr["BrandId"];
            objShipment.ApproverId = (int)dr["ApproverId"];

            if (dr["Name"] != System.DBNull.Value)
                objShipment.Name = dr["Name"].ToString();
            else
                objShipment.Name = null;

            if (dr["Invoice"] != System.DBNull.Value)
                objShipment.Invoice = dr["Invoice"].ToString();
            else
                objShipment.Invoice = null;

            if (dr["Description"] != System.DBNull.Value)
                objShipment.Description = dr["Description"].ToString();
            else
                objShipment.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objShipment.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objShipment.CreatedDate = null;

            if (dr["ImportDate"] != System.DBNull.Value)
                objShipment.ImportDate = (DateTime)dr["ImportDate"];
            else
                objShipment.ImportDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objShipment.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objShipment.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objShipment.IsDeleted = (bool)dr["IsDeleted"];
            else
                objShipment.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objShipment.Status = (int)dr["Status"];
            else
                objShipment.Status = null;

            return objShipment;
        }
    }
}
