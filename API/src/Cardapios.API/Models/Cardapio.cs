namespace Cardapios.API.Models
{
    public class Cardapio
    {
        public int CardapioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }
        public string Prato { get; set; }

        
    }
}