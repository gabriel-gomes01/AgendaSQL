namespace AgendaSQL.Entities
{
    internal class contatos
    {
        public string nome { get; set; }
        public string telefone { get; set; }

        public contatos(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
