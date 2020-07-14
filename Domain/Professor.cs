using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Professores")]
    public class Professor
    {
        public Professor()
        {

            CriadoEm = DateTime.Now;
        }
        //Atributos
        [Key]
        public int IdProfessor { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public DateTime CriadoEm { get; set; }
        public String Senha { get; set; }
        public String Especialidade { get; set; }
        public String Imagem { get; set; }
    }
}
