using Ritrama2025.Models;
using System.Data;

namespace Ritrama2025.Services
{
    public interface IDespachoService
    {
        Task<DataSet> LoadDataDespachos();
        Despacho GetDespachoById(int id);
        string GetNumberConsec();
        decimal GetRatioProductById(string product_id);
        void AddDocumentDespacho(Despacho document);
        void AddPickingListDespacho(List<RolloCortado> PickingList);
        void AddPaletDetailsDespacho(List<Paleta> paleta);
    }
}
