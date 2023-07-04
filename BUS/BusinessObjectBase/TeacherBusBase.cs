using DAO.DataLayer;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS.BusinessOjectBase
{
    public class TeacherBusBase
    {
        public static List<TeacherModel> GetAllTeachers()
        {
            return TeacherDAO.GetData();
        }
        public static void InsertTeacher(TeacherModel teacher)
        {
            if(!TeacherDAO.IsValidFirstName(teacher.FirstName))
            {
                MessageBox.Show("Họ Không Được Chứa Số và Không Để Trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!TeacherDAO.IsValidLastName(teacher.LastName))
            {
                MessageBox.Show("Tên Không Được Chứa Số và Không Để Trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidBirth(teacher.Birth))
            {
                MessageBox.Show("Ngày Sinh Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidPhone(teacher.Phone))
            {
                MessageBox.Show("Số Điện Thoại Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidEmail(teacher.Email))
            {
                MessageBox.Show("Định Dạng Email Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TeacherDAO.InsertTeacher(teacher);
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void UpdateTeacher(TeacherModel teacher)
        {
            if (!TeacherDAO.IsValidFirstName(teacher.FirstName))
            {
                MessageBox.Show("Họ Không Được Chứa Số và Không Để Trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidLastName(teacher.LastName))
            {
                MessageBox.Show("Tên Không Được Chứa Số và Không Để Trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidBirth(teacher.Birth))
            {
                MessageBox.Show("Ngày Sinh Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidPhone(teacher.Phone))
            {
                MessageBox.Show("Số Điện Thoại Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TeacherDAO.IsValidEmail(teacher.Email))
            {
                MessageBox.Show("Định Dạng Email Không Hợp Lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TeacherDAO.UpdateTeacher(teacher);
                MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static List<TeacherModel> GetTeachersAfterDelete()
        {
            return TeacherDAO.GetTeachersAfterDelete();
        }
        public static void DeleteTeacher(int Id)
        {   
            bool ckeckTeacherId =DecentralizationDAO.CheckTeacherId(Id);
            if (ckeckTeacherId)
            {
                TeacherDAO.DeleteDecentralizationAndTeacher(Id);
            }
            TeacherDAO.DeleteTeacher(Id);
        }

        public static DataTable SearchTeacherByFirstName(string FirstName)
        {
            return TeacherDAO.SearchTeacherByFirstName(FirstName);
        }
        public static DataTable SearchTeacherByLastName(string LastName)
        {
            return TeacherDAO.SearchTeacherByLastName(LastName);
        }
        public static DataTable SearchTeacherByPhone(string Phone)
        {
            return TeacherDAO.SearchTeacherByPhone(Phone);
        }
        public static TeacherModel SelectTeacherById(int Id)
        {
            return TeacherDAO.SelectTeacherById(Id);
        }
    }
}
