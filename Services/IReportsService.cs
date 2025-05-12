
namespace Ritrama2025.Services
{
    public interface IReportsService
    {
        public void ReporteConduce_conPrecio(string conduce, Form form,string ReportName);
        public void ReporteCondece_sinPrecio(string conduce, Form form, string ReportName);
        public void Reporte_PackingList();
        public void Reporte_DetallePaleta();
    }
}
