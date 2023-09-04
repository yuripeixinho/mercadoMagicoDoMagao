namespace MercadoMagico.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Senha { get; set; } = String.Empty;
    }
}