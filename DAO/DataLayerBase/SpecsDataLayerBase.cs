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
    public class SpecsDataLayerBase
    {
        // constructor
        public SpecsDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static SpecsModel SelectByPrimaryKey(int id)
        {
            SpecsModel objSpecs = null;
            string storedProcName = "[dbo].[Specs_SelectByPrimaryKey]";

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
                                objSpecs = CreateSpecsFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objSpecs;
        }

        /// <summary>
        /// Gets the total number of records in the Specs table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[Specs_GetRecordCount]", null, null, true, null);
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
        public static int GetRecordCountDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[Specs_GetRecordCountWhereDynamic]";

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
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[Specs_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<SpecsModel> objSpecsCol = null;
            string storedProcName = "[dbo].[Specs_SelectSkipAndTakeWhereDynamic]";

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
                                objSpecsCol = new List<SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    SpecsModel objSpecs = CreateSpecsFromDataRowShared(dr);
                                    objSpecsCol.Add(objSpecs);
                                }
                            }
                        }
                    }
                }
            }

            return objSpecsCol;
        }

        /// <summary>
        /// Selects all Specs
        /// </summary>
        public static List<SpecsModel> SelectAll()
        {
            return SelectShared("[dbo].[Specs_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs.
        /// </summary>
        public static List<SpecsModel> SelectAllDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<SpecsModel> objSpecsCol = null;
            string storedProcName = "[dbo].[Specs_SelectAllWhereDynamic]";

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
                                objSpecsCol = new List<SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    SpecsModel objSpecs = CreateSpecsFromDataRowShared(dr);
                                    objSpecsCol.Add(objSpecs);
                                }
                            }
                        }
                    }
                }
            }
            if (objSpecsCol != null)
                return objSpecsCol;
            else return new List<SpecsModel>();
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<SpecsModel> SelectSpecsDropDownListData()
        {
            List<SpecsModel> objSpecsCol = null;
            string storedProcName = "[dbo].[Specs_SelectDropDownListData]";

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
                                objSpecsCol = new List<SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    SpecsModel objSpecs = new SpecsModel();
                                    objSpecs.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objSpecs.Name = (string)(dr["Name"]);
                                    else
                                        objSpecs.Name = null;

                                    objSpecsCol.Add(objSpecs);
                                }
                            }
                        }
                    }
                }
            }

            return objSpecsCol;
        }

        public static List<SpecsModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<SpecsModel> objSpecsCol = null;

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
                                objSpecsCol = new List<SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    SpecsModel objSpecs = CreateSpecsFromDataRowShared(dr);
                                    objSpecsCol.Add(objSpecs);
                                }
                            }
                        }
                    }
                }
            }

            return objSpecsCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(SpecsModel objSpecs)
        {
            string storedProcName = "[dbo].[Specs_Insert]";
            return InsertUpdate(objSpecs, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(SpecsModel objSpecs)
        {
            string storedProcName = "[dbo].[Specs_Update]";
            InsertUpdate(objSpecs, true, storedProcName);
        }

        private static int InsertUpdate(SpecsModel objSpecs, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objSpecs.Id;

            object name = objSpecs.Name;
            object createdDate = objSpecs.CreatedDate;
            object createdUserId = objSpecs.CreatedUserId;
            object status = objSpecs.Status;

            if (String.IsNullOrEmpty(objSpecs.Name))
                name = System.DBNull.Value;

            if (objSpecs.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objSpecs.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objSpecs.Status == null)
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
                        command.Parameters.AddWithValue("@id", objSpecs.Id);
                    }

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objSpecs.IsDeleted);
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
            string storedProcName = "[dbo].[Specs_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (id != null)
                command.Parameters.AddWithValue("@ordinal", ordinal);
            else
                command.Parameters.AddWithValue("@ordinal", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (!String.IsNullOrEmpty(datatype))
                command.Parameters.AddWithValue("@dataType", datatype);
            else
                command.Parameters.AddWithValue("@DataType", System.DBNull.Value);

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
        protected static SpecsModel CreateSpecsFromDataRowShared(DataRow dr)
        {
            SpecsModel objSpecs = new SpecsModel();

            objSpecs.Id = (int)dr["Id"];

            if (dr["Name"] != System.DBNull.Value)
                objSpecs.Name = dr["Name"].ToString();
            else
                objSpecs.Name = null;

            if (dr["DataType"] != System.DBNull.Value)
                objSpecs.DataType = dr["DataType"].ToString();
            else
                objSpecs.DataType = null;

            if (dr["Description"] != System.DBNull.Value)
                objSpecs.Description = dr["Description"].ToString();
            else
                objSpecs.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objSpecs.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objSpecs.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objSpecs.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objSpecs.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objSpecs.IsDeleted = (bool)dr["IsDeleted"];
            else
                objSpecs.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objSpecs.Status = (int)dr["Status"];
            else
                objSpecs.Status = null;

            if (dr["Ordinal"] != System.DBNull.Value)
                objSpecs.Ordinal = (int)dr["Ordinal"];
            else
                objSpecs.Ordinal = 0;

            return objSpecs;
        }
    }
}
