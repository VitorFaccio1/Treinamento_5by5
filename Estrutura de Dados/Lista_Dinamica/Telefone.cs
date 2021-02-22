namespace Lista_Dinamica_Simplesmente_Encadeada
{
    public class Telefone
    {
        public long Numero { get; set; }
        public int DDD { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return $"------TELEFONE------\nDDD: {DDD}\nNumero: {Numero}\nTipo: {Tipo}";
        }
    }
}