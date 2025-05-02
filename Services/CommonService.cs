using Microsoft.Data.SqlClient;
using Ritrama2025.Models;
using System.Data;

namespace Ritrama2025.Services
{
    public class CommonService
    {
        public string StringConnex { get; set; } = null!;
        public string ErrorMsg { get; set; } = null!;

        public CommonService()
        {
            StringConnex = @"Data Source=DATABASE-CENTER\RITRAMASRV01; Initial Catalog=RITRAMA2;User Id=Npino;Password=123;TrustServerCertificate=True;";
        }
        public RolloCortado GetDataRolloCortado(string rc) 
        {
            RolloCortado rollo = new();
            try
            {
                using SqlConnection conn = new(StringConnex);
                SqlCommand comando = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT numero, product_id, product_name, roll_number, width, large, msi, splice, roll_id, code_person, status, unique_code, 'M' AS tipo_mov FROM rolls_details WHERE unique_code = @p1 AND disponible = 1 UNION SELECT numero, product_id, product_name, roll_number, width, large, msi, splice, roll_id, code_person, status, unique_code, 'M' AS tipo_mov  FROM RollsInic WHERE unique_code = @p1 AND disponible = 1"
                };
                SqlParameter p1 = new("@p1", rc);
                comando.Parameters.Add(p1);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    rollo = new()
                    {
                        Product_Id = reader.GetString("product_id"),
                        UniqueCode = rc
                    };
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return rollo;
        }
    }
}
