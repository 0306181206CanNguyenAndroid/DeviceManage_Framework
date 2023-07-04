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
    public class DeviceDataLayer : DeviceDataLayerBase
    {

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Specs.
        /// </summary> [dbo].[Device_GetAllDeviceInRoom](@roomId int)
        public static List<DeviceModel> GetAllDeviceUnUsing(int quantity)
        {
            List<DeviceModel> objDeviceCol = new List<DeviceModel>();
            string storedProcName = "[dbo].[Device_GetAllDeviceUnUsing]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    command.Parameters.AddWithValue("@quantity", quantity);
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
                                    DeviceModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }

        public static List<DeviceModel> GetAllDeviceInRoom(int roomId)
        {
            List<DeviceModel> objDeviceCol = new List<DeviceModel>();
            string storedProcName = "[Device_GetAllDeviceInRoom]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    command.Parameters.AddWithValue("@roomId", roomId);
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
                                    DeviceModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objDevice.LocationId = (int)dr["LocationId"];
                                    objDeviceCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objDeviceCol;
        }
    }
}
