namespace MercadoMagico.Models
{
    public class InstrumentoMagicoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Tipo { get; set; } = String.Empty;    
        public decimal Preco { get; set; }
        public string PropriedadeMagica { get; set; } = String.Empty;
    }
}
