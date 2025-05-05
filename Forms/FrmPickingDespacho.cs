using Ritrama2025.Services;
using Ritrama2025.Models;
using System.Transactions;
using System.ComponentModel;

namespace Ritrama2025.Forms
{
    public partial class FrmPickingDespacho : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<RolloCortado> Lista_Rollos { get; set; } = [];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<ItemsDespacho> Lista_Items { get; set; } = [];

        readonly List<Recepcion> Lista_Hojas = [];
        readonly List<Recepcion> Lista_Graphics = [];
        readonly List<Recepcion> Lista_Master = [];
        public CommonService servicio = null!;
        

        public FrmPickingDespacho()
        {
            InitializeComponent();
        }


        private void FrmPickingDespacho_Load(object sender, EventArgs e)
        {
            servicio = new CommonService();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Lista_Rollos.RemoveAll((RolloCortado r) => r.Cantidad >= 0);
            Lista_Graphics.RemoveAll((Recepcion r) => r.Palet_cant >= 0m);
            Lista_Hojas.RemoveAll((Recepcion r) => r.Palet_cant >= 0m);
            Lista_Master.RemoveAll((Recepcion r) => r.Palet_cant >= 0m);

            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = @"\Users\siste\OneDrive\Documentos\APPRITRAMA\data",
                Title = "Selecciona el archivo TXT para cargalo al despacho",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Archivos TXT (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (RA_CORTADO.Checked)
            {
                //crea la lista de rollo cortado solamente cwon el dato del unique code
                var task = Task.Run(async () =>
                {

                    return await ExtraerDataAppMovil(openFileDialog.FileName);
                });

                Lista_Rollos = task.Result;
                //aplicar estilos a los grid.
                EstilosGrid();
                var QueryItem = from p in Lista_Rollos
                                orderby p.Product_Id descending
                                orderby p.Width
                                group p by new { p.Product_Id, p.Width, p.Length } into g
                                select new ItemsDespacho
                                {
                                    Product_id = g.First().Product_Id,
                                    Product_name = g.First().Product_Name,
                                    Cantidad = g.Count(),
                                    Width = g.First().Width,
                                    Unidad ="ROLLO",
                                    Lenght = g.First().Length,
                                    Msi = g.First().Msi,
                                    Code_Person = g.First().Code_Person
                                };


                grid_renglones.AutoGenerateColumns = false;
                AGREGAR_COLUMN_GRID("product_id", 60, "Product Id.", "product_id", grid_renglones);
                AGREGAR_COLUMN_GRID("product_name", 180, "Nombre del Producto", "product_name", grid_renglones);
                AGREGAR_COLUMN_GRID("unidad",70, "Unidad", "unidad", grid_renglones);

                AGREGAR_COLUMN_GRID("cantidad", 80, "Cantidad", "cantidad", grid_renglones);
                AGREGAR_COLUMN_GRID("width", 80, "Width", "width", grid_renglones);
                AGREGAR_COLUMN_GRID("Lenght", 80, "Largo", "Lenght", grid_renglones);
                AGREGAR_COLUMN_GRID("msi", 80, "Msi", "msi", grid_renglones);
                AGREGAR_COLUMN_GRID("Code_Person", 80, "Msi", "Code_Person", grid_renglones);
                grid_renglones.DataSource = QueryItem.ToList();
                Lista_Items = [.. QueryItem];
            }
        }

        private void EstilosGrid()
        {
            grid_detallerc.AutoGenerateColumns = false;
            //grid de rollo detalle rc
            AGREGAR_COLUMN_GRID("UniqueCode", 65, "Codigo Unico", "UniqueCode", grid_detallerc);
            AGREGAR_COLUMN_GRID("product_id", 60, "Product Id.", "product_id", grid_detallerc);
            AGREGAR_COLUMN_GRID("product_name", 180, "Nombre del Producto", "product_name", grid_detallerc);
            AGREGAR_COLUMN_GRID("RollNumber", 60, "Roll Number", "RollNumber", grid_detallerc);
            AGREGAR_COLUMN_GRID("width", 50, "Width", "width", grid_detallerc);
            AGREGAR_COLUMN_GRID("Length", 58, "Largo", "Length", grid_detallerc);
            AGREGAR_COLUMN_GRID("msi", 54, "Msi", "msi", grid_detallerc);
            AGREGAR_COLUMN_GRID("Splice", 50, "Splice", "Splice", grid_detallerc);
            AGREGAR_COLUMN_GRID("roll_id", 72, "Roll Id.", "roll_id", grid_detallerc);
            AGREGAR_COLUMN_GRID("code_person", 74, "Codigo Perso.", "code_person", grid_detallerc);

            grid_detallerc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detallerc.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detallerc.Columns[4].DefaultCellStyle.Format = "###,##0.00";
            grid_detallerc.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detallerc.Columns[5].DefaultCellStyle.Format = "###,##0.00";
            grid_detallerc.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detallerc.Columns[6].DefaultCellStyle.Format = "###,##0.00";
            grid_detallerc.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detallerc.Columns[7].DefaultCellStyle.Format = "##";
            grid_detallerc.Columns[8].DefaultCellStyle.Format = "##";

            grid_detallerc.DataSource = Lista_Rollos;
        }

        public async Task<List<RolloCortado>> ExtraerDataAppMovil(string file)
        {
            //leer txt de picking
            List<RolloCortado> rollos = [];
            if (File.Exists(file))
            {
                try
                {
                    using StreamReader sr = new(file);
                    while (sr.Peek() >= 0)
                    {
                        try
                        {
                            string row = sr.ReadLine()!;
                            string[] data = row.Split(',');
                            string item = data[0];
                            RolloCortado rollo = new()
                            {
                                UniqueCode = data[0],
                                Paleta = data[1],
                                
                            };
                            rollos.Add(rollo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error al leer la data y convertir el archivo txt de despacho: " + ex);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("error al tratar de crear el txt de despacho" + ex2);
                }
            }
            //llenar la lista de rollo cortado.
            await servicio.GetDataRolloCortado(rollos);
            return rollos;
        }
        private static void AGREGAR_COLUMN_GRID(string name, int size, string title, string field_bd, DataGridView grid)
        {
            DataGridViewTextBoxColumn dataGridViewColumn = new()
            {
                Name = name,
                Width = size,
                HeaderText = title,
                DataPropertyName = field_bd
            };
            grid.Columns.Add(dataGridViewColumn);
        }

        private void BOT_DESPACHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
