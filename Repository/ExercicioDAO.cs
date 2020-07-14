using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ExercicioDAO : IRepository<Exercicio>
    {

        private readonly Context ctx;
        public ExercicioDAO(Context context)
        {
            ctx = context;
        }


        public bool Cadastrar(Exercicio ex)
        {
            ctx.Exercicios.Add(ex);
            ctx.SaveChanges();
            return true;
        }
        public List<Exercicio> ListarTodos()
        {
            return ctx.Exercicios.ToList();
        }


        public List<Exercicio> ListarporLista(ListaTreino lista)
        {
            return ctx.Exercicios.Include(x => x.ListaTreino).Where(x => x.ListaTreino == lista).ToList();

        }
        public Exercicio BuscarPorId(int id)
        {
            return ctx.Exercicios.Find(id);
        }

    }
}
