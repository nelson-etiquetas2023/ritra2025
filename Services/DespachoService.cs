using Microsoft.Data.SqlClient;
using Ritrama2025.Models;
using System.Data;

namespace Ritrama2025.Services
{
    public class DespachoService : IDespachoService
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
        public DataTable DtDetalleRC = new();
        public SqlDataAdapter DaDetalleRC = new();
        public DataTable DtItems = new();
        public SqlDataAdapter DaItems = new();
        public DataTable DtPalet = new();
        public SqlDataAdapter DaPalet = new();
        public DataTable DtTransport = new();
        public SqlDataAdapter DaTransport = new();
        public DataTable DtChofer = new();
        public SqlDataAdapter DaChofer = new();
        public DataTable DtCamion = new();
        public SqlDataAdapter DaCamion = new();



        public DespachoService()
        {
            StringConnex = @"Data Source=DATABASE-CENTER\RITRAMASRV01; Initial Catalog=RITRAMA2;User Id=Npino;Password=123;TrustServerCertificate=True;";
        }

        public string GetNumberConsec() 
        {
            string consec = string.Empty;
            try
            {
                using SqlConnection conn = new(StringConnex);
                SqlCommand Comando = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT MAX(numero)+1 as numero FROM despacho"
                };
                conn.OpenAsync();
                consec = Convert.ToString(Comando.ExecuteScalar())!;
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return consec;
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
                    CommandText = "SELECT numero,fecha,customer_id,person_contact,transporte,chofer,camion,vendor_id,packing,orden_trabajo,orden_compra,tipo_venta,subtotal,porc_itbis,itbis,total$rd,transport_id FROM despacho"
                };
                await conn.OpenAsync();
                SqlDataReader readerMaster = await ComandoMaster.ExecuteReaderAsync();
                await readerMaster.CloseAsync();
                DaMasterDespachos.SelectCommand = ComandoMaster;
                DaMasterDespachos.Fill(Ds, "DtMasterDespachos");
                //2.- Carga de Clientes.
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
                //3.- Carga de Vendedores
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
                //4.- Carga de Detalle de Rollo Cortado
                SqlCommand ComandoRC = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT conduce,unique_code,a.product_id,b.product_Name,roll_number,width,lenght,msi,splice,cant_despacho,tipo,no_paleta,roll_id FROM rcdespacho a LEFT JOIN producto b on a.product_id=b.product_ID"
                };
                SqlDataReader readerRC = await ComandoRC.ExecuteReaderAsync();
                await readerRC.CloseAsync();
                DaDetalleRC.SelectCommand = ComandoRC;
                DaDetalleRC.Fill(Ds, "DtDetalleRC");
                //5.- Carga de Reglones del Despacho.
                SqlCommand ComandoItems = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT numero,a.product_id,cant,b.product_name,unid_id, width,lenght,msi,total_pie_lin,a.ratio,kilo_rollo,kilo_total,a.precio,total_renglon,code_person,m2 FROM item_despacho a LEFT JOIN producto b ON a.product_id=b.product_id "
                };
                SqlDataReader readerItems = await ComandoItems.ExecuteReaderAsync();
                await readerItems.CloseAsync();
                DaItems.SelectCommand = ComandoItems;
                DaItems.Fill(Ds, "DtItems");
                //6.- Carga de Detalle de Paleta.
                SqlCommand ComandoPalet = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT numero,number_palet,medida,contenido,kilo_neto,kilo_bruto FROM paleta"
                };
                SqlDataReader readerPalet = await ComandoPalet.ExecuteReaderAsync();
                await readerPalet.CloseAsync();
                DaPalet.SelectCommand = ComandoPalet;
                DaPalet.Fill(Ds, "DtPalet");
                //7.- Carga de la tabla de transportista
                SqlCommand ComandoTransport = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT transport_id,transport_name FROM transporte"
                };
                SqlDataReader readerTranspor = await ComandoTransport.ExecuteReaderAsync();
                await readerTranspor.CloseAsync();
                DaTransport.SelectCommand = ComandoTransport;
                DaTransport.Fill(Ds, "DtTransport");
                //7.- Carga de la tabla de chofer.
                SqlCommand ComandoChofer = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT chofer_id,chofer_name FROM chofer"
                };
                SqlDataReader readerChofer = await ComandoChofer.ExecuteReaderAsync();
                await readerChofer.CloseAsync();
                DaChofer.SelectCommand = ComandoChofer;
                DaChofer.Fill(Ds, "DtChofer");
                //8.- Carga de la tabla de Camion.
                SqlCommand ComandoCamion = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT placas_id,camion_name FROM camion"
                };
                SqlDataReader readerCamion = await ComandoCamion.ExecuteReaderAsync();
                await readerCamion.CloseAsync();
                DaCamion.SelectCommand = ComandoCamion;
                DaCamion.Fill(Ds, "DtCamion");


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
                //Relacion entre master y Detalle RC
                DataColumn ParentCol2 = Ds.Tables["DtMasterDespachos"]!.Columns["numero"]!;
                DataColumn ChildCol2 = Ds.Tables["DtDetalleRC"]!.Columns["conduce"]!;
                DataRelation Despacho_DetalleRC = new("FK_DESPACHOS_DETALLERC", ParentCol2, ChildCol2);
                Ds.Relations.Add(Despacho_DetalleRC);
                //Relacion entre master y Renglones de Despacho.
                DataColumn ParentCol3 = Ds.Tables["DtMasterDespachos"]!.Columns["numero"]!;
                DataColumn ChildCol3 = Ds.Tables["DtItems"]!.Columns["numero"]!;
                DataRelation Despacho_Items = new("FK_DESPACHOS_ITEMS",
                    ParentCol3, ChildCol3);
                Ds.Relations.Add(Despacho_Items);
                //Relacion entre master y detalle de palet.
                DataColumn ParentCol4 = Ds.Tables["DtMasterDespachos"]!.Columns["numero"]!;
                DataColumn ChildCol4 = Ds.Tables["DtPalet"]!.Columns["numero"]!;
                DataRelation Despacho_Palet = new("FK_DESPACHOS_PALET",
                   ParentCol4, ChildCol4);
                Ds.Relations.Add(Despacho_Palet);
                // Relacion entre Despachos y transportista
                DataColumn ParentCol5 = Ds.Tables["DtTransport"]!.Columns["transport_id"]!;
                DataColumn ChildCol5 = Ds.Tables["DtMasterDespachos"]!.Columns["transport_id"]!;
                DataRelation Despacho_Transport = new("FK_DESPACHOS_TRANSPORT", ParentCol5, ChildCol5);
                Ds.Relations.Add(Despacho_Transport);
                Ds.Tables["DtMasterDespachos"]!.Columns.Add("transport_name", Type.GetType("System.String")!, "parent(FK_DESPACHOS_TRANSPORT).transport_name");


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al tratar de establecer las relaciones entre tablas. Error Code:" + ex);
                return false;
            }

            
        }

        public decimal GetRatioProductById(string product_id)
        {
            decimal ratio = 0;
            try
            {
                using SqlConnection conn = new(StringConnex);
                SqlCommand Comando = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT ratio FROM producto WHERE product_id = @p1"
                };
                SqlParameter p1 = new("@p1", product_id);
                Comando.Parameters.Add(p1);
                conn.Open();
                ratio = Convert.ToDecimal(Comando.ExecuteScalar())!;
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return ratio;
        }
    }
}
