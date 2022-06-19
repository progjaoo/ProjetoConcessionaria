using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleContas
    {
        RepositoryContas _Repository;

        public ControleContas()
        {
            _Repository = new RepositoryContas();
        }

        public void Incluir(Model.Contas oConta)
        {
            _Repository.Incluir(oConta);
        }
        public void Alterar(Model.Contas oConta)
        {
            _Repository.Alterar(oConta);
        }

        public void Remover(string oConta)
        {
            _Repository.Remover(oConta);
        }

        public List<Model.Contas> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public int ConfirmarConta(string user, string senha)
        {
            return _Repository.ConfirmarConta(user, senha);
        }
    }
}