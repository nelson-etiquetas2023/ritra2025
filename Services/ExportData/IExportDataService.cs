
namespace Ritrama2025.Services.ExportData
{
    public interface IExportDataService
    {
        bool ExportToExcel<T>(List<T> data,string FileName) ;        
    }
}
