using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Carros.Model.Repositorios
{
    public class RepositoryContas //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryContas()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Contas oConta)
        {
            odb.Contas.Add(oConta);
            odb.SaveChanges();
        }
        public void Remover(string usuario)
        {
            Contas oConta = odb.Contas.Find(usuario);
            odb.Contas.Remove(oConta);
            odb.SaveChanges();
        }
        public void Alterar(Contas oConta)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oConta).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Contas> SelecionarTodos()
        {
            return odb.Contas.ToList();
        }

        public List<Contas> SelecionarUmPorId(int id)
        {
            return odb.Contas.Where(p => p.IdUsuario == id).ToList();
        }

        public int ConfirmarConta(string user, string senha)
        {
            int numero = odb.Contas.Where(p => p.Usuario == user).Where(x=>x.Senha == senha).Count();
            if(numero == 0)
            {
                return 0;
            }
            return odb.Contas.Where(p => p.Usuario == user).Select(p => p.IdUsuario).ToArray().FirstOrDefault();
        }
    }
}
