namespace sistemaApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public string? categoria { get; set; }
        public decimal Preco {  get; set; }
        public bool EstoqueBaixo => Quantidade < 5;
    }
}

