using DAO.DataLayer;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessOjectBase
{
    public class DeviceBusBase : DeviceModel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceModel SelectByPrimaryKey(int id)
        {
            return DeviceDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the Device table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the Device table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceDataLayer.GetRecordCountDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of Device sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Device sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Device sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Device sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of Device
        /// </summary>
        public static List<DeviceModel> SelectAll()
        {
            return DeviceDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of Device sorted by the sort expression
        /// </summary>
        public static List<DeviceModel> SelectAll(string sortExpression)
        {
            List<DeviceModel> objDeviceCol = DeviceDataLayer.SelectAll();
            return objDeviceCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Device.
        /// </summary>
        public static List<DeviceModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceDataLayer.SelectAllDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Device sorted by the sort expression.
        /// </summary>
        public static List<DeviceModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? brandId, int? facultyId, int? shipmentId, string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<DeviceModel> objDeviceCol = DeviceDataLayer.SelectAllDynamicWhere(id, deviceTypeId, brandId, facultyId, shipmentId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
            return objDeviceCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<DeviceModel> SelectDeviceDropDownListData()
        {
            return DeviceDataLayer.SelectSpecsDropDownListData();
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceModel device)
        {
            DeviceModel objDevice = device;
            return DeviceDataLayer.Insert(objDevice);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceModel device)
        {
            DeviceModel objDevice = device;
            DeviceDataLayer.Update(objDevice);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceDataLayer.Delete(id);
        }

        private static string GetSortExpression(string sortByExpression)
        {
            if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                sortByExpression = "Id";
            else if (sortByExpression.Contains(" asc"))
                sortByExpression = sortByExpression.Replace(" asc", "");

            return sortByExpression;
        }

    }
}
