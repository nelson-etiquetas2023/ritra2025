namespace Ritrama2025.Forms
{
    partial class FrmDespacho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDespacho));
            toolStrip1 = new ToolStrip();
            bot_primero = new ToolStripButton();
            bot_anterior = new ToolStripButton();
            bot_siguiente = new ToolStripButton();
            bot_ultimo = new ToolStripButton();
            bot_nuevo = new ToolStripButton();
            bot_grabar = new ToolStripButton();
            bot_cancelar = new ToolStripButton();
            bot_buscar = new ToolStripButton();
            btn_reports = new ToolStripSplitButton();
            reporte_conduce_conprecio = new ToolStripMenuItem();
            reporte_conduce_sinprecio = new ToolStripMenuItem();
            reporte_picking_list = new ToolStripMenuItem();
            reporte_detalle_paleta = new ToolStripMenuItem();
            btn_exports = new ToolStripSplitButton();
            export_excel = new ToolStripMenuItem();
            rollosCortadosToolStripMenuItem = new ToolStripMenuItem();
            opc_exportdata_excel_detallepaleta = new ToolStripMenuItem();
            export_pdf = new ToolStripMenuItem();
            btn_close_document = new ToolStripButton();
            btn_label_print = new ToolStripButton();
            bot_anular = new ToolStripButton();
            label1 = new Label();
            txt_numero = new TextBox();
            btn_buscar_customer = new Button();
            txt_custid = new TextBox();
            txt_custname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_fecha_despacho = new DateTimePicker();
            label4 = new Label();
            txt_persondelivery = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_transport_id = new TextBox();
            bot_transporte = new Button();
            bot_chofer = new Button();
            txt_chofer_id = new TextBox();
            label7 = new Label();
            bot_camion = new Button();
            txt_camion_id = new TextBox();
            label8 = new Label();
            txt_vend_id = new TextBox();
            label9 = new Label();
            txt_vendorname = new TextBox();
            label10 = new Label();
            bot_buscar_vendor = new Button();
            txt_tipo_embalaje = new TextBox();
            label11 = new Label();
            txt_orden_trabajo = new TextBox();
            label12 = new Label();
            txt_orden_compra = new TextBox();
            label13 = new Label();
            txt_tipoventa = new TextBox();
            label14 = new Label();
            bot_picking = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grid_items = new DataGridView();
            tabPage2 = new TabPage();
            grid_rc = new DataGridView();
            grid_detalle_paletas = new DataGridView();
            label15 = new Label();
            bot_add_palet = new Button();
            bot_delete_palet = new Button();
            label16 = new Label();
            txt_subtotal = new TextBox();
            txt_itbis = new TextBox();
            txt_totalmonto = new TextBox();
            label17 = new Label();
            txt_porc_itbis = new TextBox();
            label18 = new Label();
            label19 = new Label();
            chk_impuesto = new CheckBox();
            txt_palet_kilo_neto = new TextBox();
            txt_palet_kilo_bruto = new TextBox();
            txt_cant_total = new TextBox();
            txt_msi_total = new TextBox();
            txt_pie_total = new TextBox();
            txt_kilos_total = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            pictureBox1 = new PictureBox();
            txt_chofer_name = new TextBox();
            txt_transport_name = new TextBox();
            txt_camion_name = new TextBox();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_items).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_rc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_detalle_paletas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.18868F);
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bot_primero, bot_anterior, bot_siguiente, bot_ultimo, bot_nuevo, bot_grabar, bot_cancelar, bot_buscar, btn_reports, btn_exports, btn_close_document, btn_label_print, bot_anular });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1238, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "Grabar";
            // 
            // bot_primero
            // 
            bot_primero.AutoSize = false;
            bot_primero.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_primero.Image = (Image)resources.GetObject("bot_primero.Image");
            bot_primero.ImageAlign = ContentAlignment.MiddleLeft;
            bot_primero.ImageTransparentColor = Color.Magenta;
            bot_primero.Name = "bot_primero";
            bot_primero.Size = new Size(100, 30);
            bot_primero.Text = "Primero";
            bot_primero.ToolTipText = "Primero";
            bot_primero.Click += Bot_primero_Click;
            // 
            // bot_anterior
            // 
            bot_anterior.Font = new Font("Segoe UI", 10.18868F);
            bot_anterior.Image = (Image)resources.GetObject("bot_anterior.Image");
            bot_anterior.ImageTransparentColor = Color.Magenta;
            bot_anterior.Name = "bot_anterior";
            bot_anterior.Size = new Size(81, 30);
            bot_anterior.Text = "Anterior";
            bot_anterior.Click += Bot_anterior_Click;
            // 
            // bot_siguiente
            // 
            bot_siguiente.Font = new Font("Segoe UI", 10.18868F);
            bot_siguiente.Image = (Image)resources.GetObject("bot_siguiente.Image");
            bot_siguiente.ImageTransparentColor = Color.Magenta;
            bot_siguiente.Name = "bot_siguiente";
            bot_siguiente.Size = new Size(87, 30);
            bot_siguiente.Text = "Siguiente";
            bot_siguiente.Click += Bot_siguiente_Click;
            // 
            // bot_ultimo
            // 
            bot_ultimo.Font = new Font("Segoe UI", 10.18868F);
            bot_ultimo.Image = (Image)resources.GetObject("bot_ultimo.Image");
            bot_ultimo.ImageTransparentColor = Color.Magenta;
            bot_ultimo.Name = "bot_ultimo";
            bot_ultimo.Size = new Size(72, 30);
            bot_ultimo.Text = "Ultimo";
            bot_ultimo.Click += Bot_ultimo_Click;
            // 
            // bot_nuevo
            // 
            bot_nuevo.Font = new Font("Segoe UI", 10.18868F);
            bot_nuevo.Image = (Image)resources.GetObject("bot_nuevo.Image");
            bot_nuevo.ImageTransparentColor = Color.Magenta;
            bot_nuevo.Name = "bot_nuevo";
            bot_nuevo.Size = new Size(71, 30);
            bot_nuevo.Text = "Nuevo";
            bot_nuevo.Click += Bot_nuevo_Click;
            // 
            // bot_grabar
            // 
            bot_grabar.Enabled = false;
            bot_grabar.Font = new Font("Segoe UI", 10.18868F);
            bot_grabar.Image = (Image)resources.GetObject("bot_grabar.Image");
            bot_grabar.ImageTransparentColor = Color.Magenta;
            bot_grabar.Name = "bot_grabar";
            bot_grabar.Size = new Size(73, 30);
            bot_grabar.Text = "Grabar";
            bot_grabar.Click += Bot_grabar_Click;
            // 
            // bot_cancelar
            // 
            bot_cancelar.Enabled = false;
            bot_cancelar.Font = new Font("Segoe UI", 10.18868F);
            bot_cancelar.Image = (Image)resources.GetObject("bot_cancelar.Image");
            bot_cancelar.ImageTransparentColor = Color.Magenta;
            bot_cancelar.Name = "bot_cancelar";
            bot_cancelar.Size = new Size(83, 30);
            bot_cancelar.Text = "Cancelar";
            // 
            // bot_buscar
            // 
            bot_buscar.Font = new Font("Segoe UI", 10.18868F);
            bot_buscar.Image = (Image)resources.GetObject("bot_buscar.Image");
            bot_buscar.ImageTransparentColor = Color.Magenta;
            bot_buscar.Name = "bot_buscar";
            bot_buscar.Size = new Size(71, 30);
            bot_buscar.Text = "Buscar";
            // 
            // btn_reports
            // 
            btn_reports.DropDownItems.AddRange(new ToolStripItem[] { reporte_conduce_conprecio, reporte_conduce_sinprecio, reporte_picking_list, reporte_detalle_paleta });
            btn_reports.Image = Properties.Resources.print_48px;
            btn_reports.ImageTransparentColor = Color.Magenta;
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(97, 30);
            btn_reports.Text = "Reportes";
            // 
            // reporte_conduce_conprecio
            // 
            reporte_conduce_conprecio.Image = (Image)resources.GetObject("reporte_conduce_conprecio.Image");
            reporte_conduce_conprecio.Name = "reporte_conduce_conprecio";
            reporte_conduce_conprecio.Size = new Size(201, 24);
            reporte_conduce_conprecio.Text = "Conduce con Precio";
            reporte_conduce_conprecio.Click += Reporte_conduce_conprecio_Click;
            // 
            // reporte_conduce_sinprecio
            // 
            reporte_conduce_sinprecio.Image = Properties.Resources.report48_48;
            reporte_conduce_sinprecio.Name = "reporte_conduce_sinprecio";
            reporte_conduce_sinprecio.Size = new Size(201, 24);
            reporte_conduce_sinprecio.Text = "Conduce sin Precio";
            reporte_conduce_sinprecio.Click += Reporte_conduce_sinprecio_Click;
            // 
            // reporte_picking_list
            // 
            reporte_picking_list.Image = Properties.Resources.report48_481;
            reporte_picking_list.Name = "reporte_picking_list";
            reporte_picking_list.Size = new Size(201, 24);
            reporte_picking_list.Text = "Reporte Picking List";
            reporte_picking_list.Click += Reporte_picking_list_Click;
            // 
            // reporte_detalle_paleta
            // 
            reporte_detalle_paleta.Image = Properties.Resources.report48_482;
            reporte_detalle_paleta.Name = "reporte_detalle_paleta";
            reporte_detalle_paleta.Size = new Size(201, 24);
            reporte_detalle_paleta.Text = "Detalle de Paleta";
            reporte_detalle_paleta.Click += Reporte_detalle_paleta_Click;
            // 
            // btn_exports
            // 
            btn_exports.DropDownItems.AddRange(new ToolStripItem[] { export_excel, export_pdf });
            btn_exports.Image = (Image)resources.GetObject("btn_exports.Image");
            btn_exports.ImageTransparentColor = Color.Magenta;
            btn_exports.Name = "btn_exports";
            btn_exports.Size = new Size(94, 30);
            btn_exports.Text = "Exportar";
            btn_exports.ButtonClick += btn_exports_ButtonClick;
            // 
            // export_excel
            // 
            export_excel.AccessibleRole = AccessibleRole.Clock;
            export_excel.DropDownItems.AddRange(new ToolStripItem[] { rollosCortadosToolStripMenuItem, opc_exportdata_excel_detallepaleta });
            export_excel.Image = (Image)resources.GetObject("export_excel.Image");
            export_excel.Name = "export_excel";
            export_excel.Size = new Size(182, 24);
            export_excel.Text = "Excel";
            export_excel.Click += Export_excel_Click;
            // 
            // rollosCortadosToolStripMenuItem
            // 
            rollosCortadosToolStripMenuItem.Image = (Image)resources.GetObject("rollosCortadosToolStripMenuItem.Image");
            rollosCortadosToolStripMenuItem.Name = "rollosCortadosToolStripMenuItem";
            rollosCortadosToolStripMenuItem.Size = new Size(182, 24);
            rollosCortadosToolStripMenuItem.Text = "Rollos Cortados";
            rollosCortadosToolStripMenuItem.Click += RollosCortadosToolStripMenuItem_Click;
            // 
            // opc_exportdata_excel_detallepaleta
            // 
            opc_exportdata_excel_detallepaleta.Image = Properties.Resources.DATA_READ481;
            opc_exportdata_excel_detallepaleta.Name = "opc_exportdata_excel_detallepaleta";
            opc_exportdata_excel_detallepaleta.Size = new Size(182, 24);
            opc_exportdata_excel_detallepaleta.Text = "Detalle de Paleta";
            opc_exportdata_excel_detallepaleta.Click += Opc_exportdata_excel_detallepaleta_Click;
            // 
            // export_pdf
            // 
            export_pdf.Image = (Image)resources.GetObject("export_pdf.Image");
            export_pdf.Name = "export_pdf";
            export_pdf.Size = new Size(182, 24);
            export_pdf.Text = "Documento PDF";
            export_pdf.Click += Export_pdf_Click;
            // 
            // btn_close_document
            // 
            btn_close_document.Font = new Font("Segoe UI", 10.18868F);
            btn_close_document.Image = (Image)resources.GetObject("btn_close_document.Image");
            btn_close_document.ImageTransparentColor = Color.Magenta;
            btn_close_document.Name = "btn_close_document";
            btn_close_document.Size = new Size(69, 30);
            btn_close_document.Text = "Cerrar";
            // 
            // btn_label_print
            // 
            btn_label_print.Font = new Font("Segoe UI", 10.18868F);
            btn_label_print.Image = (Image)resources.GetObject("btn_label_print.Image");
            btn_label_print.ImageTransparentColor = Color.Magenta;
            btn_label_print.Name = "btn_label_print";
            btn_label_print.Size = new Size(87, 30);
            btn_label_print.Text = "Etiquetas";
            // 
            // bot_anular
            // 
            bot_anular.Font = new Font("Segoe UI", 10.18868F);
            bot_anular.Image = (Image)resources.GetObject("bot_anular.Image");
            bot_anular.ImageTransparentColor = Color.Magenta;
            bot_anular.Name = "bot_anular";
            bot_anular.Size = new Size(71, 30);
            bot_anular.Text = "Anular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero:";
            // 
            // txt_numero
            // 
            txt_numero.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_numero.Location = new Point(31, 59);
            txt_numero.Margin = new Padding(3, 4, 3, 4);
            txt_numero.Name = "txt_numero";
            txt_numero.ReadOnly = true;
            txt_numero.Size = new Size(125, 26);
            txt_numero.TabIndex = 2;
            // 
            // btn_buscar_customer
            // 
            btn_buscar_customer.Enabled = false;
            btn_buscar_customer.Location = new Point(1082, 59);
            btn_buscar_customer.Margin = new Padding(3, 4, 3, 4);
            btn_buscar_customer.Name = "btn_buscar_customer";
            btn_buscar_customer.Size = new Size(45, 29);
            btn_buscar_customer.TabIndex = 3;
            btn_buscar_customer.Text = "...";
            btn_buscar_customer.UseVisualStyleBackColor = true;
            btn_buscar_customer.Click += Btn_buscar_customer_Click;
            // 
            // txt_custid
            // 
            txt_custid.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_custid.Location = new Point(593, 59);
            txt_custid.Margin = new Padding(3, 4, 3, 4);
            txt_custid.Name = "txt_custid";
            txt_custid.ReadOnly = true;
            txt_custid.Size = new Size(59, 26);
            txt_custid.TabIndex = 4;
            // 
            // txt_custname
            // 
            txt_custname.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_custname.Location = new Point(659, 59);
            txt_custname.Margin = new Padding(3, 4, 3, 4);
            txt_custname.Name = "txt_custname";
            txt_custname.ReadOnly = true;
            txt_custname.Size = new Size(415, 26);
            txt_custname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label2.Location = new Point(591, 39);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Cust. Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label3.Location = new Point(659, 39);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 7;
            label3.Text = "Customer Name:";
            // 
            // txt_fecha_despacho
            // 
            txt_fecha_despacho.Enabled = false;
            txt_fecha_despacho.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_fecha_despacho.Location = new Point(163, 59);
            txt_fecha_despacho.Margin = new Padding(3, 4, 3, 4);
            txt_fecha_despacho.Name = "txt_fecha_despacho";
            txt_fecha_despacho.Size = new Size(337, 26);
            txt_fecha_despacho.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label4.Location = new Point(163, 39);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha Despacho:";
            // 
            // txt_persondelivery
            // 
            txt_persondelivery.Location = new Point(31, 119);
            txt_persondelivery.Margin = new Padding(3, 4, 3, 4);
            txt_persondelivery.Name = "txt_persondelivery";
            txt_persondelivery.ReadOnly = true;
            txt_persondelivery.Size = new Size(371, 26);
            txt_persondelivery.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label5.Location = new Point(31, 95);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 10;
            label5.Text = "Entregar persona:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label6.Location = new Point(8, 176);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Transportista:";
            // 
            // txt_transport_id
            // 
            txt_transport_id.Font = new Font("Segoe UI", 10.18868F);
            txt_transport_id.Location = new Point(100, 173);
            txt_transport_id.Margin = new Padding(3, 4, 3, 4);
            txt_transport_id.Name = "txt_transport_id";
            txt_transport_id.ReadOnly = true;
            txt_transport_id.Size = new Size(38, 26);
            txt_transport_id.TabIndex = 13;
            // 
            // bot_transporte
            // 
            bot_transporte.Enabled = false;
            bot_transporte.Location = new Point(358, 170);
            bot_transporte.Margin = new Padding(3, 4, 3, 4);
            bot_transporte.Name = "bot_transporte";
            bot_transporte.Size = new Size(45, 29);
            bot_transporte.TabIndex = 14;
            bot_transporte.Text = "...";
            bot_transporte.UseVisualStyleBackColor = true;
            bot_transporte.Click += Bot_transporte_Click;
            // 
            // bot_chofer
            // 
            bot_chofer.Enabled = false;
            bot_chofer.Location = new Point(357, 207);
            bot_chofer.Margin = new Padding(3, 4, 3, 4);
            bot_chofer.Name = "bot_chofer";
            bot_chofer.Size = new Size(45, 29);
            bot_chofer.TabIndex = 17;
            bot_chofer.Text = "...";
            bot_chofer.UseVisualStyleBackColor = true;
            bot_chofer.Click += Bot_chofer_Click;
            // 
            // txt_chofer_id
            // 
            txt_chofer_id.Font = new Font("Segoe UI", 10.18868F);
            txt_chofer_id.Location = new Point(100, 209);
            txt_chofer_id.Margin = new Padding(3, 4, 3, 4);
            txt_chofer_id.Name = "txt_chofer_id";
            txt_chofer_id.ReadOnly = true;
            txt_chofer_id.Size = new Size(38, 26);
            txt_chofer_id.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label7.Location = new Point(8, 213);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 15;
            label7.Text = "Chofer:";
            // 
            // bot_camion
            // 
            bot_camion.Enabled = false;
            bot_camion.Location = new Point(358, 243);
            bot_camion.Margin = new Padding(3, 4, 3, 4);
            bot_camion.Name = "bot_camion";
            bot_camion.Size = new Size(45, 29);
            bot_camion.TabIndex = 20;
            bot_camion.Text = "...";
            bot_camion.UseVisualStyleBackColor = true;
            bot_camion.Click += Bot_camion_Click;
            // 
            // txt_camion_id
            // 
            txt_camion_id.Font = new Font("Segoe UI", 10.18868F);
            txt_camion_id.Location = new Point(73, 245);
            txt_camion_id.Margin = new Padding(3, 4, 3, 4);
            txt_camion_id.Name = "txt_camion_id";
            txt_camion_id.ReadOnly = true;
            txt_camion_id.Size = new Size(65, 26);
            txt_camion_id.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label8.Location = new Point(8, 249);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 18;
            label8.Text = "Camion:";
            // 
            // txt_vend_id
            // 
            txt_vend_id.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_vend_id.Location = new Point(418, 119);
            txt_vend_id.Margin = new Padding(3, 4, 3, 4);
            txt_vend_id.Name = "txt_vend_id";
            txt_vend_id.ReadOnly = true;
            txt_vend_id.Size = new Size(125, 26);
            txt_vend_id.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label9.Location = new Point(418, 95);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 21;
            label9.Text = "Vendor Id:";
            // 
            // txt_vendorname
            // 
            txt_vendorname.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_vendorname.Location = new Point(418, 176);
            txt_vendorname.Margin = new Padding(3, 4, 3, 4);
            txt_vendorname.Name = "txt_vendorname";
            txt_vendorname.ReadOnly = true;
            txt_vendorname.Size = new Size(285, 26);
            txt_vendorname.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label10.Location = new Point(418, 153);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 23;
            label10.Text = "Vendor Name:";
            // 
            // bot_buscar_vendor
            // 
            bot_buscar_vendor.Enabled = false;
            bot_buscar_vendor.Location = new Point(551, 120);
            bot_buscar_vendor.Margin = new Padding(3, 4, 3, 4);
            bot_buscar_vendor.Name = "bot_buscar_vendor";
            bot_buscar_vendor.Size = new Size(45, 29);
            bot_buscar_vendor.TabIndex = 25;
            bot_buscar_vendor.Text = "...";
            bot_buscar_vendor.UseVisualStyleBackColor = true;
            bot_buscar_vendor.Click += Bot_buscar_vendor_Click;
            // 
            // txt_tipo_embalaje
            // 
            txt_tipo_embalaje.Font = new Font("Segoe UI", 10.18868F);
            txt_tipo_embalaje.Location = new Point(859, 109);
            txt_tipo_embalaje.Margin = new Padding(3, 4, 3, 4);
            txt_tipo_embalaje.Name = "txt_tipo_embalaje";
            txt_tipo_embalaje.ReadOnly = true;
            txt_tipo_embalaje.Size = new Size(268, 26);
            txt_tipo_embalaje.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label11.Location = new Point(723, 112);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 26;
            label11.Text = "Tipo de Embalaje:";
            // 
            // txt_orden_trabajo
            // 
            txt_orden_trabajo.Font = new Font("Segoe UI", 10.18868F);
            txt_orden_trabajo.Location = new Point(859, 144);
            txt_orden_trabajo.Margin = new Padding(3, 4, 3, 4);
            txt_orden_trabajo.Name = "txt_orden_trabajo";
            txt_orden_trabajo.ReadOnly = true;
            txt_orden_trabajo.Size = new Size(268, 26);
            txt_orden_trabajo.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label12.Location = new Point(746, 149);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 28;
            label12.Text = "Orden Trabajo:";
            // 
            // txt_orden_compra
            // 
            txt_orden_compra.Font = new Font("Segoe UI", 10.18868F);
            txt_orden_compra.Location = new Point(859, 179);
            txt_orden_compra.Margin = new Padding(3, 4, 3, 4);
            txt_orden_compra.Name = "txt_orden_compra";
            txt_orden_compra.ReadOnly = true;
            txt_orden_compra.Size = new Size(268, 26);
            txt_orden_compra.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label13.Location = new Point(744, 183);
            label13.Name = "label13";
            label13.Size = new Size(91, 15);
            label13.TabIndex = 30;
            label13.Text = "Orden Compra:";
            // 
            // txt_tipoventa
            // 
            txt_tipoventa.Font = new Font("Segoe UI", 10.18868F);
            txt_tipoventa.Location = new Point(859, 214);
            txt_tipoventa.Margin = new Padding(3, 4, 3, 4);
            txt_tipoventa.Name = "txt_tipoventa";
            txt_tipoventa.ReadOnly = true;
            txt_tipoventa.Size = new Size(268, 26);
            txt_tipoventa.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label14.Location = new Point(743, 219);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 32;
            label14.Text = "Tipo de Venta:";
            // 
            // bot_picking
            // 
            bot_picking.Enabled = false;
            bot_picking.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bot_picking.Image = (Image)resources.GetObject("bot_picking.Image");
            bot_picking.Location = new Point(418, 229);
            bot_picking.Margin = new Padding(3, 4, 3, 4);
            bot_picking.Name = "bot_picking";
            bot_picking.Size = new Size(286, 45);
            bot_picking.TabIndex = 34;
            bot_picking.Text = "Picking";
            bot_picking.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_picking.UseVisualStyleBackColor = true;
            bot_picking.Click += Bot_picking_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 10.18868F);
            tabControl1.Location = new Point(5, 279);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1233, 338);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grid_items);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1225, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Renglones";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_items
            // 
            grid_items.AllowUserToAddRows = false;
            grid_items.AllowUserToDeleteRows = false;
            grid_items.AllowUserToResizeRows = false;
            grid_items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_items.Location = new Point(7, 7);
            grid_items.Margin = new Padding(3, 4, 3, 4);
            grid_items.Name = "grid_items";
            grid_items.ReadOnly = true;
            grid_items.RowHeadersWidth = 38;
            grid_items.Size = new Size(1210, 288);
            grid_items.TabIndex = 0;
            grid_items.CellEndEdit += Grid_items_CellEndEdit;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grid_rc);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1225, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rollos Cortados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_rc
            // 
            grid_rc.AllowUserToAddRows = false;
            grid_rc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_rc.Location = new Point(7, 7);
            grid_rc.Margin = new Padding(3, 4, 3, 4);
            grid_rc.Name = "grid_rc";
            grid_rc.ReadOnly = true;
            grid_rc.RowHeadersWidth = 45;
            grid_rc.Size = new Size(1215, 288);
            grid_rc.TabIndex = 0;
            // 
            // grid_detalle_paletas
            // 
            grid_detalle_paletas.AllowUserToAddRows = false;
            grid_detalle_paletas.AllowUserToResizeRows = false;
            grid_detalle_paletas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_detalle_paletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_detalle_paletas.Location = new Point(5, 685);
            grid_detalle_paletas.Margin = new Padding(3, 4, 3, 4);
            grid_detalle_paletas.Name = "grid_detalle_paletas";
            grid_detalle_paletas.ReadOnly = true;
            grid_detalle_paletas.RowHeadersWidth = 45;
            grid_detalle_paletas.Size = new Size(612, 152);
            grid_detalle_paletas.TabIndex = 36;
            grid_detalle_paletas.CellClick += Grid_detalle_paletas_CellClick;
            grid_detalle_paletas.CellEndEdit += Grid_detalle_paletas_CellEndEdit;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label15.Location = new Point(5, 664);
            label15.Name = "label15";
            label15.Size = new Size(104, 15);
            label15.TabIndex = 37;
            label15.Text = "Detalle de paleta:";
            // 
            // bot_add_palet
            // 
            bot_add_palet.Enabled = false;
            bot_add_palet.Image = (Image)resources.GetObject("bot_add_palet.Image");
            bot_add_palet.ImageAlign = ContentAlignment.MiddleLeft;
            bot_add_palet.Location = new Point(623, 685);
            bot_add_palet.Margin = new Padding(3, 4, 3, 4);
            bot_add_palet.Name = "bot_add_palet";
            bot_add_palet.Size = new Size(98, 46);
            bot_add_palet.TabIndex = 38;
            bot_add_palet.Text = "Add";
            bot_add_palet.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_add_palet.UseVisualStyleBackColor = true;
            bot_add_palet.Click += Bot_add_palet_Click;
            // 
            // bot_delete_palet
            // 
            bot_delete_palet.Enabled = false;
            bot_delete_palet.Image = Properties.Resources.multiply_32px;
            bot_delete_palet.Location = new Point(623, 739);
            bot_delete_palet.Margin = new Padding(3, 4, 3, 4);
            bot_delete_palet.Name = "bot_delete_palet";
            bot_delete_palet.Size = new Size(98, 46);
            bot_delete_palet.TabIndex = 39;
            bot_delete_palet.Text = "Delete";
            bot_delete_palet.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_delete_palet.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label16.Location = new Point(623, 661);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 41;
            label16.Text = "Acciones:";
            // 
            // txt_subtotal
            // 
            txt_subtotal.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_subtotal.Location = new Point(894, 658);
            txt_subtotal.Margin = new Padding(3, 4, 3, 4);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.ReadOnly = true;
            txt_subtotal.Size = new Size(321, 26);
            txt_subtotal.TabIndex = 43;
            // 
            // txt_itbis
            // 
            txt_itbis.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_itbis.Location = new Point(894, 694);
            txt_itbis.Margin = new Padding(3, 4, 3, 4);
            txt_itbis.Name = "txt_itbis";
            txt_itbis.ReadOnly = true;
            txt_itbis.Size = new Size(321, 26);
            txt_itbis.TabIndex = 44;
            // 
            // txt_totalmonto
            // 
            txt_totalmonto.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_totalmonto.Location = new Point(894, 731);
            txt_totalmonto.Margin = new Padding(3, 4, 3, 4);
            txt_totalmonto.Name = "txt_totalmonto";
            txt_totalmonto.ReadOnly = true;
            txt_totalmonto.Size = new Size(321, 26);
            txt_totalmonto.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label17.Location = new Point(800, 661);
            label17.Name = "label17";
            label17.Size = new Size(78, 15);
            label17.TabIndex = 46;
            label17.Text = "SUB-TOTAL :";
            // 
            // txt_porc_itbis
            // 
            txt_porc_itbis.Location = new Point(840, 694);
            txt_porc_itbis.Margin = new Padding(3, 4, 3, 4);
            txt_porc_itbis.Name = "txt_porc_itbis";
            txt_porc_itbis.ReadOnly = true;
            txt_porc_itbis.Size = new Size(49, 26);
            txt_porc_itbis.TabIndex = 47;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label18.Location = new Point(787, 700);
            label18.Name = "label18";
            label18.Size = new Size(40, 15);
            label18.TabIndex = 48;
            label18.Text = "ITBIS:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label19.Location = new Point(830, 734);
            label19.Name = "label19";
            label19.Size = new Size(49, 15);
            label19.TabIndex = 49;
            label19.Text = "TOTAL :";
            // 
            // chk_impuesto
            // 
            chk_impuesto.AutoSize = true;
            chk_impuesto.Enabled = false;
            chk_impuesto.Location = new Point(629, 813);
            chk_impuesto.Margin = new Padding(3, 4, 3, 4);
            chk_impuesto.Name = "chk_impuesto";
            chk_impuesto.Size = new Size(108, 23);
            chk_impuesto.TabIndex = 50;
            chk_impuesto.Text = "Sin Impuesto";
            chk_impuesto.UseVisualStyleBackColor = true;
            // 
            // txt_palet_kilo_neto
            // 
            txt_palet_kilo_neto.Location = new Point(481, 842);
            txt_palet_kilo_neto.Margin = new Padding(3, 4, 3, 4);
            txt_palet_kilo_neto.Name = "txt_palet_kilo_neto";
            txt_palet_kilo_neto.ReadOnly = true;
            txt_palet_kilo_neto.Size = new Size(63, 26);
            txt_palet_kilo_neto.TabIndex = 51;
            // 
            // txt_palet_kilo_bruto
            // 
            txt_palet_kilo_bruto.Location = new Point(552, 842);
            txt_palet_kilo_bruto.Margin = new Padding(3, 4, 3, 4);
            txt_palet_kilo_bruto.Name = "txt_palet_kilo_bruto";
            txt_palet_kilo_bruto.ReadOnly = true;
            txt_palet_kilo_bruto.Size = new Size(63, 26);
            txt_palet_kilo_bruto.TabIndex = 52;
            // 
            // txt_cant_total
            // 
            txt_cant_total.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_cant_total.Location = new Point(369, 616);
            txt_cant_total.Margin = new Padding(3, 4, 3, 4);
            txt_cant_total.Name = "txt_cant_total";
            txt_cant_total.ReadOnly = true;
            txt_cant_total.Size = new Size(63, 26);
            txt_cant_total.TabIndex = 53;
            // 
            // txt_msi_total
            // 
            txt_msi_total.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_msi_total.Location = new Point(592, 616);
            txt_msi_total.Margin = new Padding(3, 4, 3, 4);
            txt_msi_total.Name = "txt_msi_total";
            txt_msi_total.ReadOnly = true;
            txt_msi_total.Size = new Size(78, 26);
            txt_msi_total.TabIndex = 54;
            // 
            // txt_pie_total
            // 
            txt_pie_total.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_pie_total.Location = new Point(767, 616);
            txt_pie_total.Margin = new Padding(3, 4, 3, 4);
            txt_pie_total.Name = "txt_pie_total";
            txt_pie_total.ReadOnly = true;
            txt_pie_total.Size = new Size(90, 26);
            txt_pie_total.TabIndex = 55;
            // 
            // txt_kilos_total
            // 
            txt_kilos_total.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            txt_kilos_total.Location = new Point(950, 616);
            txt_kilos_total.Margin = new Padding(3, 4, 3, 4);
            txt_kilos_total.Name = "txt_kilos_total";
            txt_kilos_total.ReadOnly = true;
            txt_kilos_total.Size = new Size(92, 26);
            txt_kilos_total.TabIndex = 56;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label20.Location = new Point(294, 619);
            label20.Name = "label20";
            label20.Size = new Size(47, 15);
            label20.TabIndex = 57;
            label20.Text = "T. Cant:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label21.Location = new Point(522, 619);
            label21.Name = "label21";
            label21.Size = new Size(41, 15);
            label21.TabIndex = 58;
            label21.Text = "T. Msi:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label22.Location = new Point(697, 619);
            label22.Name = "label22";
            label22.Size = new Size(39, 15);
            label22.TabIndex = 59;
            label22.Text = "T. Pie:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label23.Location = new Point(880, 619);
            label23.Name = "label23";
            label23.Size = new Size(48, 15);
            label23.TabIndex = 60;
            label23.Text = "T. Kilos:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label24.Location = new Point(481, 875);
            label24.Name = "label24";
            label24.Size = new Size(50, 15);
            label24.TabIndex = 61;
            label24.Text = "T. Neto:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label25.Location = new Point(552, 875);
            label25.Name = "label25";
            label25.Size = new Size(54, 15);
            label25.TabIndex = 62;
            label25.Text = "T. Bruto:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(894, 771);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 132);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // txt_chofer_name
            // 
            txt_chofer_name.Font = new Font("Segoe UI", 10.18868F);
            txt_chofer_name.Location = new Point(144, 209);
            txt_chofer_name.Margin = new Padding(3, 4, 3, 4);
            txt_chofer_name.Name = "txt_chofer_name";
            txt_chofer_name.ReadOnly = true;
            txt_chofer_name.Size = new Size(208, 26);
            txt_chofer_name.TabIndex = 64;
            // 
            // txt_transport_name
            // 
            txt_transport_name.Font = new Font("Segoe UI", 10.18868F);
            txt_transport_name.Location = new Point(144, 174);
            txt_transport_name.Margin = new Padding(3, 4, 3, 4);
            txt_transport_name.Name = "txt_transport_name";
            txt_transport_name.ReadOnly = true;
            txt_transport_name.Size = new Size(208, 26);
            txt_transport_name.TabIndex = 65;
            // 
            // txt_camion_name
            // 
            txt_camion_name.Font = new Font("Segoe UI", 10.18868F);
            txt_camion_name.Location = new Point(144, 245);
            txt_camion_name.Margin = new Padding(3, 4, 3, 4);
            txt_camion_name.Name = "txt_camion_name";
            txt_camion_name.ReadOnly = true;
            txt_camion_name.Size = new Size(208, 26);
            txt_camion_name.TabIndex = 66;
            // 
            // FrmDespacho
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 915);
            Controls.Add(txt_camion_name);
            Controls.Add(txt_transport_name);
            Controls.Add(txt_chofer_name);
            Controls.Add(pictureBox1);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(txt_kilos_total);
            Controls.Add(txt_pie_total);
            Controls.Add(txt_msi_total);
            Controls.Add(txt_cant_total);
            Controls.Add(txt_palet_kilo_bruto);
            Controls.Add(txt_palet_kilo_neto);
            Controls.Add(chk_impuesto);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(txt_porc_itbis);
            Controls.Add(label17);
            Controls.Add(txt_totalmonto);
            Controls.Add(txt_itbis);
            Controls.Add(txt_subtotal);
            Controls.Add(label16);
            Controls.Add(bot_delete_palet);
            Controls.Add(bot_add_palet);
            Controls.Add(label15);
            Controls.Add(grid_detalle_paletas);
            Controls.Add(tabControl1);
            Controls.Add(bot_picking);
            Controls.Add(txt_tipoventa);
            Controls.Add(label14);
            Controls.Add(txt_orden_compra);
            Controls.Add(label13);
            Controls.Add(txt_orden_trabajo);
            Controls.Add(label12);
            Controls.Add(txt_tipo_embalaje);
            Controls.Add(label11);
            Controls.Add(bot_buscar_vendor);
            Controls.Add(txt_vendorname);
            Controls.Add(label10);
            Controls.Add(txt_vend_id);
            Controls.Add(label9);
            Controls.Add(bot_camion);
            Controls.Add(txt_camion_id);
            Controls.Add(label8);
            Controls.Add(bot_chofer);
            Controls.Add(txt_chofer_id);
            Controls.Add(label7);
            Controls.Add(bot_transporte);
            Controls.Add(txt_transport_id);
            Controls.Add(label6);
            Controls.Add(txt_persondelivery);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_fecha_despacho);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_custname);
            Controls.Add(txt_custid);
            Controls.Add(btn_buscar_customer);
            Controls.Add(txt_numero);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 10.18868F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDespacho";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Despacho";
            Load += Despacho_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_items).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_rc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_detalle_paletas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton bot_primero;
        private ToolStripButton bot_siguiente;
        private ToolStripButton bot_anterior;
        private ToolStripButton bot_ultimo;
        private ToolStripButton bot_cancelar;
        private ToolStripButton bot_grabar;
        private ToolStripButton bot_buscar;
        private ToolStripButton bot_anular;
        private Label label1;
        private TextBox txt_numero;
        private Button btn_buscar_customer;
        private TextBox txt_custid;
        private TextBox txt_custname;
        private Label label2;
        private Label label3;
        private DateTimePicker txt_fecha_despacho;
        private Label label4;
        private TextBox txt_persondelivery;
        private Label label5;
        private Label label6;
        private TextBox txt_transport_id;
        private Button bot_transporte;
        private Button bot_chofer;
        private TextBox txt_chofer_id;
        private Label label7;
        private Button bot_camion;
        private TextBox txt_camion_id;
        private Label label8;
        private TextBox txt_vend_id;
        private Label label9;
        private TextBox txt_vendorname;
        private Label label10;
        private Button bot_buscar_vendor;
        private TextBox txt_tipo_embalaje;
        private Label label11;
        private TextBox txt_orden_trabajo;
        private Label label12;
        private TextBox txt_orden_compra;
        private Label label13;
        private TextBox txt_tipoventa;
        private Label label14;
        private Button bot_picking;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView grid_detalle_paletas;
        private Label label15;
        private Button bot_add_palet;
        private Button bot_delete_palet;
        private Label label16;
        private TextBox txt_subtotal;
        private TextBox txt_itbis;
        private TextBox txt_totalmonto;
        private Label label17;
        private TextBox txt_porc_itbis;
        private Label label18;
        private Label label19;
        private DataGridView grid_items;
        private CheckBox chk_impuesto;
        private TextBox txt_palet_kilo_neto;
        private TextBox txt_palet_kilo_bruto;
        private TextBox txt_cant_total;
        private TextBox txt_msi_total;
        private TextBox txt_pie_total;
        private TextBox txt_kilos_total;
        private DataGridView grid_rc;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private ToolStripButton bot_nuevo;
        private PictureBox pictureBox1;
        private TextBox txt_chofer_name;
        private TextBox txt_transport_name;
        private TextBox txt_camion_name;
        private ToolStripSplitButton btn_exports;
        private ToolStripMenuItem export_excel;
        private ToolStripMenuItem export_pdf;
        private ToolStripSplitButton btn_reports;
        private ToolStripMenuItem reporte_conduce_conprecio;
        private ToolStripMenuItem reporte_conduce_sinprecio;
        private ToolStripMenuItem reporte_picking_list;
        private ToolStripMenuItem reporte_detalle_paleta;
        private ToolStripButton btn_label_print;
        private ToolStripButton btn_close_document;
        private ToolStripMenuItem rollosCortadosToolStripMenuItem;
        private ToolStripMenuItem opc_exportdata_excel_detallepaleta;
    }
}