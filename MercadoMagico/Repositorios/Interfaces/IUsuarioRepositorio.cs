using MercadoMagico.Models;

namespace MercadoMagico.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> GetById(int id);
        Task<UsuarioModel> Add(UsuarioModel usuario);
        Task<bool> Delete(int id);

    }
}
