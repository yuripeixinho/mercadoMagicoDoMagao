using MercadoMagico.Data;
using MercadoMagico.Models;
using MercadoMagico.Repositorios.Interfaces;

namespace MercadoMagico.Repositorios.InstrumentoMagico
{
    public class InstrumentoMagicoBusca : IInstrumentoMagicoBusca
    {

        private readonly DataContext _dbContext;

        public InstrumentoMagicoBusca(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public List<InstrumentoMagicoModel> SearchByMagicProperty(string searchTerm)
        {
            var allInstrumentosMagicos = _dbContext.InstrumentosMagicos.ToList();
            var results = allInstrumentosMagicos
                .Where(i => i.PropriedadeMagica.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return results;
        }
    }
}
