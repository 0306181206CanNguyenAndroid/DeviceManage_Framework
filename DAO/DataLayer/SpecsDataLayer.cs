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
    public class SpecsDataLayer : SpecsDataLayerBase
    {
        public static List<SpecsModel> SelectAllSpecs_By_DeviceTypeId(int deviceTypeId, bool? isDeleted)
        {
            List<SpecsModel> objSpecsCol = null;
            string storedProcName = "[dbo].[Specs_SelectAllSpecs_By_DeviceTypeId]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                    if (isDeleted != null)
                    {
                        command.Parameters.AddWithValue("@isDeleted", isDeleted);
                    }
                    else
                        command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objSpecsCol = new List<SpecsModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    SpecsModel objSpecs = CreateSpecsFromDataRowShared(dr);
                                    objSpecsCol.Add(objSpecs);
                                }
                            }
                        }
                    }
                }
            }

            return objSpecsCol;
        }
    }
}
