namespace Projeto6
{
    public class PessoaJuridica : Cliente
    {
        private string _cnpj;

        public string Cnpj
        {   
            get { return _cnpj; }
            set { _cnpj = value; } 
        }

        public PessoaJuridica(string nome, string telefone, string cnpj, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Cnpj = cnpj;
            Endereco = endereco;
        }
    }
}