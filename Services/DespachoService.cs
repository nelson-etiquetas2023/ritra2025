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
        public DataTable DtClientes = new();
        public SqlDataAdapter DaClientes = new();
        public DataTable DtVendors = new();
        public SqlDataAdapter DaVendors = new();


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
                //1.- Carga del Encabezado de Despacho
                SqlCommand ComandoMaster = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT numero,fecha,customer_id,person_contact,transporte,chofer,camion,vendor_id,packing,orden_trabajo,orden_compra,tipo_venta,subtotal,porc_itbis,itbis,total$rd FROM despacho"
                };
                await conn.OpenAsync();
                SqlDataReader readerMaster = await ComandoMaster.ExecuteReaderAsync();
                await readerMaster.CloseAsync();
                DaMasterDespachos.SelectCommand = ComandoMaster;
                DaMasterDespachos.Fill(Ds, "DtMasterDespachos");
                //1.- Carga de Clientes.
                SqlCommand ComandoClientes = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT customer_id,customer_name FROM customer"
                };

                SqlDataReader readerCliente = await  ComandoClientes.ExecuteReaderAsync();
                await readerCliente.CloseAsync();
                DaClientes.SelectCommand = ComandoClientes;
                DaClientes.Fill(Ds, "DtClientes");
                //2.- Carga de Vendedores
                SqlCommand ComandoVendor = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT vendor_id,vendor_name FROM vendedor"
                };
                SqlDataReader readerVendor = await ComandoVendor.ExecuteReaderAsync();
                await readerVendor.CloseAsync();
                DaVendors.SelectCommand = ComandoVendor;
                DaVendors.Fill(Ds, "DtVendors");

                RelationDataset();
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message;
                throw;
            }
            return Ds;
        }


        public Boolean RelationDataset() 
        {
            try
            {
                //Relacion entre master y clientes
                DataColumn ParentCol0 = Ds.Tables["DtClientes"]!.Columns["customer_id"]!;
                DataColumn ChildCol0 = Ds.Tables["DtMasterDespachos"]!.Columns["customer_id"]!;
                DataRelation Despacho_Clientes = new("FK_DESPACHOS_CLIENTES", ParentCol0, ChildCol0);
                Ds.Relations.Add(Despacho_Clientes);
                Ds.Tables["DtMasterDespachos"]!.Columns.Add("customer_name", Type.GetType("System.String")!, "parent(FK_DESPACHOS_CLIENTES).customer_name");
                //Relacion entre master y vendedores
                DataColumn ParentCol1 = Ds.Tables["DtVendors"]!.Columns["vendor_id"]!;
                DataColumn ChildCol1 = Ds.Tables["DtMasterDespachos"]!.Columns["vendor_id"]!;
                DataRelation Despacho_Vendors = new("FK_DESPACHOS_VENDOR", ParentCol1, ChildCol1);
                Ds.Relations.Add(Despacho_Vendors);
                Ds.Tables["DtMasterDespachos"]!.Columns.Add("vendor_name", Type.GetType("System.String")!, "parent(FK_DESPACHOS_VENDOR).vendor_name");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al tratar de establecer las relaciones entre tablas. Error Code:" + ex);
                return false;
            }

            
        }
    }
}
