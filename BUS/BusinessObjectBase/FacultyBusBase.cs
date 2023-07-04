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
    public class FacultyBusBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FacultyBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static FacultyModel SelectByPrimaryKey(int id)
        {
            return FacultyDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the Faculty table
        /// </summary>
        public static int GetRecordCount()
        {
            return FacultyDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the Faculty table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            return FacultyDataLayer.GetRecordCountDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records as a collection (List) of Faculty sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return FacultyDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Faculty sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return FacultyDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Faculty sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted);
            sortByExpression = GetSortExpression(sortByExpression);
            return FacultyDataLayer.SelectSkipAndTakeDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of Faculty sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<FacultyModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return FacultyDataLayer.SelectSkipAndTakeDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of Faculty
        /// </summary>
        public static List<FacultyModel> SelectAll()
        {
            return FacultyDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of Faculty sorted by the sort expression
        /// </summary>
        public static List<FacultyModel> SelectAll(string sortExpression)
        {
            List<FacultyModel> objFacultyCol = FacultyDataLayer.SelectAll();
            return objFacultyCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Faculty.
        /// </summary>
        public static List<FacultyModel> SelectAllDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted)
        {
            return FacultyDataLayer.SelectAllDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Faculty sorted by the sort expression.
        /// </summary>
        public static List<FacultyModel> SelectAllDynamicWhere(int? id, string name, string image, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortExpression)
        {
            List<FacultyModel> objFacultyCol = FacultyDataLayer.SelectAllDynamicWhere(id, name, image, description, createdDate, createdUserId, isDeleted);
            return objFacultyCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<FacultyModel> SelectFacultyDropDownListData()
        {
            return FacultyDataLayer.SelectFacultyDropDownListData();
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(FacultyModel Faculty)
        {
            FacultyModel objFaculty = Faculty;
            return FacultyDataLayer.Insert(objFaculty);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(FacultyModel Faculty)
        {
            FacultyModel objFaculty = Faculty;
            FacultyDataLayer.Update(objFaculty);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            FacultyDataLayer.Delete(id);
        }

        private static string GetSortExpression(string sortByExpression)
        {
            if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                sortByExpression = "Id";
            else if (sortByExpression.Contains(" asc"))
                sortByExpression = sortByExpression.Replace(" asc", "");

            return sortByExpression;
        }

        public static List<FacultyModel> GetAllFaculty()
        {
            return FacultyDAO.getData();
        }
        public static void InsertFaculty(FacultyModel faculty)
        {
            if (FacultyDAO.CheckNameFaculty(faculty.Name))
            {
                throw new Exception("Tên Khoa Đã Tồn Tại");
            }
            else
            {
                FacultyDAO.InsertFaculty(faculty);
            }
        }
        public static void UpdateFaculty(FacultyModel facultyModel)
        {
            if (FacultyDAO.IsDuplicateFaculty(facultyModel, facultyModel.Id))
            {
                throw new Exception("Tên Khoa Đã Tồn Tại");
            }
            FacultyDAO.UpdateFaculty(facultyModel);
        }

        public static List<FacultyModel> GetFacultyAfterDelete()
        {
            return FacultyDAO.GetFacultyAfterDelete();
        }
        public static void DeleteFaculty(int Id)
        {
            FacultyDAO.DeleteFaculty(Id);
        }
        public static DataTable SearchFacultyByName(string Name)
        {
            return FacultyDAO.SearchFacultyByName(Name);
        }
    }
}

