using Ritrama2025.Forms.Otros;
using Ritrama2025.Forms.Seleccion;
using Ritrama2025.Models;
using Ritrama2025.Services;
using Ritrama2025.Services.ExportData;
using System.Data;

namespace Ritrama2025.Forms
{
    public partial class FrmDespacho : Form
    {
        private readonly DespachoService Service = new();
        private readonly ReportsService ReportsService = new();
        private readonly ExportDataService ExportDataService = new();
        DataSet Ds = new();
        readonly BindingSource Bs = [];
        readonly BindingSource BsDetalleRC = [];
        readonly BindingSource BsItems = [];
        readonly BindingSource BsPalet = [];
        DataRowView ParentRow = null!;
        DataRowView ParentRowPalet = null!;
        public readonly decimal porc_itbis = 18.00m;
        const decimal CONST_PIE_LINEALES = 0.012m;
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
            txt_transport_id.DataBindings.Add("Text", Bs, "transport_id");
            txt_transport_name.DataBindings.Add("Text", Bs, "transporte");
            txt_chofer_id.DataBindings.Add("Text", Bs, "chofer_id");
            txt_chofer_name.DataBindings.Add("Text", Bs, "chofer");
            txt_camion_id.DataBindings.Add("Text", Bs, "placas_id");
            txt_camion_name.DataBindings.Add("Text", Bs, "camion");
            txt_vend_id.DataBindings.Add("Text", Bs, "vendor_id");
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
            txt_cant_total.DataBindings.Add("Text", Bs, "total_cantidad");
            txt_msi_total.DataBindings.Add("Text", Bs, "total_msi");
            txt_pie_total.DataBindings.Add("Text", Bs, "total_pie");
            txt_kilos_total.DataBindings.Add("Text", Bs, "total_kilos");
            txt_palet_kilo_neto.DataBindings.Add("Text", Bs, "total_kilos_netos_palet");
            txt_palet_kilo_bruto.DataBindings.Add("Text", Bs, "total_kilos_brutos_palet");
            //agregar la columna.
            DataGridViewButtonColumn ColumnButton = new()
            {
                Name = "btn_description",
                HeaderText = "Accion",
                Text = "...",
                UseColumnTextForButtonValue = true,
                Width = 60,
            };
            grid_detalle_paletas.Columns.Add(ColumnButton);
            grid_detalle_paletas.Columns["btn_description"]!.DisplayIndex = 3;
            //IR AL FINAL DE LA BASE DE DATOS LA ULTIMA ORDEN DE DESPACHO.
            Bs.Position = Bs.Count - 1;
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
            txt_numero.Text = Service.GetNumberConsec();
            txt_fecha_despacho.Enabled = true;
            txt_persondelivery.ReadOnly = false;
            txt_tipo_embalaje.ReadOnly = false;
            txt_orden_trabajo.ReadOnly = false;
            txt_orden_compra.ReadOnly = false;
            txt_tipoventa.ReadOnly = false;

            txt_subtotal.Text = "0";
            txt_itbis.Text = "0";
            txt_totalmonto.Text = "0";
            txt_palet_kilo_bruto.Text = "0";
            txt_palet_kilo_neto.Text = "0";
            txt_cant_total.Text = "0";
            txt_msi_total.Text = "0";
            txt_pie_total.Text = "0";
            txt_kilos_total.Text = "0";

            bot_add_palet.Enabled = true;
            bot_delete_palet.Enabled = true;
            bot_picking.Enabled = true;
            btn_buscar_customer.Enabled = true;
            bot_buscar_vendor.Enabled = true;
            bot_camion.Enabled = true;
            bot_transporte.Enabled = true;
            bot_chofer.Enabled = true;
            bot_grabar.Enabled = true;
            bot_cancelar.Enabled = true;

            bot_primero.Enabled = false;
            bot_siguiente.Enabled = false;
            bot_anterior.Enabled = false;
            bot_ultimo.Enabled = false;
            bot_nuevo.Enabled = false;
            bot_buscar.Enabled = false;
            btn_reports.Enabled = false;
            btn_exports.Enabled = false;
            btn_close_document.Enabled = false;
            btn_label_print.Enabled = false;
            bot_anular.Enabled = false;

            grid_detalle_paletas.ReadOnly = false;

        }

        private void Bot_picking_Click(object sender, EventArgs e)
        {
            

            FrmPickingDespacho frm_picking = new();
            frm_picking.ShowDialog();


            if (frm_picking.Lista_Rollos.Count <= 0)
            {
                return;
            }

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
            AGREGAR_COLUMN_GRID("unidad", 70, "Unidad", "unidad", grid_items);
            AGREGAR_COLUMN_GRID("cantidad", 70, "Cant.", "cantidad", grid_items);
            AGREGAR_COLUMN_GRID("width", 70, "Width [Pulg]", "width", grid_items);
            AGREGAR_COLUMN_GRID("lenght", 70, "Lenght [Pies]", "lenght", grid_items);
            AGREGAR_COLUMN_GRID("msi", 70, "Msi", "msi", grid_items);
            AGREGAR_COLUMN_GRID("pie_lin", 70, "Pie Lineales", "pie_lin", grid_items);
            AGREGAR_COLUMN_GRID("ratio", 70, "Ratio", "ratio", grid_items);
            AGREGAR_COLUMN_GRID("kilo_rollo", 70, "Kilo Rollo", "kilo_rollo", grid_items);
            AGREGAR_COLUMN_GRID("kilo_total", 70, "Kilo Total", "kilo_total", grid_items);
            AGREGAR_COLUMN_GRID("precio", 70, "Precio", "precio", grid_items);
            AGREGAR_COLUMN_GRID("total_renglon", 150, "Total Renglon", "total_renglon", grid_items);
            AGREGAR_COLUMN_GRID("m2", 80, "M2", "m2", grid_items);
            grid_items.DataSource = frm_picking.Lista_Items;

            //Calculo de los pies lineales.
            for (int i = 0; i <= grid_items.Rows.Count - 1; i++)
            {
                //pie lineales
                grid_items.Rows[i].Cells["pie_lin"].Value = Convert.ToDecimal(grid_items.Rows[i].Cells["lenght"].Value) * CONST_PIE_LINEALES;
                //Busqueda del ratio por producto.
                grid_items.Rows[i].Cells["ratio"].Value = Service.GetRatioProductById(grid_items.Rows[i].Cells["product_id"].Value!.ToString()!);
                //Calculo de la Columna Kilo-Rollo.
                grid_items.Rows[i].Cells["kilo_rollo"].Value = (Convert.ToDecimal(grid_items.Rows[i].Cells["width"].Value) * Convert.ToDecimal(grid_items.Rows[i].Cells["lenght"].Value) * Convert.ToDecimal(grid_items.Rows[i].Cells["msi"].Value)) / 1000;
                grid_items.Rows[i].Cells["kilo_total"].Value = Convert.ToDecimal(grid_items.Rows[i].Cells["kilo_rollo"].Value) * Convert.ToDecimal(grid_items.Rows[i].Cells["cantidad"].Value);

                grid_items.Rows[i].Cells["precio"].Value = "0";
                grid_items.Rows[i].Cells["total_renglon"].Value = "0";
            }


            CalcularTotalesColumns();
            txt_porc_itbis.Text = $"{porc_itbis:0.##}";


            //abrir la columna de precio para hacer el calculo de total renglon.
            grid_items.ReadOnly = false;

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

        private void Bot_buscar_vendor_Click(object sender, EventArgs e)
        {
            FrmSeleccion SelVendors = new()
            {
                DtItems = Ds.Tables["DtVendors"]!,
                Titulo = "Vendedores",
            };
            SelVendors.ShowDialog();
            txt_vend_id.Text = SelVendors.Id;
            txt_vendorname.Text = SelVendors.Description;
        }

        private void Bot_transporte_Click(object sender, EventArgs e)
        {
            FrmSeleccion SelTransport = new()
            {
                DtItems = Ds.Tables["DtTransport"]!,
                Titulo = "Transporte",
            };
            SelTransport.ShowDialog();
            txt_transport_id.Text = SelTransport.Id;
            txt_transport_name.Text = SelTransport.Description;
        }

        private void Bot_chofer_Click(object sender, EventArgs e)
        {
            FrmSeleccion SelChofer = new()
            {
                DtItems = Ds.Tables["DtChofer"]!,
                Titulo = "Chofer",
            };
            SelChofer.ShowDialog();
            txt_chofer_id.Text = SelChofer.Id;
            txt_chofer_name.Text = SelChofer.Description;
        }

        private void Bot_camion_Click(object sender, EventArgs e)
        {
            FrmSeleccion SelCamion = new()
            {
                DtItems = Ds.Tables["DtCamion"]!,
                Titulo = "Camion",
            };
            SelCamion.ShowDialog();
            txt_camion_id.Text = SelCamion.Id;
            txt_camion_name.Text = SelCamion.Description;
        }
        private void CalcularTotalesColumns()
        {
            int TotalCantitdad = 0;
            decimal TotalMsi = 0;
            decimal TotalPieLin = 0;
            decimal TotalKilosRollo = 0;
            decimal TotalKilosTotal = 0;
            for (int i = 0; i <= grid_items.Rows.Count - 1; i++)
            {
                TotalCantitdad += Convert.ToInt32(grid_items.Rows[i].Cells["cantidad"].Value);
                //TotalMsi += Convert.ToDecimal(grid_items.Rows[i].Cells["m2"].Value);
                if (!string.IsNullOrEmpty(grid_items.Rows[i].Cells["pie_lin"].Value!.ToString()))
                {
                    TotalPieLin += Convert.ToDecimal(grid_items.Rows[i].Cells["pie_lin"].Value);
                }
                if (!string.IsNullOrEmpty(grid_items.Rows[i].Cells["kilo_rollo"].Value!.ToString()))
                {
                    TotalKilosRollo += Convert.ToDecimal(grid_items.Rows[i].Cells["kilo_rollo"].Value);
                }
                if (!string.IsNullOrEmpty(grid_items.Rows[i].Cells["kilo_total"].Value!.ToString()))
                {
                    TotalKilosTotal += Convert.ToDecimal(grid_items.Rows[i].Cells["kilo_total"].Value);
                }
                if (!string.IsNullOrEmpty(grid_items.Rows[i].Cells["msi"].Value!.ToString()))
                {
                    TotalMsi += Convert.ToDecimal(grid_items.Rows[i].Cells["msi"].Value);
                }
            }
            txt_cant_total.Text = TotalCantitdad.ToString();
            txt_msi_total.Text = $"{TotalMsi:0.##}";
            txt_pie_total.Text = $"{TotalPieLin:###.###.##}";
            txt_kilos_total.Text = $"{TotalKilosTotal:###.###.##}";
            txt_cant_total.Refresh();
            txt_msi_total.Refresh();
            txt_pie_total.Refresh();
            txt_kilos_total.Refresh();
        }
        private static string CalcularImpuestoRenglon(decimal subtotal, decimal monto_itbis)
        {
            decimal renglonImpuesto = subtotal + monto_itbis;
            return $"{renglonImpuesto,12:N2}";
        }
        private static string CalcularImpuestoDocument(decimal subtotal)
        {
            decimal impuesto = (18 * subtotal) / 100;
            return $"{impuesto,12:N2}";
        }
        private string CalcularSubtotalDocument()
        {
            decimal SubTotalDoc = 0;
            for (int i = 0; i <= grid_items.Rows.Count - 1; i++)
            {
                SubTotalDoc += Convert.ToDecimal(grid_items.Rows[i].Cells["total_renglon"].Value);
            }
            return $"{SubTotalDoc,12:N2}";
        }
        private static string CalcularTotalesDocument(decimal subtotal, decimal impuesto)
        {
            decimal total = subtotal + impuesto;
            return $"{total,12:N2}";
        }
        private void CalcularTotalesDocument()
        {
            txt_subtotal.Text = CalcularSubtotalDocument();

            txt_itbis.Text = CalcularImpuestoDocument(Convert.ToDecimal(txt_subtotal.Text));

            txt_totalmonto.Text = CalcularTotalesDocument(Convert.ToDecimal(txt_subtotal.Text), Convert.ToDecimal(txt_itbis.Text));
        }

        private void Grid_items_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Calculo del total renglon.
            grid_items.Rows[e.RowIndex].Cells["total_renglon"].Value = Convert.ToDecimal(grid_items.Rows[e.RowIndex].Cells["precio"].Value) * Convert.ToDecimal(grid_items.Rows[e.RowIndex].Cells["kilo_total"].Value);
            //Calculo de los totales del documento.
            CalcularTotalesDocument();

        }

        private void Bot_add_palet_Click(object sender, EventArgs e)
        {
            ParentRowPalet = (DataRowView)BsPalet.AddNew()!;
            ParentRowPalet.BeginEdit();
            ParentRowPalet["contenido"] = "";
            ParentRowPalet[4] = "0";
            ParentRowPalet[5] = "0";
            grid_detalle_paletas.Focus();
            grid_detalle_paletas.CurrentCell = grid_detalle_paletas.Rows[0].Cells[0];
            grid_detalle_paletas.BeginEdit(true); // Opcional: inicia edición en la celda

        }

        private void CalcularTotalPalet()
        {
            decimal PaletPesoNeto = 0;
            decimal PaletPesoBruto = 0;

            for (int i = 0; i <= grid_detalle_paletas.Rows.Count - 1; i++)
            {
                PaletPesoNeto += Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_neto"].Value);
                PaletPesoBruto += Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_bruto"].Value);
            }

            txt_palet_kilo_neto.Text = Convert.ToString(PaletPesoNeto);
            txt_palet_kilo_bruto.Text = Convert.ToString(PaletPesoBruto);
        }
        private void Grid_detalle_paletas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_detalle_paletas.Columns["kilo_neto"]!.Index == e.ColumnIndex || grid_detalle_paletas.Columns["kilo_bruto"]!.Index == e.ColumnIndex)
            {
                CalcularTotalPalet();
            }
        }

        private void Grid_detalle_paletas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_detalle_paletas.Columns["btn_description"]!.Index == e.ColumnIndex)
            {
                Frm_descriptionPalet DescriptionPalet = new()
                {
                    ContentTextDescription = Convert.ToString(grid_detalle_paletas.Rows[e.RowIndex].Cells["contenido"].Value) ?? string.Empty
                };

                DescriptionPalet.ShowDialog();

                grid_detalle_paletas.Rows[e.RowIndex].Cells["contenido"].Value = DescriptionPalet.ContentTextDescription;
            }
        }

        private void Bot_grabar_Click(object sender, EventArgs e)
        {
            if (txt_custid.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir los datos del cliente...");
                return;
            }
            if (txt_vend_id.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir los datos del vendedor...");
                return;
            }
            if (txt_tipo_embalaje.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir el tipo de embalaje...");
                return;
            }
            if (txt_orden_trabajo.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir el numero de la orden de trabajo...");
                return;
            }
            if (txt_orden_compra.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir el numero de la orden de compra...");
                return;
            }
            if (txt_tipoventa.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir el tipo de venta");
                return;
            }



            Despacho DocumentDespacho = new()
            {
                //Encabezado de despacho.
                Numero = txt_numero.Text,
                Fecha_despacho = Convert.ToDateTime(txt_fecha_despacho.Text),
                Customer_Id = txt_custid.Text,
                Customer_Name = txt_custname.Text,
                Persona_Contact = txt_persondelivery.Text,
                Vendor_Id = txt_vend_id.Text,
                Vendor_Name = txt_vendorname.Text,
                Transport_Id = txt_transport_id.Text,
                Transport_Name = txt_transport_name.Text,
                Chofer_Id = txt_chofer_id.Text,
                Chofer_Name = txt_chofer_name.Text,
                Camion_Id = txt_camion_id.Text,
                Camion_Name = txt_camion_name.Text,
                Tipo_Embalaje = txt_tipo_embalaje.Text,
                Orden_Trabajo = txt_orden_trabajo.Text,
                Orden_Compra = txt_orden_compra.Text,
                Tipo_venta = txt_tipoventa.Text,
                Total_Cantidad = Convert.ToInt32(txt_cant_total.Text),
                Total_Msi = Convert.ToDecimal(txt_msi_total.Text),
                Total_Pie = Convert.ToDecimal(txt_pie_total.Text),
                Total_Kilos = Convert.ToDecimal(txt_kilos_total.Text),
                SubTotal = Convert.ToDecimal(txt_subtotal.Text),
                Porc_Itbis = Convert.ToDecimal(txt_porc_itbis.Text),
                Monto_Itbis = Convert.ToDecimal(txt_itbis.Text),
                Total_Despacho = Convert.ToDecimal(txt_totalmonto.Text),
                Total_kilos_netos_palet = Convert.ToDecimal(txt_palet_kilo_neto.Text),
                Total_kilos_brutos_palet = Convert.ToDecimal(txt_palet_kilo_bruto.Text),
                //crear picking-list.
                Detalle_RC = [],
                //Items de despacho.
                Items_Despacho = [],
                //Detalle de paleta.
                Detalle_Paleta = [],
            };
            //picking-list;
            for (int i = 0; i <= grid_rc.Rows.Count - 1; i++)
            {
                RolloCortado Rollo = new()
                {
                    Numero = DocumentDespacho.Numero,
                    UniqueCode = Convert.ToString(grid_rc.Rows[i].Cells["uniquecode"].Value) ?? string.Empty,
                    Product_Id = Convert.ToString(grid_rc.Rows[i].Cells["product_id"].Value) ?? string.Empty,
                    Product_Name = Convert.ToString(grid_rc.Rows[i].Cells["product_name"].Value) ?? string.Empty,
                    RollNumber = Convert.ToInt16(grid_rc.Rows[i].Cells["RollNumber"].Value),
                    Width = Convert.ToDecimal(grid_rc.Rows[i].Cells["width"].Value),
                    Length = Convert.ToDecimal(grid_rc.Rows[i].Cells["length"].Value),
                    Msi = Convert.ToDecimal(grid_rc.Rows[i].Cells["msi"].Value),
                    Splice = Convert.ToInt16(grid_rc.Rows[i].Cells["splice"].Value),
                    Roll_Id = Convert.ToString(grid_rc.Rows[i].Cells["roll_id"].Value) ?? string.Empty,
                    Code_Person = Convert.ToString(grid_rc.Rows[i].Cells["code_person"].Value) ?? string.Empty,
                    Cantidad_despacho = 0,
                    Tipo = "n/a",
                    Paleta = "0"
                };
                DocumentDespacho.Detalle_RC.Add(Rollo);
            }
            //item a despachar.
            for (int i = 0; i <= grid_items.Rows.Count - 1; i++)
            {
                ItemsDespacho itemsDespacho = new()
                {
                    Numero = DocumentDespacho.Numero,
                    Product_id = Convert.ToString(grid_items.Rows[i].Cells["product_id"].Value) ?? string.Empty,
                    Product_name = Convert.ToString(grid_items.Rows[i].Cells["product_name"].Value) ?? string.Empty,
                    Cantidad = Convert.ToDecimal(grid_items.Rows[i].Cells["cantidad"].Value),
                    Unid_id = "1",
                    Unidad = Convert.ToString(grid_items.Rows[i].Cells["unidad"].Value) ?? string.Empty,
                    Width = Convert.ToDecimal(grid_items.Rows[i].Cells["width"].Value),
                    Lenght = Convert.ToDecimal(grid_items.Rows[i].Cells["lenght"].Value),
                    Msi = Convert.ToDecimal(grid_items.Rows[i].Cells["msi"].Value),
                    Total_PieLineal = Convert.ToDecimal(grid_items.Rows[i].Cells["pie_lin"].Value),
                    Ratio = Convert.ToDecimal(grid_items.Rows[i].Cells["ratio"].Value),
                    Kilo_Rollo = Convert.ToDecimal(grid_items.Rows[i].Cells["kilo_rollo"].Value),
                    Kilo_Total = Convert.ToDecimal(grid_items.Rows[i].Cells["kilo_total"].Value),
                    Precio = Convert.ToDecimal(grid_items.Rows[i].Cells["precio"].Value),
                    Total_Renglon = Convert.ToDecimal(grid_items.Rows[i].Cells["total_renglon"].Value),
                    Code_Person = "N/A",
                    M2 = Convert.ToDecimal(grid_items.Rows[i].Cells["m2"].Value)
                };
                DocumentDespacho.Items_Despacho.Add(itemsDespacho);
                //Guardar en base de datos el encxabezado del despacho.

            }
            //detalle paleta.
            for (int i = 0; i <= grid_detalle_paletas.Rows.Count - 1; i++)
            {
                Paleta palet = new()
                {
                    Numero = DocumentDespacho.Numero,
                    Number_Palet = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["number_palet"].Value) ?? string.Empty,
                    Medida = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["medida"].Value) ?? string.Empty,
                    Contenido = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["contenido"].Value) ?? string.Empty,
                    Kilo_Neto = Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_neto"].Value),
                    Kilo_Bruto = Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_bruto"].Value)
                };
                DocumentDespacho.Detalle_Paleta.Add(palet);
            }
            Service.AddDocumentDespacho(DocumentDespacho);
            Service.AddPickingListDespacho(DocumentDespacho.Detalle_RC);
            Service.AddItemsDespacho(DocumentDespacho.Items_Despacho);
            Service.AddPaletDetailsDespacho(DocumentDespacho.Detalle_Paleta);
            //cerrar el formulario a solo lectura.
            txt_persondelivery.ReadOnly = true;
            txt_fecha_despacho.Enabled = false;
            txt_tipoventa.ReadOnly = true;
            txt_tipo_embalaje.ReadOnly = true;
            txt_orden_compra.ReadOnly = true;
            txt_orden_trabajo.ReadOnly = true;
            bot_camion.Enabled = false;
            bot_chofer.Enabled = false;
            bot_transporte.Enabled = false;
            bot_add_palet.Enabled = false;
            bot_delete_palet.Enabled = false;
            bot_buscar_vendor.Enabled = false;
            btn_buscar_customer.Enabled = false;
            bot_picking.Enabled = false;
            btn_exports.Enabled = true;
            btn_label_print.Enabled = true;
            bot_anular.Enabled = true;
            grid_items.ReadOnly = true;
            grid_rc.ReadOnly = true;
            grid_detalle_paletas.ReadOnly = true;

            bot_primero.Enabled = true;
            bot_siguiente.Enabled = true;
            bot_anterior.Enabled = true;
            bot_ultimo.Enabled = true;
            bot_nuevo.Enabled = true;
            bot_grabar.Enabled = false;
            bot_cancelar.Enabled = false;
            bot_buscar.Enabled = true;
            btn_reports.Enabled = true;
            export_excel.Enabled = true;


        }

        private void Reporte_conduce_conprecio_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                var TitleReport = "REPORTE DE CONDUCE CON PRECIO.";
                ReportsService.ReporteConduce_conPrecio(txt_numero.Text, this, "RptConduceConPrecio.rdlc", TitleReport);
            }
        }

        private void Reporte_conduce_sinprecio_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                var TitleReport = "REPORTE DE CONDUCE SIN PRECIO.";
                ReportsService.ReporteCondece_sinPrecio(txt_numero.Text, this, "RptConduceSinPrecio.rdlc", TitleReport);
            }
        }

        private void Reporte_picking_list_Click(object sender, EventArgs e)
        {
            ReportsService.Reporte_PackingList(txt_numero.Text, this);
        }

        private void Reporte_detalle_paleta_Click(object sender, EventArgs e)
        {
            ReportsService.Reporte_DetallePaleta(txt_numero.Text, this);
        }

        private void Export_excel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportar a Excel");
        }

        private void Export_pdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportar a PDF.");
        }

        private void RollosCortadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RolloCortado> rollosCortados = CREATE_ROLLOS_CORTADOS();
            ExportDataService.ExportToExcel<RolloCortado>(rollosCortados, "RollosCortados.xlsx");
        }

        private List<RolloCortado> CREATE_ROLLOS_CORTADOS()
        {
            List<RolloCortado> Lista_Rollos = [];
            //picking-list;
            for (int i = 0; i <= grid_rc.Rows.Count - 1; i++)
            {
                RolloCortado Rollo = new()
                {
                    Numero = txt_numero.Text,
                    UniqueCode = Convert.ToString(grid_rc.Rows[i].Cells["unique_code"].Value) ?? string.Empty,
                    Product_Id = Convert.ToString(grid_rc.Rows[i].Cells["product_id"].Value) ?? string.Empty,
                    Product_Name = Convert.ToString(grid_rc.Rows[i].Cells["product_name"].Value) ?? string.Empty,
                    RollNumber = Convert.ToInt16(grid_rc.Rows[i].Cells["Roll_Number"].Value),
                    Width = Convert.ToDecimal(grid_rc.Rows[i].Cells["width"].Value),
                    Length = Convert.ToDecimal(grid_rc.Rows[i].Cells["length"].Value),
                    Msi = Convert.ToDecimal(grid_rc.Rows[i].Cells["msi"].Value),
                    Splice = Convert.ToInt16(grid_rc.Rows[i].Cells["splice"].Value),
                    Roll_Id = Convert.ToString(grid_rc.Rows[i].Cells["roll_id"].Value) ?? string.Empty,
                    //Code_Person = Convert.ToString(grid_rc.Rows[i].Cells["code_person"].Value) ?? string.Empty,
                    Cantidad_despacho = 0,
                    Tipo = "n/a",
                    Paleta = "0"
                };
                Lista_Rollos.Add(Rollo);
            }
            return Lista_Rollos;
        }

        private List<Paleta> CREATE_DETALLE_PALETA_LIST()
        {
            List<Paleta> Lista_Paletas = [];
            //detalle paleta.
            for (int i = 0; i <= grid_detalle_paletas.Rows.Count - 1; i++)
            {
                Paleta palet = new()
                {
                    Numero = txt_numero.Text,
                    Number_Palet = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["number_palet"].Value) ?? string.Empty,
                    Medida = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["medida"].Value) ?? string.Empty,
                    Contenido = Convert.ToString(grid_detalle_paletas.Rows[i].Cells["contenido"].Value) ?? string.Empty,
                    Kilo_Neto = Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_neto"].Value),
                    Kilo_Bruto = Convert.ToDecimal(grid_detalle_paletas.Rows[i].Cells["kilo_bruto"].Value)
                };
                Lista_Paletas.Add(palet);
            }
            return Lista_Paletas;
        }

        private void Opc_exportdata_excel_detallepaleta_Click(object sender, EventArgs e)
        {
            List<Paleta> detalle_paleta = CREATE_DETALLE_PALETA_LIST();
            ExportDataService.ExportToExcel<Paleta>(detalle_paleta, "detalle_paleta.xlsx");
        }

        private void btn_exports_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
