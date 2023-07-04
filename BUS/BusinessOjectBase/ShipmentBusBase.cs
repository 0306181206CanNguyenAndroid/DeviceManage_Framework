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
    public class ShipmentBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ShipmentBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static ShipmentModel SelectByPrimaryKey(int id)
        {
            return ShipmentDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the Shipment table
        /// </summary>
        public static int GetRecordCount()
        {
            return ShipmentDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the Shipment table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return ShipmentDataLayer.GetRecordCountDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of Shipment sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return ShipmentDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Shipment sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Shipment sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTakeDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDataLayer.SelectSkipAndTakeDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Shipment sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<ShipmentModel> SelectSkipAndTakeDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return ShipmentDataLayer.SelectSkipAndTakeDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of Shipment
        /// </summary>
        public static List<ShipmentModel> SelectAll()
        {
            return ShipmentDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of Shipment sorted by the sort expression
        /// </summary>
        public static List<ShipmentModel> SelectAll(string sortExpression)
        {
            List<ShipmentModel> objShipmentCol = ShipmentDataLayer.SelectAll();
            return objShipmentCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Shipment.
        /// </summary>
        public static List<ShipmentModel> SelectAllDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return ShipmentDataLayer.SelectAllDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Shipment sorted by the sort expression.
        /// </summary>
        public static List<ShipmentModel> SelectAllDynamicWhere(int? id, int? brandId, int? approverId, string name, string invoice, string description, DateTime? importDate, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<ShipmentModel> objShipmentCol = ShipmentDataLayer.SelectAllDynamicWhere(id, brandId, approverId, name, invoice, description, importDate, createdDate, createdUserId, isDeleted, status);
            return objShipmentCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<ShipmentModel> SelectShipmentDropDownListData()
        {
            return ShipmentDataLayer.SelectShipmentDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(ShipmentModel Shipment)
        {
            ShipmentModel objShipment = Shipment;
            return ShipmentDataLayer.Insert(objShipment);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(ShipmentModel Shipment)
        {
            ShipmentModel objShipment = Shipment;
            ShipmentDataLayer.Update(objShipment);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            ShipmentDataLayer.Delete(id);
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

