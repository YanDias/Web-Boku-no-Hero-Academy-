using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ProfessorDAO : IRepository<Professor>
    {
        private readonly Context ctx;
        public ProfessorDAO(Context context)
        {
            ctx = context;
        }
        public Professor BuscarProfessorPorNome(Professor p)
        {
            return ctx.Professores.FirstOrDefault
                (x => x.Nome.Equals(p.Nome));
        }
        public List<Professor> ListarTodos()
        {
            return ctx.Professores.ToList();
        }

        public bool Cadastrar(Professor p)
        {


            if (BuscarProfessorPorNome(p) == null)

            {
                ctx.Professores.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public Professor BuscarPorId(int id)
        {
            return ctx.Professores.Find(id);
        }

        public Professor ValidarSenha(Professor p)
        {
            var login = ctx.Professores.FirstOrDefault(x =>  x.Nome.Equals(p.Nome));
            if (login != null)
            {
                if(login.Senha == p.Senha)
                {
                    return login;
                }
                else
                {
                    return null;
                }
            }

            else
            {
                return null;
            }
        }
    }
}

