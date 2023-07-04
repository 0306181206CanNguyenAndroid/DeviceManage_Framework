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
    public class ShipmentDetailBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ShipmentDetailBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static ShipmentDetailModel SelectByPrimaryKey(int id)
        {
            return ShipmentDetailDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the ShipmentDetail table
        /// </summary>
        public static int GetRecordCount()
        {
            return ShipmentDetailDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the ShipmentDetail table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status)
        {
            return ShipmentDetailDataLayer.GetRecordCountDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of ShipmentDetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return ShipmentDetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of ShipmentDetail sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of ShipmentDetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDetailDataLayer.SelectSkipAndTakeDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of ShipmentDetail sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<ShipmentDetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDetailDataLayer.SelectSkipAndTakeDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of ShipmentDetail
        /// </summary>
        public static List<ShipmentDetailModel> SelectAll()
        {
            return ShipmentDetailDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of ShipmentDetail sorted by the sort expression
        /// </summary>
        public static List<ShipmentDetailModel> SelectAll(string sortExpression)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = ShipmentDetailDataLayer.SelectAll();
            return objShipmentDetailCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of ShipmentDetail.
        /// </summary>
        public static List<ShipmentDetailModel> SelectAllDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status)
        {
            return ShipmentDetailDataLayer.SelectAllDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of ShipmentDetail sorted by the sort expression.
        /// </summary>
        public static List<ShipmentDetailModel> SelectAllDynamicWhere(int? id, int? shipmentId, int? deviceId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string code, int? status, string sortExpression)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = ShipmentDetailDataLayer.SelectAllDynamicWhere(id, shipmentId, deviceId, description, createdDate, createdUserId, isDeleted, code, status);
            return objShipmentDetailCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<ShipmentDetailModel> SelectShipmentDetailDropDownListData()
        {
            return ShipmentDetailDataLayer.SelectShipmentDetailDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(ShipmentDetailModel ShipmentDetail)
        {
            ShipmentDetailModel objShipmentDetail = ShipmentDetail;
            return ShipmentDetailDataLayer.Insert(objShipmentDetail);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(ShipmentDetailModel ShipmentDetail)
        {
            ShipmentDetailModel objShipmentDetail = ShipmentDetail;
            ShipmentDetailDataLayer.Update(objShipmentDetail);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            ShipmentDetailDataLayer.Delete(id);
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

