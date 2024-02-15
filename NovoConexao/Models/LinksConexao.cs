namespace NovoConexao.Models
{
    public class LinksConexao
    {
        public required string Negocio { get; set; }

        public string? Categoria { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public string? LinkAcesso { get; set; }
    }
}
