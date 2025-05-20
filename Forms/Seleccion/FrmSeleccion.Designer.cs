namespace Ritrama2025.Forms.Seleccion
{
    partial class FrmSeleccion
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
            Grid_Items = new DataGridView();
            txt_buscar = new TextBox();
            bot_buscar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ra_description = new RadioButton();
            ra_id = new RadioButton();
            Numero_reg = new Label();
            panel1 = new Panel();
            titleform = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_Items).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Grid_Items
            // 
            Grid_Items.AllowUserToAddRows = false;
            Grid_Items.AllowUserToDeleteRows = false;
            Grid_Items.AllowUserToResizeRows = false;
            Grid_Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Items.Location = new Point(12, 140);
            Grid_Items.MultiSelect = false;
            Grid_Items.Name = "Grid_Items";
            Grid_Items.ReadOnly = true;
            Grid_Items.RowHeadersWidth = 36;
            Grid_Items.ScrollBars = ScrollBars.Vertical;
            Grid_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Items.Size = new Size(481, 292);
            Grid_Items.TabIndex = 0;
            Grid_Items.CellMouseDoubleClick += Grid_Items_CellMouseDoubleClick;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(96, 109);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(308, 25);
            txt_buscar.TabIndex = 1;
            // 
            // bot_buscar
            // 
            bot_buscar.Location = new Point(410, 109);
            bot_buscar.Name = "bot_buscar";
            bot_buscar.Size = new Size(83, 25);
            bot_buscar.TabIndex = 2;
            bot_buscar.Text = "Buscar";
            bot_buscar.UseVisualStyleBackColor = true;
            bot_buscar.Click += Bot_buscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 3;
            label1.Text = "Buscar por:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ra_description);
            groupBox1.Controls.Add(ra_id);
            groupBox1.Location = new Point(274, 438);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 92);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar por:";
            // 
            // ra_description
            // 
            ra_description.AutoSize = true;
            ra_description.Checked = true;
            ra_description.Location = new Point(36, 57);
            ra_description.Name = "ra_description";
            ra_description.Size = new Size(85, 21);
            ra_description.TabIndex = 1;
            ra_description.TabStop = true;
            ra_description.Text = "Por Name";
            ra_description.UseVisualStyleBackColor = true;
            // 
            // ra_id
            // 
            ra_id.AutoSize = true;
            ra_id.Location = new Point(36, 30);
            ra_id.Name = "ra_id";
            ra_id.Size = new Size(64, 21);
            ra_id.TabIndex = 0;
            ra_id.Text = "Por Id.";
            ra_id.UseVisualStyleBackColor = true;
            // 
            // Numero_reg
            // 
            Numero_reg.AutoSize = true;
            Numero_reg.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            Numero_reg.Location = new Point(12, 438);
            Numero_reg.Name = "Numero_reg";
            Numero_reg.Size = new Size(119, 17);
            Numero_reg.TabIndex = 5;
            Numero_reg.Text = "Numero de Items:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(titleform);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 84);
            panel1.TabIndex = 6;
            // 
            // titleform
            // 
            titleform.AutoSize = true;
            titleform.Font = new Font("JetBrains Mono ExtraBold", 23.7735825F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleform.Location = new Point(158, 22);
            titleform.Name = "titleform";
            titleform.Size = new Size(146, 47);
            titleform.TabIndex = 0;
            titleform.Text = "label2";
            // 
            // label2
            // 
            label2.Location = new Point(12, 470);
            label2.Name = "label2";
            label2.Size = new Size(160, 60);
            label2.TabIndex = 7;
            label2.Text = "Haga double-click en la fila para seleccionarla ";
            // 
            // FrmSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 542);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(Numero_reg);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(bot_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(Grid_Items);
            Name = "FrmSeleccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccion de Registros:";
            Load += Seleccion_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Items).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_Items;
        private TextBox txt_buscar;
        private Button bot_buscar;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton ra_description;
        private RadioButton ra_id;
        private Label Numero_reg;
        private Panel panel1;
        private Label titleform;
        private Label label2;
    }
}