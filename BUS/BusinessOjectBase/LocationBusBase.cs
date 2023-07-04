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
    public class LocationBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static LocationModel SelectByPrimaryKey(int id)
        {
            return LocationDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the Location table
        /// </summary>
        public static int GetRecordCount()
        {
            return LocationDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the Location table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            return LocationDataLayer.GetRecordCountDynamicWhere(id, name, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records as a collection (List) of Location sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<LocationModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return LocationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Location sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<LocationModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return LocationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Location sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<LocationModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, name, createdDate, createdUserId, isDeleted);
            sortByExpression = GetSortExpression(sortByExpression);
            return LocationDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Location sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<LocationModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return LocationDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of Location
        /// </summary>
        public static List<LocationModel> SelectAll()
        {
            return LocationDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of Location sorted by the sort expression
        /// </summary>
        public static List<LocationModel> SelectAll(string sortExpression)
        {
            List<LocationModel> objLocationCol = LocationDataLayer.SelectAll();
            return objLocationCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Location.
        /// </summary>
        public static List<LocationModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            return LocationDataLayer.SelectAllDynamicWhere(id, name, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Location sorted by the sort expression.
        /// </summary>
        public static List<LocationModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortExpression)
        {
            List<LocationModel> objLocationCol = LocationDataLayer.SelectAllDynamicWhere(id, name, createdDate, createdUserId, isDeleted);
            return objLocationCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<LocationModel> SelectLocationDropDownListData()
        {
            return LocationDataLayer.SelectLocationDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(LocationModel Location)
        {
            LocationModel objLocation = Location;
            return LocationDataLayer.Insert(objLocation);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(LocationModel Location)
        {
            LocationModel objLocation = Location;
            LocationDataLayer.Update(objLocation);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            LocationDataLayer.Delete(id);
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

