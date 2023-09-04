using MercadoMagico.Models;

namespace MercadoMagico.Repositorios.Interfaces
{
    public interface IInstrumentoMagicoRepositorio
    {
        Task<List<InstrumentoMagicoModel>> ListAll();
        Task<InstrumentoMagicoModel> GetById(int id);
        Task<InstrumentoMagicoModel> Add(InstrumentoMagicoModel instrumentoMagico);
        Task<InstrumentoMagicoModel> Update(InstrumentoMagicoModel instrumentoMagico, int id);    
        Task<bool> Delete(int id);

    }

    public interface IInstrumentoMagicoEstatistica
    {
        decimal CalculateTotalPriceByType(string tipo);
    }

    public interface IInstrumentoMagicoBusca
    {
        List<InstrumentoMagicoModel> SearchByMagicProperty(string searchTerm);
    }

}
