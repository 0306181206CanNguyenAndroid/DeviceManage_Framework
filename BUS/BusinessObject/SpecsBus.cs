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
    public class SpecsBus : SpecsBusBase
    {
        public static List<SpecsModel> SelectAllSpecs_By_DeviceTypeId(int deviceTypeId, bool? isDeleted)
        {

            List<SpecsModel> listSpecs = SpecsDataLayer.SelectAllSpecs_By_DeviceTypeId(deviceTypeId, isDeleted);
            if (listSpecs == null)
                return new List<SpecsModel>();
            else
                return listSpecs;
        }
    }
}
