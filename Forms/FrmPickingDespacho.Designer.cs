namespace Ritrama2025.Forms
{
    partial class FrmPickingDespacho
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            RA_CORTADO = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grid_detallerc = new DataGridView();
            tabPage2 = new TabPage();
            grid_renglones = new DataGridView();
            BOT_DESPACHAR = new Button();
            BOT_LEER_TXT = new Button();
            BOT_ELIMINAR_RENGLON = new Button();
            BOT_CARGAR_RESERVA = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_detallerc).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_renglones).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del Picking-List";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 25);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 39);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Reversa :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 3;
            label2.Text = "Total :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(433, 91);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 21);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Codigo Especial";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 87);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 0;
            label1.Text = "Unique Code:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(RA_CORTADO);
            groupBox2.Location = new Point(615, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(159, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categoria de Producto";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(19, 110);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 21);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Master";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 83);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 21);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Graphics";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hojas";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // RA_CORTADO
            // 
            RA_CORTADO.AutoSize = true;
            RA_CORTADO.Checked = true;
            RA_CORTADO.Location = new Point(19, 29);
            RA_CORTADO.Name = "RA_CORTADO";
            RA_CORTADO.Size = new Size(108, 21);
            RA_CORTADO.TabIndex = 0;
            RA_CORTADO.TabStop = true;
            RA_CORTADO.Text = "Rollo Cortado";
            RA_CORTADO.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 160);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(862, 278);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grid_detallerc);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(854, 248);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Unique Code";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_detallerc
            // 
            grid_detallerc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_detallerc.Location = new Point(6, 9);
            grid_detallerc.Name = "grid_detallerc";
            grid_detallerc.ReadOnly = true;
            grid_detallerc.RowHeadersWidth = 38;
            grid_detallerc.Size = new Size(843, 236);
            grid_detallerc.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grid_renglones);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 248);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Renglones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_renglones
            // 
            grid_renglones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_renglones.Location = new Point(6, 6);
            grid_renglones.Name = "grid_renglones";
            grid_renglones.RowHeadersWidth = 45;
            grid_renglones.Size = new Size(845, 236);
            grid_renglones.TabIndex = 0;
            // 
            // BOT_DESPACHAR
            // 
            BOT_DESPACHAR.Image = Properties.Resources.DATA_DOWNLOAD48;
            BOT_DESPACHAR.Location = new Point(892, 12);
            BOT_DESPACHAR.Name = "BOT_DESPACHAR";
            BOT_DESPACHAR.Size = new Size(160, 63);
            BOT_DESPACHAR.TabIndex = 3;
            BOT_DESPACHAR.Text = "Despachar";
            BOT_DESPACHAR.TextImageRelation = TextImageRelation.ImageBeforeText;
            BOT_DESPACHAR.UseVisualStyleBackColor = true;
            BOT_DESPACHAR.Click += BOT_DESPACHAR_Click;
            // 
            // BOT_LEER_TXT
            // 
            BOT_LEER_TXT.Image = Properties.Resources.DATA_READ48;
            BOT_LEER_TXT.Location = new Point(892, 81);
            BOT_LEER_TXT.Name = "BOT_LEER_TXT";
            BOT_LEER_TXT.Size = new Size(160, 63);
            BOT_LEER_TXT.TabIndex = 4;
            BOT_LEER_TXT.Text = "Leer Data TXT";
            BOT_LEER_TXT.TextImageRelation = TextImageRelation.ImageBeforeText;
            BOT_LEER_TXT.UseVisualStyleBackColor = true;
            BOT_LEER_TXT.Click += Button2_Click;
            // 
            // BOT_ELIMINAR_RENGLON
            // 
            BOT_ELIMINAR_RENGLON.Image = Properties.Resources.ROWDELETE48;
            BOT_ELIMINAR_RENGLON.Location = new Point(892, 219);
            BOT_ELIMINAR_RENGLON.Name = "BOT_ELIMINAR_RENGLON";
            BOT_ELIMINAR_RENGLON.Size = new Size(160, 63);
            BOT_ELIMINAR_RENGLON.TabIndex = 5;
            BOT_ELIMINAR_RENGLON.Text = "Borrar Renglon";
            BOT_ELIMINAR_RENGLON.TextImageRelation = TextImageRelation.ImageBeforeText;
            BOT_ELIMINAR_RENGLON.UseVisualStyleBackColor = true;
            // 
            // BOT_CARGAR_RESERVA
            // 
            BOT_CARGAR_RESERVA.Image = Properties.Resources.DATA_RESERVA48;
            BOT_CARGAR_RESERVA.Location = new Point(892, 150);
            BOT_CARGAR_RESERVA.Name = "BOT_CARGAR_RESERVA";
            BOT_CARGAR_RESERVA.Size = new Size(160, 63);
            BOT_CARGAR_RESERVA.TabIndex = 6;
            BOT_CARGAR_RESERVA.Text = "Reserva";
            BOT_CARGAR_RESERVA.TextImageRelation = TextImageRelation.ImageBeforeText;
            BOT_CARGAR_RESERVA.UseVisualStyleBackColor = true;
            // 
            // FrmPickingDespacho
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(BOT_ELIMINAR_RENGLON);
            Controls.Add(BOT_CARGAR_RESERVA);
            Controls.Add(BOT_DESPACHAR);
            Controls.Add(BOT_LEER_TXT);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPickingDespacho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Picking Despacho";
            Load += FrmPickingDespacho_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_detallerc).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_renglones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton RA_CORTADO;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BOT_DESPACHAR;
        private Button BOT_LEER_TXT;
        private Button BOT_ELIMINAR_RENGLON;
        private Button BOT_CARGAR_RESERVA;
        private DataGridView grid_detallerc;
        private DataGridView grid_renglones;
    }
}