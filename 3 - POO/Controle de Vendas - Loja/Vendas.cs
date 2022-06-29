namespace Projeto6
{
    public class Vendas
    {
        private string _descricao;
        private decimal _valorTotal;
        private Cliente _cliente;

        public string Descricao
        { 
            get { return _descricao; }
            set { _descricao = value; }
        }

        public decimal ValorTotal
        { 
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Vendas(Cliente clienteVenda)
        {
            Cliente = clienteVenda;
        }

    }
}