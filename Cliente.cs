namespace ModeloAnemico1
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public Cliente(int externalId, string externalNome, string externalEndereco)
        {
            Validar(externalId, externalNome, externalEndereco);
            Id = externalId;
            Nome = externalNome;
            Endereco = externalEndereco;
        }

        public void Update(int externalId, string externalNome, string externalEndereco)
        {
            Validar(externalId, externalNome, externalEndereco);
            Id = externalId;
            Nome = externalNome;
            Endereco = externalEndereco;
        }

        public void Validar(int externalId, string externalNome, string externalEndereco)
        {
            if(externalId < 0)
            {
                throw new InvalidOperationException("O Id tem que ser maior que 0");
            }

            if(string.IsNullOrEmpty(externalNome) || string.IsNullOrEmpty(externalEndereco))
            {
                throw new InvalidOperationException("Por favor preencha os campos!");
            }

            if(externalNome.Length < 3)
            {
                throw new ArgumentException("O nome deve ter no mínimo 3 caracteres");
            }

            if(externalNome.Length > 100)
            {
                throw new ArgumentException("O nome excedeu 100 caracteres");
            }
        }
    }
}