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
    public class DeviceDataLayerBase
    {
        // constructor
        public DeviceDataLayerBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary> 
        public static DeviceModel SelectByPrimaryKey(int id)
        {
            DeviceModel objDevice = null;
            string storedProcName = "[dbo].[Device_SelectByPrimaryKey]";

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
                                objDevice = CreateDeviceFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objDevice;
        }

        /// <summary>
        /// Gets the total number of records in the Specs table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[Device_GetRecordCount]", null, null, true, null);
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
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[Device_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);

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
        public static List<DeviceModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[Device_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects Specs records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<DeviceModel> objDeviceCol = null;
            string storedProcName = "[dbo].[Device_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objDeviceCol = new List<DeviceModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }

        /// <summary>
        /// Selects all Specs
        /// </summary>
        public static List<DeviceModel> SelectAll()
        {
            return SelectShared("[dbo].[Device_SelectAll]", String.Empty, null);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs.
        /// </summary>
        public static List<DeviceModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<DeviceModel> objDeviceCol = new List<DeviceModel>();
            string storedProcName = "[dbo].[Device_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);

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
                                    DeviceModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }

        /// <summary>
        /// Selects Id and Name columns for use with a DropDownList web control
        /// </summary>
        public static List<DeviceModel> SelectSpecsDropDownListData()
        {
            List<DeviceModel> objDeviceCol = null;
            string storedProcName = "[dbo].[Device_SelectDropDownListData]";

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
                                objDeviceCol = new List<DeviceModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceModel objDevice = new DeviceModel();
                                    objDevice.Id = (int)dr["Id"];

                                    if (dr["Name"] != System.DBNull.Value)
                                        objDevice.Name = (string)(dr["Name"]);
                                    else
                                        objDevice.Name = null;

                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }

        public static List<DeviceModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<DeviceModel> objDeviceCol = null;

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
                                objDeviceCol = new List<DeviceModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    DeviceModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceModel objDevice)
        {
            string storedProcName = "[dbo].[Device_Insert]";
            return InsertUpdate(objDevice, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceModel objDevice)
        {
            string storedProcName = "[dbo].[Device_Update]";
            InsertUpdate(objDevice, true, storedProcName);
        }

        private static int InsertUpdate(DeviceModel objDevice, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objDevice.Id;

            object deviceTypeId = objDevice.DeviceTypeId;
            object brandId = objDevice.BrandId;
            object facultyId = objDevice.FacultyId;
            object shipmentId = objDevice.ShipmentId;
            object name = objDevice.Name;
            object image = objDevice.Image;
            object qr_code = objDevice.QR_Code;
            object price = objDevice.Price;
            object note = objDevice.Note;
            object description = objDevice.Description;
            object warrantyPeriod = objDevice.WarrantyPeriod;
            object createdDate = objDevice.CreatedDate;
            object createdUserId = objDevice.CreatedUserId;
            object status = objDevice.Status;

            if (String.IsNullOrEmpty(objDevice.Name))
                name = System.DBNull.Value;

            if (String.IsNullOrEmpty(objDevice.QR_Code))
                qr_code = System.DBNull.Value;

            if (String.IsNullOrEmpty(objDevice.Note))
                note = System.DBNull.Value;

            if (String.IsNullOrEmpty(objDevice.Description))
                description = System.DBNull.Value;

            if (objDevice.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objDevice.WarrantyPeriod == null)
                warrantyPeriod = System.DBNull.Value;

            if (objDevice.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objDevice.Status == null)
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
                        command.Parameters.AddWithValue("@id", objDevice.Id);
                    }

                    command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                    command.Parameters.AddWithValue("@brandId", brandId);
                    command.Parameters.AddWithValue("@facultyId", facultyId);
                    command.Parameters.AddWithValue("@shipmentId", shipmentId);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@note", note);
                    command.Parameters.AddWithValue("@qr_code", qr_code);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@warrantyPeriod", warrantyPeriod);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@isDeleted", objDevice.IsDeleted);
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
            string storedProcName = "[dbo].[Device_Hide]";

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
        protected static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (deviceTypeId != null)
                command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
            else
                command.Parameters.AddWithValue("@deviceTypeId", System.DBNull.Value);

            if (brandId != null)
                command.Parameters.AddWithValue("@brandId", brandId);
            else
                command.Parameters.AddWithValue("@brandId", System.DBNull.Value);

            if (brandId != null)
                command.Parameters.AddWithValue("@facultyId", brandId);
            else
                command.Parameters.AddWithValue("@facultyId", System.DBNull.Value);

            //if (shipmentId != null)
            //    command.Parameters.AddWithValue("@shipmentId", shipmentId);
            //else
            //    command.Parameters.AddWithValue("@shipmentId", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (!String.IsNullOrEmpty(image))
                command.Parameters.AddWithValue("@image", image);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);

            if (!String.IsNullOrEmpty(qr_code))
                command.Parameters.AddWithValue("@qr_code", qr_code);
            else
                command.Parameters.AddWithValue("@qr_code", System.DBNull.Value);

            if (price != null)
                command.Parameters.AddWithValue("@price", price);
            else
                command.Parameters.AddWithValue("@price", System.DBNull.Value);

            if (!String.IsNullOrEmpty(note))
                command.Parameters.AddWithValue("@note", note);
            else
                command.Parameters.AddWithValue("@note", System.DBNull.Value);

            if (!String.IsNullOrEmpty(description))
                command.Parameters.AddWithValue("@description", description);
            else
                command.Parameters.AddWithValue("@description", System.DBNull.Value);

            if (warrantyPeriod != null)
                command.Parameters.AddWithValue("@warrantyPeriod", warrantyPeriod);
            else
                command.Parameters.AddWithValue("@warrantyPeriod", System.DBNull.Value);

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
        protected static DeviceModel CreateDeviceFromDataRowShared(DataRow dr)
        {
            DeviceModel objDevice = new DeviceModel();

            objDevice.Id = (int)dr["Id"];
            objDevice.DeviceTypeId = (int)dr["DeviceTypeId"];
            //objDevice.ShipmentId = (int)dr["ShipmentId"];
            objDevice.BrandId = (int)dr["BrandId"];
            //objDevice.FacultyId = (int)dr["FacultyId"];

            if (dr["Name"] != System.DBNull.Value)
                objDevice.Name = dr["Name"].ToString();
            else
                objDevice.Name = null;

            if (dr["BrandId"] != System.DBNull.Value)
                objDevice.BrandId = (int)dr["BrandId"];
            else
                objDevice.BrandId = 1;

            if (dr["FacultyId"] != System.DBNull.Value)
                objDevice.FacultyId = (int)dr["FacultyId"];
            else
                objDevice.FacultyId = 1;

            if (dr["ShipmentId"] != System.DBNull.Value)
                objDevice.ShipmentId = (int)dr["ShipmentId"];
            else
                objDevice.ShipmentId = 1;

            if (dr["QR_Code"] != System.DBNull.Value)
                objDevice.QR_Code = dr["QR_Code"].ToString();
            else
                objDevice.QR_Code = null;

            if (dr["Image"] != System.DBNull.Value)
                objDevice.Image = dr["Image"].ToString();
            else
                objDevice.Image = null;

            if (dr["Note"] != System.DBNull.Value)
                objDevice.Note = dr["Note"].ToString();
            else
                objDevice.Note = null;

            if (dr["Price"] != System.DBNull.Value)
                objDevice.Price = (decimal) dr["Price"];
            else
                objDevice.Price = 0;

            if (dr["Description"] != System.DBNull.Value)
                objDevice.Description = dr["Description"].ToString();
            else
                objDevice.Description = null;

            if (dr["WarrantyPeriod"] != System.DBNull.Value)
                objDevice.WarrantyPeriod = (DateTime)dr["WarrantyPeriod"];
            else
                objDevice.WarrantyPeriod = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objDevice.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDevice.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDevice.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDevice.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDevice.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDevice.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objDevice.Status = (int)dr["Status"];
            else
                objDevice.Status = null;

            return objDevice;
        }
    }
}
