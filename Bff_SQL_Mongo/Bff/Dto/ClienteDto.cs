namespace Bff.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeMae { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}