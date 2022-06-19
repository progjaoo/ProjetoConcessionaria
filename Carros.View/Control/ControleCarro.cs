using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleCarros
    {
        RepositoryCarro _Repository;

        public ControleCarros()
        {
            _Repository = new RepositoryCarro();
        }

        public void Incluir(Model.Carros oCarro)
        {
            _Repository.Incluir(oCarro);
        }
        public void Alterar(Model.Carros oCarro)
        {
            _Repository.Alterar(oCarro);
        }

        public void Remover(int id)
        {
            _Repository.Remover(id);
        }

        public List<Model.Carros> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public List<Model.Carros> PesquisarNome(string text)
        {
            return _Repository.PesquisarNome(text);
        }

        public Array SelecionarUm(int id)
        {
            return _Repository.SelecioarUm(id);
        }

    }
}