using MercadoMagico.Models;
using Microsoft.EntityFrameworkCore;

namespace MercadoMagico.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
       {
       }

        public DbSet<InstrumentoMagicoModel> InstrumentosMagicos => Set<InstrumentoMagicoModel>();
        public DbSet<UsuarioModel> Usuarios => Set<UsuarioModel>();
    }
}
