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
            if (Program.Configuration != null) 
            {
                StringConnex = Convert.ToString(Program.Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value)!;
            }
        }

        public void AddPaletDetailsDespacho(List<Paleta> paleta)
        {
            try
            {
                foreach (var item in paleta) 
                {
                    using SqlConnection conn = new(StringConnex);
                    SqlCommand Comando = new()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO paleta (numero,number_palet,medida,contenido,kilo_neto,kilo_bruto) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)"
                    };
                    conn.Open();
                    SqlParameter p1 = new("@p1", item.Numero);
                    SqlParameter p2 = new("@p2", item.Number_Palet);
                    SqlParameter p3 = new("@p3", item.Medida);
                    SqlParameter p4 = new("@p4", item.Contenido);
                    SqlParameter p5 = new("@p5", item.Kilo_Neto);
                    SqlParameter p6 = new("@p6", item.Kilo_Bruto);
                    Comando.Parameters.Add(p1);
                    Comando.Parameters.Add(p2);
                    Comando.Parameters.Add(p3);
                    Comando.Parameters.Add(p4);
                    Comando.Parameters.Add(p5);
                    Comando.Parameters.Add(p6);
                    Comando.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    Comando.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al grabar los items del despacho");
                ErrorMsg = ex.Message;
            }
        }
        public void AddItemsDespacho(List<ItemsDespacho> items) 
        {
            try
            {
                foreach (var item in items) 
                {
                    using SqlConnection conn = new(StringConnex);
                    SqlCommand Comando = new()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO item_despacho (numero,product_id,cant,unid_id,width,lenght,code_person,msi,total_pie_lin,ratio,kilo_rollo,kilo_total,precio,total_renglon,m2) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)"
                    };
                    conn.Open();
                    SqlParameter p1 = new("@p1", item.Numero);
                    SqlParameter p2 = new("@p2", item.Product_id);
                    SqlParameter p3 = new("@p3", item.Cantidad);
                    SqlParameter p4 = new("@p4", item.Unid_id);
                    SqlParameter p5 = new("@p5", item.Width);
                    SqlParameter p6 = new("@p6", item.Lenght);
                    SqlParameter p7 = new("@p7", item.Code_Person);
                    SqlParameter p8 = new("@p8", item.Msi);
                    SqlParameter p9 = new("@p9", item.Total_PieLineal);
                    SqlParameter p10 = new("@p10", item.Ratio);
                    SqlParameter p11 = new("@p11", item.Kilo_Rollo);
                    SqlParameter p12 = new("@p12", item.Kilo_Total);
                    SqlParameter p13 = new("@p13", item.Precio);
                    SqlParameter p14 = new("@p14", item.Total_Renglon);
                    SqlParameter p15 = new("@p15", item.M2);
                    Comando.Parameters.Add(p1);
                    Comando.Parameters.Add(p2);
                    Comando.Parameters.Add(p3);
                    Comando.Parameters.Add(p4);
                    Comando.Parameters.Add(p5);
                    Comando.Parameters.Add(p6);
                    Comando.Parameters.Add(p7);
                    Comando.Parameters.Add(p8);
                    Comando.Parameters.Add(p9);
                    Comando.Parameters.Add(p10);
                    Comando.Parameters.Add(p11);
                    Comando.Parameters.Add(p12);
                    Comando.Parameters.Add(p13);
                    Comando.Parameters.Add(p14);
                    Comando.Parameters.Add(p15);
                    Comando.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    Comando.Dispose();
                }
                MessageBox.Show("La Orden de despacho se guardo correctamente...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al grabar los items del despacho");
                ErrorMsg = ex.Message;
            }
        }
        public void AddPickingListDespacho(List<RolloCortado> rollos)
        {
            try
            {
                foreach (var item in rollos) 
                {
                    using SqlConnection conn = new(StringConnex);
                    SqlCommand Comando = new()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO rcdespacho (conduce,unique_code,product_id,roll_number,width,lenght,msi,splice,roll_id,cant_despacho,tipo,no_paleta) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)"
                    };
                    conn.Open();
                    SqlParameter p1 = new("@p1", item.Numero);
                    SqlParameter p2 = new("@p2", item.UniqueCode);
                    SqlParameter p3 = new("@p3", item.Product_Id);
                    SqlParameter p4 = new("@p4", item.RollNumber);
                    SqlParameter p5 = new("@p5", item.Width);
                    SqlParameter p6 = new("@p6", item.Length);
                    SqlParameter p7 = new("@p7", item.Msi);
                    SqlParameter p8 = new("@p8", item.Splice);
                    SqlParameter p9 = new("@p9", item.Roll_Id);
                    SqlParameter p10 = new("@p10", item.Cantidad_despacho);
                    SqlParameter p11 = new("@p11", item.Tipo);
                    SqlParameter p12 = new("@p12", item.Paleta);
                    Comando.Parameters.Add(p1);
                    Comando.Parameters.Add(p2);
                    Comando.Parameters.Add(p3);
                    Comando.Parameters.Add(p4);
                    Comando.Parameters.Add(p5);
                    Comando.Parameters.Add(p6);
                    Comando.Parameters.Add(p7);
                    Comando.Parameters.Add(p8);
                    Comando.Parameters.Add(p9);
                    Comando.Parameters.Add(p10);
                    Comando.Parameters.Add(p11);
                    Comando.Parameters.Add(p12);
                    Comando.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    Comando.Dispose();
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                MessageBox.Show("error al grabar los rollos cortados...");
            }
        }
        public void AddDocumentDespacho(Despacho document)
        {
            //Grabar el encabezado del despacho.
            try
            {
                using SqlConnection conn = new(StringConnex);
                SqlCommand Comando = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO despacho (numero,fecha,person_contact,vendor_id,packing,orden_trabajo,orden_compra,subtotal,itbis,total$rd,transporte,chofer,camion,customer_id,tipo_venta,transport_id,chofer_id,placas_id,total_cantidad,total_msi,total_pie,total_kilos,porc_itbis,total_kilos_netos_palet,total_kilos_brutos_palet) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25)"
                };
                conn.Open();
                SqlParameter p1 = new("@p1", document.Numero);
                SqlParameter p2 = new("@p2", document.Fecha_despacho);
                SqlParameter p3 = new("@p3", document.Persona_Contact);
                SqlParameter p4 = new("@p4", document.Vendor_Id);
                SqlParameter p5 = new("@p5", document.Tipo_Embalaje);
                SqlParameter p6 = new("@p6", document.Orden_Trabajo);
                SqlParameter p7 = new("@p7", document.Orden_Compra);
                SqlParameter p8 = new("@p8", document.SubTotal);
                SqlParameter p9 = new("@p9", document.Monto_Itbis);
                SqlParameter p10 = new("@p10", document.Total_Despacho);
                SqlParameter p11 = new("@p11", document.Transport_Name);
                SqlParameter p12 = new("@p12", document.Chofer_Name);
                SqlParameter p13 = new("@p13", document.Camion_Name);
                SqlParameter p14 = new("@p14", document.Customer_Id);
                SqlParameter p15 = new("@p15", document.Tipo_venta);
                SqlParameter p16 = new("@p16", document.Transport_Id);
                SqlParameter p17 = new("@p17", document.Chofer_Id);
                SqlParameter p18 = new("@p18", document.Camion_Id);
                SqlParameter p19 = new("@p19", document.Total_Cantidad);
                SqlParameter p20 = new("@p20", document.Total_Msi);
                SqlParameter p21 = new("@p21", document.Total_Pie);
                SqlParameter p22 = new("@p22", document.Total_Kilos);
                SqlParameter p23 = new("@p23", document.Porc_Itbis);
                SqlParameter p24 = new("@p24", document.Total_kilos_netos_palet);
                SqlParameter p25  = new("@p25", document.Total_kilos_brutos_palet);
                Comando.Parameters.Add(p1);
                Comando.Parameters.Add(p2);
                Comando.Parameters.Add(p3);
                Comando.Parameters.Add(p4);
                Comando.Parameters.Add(p5);
                Comando.Parameters.Add(p6);
                Comando.Parameters.Add(p7);
                Comando.Parameters.Add(p8);
                Comando.Parameters.Add(p9);
                Comando.Parameters.Add(p10);
                Comando.Parameters.Add(p11);
                Comando.Parameters.Add(p12);
                Comando.Parameters.Add(p13);
                Comando.Parameters.Add(p14);
                Comando.Parameters.Add(p15);
                Comando.Parameters.Add(p16);
                Comando.Parameters.Add(p17);
                Comando.Parameters.Add(p18);
                Comando.Parameters.Add(p19);
                Comando.Parameters.Add(p20);
                Comando.Parameters.Add(p21);
                Comando.Parameters.Add(p22);
                Comando.Parameters.Add(p23);
                Comando.Parameters.Add(p24);
                Comando.Parameters.Add(p25);
                Comando.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                Comando.Dispose();
             }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el encabezado del despacho...");
                ErrorMsg = ex.Message;
            }
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
                    CommandText = "SELECT ISNULL(MAX(numero)+1,1) as numero FROM despacho"
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
                    CommandText = "SELECT numero,fecha,customer_id,person_contact,transporte,chofer,camion,vendor_id,packing,orden_trabajo,orden_compra,tipo_venta,subtotal,porc_itbis,itbis,total$rd,transport_id,chofer_id,placas_id,total_cantidad,total_msi,total_pie,total_kilos,subtotal,total_kilos_netos_palet,total_kilos_brutos_palet FROM despacho"
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
                DataRelation Despacho_DetalleRC = new("FK_DESPACHOS_DETALLERC", ParentCol2, ChildCol2,false);
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
