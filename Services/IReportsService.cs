
namespace Ritrama2025.Services
{
    public interface IReportsService
    {
        public void ReporteConduce_conPrecio(string conduce, Form form,string ReportName,string TitleReport);
        public void ReporteCondece_sinPrecio(string conduce, Form form, string ReportName,string TitleReport);
        public void Reporte_PackingList(string conduce,Form form);
        public void Reporte_DetallePaleta(string conduce,Form form);
    }
}
