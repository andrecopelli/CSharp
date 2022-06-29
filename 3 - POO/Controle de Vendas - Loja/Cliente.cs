namespace Projeto6
{
    public class Cliente
    {
        private string _nome;
        private string _telefone;
        private Endereco _endereco;

        public string Nome
        {   
            get { return _nome; }
            set { _nome = value; } 
        }
        
        public string Telefone
        {   
            get { return _telefone; }
            set { _telefone = value; } 
        }
        public Endereco Endereco
        {   
            get { return _endereco; }
            set { _endereco = value; } 
        }

    }
}