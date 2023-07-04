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
    public class LocationDataLayer :LocationDataLayerBase
    {
        
        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of Location.
        /// </summary>
        public static List<LocationModel> GetAllLocationUnUsing(int roomId)
        {
            List<LocationModel> objLocationCol = new List<LocationModel>();
            string storedProcName = "[dbo].[Location_GetAllLocationUnUsing]";

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
                                objLocationCol = new List<LocationModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    LocationModel objLocation = CreateLocationFromDataRowShared(dr);
                                    objLocationCol.Add(objLocation);
                                }
                            }
                        }
                    }
                }
            }

            return objLocationCol;
        }
    }
}
