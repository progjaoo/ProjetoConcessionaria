using System;       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carros.Model.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Carros.Model.Repositorios
{
    public class RepositoryFuncionario //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryFuncionario()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Funcionarios oFuncionario)
        {
            odb.Funcionarios.Add(oFuncionario);
            odb.SaveChanges();
        }
        public void Remover(int id)        {
            Funcionarios oFuncionario = odb.Funcionarios.Find(id);
            odb.Funcionarios.Remove(oFuncionario);
            odb.SaveChanges();
        }
        public void Alterar(Funcionarios oFuncionario)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oFuncionario).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Funcionarios> SelecionarTodos()
        {
            return odb.Funcionarios.ToList();
        }

        public List<Funcionarios> PesquisarNome(string text)
        {
            if (int.TryParse(text, out int id))
            {
                return odb.Funcionarios.Where(p => p.IdFuncionario == id).ToList();
            }
            else {
                return odb.Funcionarios.Where(p => p.NomeFuncionario.Contains(text)).ToList();
            }
        }
        public int AcharId(string cpf)
        {
            return odb.Funcionarios.Where(oFuncionario => oFuncionario.Cpf == cpf).Select(oFuncionario => oFuncionario.IdFuncionario).FirstOrDefault();
        }

        public Array SelecioarUm(int id)
        {
            return odb.Funcionarios.Where(p => p.IdFuncionario == id).ToArray();
        }

        public bool AcharNivel(int id)
        {
            string cargo = odb.Funcionarios.Where(p => p.IdFuncionario == id).Select(p => p.Cargo).FirstOrDefault().TrimEnd();
            if(cargo == "Gerente" || cargo == "Administrador")
            {
                return true;
            }
            return false;
        }

    }
}
