using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Treinos")]
    public class Treino
    {
        //construtor
        public Treino()
        {
            CriadoEm = DateTime.Now;
            ListaTreino = new ListaTreino();
            Professor = new Professor();
            Aluno = new Aluno();
        }
        //atributos
        [Key]
        public int IdTreino { get; set; }
        public ListaTreino ListaTreino { get; set; }
        public DateTime CriadoEm { get; set; }
        public Professor Professor { get; set; }
        public Aluno Aluno { get; set; }
        public String Periodo { get; set; }
    }
}
