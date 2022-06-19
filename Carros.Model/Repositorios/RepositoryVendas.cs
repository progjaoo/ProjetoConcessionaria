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
    public class RepositoryVenda //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryVenda()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Vendas oVenda)
        {
            odb.Vendas.Add(oVenda);
            odb.SaveChanges();
        }
        public void Remover(int id)        {
            Vendas oVenda = odb.Vendas.Find(id);
            odb.Vendas.Remove(oVenda);
            odb.SaveChanges();
        }
        public void Alterar(Vendas oVenda)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oVenda).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Vendas> SelecionarTodos()
        {
            return odb.Vendas.ToList();
        }

        public List<Vendas> PesquisarNome(string text)
        {
            if (int.TryParse(text, out int id))
            {
                return odb.Vendas.Where(p => p.IdVenda == id).ToList();
                return odb.Vendas.Where(p => p.IdFuncionario == id).ToList();
            }
                return null;
        }

        public Array SelecioarUm(int id)
        {
            return odb.Vendas.Where(p => p.IdVenda == id).ToArray();
        }

    }
}
