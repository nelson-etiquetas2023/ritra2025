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
            if (Program.Configuration != null)
            {
                StringConnex = Convert.ToString(Program.Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value)!;
            }
        }
        public async Task<List<RolloCortado>> GetDataRolloCortado(List<RolloCortado> lista)
        {
            // recorrer la lista para llenarla.
            foreach (var item in lista)
            {
                try
                {
                    using SqlConnection conn = new(StringConnex);
                    SqlCommand comando = new()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "SELECT numero, product_id, product_name, roll_number, width, large, msi, splice, roll_id, code_person, status, unique_code, 'M' AS tipo_mov FROM rolls_details WHERE unique_code = @p1 AND disponible = 1 UNION SELECT numero, product_id, product_name, roll_number, width, large, msi, splice, roll_id, code_person, status, unique_code, 'M' AS tipo_mov  FROM RollsInic WHERE unique_code = @p1 AND disponible = 1"
                    };
                    SqlParameter p1 = new("@p1", item.UniqueCode);
                    comando.Parameters.Add(p1);
                    await conn.OpenAsync();
                    SqlDataReader reader = await comando.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        item.Product_Id = reader.GetString("product_id");
                        item.Product_Name = reader.GetString("product_name");
                        item.RollNumber = reader.GetInt32("roll_number");
                        item.Width = reader.GetDecimal("width");
                        item.Length = reader.GetDecimal("large");
                        item.Msi = reader.GetDecimal("msi");
                        item.Splice = reader.GetInt32("splice");
                        item.Roll_Id = reader.GetString("roll_id");
                        item.Cantidad_despacho = 0;
                        item.Cantidad = 0;
                        item.Tipo = reader.GetString("tipo_mov");
                        item.Code_Person = reader.GetString("code_person");
                        
                    }
                }
                catch (SqlException ex)
                {
                    ErrorMsg = ex.Message;
                    MessageBox.Show("error al cargar los datos del rc en el picking: "+ErrorMsg); 
                }
            }
            return lista;
        }   
    }
}
