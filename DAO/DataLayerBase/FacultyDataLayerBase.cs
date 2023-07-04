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
    /// Base class for FacultyDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the FacultyDataLayer class
    /// </summary>
    public class FacultyDataLayerBase
    {
        // constructor
        public FacultyDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static FacultyModel SelectByPrimaryKey(int id)
        {
            FacultyModel objFaculty = null;
            string storedProcName = "[dbo].[Faculty_SelectByPrimaryKey]";

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
                                objFaculty = CreateFacultyFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objFaculty;
        }

        /// <summary>
        /// Gets the total number of records in the Faculty table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[Faculty_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the Faculty table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted )
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[Faculty_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, image, description, createdDate, createdUserId, isDeleted );

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
        /// Selects Faculty records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[Faculty_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Faculty records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
        {
            List<FacultyModel> objFacultyCol = null;
            string storedProcName = "[dbo].[Faculty_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, name, image, description, createdDate, createdUserId, isDeleted );

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objFacultyCol = new List<FacultyModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    FacultyModel objFaculty = CreateFacultyFromDataRowShared(dr);
                                    objFacultyCol.Add(objFaculty);
                                }
                            }
                        }
                    }
                }
            }

            return objFacultyCol;
        }

        /// <summary>
        /// Selects all Faculty
        /// </summary>
        public static List<FacultyModel> SelectAll()
        {
            return SelectShared("[dbo].[Faculty_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Faculty.
        /// </summary>
        public static List<FacultyModel> SelectAllDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            List<FacultyModel> objFacultyCol = null;
            string storedProcName = "[dbo].[Faculty_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, name, image, description, createdDate, createdUserId, isDeleted );

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objFacultyCol = new List<FacultyModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    FacultyModel objFaculty = CreateFacultyFromDataRowShared(dr);
                                    objFacultyCol.Add(objFaculty);
                                }
                            }
                        }
                    }
                }
            }
            if (objFacultyCol != null)
                return objFacultyCol;
            else return new List<FacultyModel>();
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<FacultyModel> SelectFacultyDropDownListData()
        {
            List<FacultyModel> objFacultyCol = null;
            string storedProcName = "[dbo].[Faculty_SelectDropDownListData]";

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
                                objFacultyCol = new List<FacultyModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    FacultyModel objFaculty = new FacultyModel();
                                    objFaculty.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objFaculty.Name = (string)(dr["Name"]);
                                    else
                                        objFaculty.Name = null;

                                    objFacultyCol.Add(objFaculty);
                                }
                            }
                        }
                    }
                }
            }

            return objFacultyCol;
        }

        public static List<FacultyModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<FacultyModel> objFacultyCol = null;

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
                                objFacultyCol = new List<FacultyModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    FacultyModel objFaculty = CreateFacultyFromDataRowShared(dr);
                                    objFacultyCol.Add(objFaculty);
                                }
                            }
                        }
                    }
                }
            }

            return objFacultyCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(FacultyModel objFaculty)
        {
            string storedProcName = "[dbo].[Faculty_Insert]";
            return InsertUpdate(objFaculty, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(FacultyModel objFaculty)
        {
            string storedProcName = "[dbo].[Faculty_Update]";
            InsertUpdate(objFaculty, true, storedProcName);
        }

        private static int InsertUpdate(FacultyModel objFaculty, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objFaculty.Id;

            object name = objFaculty.Name;
            object createdDate = objFaculty.CreatedDate;
            object createdUserId = objFaculty.CreatedUserId;
            //object image = objFaculty.Image;

            if (String.IsNullOrEmpty(objFaculty.Name))
                name = System.DBNull.Value;

            if (objFaculty.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objFaculty.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            //if (objFaculty.Image == null)
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
                        command.Parameters.AddWithValue("@id", objFaculty.Id);
                    }

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objFaculty.IsDeleted);
                    //command.Parameters.AddWithValue("@image",objFaculty.Image);

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
            string storedProcName = "[dbo].[Faculty_Hide]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted )
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

            if (image != null)
                command.Parameters.AddWithValue("@image", image);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);

        }

        /// <summary>
        /// Creates a Faculty object from the passed data row
        /// </summary>
        protected static FacultyModel CreateFacultyFromDataRowShared(DataRow dr)
        {
            FacultyModel objFaculty = new FacultyModel();

            objFaculty.Id = (int)dr["Id"];

            if (dr["Name"] != System.DBNull.Value)
                objFaculty.Name = dr["Name"].ToString();
            else
                objFaculty.Name = null;

            if (dr["Description"] != System.DBNull.Value)
                objFaculty.Description = dr["Description"].ToString();
            else
                objFaculty.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objFaculty.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objFaculty.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objFaculty.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objFaculty.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objFaculty.IsDeleted = (bool)dr["IsDeleted"];
            else
                objFaculty.IsDeleted = false;

            //if (dr["image"] != System.DBNull.Value)
               // objFaculty.Image = dr["image"].ToString();
            //else
               // objFaculty.Image = null;

            return objFaculty;
        }
    }
}
