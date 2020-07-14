using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AvisosDAO : IRepository<Avisos>
    {
        private readonly Context ctx;
        public AvisosDAO(Context context)
        {
            ctx = context;
        }
       
        public bool Cadastrar(Avisos a)
        {
            ctx.Avisos.Add(a);
            ctx.SaveChanges();
            return true;

        }
        public Avisos BuscarPorId(int id)
        {
            return ctx.Avisos.Find(id);
        }
        public List<Avisos> ListarTodos()
        {
            return ctx.Avisos.ToList();
        }
        public void RemoverAvisos(Avisos a)
        {
            ctx.Avisos.Attach(a);
            ctx.Avisos.Remove(a);
            ctx.SaveChanges();

        }
        public void AlterarAvisos(Avisos a)
        {
            ctx.Avisos.Update(a);
            ctx.SaveChanges();
        }
    }
}
