namespace ProjetoFinanceiro.Models
{
    public class Cliente
    {
        #region Props

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public ContaCorrente ContaCorrente { get; set; }

        #endregion
    }
}