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
    public class DeviceDetailBusBase : DeviceDetailModel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceDetailBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceDetailModel SelectByPrimaryKey(int id)
        {
            return DeviceDetailDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the DeviceDetail table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceDetailDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the DeviceDetail table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceDetailDataLayer.GetRecordCountDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceDetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceDetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceDetail sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceDetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDetailDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of DeviceDetail sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDetailDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceDetail
        /// </summary>
        public static List<DeviceDetailModel> SelectAll()
        {
            return DeviceDetailDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of DeviceDetail sorted by the sort expression
        /// </summary>
        public static List<DeviceDetailModel> SelectAll(string sortExpression)
        {
            List<DeviceDetailModel> objDeviceDetailCol = DeviceDetailDataLayer.SelectAll();
            return objDeviceDetailCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceDetail.
        /// </summary>
        public static List<DeviceDetailModel> SelectAllDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List < DeviceDetailModel> list = DeviceDetailDataLayer.SelectAllDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);

            return list == null ? new List<DeviceDetailModel>() : list;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of DeviceDetail sorted by the sort expression.
        /// </summary>
        public static List<DeviceDetailModel> SelectAllDynamicWhere(int? id, int? deviceId, int? deviceTypeSpecsId, int? brandId, string nameSpecs, decimal? values,  string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<DeviceDetailModel> objDeviceDetailCol = DeviceDetailDataLayer.SelectAllDynamicWhere(id, deviceId, deviceTypeSpecsId, brandId, nameSpecs, values, description, createdDate, createdUserId, isDeleted, status);
            return objDeviceDetailCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<DeviceDetailModel> SelectDeviceDetailDropDownListData()
        {
            return DeviceDetailDataLayer.SelectSpecsDropDownListData();
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceDetailModel deviceDetail)
        {
            DeviceDetailModel objDeviceDetail = deviceDetail;
            return DeviceDetailDataLayer.Insert(objDeviceDetail);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceDetailModel deviceDetail)
        {
            DeviceDetailModel objDeviceDetail = deviceDetail;
            DeviceDetailDataLayer.Update(objDeviceDetail);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceDetailDataLayer.Delete(id);
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
