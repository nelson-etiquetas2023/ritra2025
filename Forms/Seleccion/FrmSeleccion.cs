using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritrama2025.Forms.Seleccion
{
    public partial class FrmSeleccion : Form
    {
        public FrmSeleccion()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTable DtItems { get; set; } = null!;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Id { get; set; } = null!;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Description { get; set; } = null!;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo { get; set; } = null!;

        DataView Dv = new();
        private void Seleccion_Load(object sender, EventArgs e)
        {
            Dv = DtItems.DefaultView;
            Grid_Items.AutoGenerateColumns = false;
            EstilosGrid();
            Dv.RowFilter = "";
            Grid_Items.DataSource = Dv;
            Numero_reg.Text = Convert.ToString(Dv.Count) + " Registro Encontrados";
            titleform.Text = Titulo;
            bot_buscar.Focus();
        }
        private void BuscarItems()
        {
            if (ra_id.Checked)
            {
                Dv.RowFilter = "customer_id like '%" + txt_buscar.Text + "%'";
            }
            if (ra_description.Checked)
            {
                Dv.RowFilter = "customer_name like '%" + txt_buscar.Text + "%'";
            }

        }
        private void EstilosGrid()
        {
            DataGridViewTextBoxColumn col1 = new()
            {
                Name = "customer_id",
                Width = 80,
                HeaderText = "Codigo",
                DataPropertyName = "customer_id"
            };
            Grid_Items.Columns.Add(col1);
            DataGridViewTextBoxColumn col2 = new()
            {
                Name = "customer_name",
                Width = 280,
                HeaderText = "Nombre del Clinete",
                DataPropertyName = "customer_name"
            };
            Grid_Items.Columns.Add(col2);
        }

        private void Bot_buscar_Click(object sender, EventArgs e)
        {
            BuscarItems();
        }

        private void Grid_Items_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Id = Grid_Items.Rows[e.RowIndex].Cells[0].Value!.ToString()!;
            Description = Grid_Items.Rows[e.RowIndex].Cells[1].Value!.ToString()!;
            this.Close();
        }
    }
}
