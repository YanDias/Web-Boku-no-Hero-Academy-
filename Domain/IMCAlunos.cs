using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("ImcAlunos")]
    public class IMCAlunos
    {



        //Construtor
        public IMCAlunos()
        {
            CriadoEm = DateTime.Now;
            Aluno = new Aluno();
        }
        [Key]
        public int IMCId { get; set; }
        public Aluno Aluno { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double CalcImc { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}
