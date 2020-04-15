namespace Alura.Loja.Testes.ConsoleApp
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        public Endereco EnderecoDeEntrega { get; set; }
        public string Nome { get; internal set; }
    }
}