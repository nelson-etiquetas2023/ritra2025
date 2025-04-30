using Ritrama2025.Services;
using Ritrama2025.Models;
using System.Data;

namespace Ritrama2025.Forms
{
    public partial class FrmDespacho : Form
    {
        private readonly DespachoService Service = new();

        DataSet Ds = new();
        readonly BindingSource Bs = [];
        readonly BindingSource BsDetalle = [];

        public FrmDespacho()
        {
            InitializeComponent();
        }

        private void Despacho_Load(object sender, EventArgs e)
        {
            // 1.- Procedimiento para cargar los despachos.
            var task = Task.Run(async () =>
            {
                return await Service.LoadDataDespachos();
            });
            Ds = task.Result;
            //Enlace a datos
            Bs.DataSource = Ds;
            Bs.DataMember = "DtMasterDespachos";
            txt_numero.DataBindings.Add("Text", Bs, "numero");
            txt_fecha_despacho.DataBindings.Add("Text", Bs, "fecha");
            txt_persondelivery.DataBindings.Add("Text", Bs, "person_contact");
            txt_custid.DataBindings.Add("Text", Bs, "customer_id");
            txt_transport.DataBindings.Add("Text", Bs, "transporte");
            txt_chofer.DataBindings.Add("Text", Bs, "chofer");
            txt_camion.DataBindings.Add("Text", Bs, "camion");
            txt_venid.DataBindings.Add("Text", Bs, "vendor_id");
            txt_tipo_embalaje.DataBindings.Add("Text", Bs, "packing");
            txt_orden_trabajo.DataBindings.Add("Text", Bs, "orden_trabajo");
            txt_orden_compra.DataBindings.Add("Text", Bs, "orden_compra");
            txt_tipoventa.DataBindings.Add("Text", Bs, "tipo_venta");
            txt_subtotal.DataBindings.Add("Text", Bs, "subtotal");
            txt_porc_itbis.DataBindings.Add("Text", Bs, "porc_itbis");
            txt_itbis.DataBindings.Add("Text", Bs, "itbis");
            txt_totalmonto.DataBindings.Add("Text", Bs, "total$rd");
            txt_custname.DataBindings.Add("Text", Bs, "customer_name");
            txt_vendorname.DataBindings.Add("Text", Bs, "vendor_name");

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_tipoventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bot_primero_Click(object sender, EventArgs e)
        {
            Bs.Position = 0;
        }

        private void bot_siguiente_Click(object sender, EventArgs e)
        {
            Bs.Position += 1;
        }

        private void bot_anterior_Click(object sender, EventArgs e)
        {
            Bs.Position -= 1;
        }

        private void bot_ultimo_Click(object sender, EventArgs e)
        {
            Bs.Position = Bs.Count - 1; 
        }
    }
}
