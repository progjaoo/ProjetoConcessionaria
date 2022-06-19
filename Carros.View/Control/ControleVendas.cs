using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleVendas
    {
        RepositoryVenda _Repository;

        public ControleVendas()
        {
            _Repository = new RepositoryVenda();
        }

        public void Incluir(Model.Vendas oVenda)
        {
            _Repository.Incluir(oVenda);
        }
        public void Alterar(Model.Vendas oVenda)
        {
            _Repository.Alterar(oVenda);
        }

        public void Remover(int id)
        {
            _Repository.Remover(id);
        }

        public List<Model.Vendas> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public List<Model.Vendas> PesquisarNome(string text)
        {
            return _Repository.PesquisarNome(text);
        }

        public Array SelecionarUm(int id)
        {
            return _Repository.SelecioarUm(id);
        }

    }
}