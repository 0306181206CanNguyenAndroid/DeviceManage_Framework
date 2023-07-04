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
    public class DeviceErrorBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceErrorBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceErrorModel SelectByPrimaryKey(int id)
        {
            return DeviceErrorDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the DeviceError table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceErrorDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the DeviceError table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceErrorDataLayer.GetRecordCountDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceError sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceErrorDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceError sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceErrorDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceError sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceErrorDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceError sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceErrorModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceErrorDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceError
        /// </summary>
        public static List<DeviceErrorModel> SelectAll()
        {
            return DeviceErrorDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceError sorted by the sort expression
        /// </summary>
        public static List<DeviceErrorModel> SelectAll(string sortExpression)
        {
            List<DeviceErrorModel> objDeviceErrorCol = DeviceErrorDataLayer.SelectAll();
            return objDeviceErrorCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceError.
        /// </summary>
        public static List<DeviceErrorModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceErrorDataLayer.SelectAllDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceError sorted by the sort expression.
        /// </summary>
        public static List<DeviceErrorModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, string errorCode, string solution, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<DeviceErrorModel> objDeviceErrorCol = DeviceErrorDataLayer.SelectAllDynamicWhere(id, deviceTypeId, errorCode, solution, description, createdDate, createdUserId, isDeleted, status);
            return objDeviceErrorCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<DeviceErrorModel> SelectDeviceErrorDropDownListData()
        {
            return DeviceErrorDataLayer.SelectDeviceErrorDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceErrorModel DeviceError)
        {
            DeviceErrorModel objDeviceError = DeviceError;
            return DeviceErrorDataLayer.Insert(objDeviceError);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceErrorModel DeviceError)
        {
            DeviceErrorModel objDeviceError = DeviceError;
            DeviceErrorDataLayer.Update(objDeviceError);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceErrorDataLayer.Delete(id);
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

