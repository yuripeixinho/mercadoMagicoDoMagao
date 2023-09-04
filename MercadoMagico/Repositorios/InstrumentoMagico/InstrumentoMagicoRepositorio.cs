using MercadoMagico.Data;
using MercadoMagico.Models;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MercadoMagico.Repositorios.InstrumentoMagico
{
    public class InstrumentoMagicoRepositorio : IInstrumentoMagicoRepositorio
    {
        private readonly DataContext _dbContext;

        public InstrumentoMagicoRepositorio(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<InstrumentoMagicoModel>> ListAll()
        {
            return await _dbContext.InstrumentosMagicos.ToListAsync();
        }

        public async Task<InstrumentoMagicoModel> GetById(int id)
        {
            return await _dbContext.InstrumentosMagicos
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<InstrumentoMagicoModel> Add(InstrumentoMagicoModel instrumentoMagico)
        {
            await _dbContext.InstrumentosMagicos.AddAsync(instrumentoMagico);
            await _dbContext.SaveChangesAsync();

            return instrumentoMagico;
        }

        public async Task<InstrumentoMagicoModel> Update(InstrumentoMagicoModel instrumentoMagico, int id)
        {
            var instrumentoMagicoPorId = await _dbContext.InstrumentosMagicos.FindAsync(id);

            if (instrumentoMagicoPorId == null)
            {
                throw new Exception($"Instrumento mágico com o ID: {id} não foi encontrado.");
            }

            instrumentoMagicoPorId.Nome = instrumentoMagico.Nome;
            instrumentoMagicoPorId.Tipo = instrumentoMagico.Tipo;
            instrumentoMagicoPorId.Preco = instrumentoMagico.Preco;
            instrumentoMagicoPorId.PropriedadeMagica = instrumentoMagico.PropriedadeMagica;

            _dbContext.InstrumentosMagicos.Update(instrumentoMagicoPorId);
            await _dbContext.SaveChangesAsync();

            return instrumentoMagicoPorId;
        }

        public async Task<bool> Delete(int id)
        {
            InstrumentoMagicoModel instrumentoMagicoPorId = await GetById(id);

            if (instrumentoMagicoPorId == null)
            {
                throw new Exception($"Instrumento mágico com o ID: {id} não foi encontrado.");
            }

            _dbContext.InstrumentosMagicos.Remove(instrumentoMagicoPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
