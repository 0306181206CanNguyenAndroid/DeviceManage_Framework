using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO.Model
{
    public class DeviceType_SpecsModel : DeviceType_SpecsModelBase
    {
        public string SpecsName { get; set; }
        public string DataType { get; set; }
        public int Ordinal { get; set; }
        public string DeviceTypeName { get; set; }
        public DeviceType_SpecsModel() { }
    }
}
