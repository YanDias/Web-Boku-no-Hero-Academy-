using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AulaDAO : IRepository<Aula>
    {
        private readonly Context ctx;
        public AulaDAO(Context context)
        {
            ctx = context;
        }
        public Aula BuscarAulaPorNome(Aula a)
        {
            return ctx.Aulas.FirstOrDefault
                (x => x.Tipo.Equals(a.Tipo));
        }
        public bool Cadastrar(Aula a)
        {
            ctx.Aulas.Add(a);
            ctx.SaveChanges();
            return true;

        }
        public Aula BuscarPorId(int id)
        {
            return ctx.Aulas.Find(id);
        }
        public List<Aula> ListarTodos()
        {
            return ctx.Aulas.ToList();
        }
        public void RemoverAula(Aula aula)
        {
            ctx.Aulas.Attach(aula);
            ctx.Aulas.Remove(aula);
            ctx.SaveChanges();

        }
        public void AlterarAula(Aula a)
        {
            ctx.Aulas.Update(a);
            ctx.SaveChanges();
        }
    }
}
