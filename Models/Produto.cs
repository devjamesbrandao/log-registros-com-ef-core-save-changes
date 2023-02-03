namespace Log.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}