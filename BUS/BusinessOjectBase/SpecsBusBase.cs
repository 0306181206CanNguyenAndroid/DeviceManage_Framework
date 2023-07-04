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
    public class SpecsBusBase : SpecsModel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public SpecsBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static SpecsModel SelectByPrimaryKey(int id)
        {
            return SpecsDataLayer.SelectByPrimaryKey(id);
        }

       
        /// <summary>
        /// Gets the total number of records in the Specs table
        /// </summary>
        public static int GetRecordCount()
        {
            return SpecsDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the Specs table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return SpecsDataLayer.GetRecordCountDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of Specs sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return SpecsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Specs sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return SpecsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Specs sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status) ;
            sortByExpression = GetSortExpression(sortByExpression);
            return SpecsDataLayer.SelectSkipAndTakeDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Specs sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return SpecsDataLayer.SelectSkipAndTakeDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of Specs
        /// </summary>
        public static List<SpecsModel> SelectAll()
        {
            return SpecsDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of Specs sorted by the sort expression
        /// </summary>
        public static List<SpecsModel> SelectAll(string sortExpression)
        {
            List<SpecsModel> objSpecsCol = SpecsDataLayer.SelectAll();
            return objSpecsCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs.
        /// </summary>
        public static List<SpecsModel> SelectAllDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return SpecsDataLayer.SelectAllDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs sorted by the sort expression.
        /// </summary>
        public static List<SpecsModel> SelectAllDynamicWhere(int? id, string name, string datatype, int? ordinal, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<SpecsModel> objSpecsCol = SpecsDataLayer.SelectAllDynamicWhere(id, name, datatype, ordinal, description, createdDate, createdUserId, isDeleted, status);
            return objSpecsCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<SpecsModel> SelectSpecsDropDownListData()
        {
            return SpecsDataLayer.SelectSpecsDropDownListData();
        }

        
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(SpecsModel specs)
        {
            SpecsModel objSpecs = specs;
            return SpecsDataLayer.Insert(objSpecs);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(SpecsModel specs)
        {
            SpecsModel objSpecs = specs;
            SpecsDataLayer.Update(objSpecs);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            SpecsDataLayer.Delete(id);
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
