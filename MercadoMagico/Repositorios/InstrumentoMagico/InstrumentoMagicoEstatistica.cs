using MercadoMagico.Data;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MercadoMagico.Repositorios.InstrumentoMagico
{
    public class InstrumentoMagicoEstatistica : IInstrumentoMagicoEstatistica
    {
        private readonly DataContext _dbContext;

        public InstrumentoMagicoEstatistica(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public decimal CalculateTotalPriceByType(string tipo)
        {
            tipo = tipo.ToUpper();

            var instrumentos = _dbContext.InstrumentosMagicos
                .Where(i => i.Tipo.ToUpper() == tipo)
                .ToList();

            decimal totalPrice = instrumentos.Sum(i => i.Preco);

            return totalPrice;
        }
    }
}
