using ClosedXML.Excel;
using System.Diagnostics;
using System.Reflection;


namespace Ritrama2025.Services.ExportData
{
    public class ExportDataService : IExportDataService
    {
        public bool ExportToExcel<T>(List<T> data, string FileName)
        {
            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("La coleccion de datos no puede ser vacia.", nameof(data));
            }
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add(typeof(T).Name);

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead)
                .ToArray();

            // 1. Escribir encabezados
            for (int col = 0; col < properties.Length; col++)
            {
                worksheet.Cell(1, col + 1).Value = properties[col].Name;
                // Opcional: dar formato de negrita
                worksheet.Cell(1, col + 1).Style.Font.Bold = true;
            }

            // 2. Rellenar filas con los valores de cada entidad
            int row = 2;
            foreach (var item in data)
            {
                for (int col = 0; col < properties.Length; col++)
                {
                    var value = properties[col].GetValue(item);
                    worksheet.Cell(row, col + 1).Value = XLCellValue.FromObject(value); // Conversión explícita
                }
                row++;
            }

            // 3. Autoajustar ancho de columnas
            worksheet.Columns().AdjustToContents();
            string filePath = Path.Combine(Environment.CurrentDirectory, FileName);
            // 4. Guardar el archivo
            workbook.SaveAs(filePath);

            // 5) Lanzar Excel automáticamente
            var psi = new ProcessStartInfo
            {
                FileName = filePath,      // Abre con la app por defecto (.xlsx → Excel)
                UseShellExecute = true     // Necesario en .NET Core/5+ para usar la asociación de ficheros
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el archivo automáticamente: {ex.Message}");
            }
            return true;
        }
    }
}
