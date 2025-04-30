using Microsoft.Data.SqlClient;
using Ritrama2025.Models;
using System.Data;


namespace Ritrama2025.Services
{
    internal class DespachoService : IDespachoService
    {
        public string StringConnex { get; set; } = null!;
        public string ErrorMsg { get; set; } = null!;
        private readonly List<Despacho> lista = [];
        public DataSet Ds = new();
        public DataTable DtMasterDespachos = new();
        public SqlDataAdapter DaMasterDespachos = new();



        public DespachoService()
        {
            StringConnex = @"Data Source=DATABASE-CENTER\RITRAMASRV01; Initial Catalog=RITRAMA2;User Id=Npino;Password=123;TrustServerCertificate=True;";
        }
        public Despacho GetDespachoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DataSet> LoadDataDespachos()
        {
            try
            {
                using SqlConnection conn = new(StringConnex);
                SqlCommand Comando = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT numero,fecha,customer_id,person_contact,transporte,chofer,camion,vendor_id,packing,orden_trabajo,orden_compra,tipo_venta,subtotal,porc_itbis,itbis,total$rd FROM despacho"
                };
                await conn.OpenAsync();
                SqlDataReader reader = await Comando.ExecuteReaderAsync();
                await reader.CloseAsync();
                DaMasterDespachos.SelectCommand = Comando;
                DaMasterDespachos.Fill(Ds, "DtMasterDespachos");
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message;
                throw;
            }
            return Ds;
        }
    }
}
