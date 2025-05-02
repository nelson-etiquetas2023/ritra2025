namespace Ritrama2025
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            bot_products = new Button();
            bot_recepciones = new Button();
            bot_inventario = new Button();
            bot_despacho = new Button();
            bot_ordencorte = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(bot_products);
            panel1.Controls.Add(bot_recepciones);
            panel1.Controls.Add(bot_inventario);
            panel1.Controls.Add(bot_despacho);
            panel1.Controls.Add(bot_ordencorte);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 536);
            panel1.TabIndex = 0;
            // 
            // bot_products
            // 
            bot_products.Dock = DockStyle.Top;
            bot_products.FlatAppearance.BorderSize = 0;
            bot_products.FlatStyle = FlatStyle.Flat;
            bot_products.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_products.Image = (Image)resources.GetObject("bot_products.Image");
            bot_products.Location = new Point(0, 280);
            bot_products.Name = "bot_products";
            bot_products.Size = new Size(221, 70);
            bot_products.TabIndex = 5;
            bot_products.Text = "Productos";
            bot_products.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_products.UseVisualStyleBackColor = true;
            // 
            // bot_recepciones
            // 
            bot_recepciones.Dock = DockStyle.Top;
            bot_recepciones.FlatAppearance.BorderSize = 0;
            bot_recepciones.FlatStyle = FlatStyle.Flat;
            bot_recepciones.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_recepciones.Image = Properties.Resources.add_to_clipboard_48px;
            bot_recepciones.Location = new Point(0, 210);
            bot_recepciones.Name = "bot_recepciones";
            bot_recepciones.Size = new Size(221, 70);
            bot_recepciones.TabIndex = 4;
            bot_recepciones.Text = "Recepciones";
            bot_recepciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_recepciones.UseVisualStyleBackColor = true;
            // 
            // bot_inventario
            // 
            bot_inventario.Dock = DockStyle.Top;
            bot_inventario.FlatAppearance.BorderSize = 0;
            bot_inventario.FlatStyle = FlatStyle.Flat;
            bot_inventario.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_inventario.Image = Properties.Resources.procurement_48px;
            bot_inventario.Location = new Point(0, 140);
            bot_inventario.Name = "bot_inventario";
            bot_inventario.Size = new Size(221, 70);
            bot_inventario.TabIndex = 3;
            bot_inventario.Text = "Inventario";
            bot_inventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_inventario.UseVisualStyleBackColor = true;
            // 
            // bot_despacho
            // 
            bot_despacho.Dock = DockStyle.Top;
            bot_despacho.FlatAppearance.BorderSize = 0;
            bot_despacho.FlatStyle = FlatStyle.Flat;
            bot_despacho.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_despacho.Image = Properties.Resources.product_48px;
            bot_despacho.Location = new Point(0, 70);
            bot_despacho.Name = "bot_despacho";
            bot_despacho.Size = new Size(221, 70);
            bot_despacho.TabIndex = 2;
            bot_despacho.Text = "Despacho";
            bot_despacho.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_despacho.UseVisualStyleBackColor = true;
            bot_despacho.Click += bot_despacho_Click;
            // 
            // bot_ordencorte
            // 
            bot_ordencorte.Dock = DockStyle.Top;
            bot_ordencorte.FlatAppearance.BorderSize = 0;
            bot_ordencorte.FlatStyle = FlatStyle.Flat;
            bot_ordencorte.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bot_ordencorte.Image = (Image)resources.GetObject("bot_ordencorte.Image");
            bot_ordencorte.Location = new Point(0, 0);
            bot_ordencorte.Name = "bot_ordencorte";
            bot_ordencorte.Size = new Size(221, 70);
            bot_ordencorte.TabIndex = 1;
            bot_ordencorte.Text = "Orden Corte";
            bot_ordencorte.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_ordencorte.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(935, 536);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bot_ordencorte;
        private Button bot_products;
        private Button bot_recepciones;
        private Button bot_inventario;
        private Button bot_despacho;
    }
}