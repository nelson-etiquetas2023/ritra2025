using Ritrama2025.Services;
using System.Data;
using Ritrama2025.Forms.Seleccion;

namespace Ritrama2025.Forms
{
    public partial class FrmDespacho : Form
    {
        private readonly DespachoService Service = new();
        DataSet Ds = new();
        readonly BindingSource Bs = [];
        readonly BindingSource BsDetalleRC = [];
        readonly BindingSource BsItems = [];
        readonly BindingSource BsPalet = [];
        DataRowView ParentRow = null!;

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
            //Enlace Datos Items.
            BsItems.DataSource = Bs;
            BsItems.DataMember = "FK_DESPACHOS_ITEMS";
            //Enlace Datos Grid Palet.
            BsPalet.DataSource = Bs;
            BsPalet.DataMember = "FK_DESPACHOS_PALET";
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
            //Definicion de las columnas del grid de Items.
            grid_items.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("product_id", 70, "Product Id.", "product_id", grid_items);
            AGREGAR_COLUMN_GRID("product_name", 200, "Product Name", "product_name", grid_items);
            AGREGAR_COLUMN_GRID("unid_id", 65, "Unidad", "unid_id", grid_items);
            AGREGAR_COLUMN_GRID("cant", 60, "Cant.", "cant", grid_items);
            AGREGAR_COLUMN_GRID("width", 65, "Width [Pulg]", "width", grid_items);
            AGREGAR_COLUMN_GRID("lenght", 65, "Lenght [Pies]", "lenght", grid_items);
            AGREGAR_COLUMN_GRID("msi", 70, "MSI", "msi", grid_items);
            AGREGAR_COLUMN_GRID("total_pie_lin", 70, "Pie Lineales", "total_pie_lin", grid_items);
            AGREGAR_COLUMN_GRID("ratio", 60, "Ratio", "ratio", grid_items);
            AGREGAR_COLUMN_GRID("kilo_rollo", 70, "Kilo Rollo", "kilo_rollo", grid_items);
            AGREGAR_COLUMN_GRID("kilo_total", 70, "Kilo Total", "kilo_total", grid_items);
            AGREGAR_COLUMN_GRID("precio", 60, "Precio", "precio", grid_items);
            AGREGAR_COLUMN_GRID("total_renglon", 70, "Total Renglon", "total_renglon", grid_items);
            AGREGAR_COLUMN_GRID("code_person", 70, "Code Person", "code_person", grid_items);
            AGREGAR_COLUMN_GRID("m2", 70, "Total M2", "m2", grid_items);
            grid_items.DataSource = BsItems;
            //Definicion de las columnas del grid de Detalle de paleta.
            grid_detalle_paletas.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("number_palet", 70, "# Palet.", "number_palet", grid_detalle_paletas);
            AGREGAR_COLUMN_GRID("medida", 70, "Medida", "medida", grid_detalle_paletas);
            AGREGAR_COLUMN_GRID("contenido", 200, "Contenido", "contenido", grid_detalle_paletas);
            AGREGAR_COLUMN_GRID("kilo_neto", 70, "Kilo Neto", "kilo_neto", grid_detalle_paletas);
            AGREGAR_COLUMN_GRID("kilo_bruto", 70, "Kilo Bruto", "kilo_bruto", grid_detalle_paletas);
            grid_detalle_paletas.DataSource = BsPalet;



            //Binding Forms
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

        private void Bot_primero_Click(object sender, EventArgs e)
        {
            Bs.Position = 0;
        }

        private void Bot_siguiente_Click(object sender, EventArgs e)
        {
            Bs.Position += 1;
        }

        private void Bot_anterior_Click(object sender, EventArgs e)
        {
            Bs.Position -= 1;
        }

        private void Bot_ultimo_Click(object sender, EventArgs e)
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

        private void Bot_nuevo_Click(object sender, EventArgs e)
        {
            ParentRow = (DataRowView)Bs.AddNew()!;
            ParentRow.BeginEdit();
            ParentRow["numero"] = "5000";

            txt_numero.ReadOnly = false;
            txt_fecha_despacho.Enabled = true;

            bot_picking.Enabled = true;
            btn_buscar_customer.Enabled = true;
            bot_buscar_vendor.Enabled = true;
            bot_camion.Enabled = true;
            bot_transporte.Enabled = true;
            bot_chofer.Enabled = true;
        }

        private void Bot_picking_Click(object sender, EventArgs e)
        {
            FrmPickingDespacho frm_picking = new();
            frm_picking.ShowDialog();
            //actualizar el grid de detalle de rc (packing list)
            grid_rc.Columns.Clear();
            grid_rc.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("uniquecode", 70, "Unique Code", "uniquecode", grid_rc);
            AGREGAR_COLUMN_GRID("product_id", 80, "Product Id.", "product_id", grid_rc);
            AGREGAR_COLUMN_GRID("product_name", 180, "Nombre del Producto", "product_name", grid_rc);
            AGREGAR_COLUMN_GRID("RollNumber", 70, "Roll Number", "RollNumber", grid_rc);
            AGREGAR_COLUMN_GRID("width", 80, "Width", "width", grid_rc);
            AGREGAR_COLUMN_GRID("Length", 80, "Largo", "Length", grid_rc);
            AGREGAR_COLUMN_GRID("msi", 80, "Msi", "msi", grid_rc);
            AGREGAR_COLUMN_GRID("Splice", 70, "Splice", "Splice", grid_rc);
            AGREGAR_COLUMN_GRID("roll_id", 72, "Roll Id.", "roll_id", grid_rc);
            AGREGAR_COLUMN_GRID("code_person", 74, "Codigo Perso.", "code_person", grid_rc);
            grid_rc.DataSource = frm_picking.Lista_Rollos;
            //actualizar el grid de renglones a despachar.
            grid_items.Columns.Clear();
            grid_items.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("product_id", 80, "Product Id.", "product_id", grid_items);
            AGREGAR_COLUMN_GRID("product_name", 200, "Product Name", "product_name", grid_items);
            AGREGAR_COLUMN_GRID("unid_id", 70, "Unidad", "unid_id", grid_items);
            AGREGAR_COLUMN_GRID("cantidad", 70, "Cant.", "cantidad", grid_items);
            AGREGAR_COLUMN_GRID("width", 70, "Width [Pulg]", "width", grid_items);
            AGREGAR_COLUMN_GRID("width", 70, "Lenght [Pies]", "lenght", grid_items);
            AGREGAR_COLUMN_GRID("msi", 70, "Msi", "msi", grid_items);
            AGREGAR_COLUMN_GRID("pie_lin", 70, "Pie Lineales", "pie_lin", grid_items);
            AGREGAR_COLUMN_GRID("ratio", 70, "Ratio", "ratio", grid_items);
            AGREGAR_COLUMN_GRID("kilo_rollo", 70, "Kilo Rollo", "kilo_rollo", grid_items);
            AGREGAR_COLUMN_GRID("kilo_total", 70, "Kilo Total", "kilo_total", grid_items);
            AGREGAR_COLUMN_GRID("precio", 70, "Precio", "precio", grid_items);
            AGREGAR_COLUMN_GRID("total_renglon", 70, "Total Renglon", "total_renglon", grid_items);
            grid_items.DataSource = frm_picking.Lista_Items;

        }

        private void Btn_buscar_customer_Click(object sender, EventArgs e)
        {
            FrmSeleccion SelClientes = new()
            {
                DtItems = Ds.Tables["DtClientes"]!,
                Titulo = "Clientes",
            };
            SelClientes.ShowDialog();
            txt_custid.Text = SelClientes.Id;
            txt_custname.Text = SelClientes.Description;
        }
    }
}
