using Ritrama2025.Services;
using Ritrama2025.Models;
using System.Transactions;

namespace Ritrama2025.Forms
{
    public partial class FrmPickingDespacho : Form
    {
        readonly List<RolloCortado> Lista_Rollos = [];
        List<RolloCortado> Lista_Rollos_f = [];
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
                var task = Task.Run(async () => { 
                
                    return await ExtraerDataAppMovil(openFileDialog.FileName);
                });

                Lista_Rollos_f = task.Result;
            }
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
    }
}
