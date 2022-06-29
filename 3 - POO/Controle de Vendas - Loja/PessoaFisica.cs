namespace Projeto6
{
    public class PessoaFisica : Cliente
    {
        private string _cpf;

        public string Cpf
        {   
            get { return _cpf; }
            set { _cpf = value; } 
        }

        public PessoaFisica(string nome, string telefone, string cpf, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}