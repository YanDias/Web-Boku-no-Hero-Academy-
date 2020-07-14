using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class TreinoDAO : IRepository<Treino>
    {
        private readonly Context ctx;
        public TreinoDAO(Context context)
        {
            ctx = context;
        }

        public bool Cadastrar(Treino t)
        {
            ctx.Treinos.Add(t);
            ctx.SaveChanges();
            return true;
        }
        public List<Treino> ListarTodos()
        {
            return ctx.Treinos.ToList();
        }
        public List<Treino> ListarPorAluno(Aluno a)
        {
            return ctx.Treinos.Include(x => x.Aluno).Include(x => x.Professor).Include(x => x.ListaTreino).Where(x => x.Aluno == a).
                ToList();
        }

        public Treino BuscarPorId(int id)
        {
            return ctx.Treinos.Find(id);
        }
        public void RemoverTreino(Treino t)
        {
            ctx.Treinos.Remove(t);
            ctx.SaveChanges();
        }

    }
}
