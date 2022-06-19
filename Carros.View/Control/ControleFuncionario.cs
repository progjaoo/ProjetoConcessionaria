using Carros.Model.Repositorios;

namespace Carros.View.Control
{
    public class ControleFuncionarios
    {
        RepositoryFuncionario _Repository;

        public ControleFuncionarios()
        {
            _Repository = new RepositoryFuncionario();
        }

        public void Incluir(Model.Funcionarios oFuncionario)
        {
            _Repository.Incluir(oFuncionario);
        }
        public void Alterar(Model.Funcionarios oFuncionario)
        {
            _Repository.Alterar(oFuncionario);
        }

        public void Remover(int id)
        {
            _Repository.Remover(id);
        }

        public List<Model.Funcionarios> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public List<Model.Funcionarios> PesquisarNome(string text)
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

        public bool AcharNivel(int id)
        {
            return _Repository.AcharNivel(id);
        }

    }
}