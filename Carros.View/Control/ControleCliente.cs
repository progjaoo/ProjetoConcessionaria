using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleClientes
    {
        RepositoryCliente _Repository;

        public ControleClientes()
        {
            _Repository = new RepositoryCliente();
        }

        public void Incluir(Model.Clientes oCliente)
        {
            _Repository.Incluir(oCliente);
        }
        public void Alterar(Model.Clientes oCliente)
        {
            _Repository.Alterar(oCliente);
        }

        public void Remover(int id)
        {
            _Repository.Remover(id);
        }

        public List<Model.Clientes> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public List<Model.Clientes> PesquisarNome(string text)
        {
            return _Repository.PesquisarNome(text);
        }

        public int AcharId(string cpf)
        {
            return _Repository.AcharId(cpf);
        }

        public Array SelecionarUm(int id)
        {
            return _Repository.SelecioarUm(id);
        }

    }
}