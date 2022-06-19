using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleConcessionaria
    {
        RepositoryConcessionaria _Repository;

        public ControleConcessionaria()
        {
            _Repository = new RepositoryConcessionaria();
        }

        public void Incluir(Model.Concessionarias oConcessionaria)
        {
            _Repository.Incluir(oConcessionaria);
        }
        public void Alterar(Model.Concessionarias oConcessionaria)
        {
            _Repository.Alterar(oConcessionaria);
        }

        public void Remover(int id)
        {
            _Repository.Remover(id);
        }

        public List<Model.Concessionarias> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public List<Model.Concessionarias> PesquisarNome(string text)
        {
            return _Repository.PesquisarNome(text);
        }

        public Array SelecionarUm(int id)
        {
            return _Repository.SelecioarUm(id);
        }
    }
}