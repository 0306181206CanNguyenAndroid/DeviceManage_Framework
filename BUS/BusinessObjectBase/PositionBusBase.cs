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
   public class PositionBusBase
    {
        public static DataTable GetAllPosition()
        {
            return PositionDao.getData();
        }
        public static void InsertPosition(PositionModel position)
        {
            if(PositionDao.CheckNamePosition(position.Name))
            {
                throw new Exception("Tên Chức Vụ Đã Tồn Tại");
            }
            else
            {
                PositionDao.InsertPosition(position);
            }
        }
        public static void UpdatePosition(PositionModel positionModel)
        {
            if (PositionDao.IsDuplicatePosition(positionModel,positionModel.Id))
            {
                throw new Exception("Tên Chức Vụ Đã Tồn Tại");
            }
            PositionDao.UpdatePosition(positionModel);
        }
        public static DataTable GetPositonAfterDelete()
        {
            return PositionDao.GetPositionAfterDelete();
        }
        public static void DeletePosition(int Id)
        {
            PositionDao.DeletePosition(Id);
        }
        public static DataTable SearchPositionByName(string Name)
        {
            return PositionDao.SearchPositionByName(Name);
        }
    }
}
