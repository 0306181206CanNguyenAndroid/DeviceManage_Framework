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
    public class UserBusBase
    {
        UserDataLayer ktkq = new UserDataLayer();
        public UserBusBase() { }

        public static List<UserModel> SelectAll()
        {
            return UserDataLayer.SelectAll();
        }

        public static UserModel SelectByPrimaryKey(int Id)
        {
            return UserDataLayer.SelectByPrimaryKey(Id);
        }

        public static List<UserModel> SelectAllDynamicWhere(int? Id, string username, string name, string image, bool? isdeleted, int? status, int? accessrightsgroup, DateTime? createddate, DateTime? modifieddate, int? createduserid, int? modifieduserid, string sort)
        {
            return UserDataLayer.SelectAllDynamicWhere(Id, username, name, image, isdeleted, status, accessrightsgroup, createddate, modifieddate, createduserid, modifieduserid, sort);
        }

        public static UserModel SelectWithUserAndPass(string UserName, string pass)
        {
            return UserDataLayer.SelectWithUserAndPass(UserName, pass);
        }

        public string CheckLogin(UserModel taikhoan)
        {
            if (taikhoan.UserName == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.Pass == "")
            {
                return "requeid_pass";
            }
            string info = ktkq.CheckLogin(taikhoan);
            return info;
        }

        public static void InsertUser(UserModel user)
        {
            if (UserDataLayer.CheckUserName(user.UserName))
            {
                throw new Exception("Tên Tài Khoản Đã Tồn Tại");
            }
            else if(UserDataLayer.CheckName(user.Name)) 
            { 
                throw new Exception("Tên Hiển Thị Đã Tồn Tại");
            }
            else
            {
                UserDataLayer.InsertUser(user);
            } 
        }
        
    }
}
