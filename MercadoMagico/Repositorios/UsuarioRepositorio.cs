using MercadoMagico.Data;
using MercadoMagico.Models;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MercadoMagico.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly DataContext _dbContext;

        public UsuarioRepositorio(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<UsuarioModel> GetById(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UsuarioModel> Add(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }


        public async Task<bool> Delete(int id)
        {
            UsuarioModel usuarioById = await GetById(id);

            if (usuarioById == null)
            {
                throw new Exception($"Usuário com o ID: {id} não foi encontrado.");
            }

            _dbContext.Usuarios.Remove(usuarioById);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
