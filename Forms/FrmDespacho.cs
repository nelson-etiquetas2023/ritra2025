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
        readonly BindingSource BsDetalleRC = [];

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
            //Enlace a datos Encabezado.
            Bs.DataSource = Ds;
            Bs.DataMember = "DtMasterDespachos";
            //Enlace Datos DetalleRC.
            BsDetalleRC.DataSource = Bs;
            BsDetalleRC.DataMember = "FK_DESPACHOS_DETALLERC";
            //Definicion de las columnas del grid de DetalleRC
            grid_rc.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("unique_code", 70, "Unique Code", "unique_code", grid_rc);
            AGREGAR_COLUMN_GRID("product_id", 70, "Prod. Id.", "product_id", grid_rc);
            AGREGAR_COLUMN_GRID("product_name", 250, "Product Name", "product_name", grid_rc);
            AGREGAR_COLUMN_GRID("roll_number", 70, "Roll Number", "roll_number", grid_rc);
            AGREGAR_COLUMN_GRID("width", 70, "Width", "width", grid_rc);
            AGREGAR_COLUMN_GRID("length", 70, "Lenght", "lenght", grid_rc);
            AGREGAR_COLUMN_GRID("msi", 70, "Msi", "msi", grid_rc);
            AGREGAR_COLUMN_GRID("splice", 70, "Splice", "splice", grid_rc);
            AGREGAR_COLUMN_GRID("cant_despacho", 80, "Cantidad Despacho", "cant_despacho", grid_rc);
            AGREGAR_COLUMN_GRID("roll_id", 70, "Roll Id.", "roll_id", grid_rc);
            AGREGAR_COLUMN_GRID("tipo", 70, "Tipo", "cant_despacho", grid_rc);
            AGREGAR_COLUMN_GRID("paleta", 70, "Paleta", "no_paleta", grid_rc);
            grid_rc.DataSource = BsDetalleRC;

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
        private static void AGREGAR_COLUMN_GRID(string name, int size, string title, string field_bd, DataGridView grid) 
        {
            DataGridViewTextBoxColumn col = new()
            {
                Name = name,
                Width = size,
                HeaderText = title,
                DataPropertyName = field_bd,
            };
            grid.Columns.Add(col);
        }
    }
}
