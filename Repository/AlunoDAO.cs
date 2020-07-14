using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class AlunoDAO : IRepository<Aluno>
    {
        private readonly Context ctx;

        public AlunoDAO(Context context)
        {
            ctx = context;
        }
        public bool Cadastrar(Aluno a)
        {
            if (BuscarAlunoPorNome(a) == null)
            {
                ctx.Alunos.Add(a);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public Aluno BuscarAlunoPorNome(Aluno a)
        {
            return ctx.Alunos.FirstOrDefault
                (x => x.Nome.Equals(a.Nome));
        }

        public Aluno ValidarSenha(Aluno a)
        {
            var login = ctx.Alunos.FirstOrDefault(s => s.Nome.Equals(a.Nome));
            if (login != null)

            {
                if (login.Senha == a.Senha)
                {
                    return login;
                }
                else {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public List<Aluno> ListarTodos()
        {
            return ctx.Alunos.ToList();
        }

        public Aluno BuscarPorId(int id)
        {
            return ctx.Alunos.Find(id);
        }

        public bool CadastrarIMC(IMCAlunos imc)
        {
            imc.CalcImc = imc.Peso / (imc.Altura * imc.Altura);
            ctx.IMCAlunos.Add(imc);
            ctx.SaveChanges();
            return true;
        }
        public List<IMCAlunos> ListarImcporAluno(Aluno a)
        {
            List<IMCAlunos> list = ctx.IMCAlunos.ToList();
            List<IMCAlunos> listAlunos = new List<IMCAlunos>();
            int f = list.Count();
            for (int i = 1; i <= f; i++)
            {
                var c = list[i - 1];
                if (c.Aluno.Equals(a))
                {
                    listAlunos.Add(c);
                }
            }
            if (listAlunos != null)
            {
                return listAlunos.ToList();
            }
            else
            {
                return null;
            }
        }
        public void Remover(int id)
        {
            ctx.Alunos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }
        public void Alterar(Aluno a)
        {
            ctx.Alunos.Update(a);
            ctx.SaveChanges();
        }
    }
}
