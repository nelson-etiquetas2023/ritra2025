using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Ritrama2025.Forms.Otros;
using System.Data;


namespace Ritrama2025.Services
{
    public class ReportsService : IReportsService
    {
        public string StringConnex { get; set; } = "";
        public string MessageError { get; set; } = "";

        public ReportsService()
        {
            StringConnex = @"Data Source=DATABASE-CENTER\RITRAMASRV01; Initial Catalog=RITRAMA2;User Id=Npino;Password=123;TrustServerCertificate=True;";
        }

        public void ReporteConduce_conPrecio(string conduce, Form form)
        {
            DataSet ds = new();
            using (SqlConnection conn = new(StringConnex))
            {
                SqlCommand comando = new()
                {
                    Connection = conn,
                    CommandText = "select a.numero,a.fecha,a.customer_id,b.Customer_Name,a.person_contact,a.vendor_id,c.vendor_name,a.packing," +
                      "a.orden_trabajo,a.orden_compra,a.subtotal,a.porc_itbis,a.itbis,a.total$rd as " + "TotalMontoDoc,a.transport_id,a.transporte,a.chofer_id,a.chofer,a.placas_id,a.camion,a.tipo_venta," + "a.reserva,a.impuesto,a.status,a.total_cantidad,a.total_msi,a.total_pie,a.total_kilos,a.total_kilos_netos_palet,a.total_kilos_brutos_palet,d.product_id,e.Product_Name,e.Product_Descrip,e.ratio,e.precio," + "d.cant,d.unid_id,f.UNID_NAME,d.width,d.lenght,d.msi,d.total_pie_lin,d.ratio,d.kilo_rollo,d.kilo_total," +
                      "d.precio,d.total_renglon,d.code_person,d.m2 from despacho a left join Customer b on " + "a.customer_id=b.Customer_ID left join vendedor c on a.vendor_id=c.vendor_id left join item_despacho d on a.numero = d.numero left join producto e on d.product_id = e.Product_ID left join unidad f on f.UNID_ID = d.unid_id where a.numero='9'",
                    CommandType = CommandType.Text
                };
                SqlParameter p1 = new("@p1", SqlDbType.VarChar)
                {
                    Value = conduce
                };
                comando.Parameters.Add(p1);
                conn.Open();
                SqlDataAdapter da = new(comando);
                da.Fill(ds, "dt");
            }

            ReportsViewer reports = new()
            {
                Text = "Reporte Conduce con Precio",
                Width = 1130,
                Height = 780,
                MdiParent = form.MdiParent,
            };
            reports.reportViewer1.ProcessingMode = ProcessingMode.Local;
            reports.reportViewer1.LocalReport.ReportPath = @"c:\programacion\ritrama2025\Reports\RptConduceConPrecio.rdlc";
            reports.reportViewer1.LocalReport.DataSources.Clear();
            reports.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dt"]));

            reports.reportViewer1.RefreshReport();
            reports.Show();
        }
        public void ReporteCondece_sinPrecio()
        {
            throw new NotImplementedException();
        }
        public void Reporte_DetallePaleta()
        {
            throw new NotImplementedException();
        }

        public void Reporte_PackingList()
        {
            throw new NotImplementedException();
        }
    }
}
