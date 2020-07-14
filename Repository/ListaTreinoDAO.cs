using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ListaTreinoDAO : IRepository<ListaTreino>
    {
        private readonly Context ctx;
        public ListaTreinoDAO(Context context)
        {
            ctx = context;
        }
        public bool Cadastrar(ListaTreino lt)
        {
            ctx.ListaTreinos.Add(lt);
            ctx.SaveChanges();
            return true;
        }


        public List<ListaTreino> ListarTodos()
        {
            return ctx.ListaTreinos.ToList();
        }
        public ListaTreino BuscarPorId(int id)
        {
            return ctx.ListaTreinos.Find(id);
        }
    }
}
