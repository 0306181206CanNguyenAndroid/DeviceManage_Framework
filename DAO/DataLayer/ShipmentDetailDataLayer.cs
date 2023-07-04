using DAO.DataLayerBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Model;
using System.Data.SqlClient;
using DAO;
using System.Data;

namespace DAO.DataLayer
{
    public class ShipmentDetailDataLayer : ShipmentDetailDataLayerBase
    {
        public static List<ShipmentDetailModel> SelectDeviceInfoAndCollectByShipmentId(int shipmentId)
        {
            List<ShipmentDetailModel> objShipmentDetailCol = new List<ShipmentDetailModel>();
            string storedProcName = ProcString.procShipmentDetail_SelectDeviceInfoAndCollectByShipmentId;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // select, skip, take, sort parameters
                    command.Parameters.AddWithValue("@id", shipmentId);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ShipmentDetailModel objShipmentDetail = CreateShipmentDetailFromRow(dr);

                                    objShipmentDetailCol.Add(objShipmentDetail);
                                }
                            }
                        }
                    }
                }
            }

            return objShipmentDetailCol;
        }

        private static ShipmentDetailModel CreateShipmentDetailFromRow(DataRow dr)
        {
            ShipmentDetailModel objShipmentDetail = new ShipmentDetailModel();

            if (dr["Id"] != System.DBNull.Value)
                objShipmentDetail.Id = (int)dr["Id"];

            if (dr["DeviceTypeId"] != System.DBNull.Value)
                objShipmentDetail.DeviceTypeId = (int)dr["DeviceTypeId"];
            else
                objShipmentDetail.DeviceTypeId = null;

            if (dr["DeviceName"] != System.DBNull.Value)
                objShipmentDetail.DeviceName = dr["DeviceName"].ToString();
            else
                objShipmentDetail.DeviceName = null;

            if (dr["Info"] != System.DBNull.Value)
                objShipmentDetail.DeviceInfo = dr["Info"].ToString();
            else
                objShipmentDetail.DeviceInfo = null;

            //if (dr["SL"] != System.DBNull.Value)
            //    objShipmentDetail.CountNumber = (int)dr["SL"];
            //else
            //    objShipmentDetail.CountNumber = 0;

            if (dr["Price"] != System.DBNull.Value)
                objShipmentDetail.TotalPrice = dr["Price"].ToString();
            else
                objShipmentDetail.TotalPrice = null;

            return objShipmentDetail;
        }
    }
}
