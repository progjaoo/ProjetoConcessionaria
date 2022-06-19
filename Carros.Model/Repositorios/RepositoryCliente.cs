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
    public class RepositoryCliente //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryCliente()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Clientes oCliente)
        {
            odb.Clientes.Add(oCliente);
            odb.SaveChanges();
        }
        public void Remover(int id)        {
            Clientes oCliente = odb.Clientes.Find(id);
            odb.Clientes.Remove(oCliente);
            odb.SaveChanges();
        }
        public void Alterar(Clientes oCliente)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oCliente).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Clientes> SelecionarTodos()
        {
            return odb.Clientes.ToList();
        }

        public List<Clientes> PesquisarNome(string text)
        {
            if (int.TryParse(text, out int id))
            {
                return odb.Clientes.Where(p => p.IdCliente == id).ToList();
            }
            else {
                return odb.Clientes.Where(p => p.NomeCliente.Contains(text)).ToList();
            }
        }
        public int AcharId(string cpf)
        {
            return odb.Clientes.Where(oCliente => oCliente.Cpf == cpf).Select(oCliente => oCliente.IdCliente).FirstOrDefault();
        }

        public Array SelecioarUm(int id)
        {
            return odb.Clientes.Where(p => p.IdCliente == id).ToArray();
        }

    }
}
