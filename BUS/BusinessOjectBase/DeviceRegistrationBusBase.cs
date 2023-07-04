using DAO.DataLayer;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using DTO.Model;
using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerApp.BUS.BusinessOjectBase
{
    public class DeviceRegistrationBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceRegistrationBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceRegistrationModel SelectByPrimaryKey(int id)
        {
            return DeviceRegistrationDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the DeviceRegistration table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceRegistrationDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the DeviceRegistration table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceRegistrationDataLayer.GetRecordCountDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceRegistration sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceRegistrationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceRegistration sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceRegistrationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceRegistration sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceRegistrationDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceRegistration sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceRegistrationModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceRegistrationDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceRegistration
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAll()
        {
            return DeviceRegistrationDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceRegistration sorted by the sort expression
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAll(string sortExpression)
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = DeviceRegistrationDataLayer.SelectAll();
            return objDeviceRegistrationCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceRegistration.
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAllDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceRegistrationDataLayer.SelectAllDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceRegistration sorted by the sort expression.
        /// </summary>
        public static List<DeviceRegistrationModel> SelectAllDynamicWhere(int? id, int? deviceId, int? roomId, int? locationId, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<DeviceRegistrationModel> objDeviceRegistrationCol = DeviceRegistrationDataLayer.SelectAllDynamicWhere(id, deviceId, roomId, locationId, createdDate, createdUserId, isDeleted, status);
            return objDeviceRegistrationCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<DeviceRegistrationModel> SelectDeviceRegistrationDropDownListData()
        {
            return DeviceRegistrationDataLayer.SelectDeviceRegistrationDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceRegistrationModel DeviceRegistration)
        {
            DeviceRegistrationModel objDeviceRegistration = DeviceRegistration;
            return DeviceRegistrationDataLayer.Insert(objDeviceRegistration);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceRegistrationModel DeviceRegistration)
        {
            DeviceRegistrationModel objDeviceRegistration = DeviceRegistration;
            DeviceRegistrationDataLayer.Update(objDeviceRegistration);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceRegistrationDataLayer.Delete(id);
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

