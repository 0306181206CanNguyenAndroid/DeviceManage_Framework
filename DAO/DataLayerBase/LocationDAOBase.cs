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
    /// Base class for LocationDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the LocationDataLayer class
    /// </summary>
    public class LocationDataLayerBase
    {
        // constructor
        public LocationDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static LocationModel SelectByPrimaryKey(int id)
        {
            LocationModel objLocation = null;
            string storedProcName = "[dbo].[Location_SelectByPrimaryKey]";

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
                                objLocation = CreateLocationFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objLocation;
        }

        /// <summary>
        /// Gets the total number of records in the Location table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[Location_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the Location table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[Location_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, createdDate, createdUserId, isDeleted);

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
        /// Selects Location records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<LocationModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[Location_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Location records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<LocationModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
        {
            List<LocationModel> objLocationCol = null;
            string storedProcName = "[dbo].[Location_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, name, createdDate, createdUserId, isDeleted);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objLocationCol = new List<LocationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    LocationModel objLocation = CreateLocationFromDataRowShared(dr);
                                    objLocationCol.Add(objLocation);
                                }
                            }
                        }
                    }
                }
            }

            return objLocationCol;
        }

        /// <summary>
        /// Selects all Location
        /// </summary>
        public static List<LocationModel> SelectAll()
        {
            return SelectShared("[dbo].[Location_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Location.
        /// </summary>
        public static List<LocationModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            List<LocationModel> objLocationCol = new List<LocationModel>();
            string storedProcName = "[dbo].[Location_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, createdDate, createdUserId, isDeleted);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objLocationCol = new List<LocationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    LocationModel objLocation = CreateLocationFromDataRowShared(dr);
                                    objLocationCol.Add(objLocation);
                                }
                            }
                        }
                    }
                }
            }
            
            return objLocationCol;
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<LocationModel> SelectLocationDropDownListData()
        {
            List<LocationModel> objLocationCol = null;
            string storedProcName = "[dbo].[Location_SelectDropDownListData]";

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
                                objLocationCol = new List<LocationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    LocationModel objLocation = new LocationModel();
                                    objLocation.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objLocation.Name = (string)(dr["Name"]);
                                    else
                                        objLocation.Name = null;

                                    objLocationCol.Add(objLocation);
                                }
                            }
                        }
                    }
                }
            }

            return objLocationCol;
        }

        public static List<LocationModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<LocationModel> objLocationCol = null;

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
                                objLocationCol = new List<LocationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    LocationModel objLocation = CreateLocationFromDataRowShared(dr);
                                    objLocationCol.Add(objLocation);
                                }
                            }
                        }
                    }
                }
            }

            return objLocationCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(LocationModel objLocation)
        {
            string storedProcName = "[dbo].[Location_Insert]";
            return InsertUpdate(objLocation, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(LocationModel objLocation)
        {
            string storedProcName = "[dbo].[Location_Update]";
            InsertUpdate(objLocation, true, storedProcName);
        }

        private static int InsertUpdate(LocationModel objLocation, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objLocation.Id;

            object name = objLocation.Name;
            object createdDate = objLocation.CreatedDate;
            object createdUserId = objLocation.CreatedUserId;

            if (String.IsNullOrEmpty(objLocation.Name))
                name = System.DBNull.Value;

            if (objLocation.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objLocation.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            //if (objLocation.Image == null)
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
                        command.Parameters.AddWithValue("@id", objLocation.Id);
                    }

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objLocation.IsDeleted);

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
            string storedProcName = "[dbo].[Location_Hide]";

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
        protected static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

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

        }

        /// <summary>
        /// Creates a Location object from the passed data row
        /// </summary>
        protected static LocationModel CreateLocationFromDataRowShared(DataRow dr)
        {
            LocationModel objLocation = new LocationModel();

            objLocation.Id = (int)dr["Id"];

            if (dr["Name"] != System.DBNull.Value)
                objLocation.Name = dr["Name"].ToString();
            else
                objLocation.Name = null;

            //if (dr["note"] != System.DBNull.Value)
                //objLocation.Note = dr["note"].ToString();
            //else
               // objLocation.Note = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objLocation.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objLocation.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objLocation.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objLocation.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objLocation.IsDeleted = (bool)dr["IsDeleted"];
            else
                objLocation.IsDeleted = false;

            return objLocation;
        }
    }
}
