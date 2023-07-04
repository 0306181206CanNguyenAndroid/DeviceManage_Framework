using BUS.BusinessOjectBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DAO.DataLayer;

namespace BUS.BusinessObject
{
    public class LocationBus : LocationBusBase
    {
         public static List<LocationModel> GetAllLocationUnUsing(int roomId)
        {
            return LocationDataLayer.GetAllLocationUnUsing(roomId);
        }
    }
}
