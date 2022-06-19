using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Carros.Model.Repositorios
{
    public class RepositoryConcessionaria //: IDisposable
    {
        private EMPRESACARROSContext odb;
        public RepositoryConcessionaria()
        {
            odb = new EMPRESACARROSContext();
        }
        public void Incluir(Concessionarias oConcessionaria)
        {
            odb.Concessionarias.Add(oConcessionaria);
            odb.SaveChanges();
        }
        public void Remover(int id)
        {
            Concessionarias oConcessionaria = odb.Concessionarias.Find(id);
            odb.Concessionarias.Remove(oConcessionaria);
            odb.SaveChanges();
        }
        public void Alterar(Concessionarias oConcessionaria)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oConcessionaria).State = EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Concessionarias> SelecionarTodos()
        {
            return odb.Concessionarias.ToList();
        }

        public List<Concessionarias> PesquisarNome(string text)
        {
            if (int.TryParse(text, out int id))
            {
                return odb.Concessionarias.Where(p => p.IdConcessionaria == id).ToList();
            }
            else
            {
                return odb.Concessionarias.Where(p => p.NomeConcessionaria.Contains(text)).ToList();
            }
        }

        public Array SelecioarUm(int id)
        {
            return odb.Concessionarias.Where(p => p.IdConcessionaria == id).ToArray();

        }
    }
}
