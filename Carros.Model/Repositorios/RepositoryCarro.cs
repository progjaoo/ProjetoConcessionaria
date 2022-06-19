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
    public class RepositoryCarro //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryCarro()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Carros oCarro)
        {
            odb.Carros.Add(oCarro);
            odb.SaveChanges();
        }
        public void Remover(int id)        {
            Carros oCarro = odb.Carros.Find(id);
            odb.Carros.Remove(oCarro);
            odb.SaveChanges();
        }
        public void Alterar(Carros oCarro)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oCarro).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Carros> SelecionarTodos()
        {
            return odb.Carros.ToList();
        }

        public List<Carros> PesquisarNome(string text)
        {
            if (int.TryParse(text, out int id))
            {
                return odb.Carros.Where(p => p.IdCarro == id).ToList();
            }
            else {
                return odb.Carros.Where(p => p.ModeloCarro.Contains(text)).ToList();
            }
        }
        public Array SelecioarUm(int id)
        {
            return odb.Carros.Where(p => p.IdCarro == id).ToArray();
        }

    }
}
